using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task4_14
{
        public class PasswordGenerator
        {
            public static string GenerateSecurePassword(int length)
            {
                const string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                const string lowerCase = "abcdefghijklmnopqrstuvwxyz";
                const string digits = "0123456789";
                const string specialCharacters = "!@#$%^&*()_+-=[]{}|;:',.<>?";
                const string allCharacters = upperCase + lowerCase + digits + specialCharacters;

                if (length < 8)
                {
                    throw new ArgumentException("Password length must be at least 8 characters.");
                }

                StringBuilder password = new StringBuilder();
                using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
                {
                    byte[] buffer = new byte[4];

                    // Ensure the password contains at least one character from each category
                    password.Append(upperCase[GetRandomIndex(rng, upperCase.Length)]);
                    password.Append(lowerCase[GetRandomIndex(rng, lowerCase.Length)]);
                    password.Append(digits[GetRandomIndex(rng, digits.Length)]);
                    password.Append(specialCharacters[GetRandomIndex(rng, specialCharacters.Length)]);

                    for (int i = 4; i < length; i++)
                    {
                        password.Append(allCharacters[GetRandomIndex(rng, allCharacters.Length)]);
                    }
                }

                return password.ToString();
            }

            private static int GetRandomIndex(RNGCryptoServiceProvider rng, int max)
            {
                byte[] buffer = new byte[4];
                rng.GetBytes(buffer);
                uint randomValue = BitConverter.ToUInt32(buffer, 0);
                return (int)(randomValue % (uint)max);
            }
        }
    }
