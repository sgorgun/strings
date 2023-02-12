using System;

namespace Strings
{
    public static class Manipulations
    {
        /// <summary>
        /// Returns a greeting.
        /// </summary>
        public static string GetHelloGreeting1(string name)
        {
            const string template = "Hello, !";
            return template.Insert(7, name);
        }

        /// <summary>
        /// Returns a greeting.
        /// </summary>
        public static string GetGreeting1(string greeting, string name)
        {
            const string template = $", !";
            return template.Insert(0, greeting).Insert(greeting.Length + 2, name.ToUpperInvariant());
        }

        /// <summary>
        /// Returns a greeting.
        /// </summary>
        public static string GetHelloGreeting2(string name)
        {
            const string template = "Hello, !";
            return template.Insert(7, name.Trim());
        }

        /// <summary>
        /// Returns a greeting.
        /// </summary>
        public static string GetGreeting2(string greeting, string name)
        {
            const string template = $", !";
            return template.Insert(0, greeting.Trim()).Insert(greeting.Trim().Length + 2, name.Trim().ToLowerInvariant());
        }

        /// <summary>
        /// Returns a greeting.
        /// </summary>
        public static string GetHelloGreeting3(string template, string name)
        {
            return template.Replace("{name}", name, StringComparison.InvariantCulture);
        }

        /// <summary>
        /// Returns a greeting.
        /// </summary>
        public static string GetGreeting3(string template, string greeting, string name)
        {
            return template!.Replace("{greeting}", greeting.ToLowerInvariant(), StringComparison.InvariantCulture).Replace("{name}", name.ToUpperInvariant(), StringComparison.InvariantCulture);
        }

        /// <summary>
        /// Returns refined code - without zero characters.
        /// </summary>
        public static string GetRefinedCode(string code)
        {
            return code.Remove(3, 3);
        }

        /// <summary>
        /// Returns refined date - without dash characters.
        /// </summary>
        public static string GetRefinedDate(string date)
        {
            return date.Remove(2, 1).Remove(4, 1);
        }
    }
}
