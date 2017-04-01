using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentoringD1D2.Module1.Task2.Helpers
{
    /// <summary>
    /// The helper that provides methods of conversion int values to bool or nullable bool values.
    /// </summary>
    public static class ConvertHelper
    {
        /// <summary>
        /// Converts int values to bool.
        /// </summary>
        /// <param name="fromValue">The int value that should be converted to bool.</param>
        /// <returns>The result of conversion.</returns>
        public static bool ToBool(int fromValue)
        {
            return Convert.ToBoolean(fromValue);
        }

        /// <summary>
        /// Converts int value to nullable bool.
        /// </summary>
        /// <param name="fromValue">The int value that should be converted to nullable bool.</param>
        /// <returns>The result of conversion.</returns>
        public static bool? ToNullableBool(int fromValue)
        {
            return (fromValue >= 0) ? Convert.ToBoolean(fromValue) : (bool?)null;
        }
    }
}
