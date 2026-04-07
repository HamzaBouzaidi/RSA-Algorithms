using System;
using System.Text;

namespace RSA_Algorithms
{
    internal static class RsaFormatter
    {
        public static string BuildParametersText(RsaParametersBundle parameters)
        {
            var builder = new StringBuilder();
            builder.AppendLine($"n = p * q = {parameters.P} * {parameters.Q} = {parameters.N}");
            builder.AppendLine($"Phi = (p - 1) * (q - 1) = {parameters.Phi}");
            builder.AppendLine($"gcd(e, Phi) = {parameters.Gcd}");
            builder.AppendLine($"Extended Euclidean result: {parameters.E} * ({parameters.X}) + {parameters.Phi} * ({parameters.Y}) = {parameters.Gcd}");
            builder.AppendLine($"Public key: (n = {parameters.N}, e = {parameters.E})");
            builder.AppendLine($"Private key: (n = {parameters.N}, d = {parameters.D})");
            return builder.ToString();
        }

        public static string BuildExplanationText()
        {
            return
                "RSA algorithm explanation" + Environment.NewLine +
                "1. Enter two prime numbers p and q." + Environment.NewLine +
                "2. Compute n = p * q and Phi = (p - 1) * (q - 1)." + Environment.NewLine +
                "3. Choose e so that gcd(e, Phi) = 1 using the Euclidean algorithm." + Environment.NewLine +
                "4. Use the extended Euclidean algorithm to find d, where e * d mod Phi = 1." + Environment.NewLine +
                "5. Encrypt each UTF-8 byte m with c = m^e mod n." + Environment.NewLine +
                "6. Save the ciphertext together with the public key (n, e)." + Environment.NewLine +
                "7. Read the ciphertext back from file." + Environment.NewLine +
                "8. For recovery, factor n to get p and q, compute Phi again, recompute d, and decrypt with m = c^d mod n.";
        }
    }
}
