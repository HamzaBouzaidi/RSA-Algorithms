using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace RSA_Algorithms
{
    internal static class RsaStorage
    {
        public static string BuildStorageText(RsaParametersBundle parameters, IEnumerable<BigInteger> ciphertext)
        {
            var builder = new StringBuilder();
            builder.AppendLine($"n={parameters.N}");
            builder.AppendLine($"e={parameters.E}");
            builder.AppendLine("cipher=" + string.Join(",", ciphertext));
            return builder.ToString();
        }

        public static StoredCipherData ParseStorageText(string content)
        {
            var data = new StoredCipherData();
            string[] lines = content
                .Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in lines)
            {
                string[] parts = line.Split(new[] { '=' }, 2);
                if (parts.Length != 2)
                {
                    continue;
                }

                string key = parts[0].Trim().ToLowerInvariant();
                string value = parts[1].Trim();

                switch (key)
                {
                    case "n":
                        data.N = BigInteger.Parse(value);
                        break;
                    case "e":
                        data.E = BigInteger.Parse(value);
                        break;
                    case "cipher":
                        data.Ciphertext = value
                            .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(BigInteger.Parse)
                            .ToList();
                        break;
                }
            }

            if (data.N <= 0 || data.E <= 0 || data.Ciphertext == null || !data.Ciphertext.Any())
            {
                throw new InvalidOperationException("The selected file does not contain valid RSA data.");
            }

            return data;
        }
    }
}
