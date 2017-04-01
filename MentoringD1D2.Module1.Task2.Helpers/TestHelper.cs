using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentoringD1D2.Module1.Task2.Helpers
{
    /// <summary>
    /// The test helper that expands IntToNullableBool and IntToBool types.
    /// </summary>
    public static class TestHelper
    {
        /// <summary>
        /// Convert IntToNullableBool delegate to IntToBool delegate.
        /// </summary>
        /// <param name="fromFunction">The deleaget that should be converted to IntToBool delegate.</param>
        /// <returns>The result of conversion : IntToBool deleate.</returns>
        public static IntToBool ToBool(this IntToNullableBool fromFunction)
        {
            return fromFunction != null ? delegate (int fromValue) { return fromFunction(fromValue) ?? false; } : (IntToBool)null;
        }

        /// <summary>
        /// Convert IntToBool delegate to IntToNullableBool delegate.
        /// </summary>
        /// <param name="fromFunction">The deleaget that should be converted to IntToNullableBool delegate.</param>
        /// <returns>The result of conversion : IntToNullableBool deleate.</returns>
        public static IntToNullableBool ToNullableBool(this IntToBool fromFunction)
        {
            return fromFunction != null ? (fromValue => (fromValue < 0) ? (bool?)null : fromFunction(fromValue)) : (IntToNullableBool)null;
        }
    }
}
