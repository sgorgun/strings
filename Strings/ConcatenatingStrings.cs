using System;

namespace Strings
{
    public static class ConcatenatingStrings
    {
        /// <summary>
        /// Concatenates two specified instances of <see cref="string"/>.
        /// </summary>
        public static string ConcatenateStrings(string str1, string str2)
        {
            return string.Concat(str1, str2);
        }

        /// <summary>
        /// Concatenates three specified instances of <see cref="string"/>.
        /// </summary>
        public static string ConcatenateStrings(string str0, string str1, string str2)
        {
            // TODO #7-1. Analyze unit tests for the method, and add the method implementation.
            // Use String.Concat method to concatenate string: https://docs.microsoft.com/en-us/dotnet/api/system.string.concat
            throw new NotImplementedException();
        }

        /// <summary>
        /// Concatenates four specified instances of <see cref="string"/>.
        /// </summary>
        public static string ConcatenateStrings(string str0, string str1, string str2, string str3)
        {
            // TODO #7-2. Analyze unit tests for the method, and add the method implementation.
            // Use String.Concat method to concatenate string: https://docs.microsoft.com/en-us/dotnet/api/system.string.concat
            throw new NotImplementedException();
        }

        /// <summary>
        /// Concatenates the members of an <see cref="IEnumerable{T}"/> implementation.
        /// </summary>
        public static string ConcatenateStrings(IEnumerable<string> strings)
        {
            // TODO #7-3. Analyze unit tests for the method, and add the method implementation.
            // Use String.Concat method to concatenate string: https://docs.microsoft.com/en-us/dotnet/api/system.string.concat
            throw new NotImplementedException();
        }

        /// <summary>
        /// Concatenates the string representations of three specified objects.
        /// </summary>
        public static string ConcatenateValues(string str, int intValue, long longValue)
        {
            // TODO #7-4. Analyze unit tests for the method, and add the method implementation.
            // Use String.Concat method to concatenate string: https://docs.microsoft.com/en-us/dotnet/api/system.string.concat
            throw new NotImplementedException();
        }

        /// <summary>
        /// Concatenates the string representations of four specified objects.
        /// </summary>
        public static string ConcatenateValues(short shortValue, float floatValue, bool boolValue, double doubleValue)
        {
            // TODO #7-5. Analyze unit tests for the method, and add the method implementation.
            // Use String.Concat method to concatenate string: https://docs.microsoft.com/en-us/dotnet/api/system.string.concat
            throw new NotImplementedException();
        }

        /// <summary>
        /// Concatenates the members of an <see cref="IEnumerable{T}"/> implementation.
        /// </summary>
        public static string ConcatenateValues(IEnumerable<object> values)
        {
            // TODO #7-6. Analyze unit tests for the method, and add the method implementation.
            // Use String.Concat method to concatenate string: https://docs.microsoft.com/en-us/dotnet/api/system.string.concat
            throw new NotImplementedException();
        }
    }
}
