using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4_13
{
        public class Address
        {
            public string Street { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string ZipCode { get; set; }

            public Address(string street, string city, string state, string zipCode)
            {
                Street = street;
                City = city;
                State = state;
                ZipCode = zipCode;
            }

            public string Format()
            {
                string capitalizedStreet = CapitalizeWords(Street);
                string capitalizedCity = CapitalizeWords(City);
                string capitalizedState = CapitalizeWords(State);
                string formattedZipCode = FormatZipCode(ZipCode);

                return $"{capitalizedStreet}, {capitalizedCity}, {capitalizedState} {formattedZipCode}";
            }

            private string CapitalizeWords(string input)
            {
                if (string.IsNullOrWhiteSpace(input)) return string.Empty;

                string[] words = input.Split(' ');
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Length > 0)
                    {
                        char firstChar = char.ToUpper(words[i][0]);
                        string restOfWord = words[i].Substring(1).ToLower();
                        words[i] = firstChar + restOfWord;
                    }
                }

                return string.Join(' ', words);
            }

            private string FormatZipCode(string zipCode)
            {
                if (zipCode.Length == 9)
                {
                    return $"{zipCode.Substring(0, 5)}-{zipCode.Substring(5)}";
                }
                else if (zipCode.Length == 5)
                {
                    return zipCode;
                }
                else
                {
                    throw new ArgumentException("Invalid zip code format. Zip code must be 5 or 9 digits.");
                }
            }

            public override string ToString()
            {
                return Format();
            }
        }
    }



