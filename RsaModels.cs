using System.Collections.Generic;
using System.Numerics;

namespace RSA_Algorithms
{
    internal sealed class StoredCipherData
    {
        public BigInteger N { get; set; }

        public BigInteger E { get; set; }

        public List<BigInteger> Ciphertext { get; set; } = new List<BigInteger>();
    }

    internal sealed class FactorizationResult
    {
        public BigInteger P { get; set; }

        public BigInteger Q { get; set; }
    }

    internal sealed class RsaParametersBundle
    {
        public BigInteger P { get; set; }

        public BigInteger Q { get; set; }

        public BigInteger N { get; set; }

        public BigInteger Phi { get; set; }

        public BigInteger E { get; set; }

        public BigInteger D { get; set; }

        public BigInteger Gcd { get; set; }

        public BigInteger X { get; set; }

        public BigInteger Y { get; set; }
    }

    internal sealed class ExtendedEuclideanResult
    {
        public BigInteger Gcd { get; set; }

        public BigInteger X { get; set; }

        public BigInteger Y { get; set; }
    }
}
