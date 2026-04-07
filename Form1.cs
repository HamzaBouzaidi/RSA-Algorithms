using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace RSA_Algorithms
{
    public partial class Form1 : Form
    {
        private const string DefaultFileName = "rsa_data.txt";

        private RsaParametersBundle currentParameters;
        private List<BigInteger> currentCiphertext = new List<BigInteger>();
        private string currentFilePath = string.Empty;

        public Form1()
        {
            InitializeComponent();
            txtExplanation.Text = RsaFormatter.BuildExplanationText();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                BigInteger p = ParsePrime(txtP.Text, "p");
                BigInteger q = ParsePrime(txtQ.Text, "q");

                if (p == q)
                {
                    throw new InvalidOperationException("p and q must be different prime numbers.");
                }

                currentParameters = RsaMath.CalculateParameters(p, q);
                txtResults.Text = RsaFormatter.BuildParametersText(currentParameters);
                txtStatus.Text = "RSA parameters calculated successfully.";
            }
            catch (Exception ex)
            {
                txtStatus.Text = ex.Message;
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                EnsureParametersAvailable();

                string plaintext = txtInput.Text;
                if (string.IsNullOrWhiteSpace(plaintext))
                {
                    throw new InvalidOperationException("Enter the initial text x before encryption.");
                }

                byte[] data = Encoding.UTF8.GetBytes(plaintext);
                if (currentParameters.N <= 255)
                {
                    throw new InvalidOperationException("n must be greater than 255 so each UTF-8 byte can be encrypted.");
                }

                currentCiphertext = data
                    .Select(value => RsaMath.ModPow(value, currentParameters.E, currentParameters.N))
                    .ToList();

                txtCiphertext.Text = string.Join(" ", currentCiphertext);
                txtStatus.Text = "Text encrypted successfully.";
            }
            catch (Exception ex)
            {
                txtStatus.Text = ex.Message;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                EnsureParametersAvailable();

                if (!currentCiphertext.Any())
                {
                    throw new InvalidOperationException("Encrypt the text before saving.");
                }

                using (var dialog = new SaveFileDialog())
                {
                    dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                    dialog.FileName = DefaultFileName;

                    if (dialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }

                    File.WriteAllText(dialog.FileName, RsaStorage.BuildStorageText(currentParameters, currentCiphertext));
                    currentFilePath = dialog.FileName;
                    txtFilePath.Text = currentFilePath;
                    txtStatus.Text = "Encrypted text and public key saved successfully.";
                }
            }
            catch (Exception ex)
            {
                txtStatus.Text = ex.Message;
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dialog = new OpenFileDialog())
                {
                    dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                    if (dialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }

                    currentFilePath = dialog.FileName;
                    txtFilePath.Text = currentFilePath;

                    StoredCipherData storedData = RsaStorage.ParseStorageText(File.ReadAllText(currentFilePath));
                    txtStoredPublicKey.Text = $"n = {storedData.N}, e = {storedData.E}";
                    txtCiphertext.Text = string.Join(" ", storedData.Ciphertext);

                    currentCiphertext = storedData.Ciphertext;
                    txtStatus.Text = "Encrypted text read successfully.";
                }
            }
            catch (Exception ex)
            {
                txtStatus.Text = ex.Message;
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (!currentCiphertext.Any())
                {
                    throw new InvalidOperationException("Read or encrypt ciphertext before decryption.");
                }

                StoredCipherData storedData;
                if (!string.IsNullOrWhiteSpace(currentFilePath) && File.Exists(currentFilePath))
                {
                    storedData = RsaStorage.ParseStorageText(File.ReadAllText(currentFilePath));
                }
                else if (currentParameters != null)
                {
                    storedData = new StoredCipherData
                    {
                        N = currentParameters.N,
                        E = currentParameters.E,
                        Ciphertext = currentCiphertext.ToList()
                    };
                }
                else
                {
                    throw new InvalidOperationException("No public key data is available for decryption.");
                }

                FactorizationResult factorization = RsaMath.FactorizeModulus(storedData.N);
                RsaParametersBundle recovered = RsaMath.CalculateParameters(factorization.P, factorization.Q, storedData.E);

                byte[] decryptedBytes = storedData.Ciphertext
                    .Select(value => (byte)RsaMath.ModPow(value, recovered.D, recovered.N))
                    .ToArray();

                txtDecrypted.Text = Encoding.UTF8.GetString(decryptedBytes);
                txtResults.Text = RsaFormatter.BuildParametersText(recovered)
                    + Environment.NewLine
                    + "Recovered from n:" + Environment.NewLine
                    + $"p = {factorization.P}" + Environment.NewLine
                    + $"q = {factorization.Q}";

                txtStatus.Text = "Ciphertext decrypted and original message restored successfully.";
            }
            catch (Exception ex)
            {
                txtStatus.Text = ex.Message;
            }
        }

        private static BigInteger ParsePrime(string input, string name)
        {
            if (!BigInteger.TryParse(input, out BigInteger value))
            {
                throw new InvalidOperationException($"Enter a valid integer for {name}.");
            }

            if (value <= 1 || !RsaMath.IsPrime(value))
            {
                throw new InvalidOperationException($"{name} must be a prime number.");
            }

            return value;
        }

        private void EnsureParametersAvailable()
        {
            if (currentParameters == null)
            {
                throw new InvalidOperationException("Calculate RSA parameters first.");
            }
        }
    }
}
