using System;
using System.Numerics;

namespace RSA_Algorithms
{
    internal static class RsaMath
    {
        public static bool IsPrime(BigInteger value)
        {
            if (value < 2)
            {
                return false;
            }

            if (value == 2)
            {
                return true;
            }

            if (value % 2 == 0)
            {
                return false;
            }

            for (BigInteger i = 3; i * i <= value; i += 2)
            {
                if (value % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static RsaParametersBundle CalculateParameters(BigInteger p, BigInteger q, BigInteger? preferredE = null)
        {
            BigInteger n = p * q;
            BigInteger phi = (p - 1) * (q - 1);
            BigInteger e = preferredE ?? ChoosePublicExponent(phi);

            ExtendedEuclideanResult result = ExtendedGcd(e, phi);
            if (result.Gcd != 1)
            {
                throw new InvalidOperationException("The selected e is not coprime with Phi.");
            }

            BigInteger d = Mod(result.X, phi);

            return new RsaParametersBundle
            {
                P = p,
                Q = q,
                N = n,
                Phi = phi,
                E = e,
                D = d,
                Gcd = result.Gcd,
                X = result.X,
                Y = result.Y
            };
        }

        public static BigInteger ChoosePublicExponent(BigInteger phi)
        {
            for (BigInteger candidate = 3; candidate < phi; candidate += 2)
            {
                if (Gcd(candidate, phi) == 1)
                {
                    return candidate;
                }
            }

            throw new InvalidOperationException("Could not find a valid public exponent e.");
        }

        public static BigInteger Gcd(BigInteger a, BigInteger b)
        {
            while (b != 0)
            {
                BigInteger temp = b;
                b = a % b;
                a = temp;
            }

            return BigInteger.Abs(a);
        }

        public static ExtendedEuclideanResult ExtendedGcd(BigInteger a, BigInteger b)
        {
            if (b == 0)
            {
                return new ExtendedEuclideanResult
                {
                    Gcd = a,
                    X = 1,
                    Y = 0
                };
            }

            ExtendedEuclideanResult next = ExtendedGcd(b, a % b);
            return new ExtendedEuclideanResult
            {
                Gcd = next.Gcd,
                X = next.Y,
                Y = next.X - (a / b) * next.Y
            };
        }

        public static BigInteger ModPow(BigInteger value, BigInteger exponent, BigInteger modulus)
        {
            BigInteger result = 1;
            BigInteger baseValue = Mod(value, modulus);
            BigInteger power = exponent;

            while (power > 0)
            {
                if ((power & 1) == 1)
                {
                    result = (result * baseValue) % modulus;
                }

                baseValue = (baseValue * baseValue) % modulus;
                power >>= 1;
            }

            return result;
        }

        public static FactorizationResult FactorizeModulus(BigInteger n)
        {
            for (BigInteger candidate = 2; candidate * candidate <= n; candidate++)
            {
                if (n % candidate == 0)
                {
                    BigInteger other = n / candidate;
                    if (IsPrime(candidate) && IsPrime(other))
                    {
                        return new FactorizationResult
                        {
                            P = candidate,
                            Q = other
                        };
                    }
                }
            }

            throw new InvalidOperationException("Could not factor n into two prime numbers.");
        }

        private static BigInteger Mod(BigInteger value, BigInteger modulus)
        {
            BigInteger result = value % modulus;
            return result < 0 ? result + modulus : result;
        }
    }
}
