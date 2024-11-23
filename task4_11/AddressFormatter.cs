using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4_11
{
    public class AddressFormatter
    {
            public string FormatAddress(string street, string city, string state, string zipCode)
            {
                // Capitalize the first letter of each word in street, city, and state
                street = CapitalizeWords(street);
                city = CapitalizeWords(city);
                state = CapitalizeWords(state);

                // Format the zip code
                zipCode = FormatZipCode(zipCode);

                // Combine all parts into a single formatted address
                return $"{street}, {city}, {state} {zipCode}";
            }

            private string CapitalizeWords(string input)
            {
                // Use TextInfo to capitalize the first letter of each word
                TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                return textInfo.ToTitleCase(input.ToLower());
            }

            private string FormatZipCode(string zipCode)
            {
                // Ensure the zip code is in the format #####-#### or #####
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
    }
}


