using System;

namespace Strings
{
    public static class CopyingStrings
    {
        /// <summary>
        /// Copies one character from the <paramref name="source"/> to the <paramref name="destination"/>.
        /// </summary>
        public static string CopyOneChar(string source, string destination)
        {
            char[] destinationArray = destination.ToCharArray();
            source.CopyTo(0, destinationArray, 4, source.Length);
            return new string(destinationArray);
        }

        /// <summary>
        /// Copies three characters from the <paramref name="source"/> to the <paramref name="destination"/>.
        /// </summary>
        public static string CopyThreeChars(string source, string destination)
        {
            char[] destinationArray = destination.ToCharArray();
            source.CopyTo(0, destinationArray, 0, 3);

            return new string(destinationArray);
        }

        /// <summary>
        /// Copies five characters from the <paramref name="source"/> to the <paramref name="destination"/>.
        /// </summary>
        public static string CopyFiveChars(string source, string destination)
        {
            return CopyOneChar(source, destination);
        }

        /// <summary>
        /// Copies six characters from the <paramref name="source"/> to the <paramref name="destination"/>.
        /// </summary>
        public static string CopySixChars(string source, string destination)
        {
            char[] sourceChars = source.ToCharArray();
            char[] destinationChars = destination.ToCharArray();

            sourceChars[2..8].CopyTo(destinationChars, 5);

            return new string(destinationChars);
        }

        /// <summary>
        /// Gets a production code by copying substrings of the <paramref name="regionCode"/>, <paramref name="locationCode"/>, <paramref name="dateCode"/> and <paramref name="factoryCode"/> parameters to the <paramref name="template"/>.
        /// </summary>
        public static string GetProductionCode(string template, string regionCode, string locationCode, string dateCode, string factoryCode)
        {
            char[] templateChars = template.ToCharArray();
            char[] regionCodeChars = regionCode.ToCharArray();
            char[] locationCodeChars = locationCode.ToCharArray();
            char[] dateCodeChars = dateCode.ToCharArray();
            char[] factoryCodeChars = factoryCode.ToCharArray();

            Array.Copy(regionCodeChars, 1, templateChars, 0, 1);
            Array.Copy(locationCodeChars, 4, templateChars, 3, 2);
            Array.Copy(dateCodeChars, 3, templateChars, 7, 3);
            Array.Copy(factoryCodeChars, 2, templateChars, 12, 4);

            return new string(templateChars);
        }
    }
}
