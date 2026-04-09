# RSA Algorithms

A C# Windows Forms application that demonstrates the RSA algorithm step by step.

The project gives you the ability to:

- enter two prime numbers `p` and `q`
- calculate RSA parameters `n`, `phi`, `e`, and `d`
- encrypt plain text as UTF-8 bytes
- save ciphertext together with the public key
- read saved ciphertext back from a file
- decrypt the message by factoring `n` and restoring the private key


  ## Tech Stack

  - C#
- .NET Framework 4.7.2
- Windows Forms
- `System.Numerics.BigInteger`

  ## How It Works


  The app follows the standard RSA flow:

1. Choose two different prime numbers `p` and `q`.
2. Compute `n = p * q`.
3. Compute `phi = (p - 1) * (q - 1)`.
4. Choose a public exponent `e` such that `gcd(e, phi) = 1`.
5. Use the extended Euclidean algorithm to compute the private exponent `d`.
6. Encrypt each UTF-8 byte with `c = m^e mod n`.
7. Save the ciphertext and public key `(n, e)` to a text file.
8. Read the saved file and decrypt by factoring `n`, rebuilding the private key, and applying `m = c^d mod n`.


   ## Features

- Prime number validation for `p` and `q`
- RSA parameter calculation with formatted output
- Euclidean and extended Euclidean algorithm usage
- Manual modular exponentiation implementation
- File export/import for ciphertext and public key
- Recovery of the original message by factoring the modulus
- Simple educational UI showing inputs, results, status, and explanations
