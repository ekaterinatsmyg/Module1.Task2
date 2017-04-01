using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentoringD1D2.Module1.Task2.Helpers
{
    /// <summary>
    /// Converts int value to bool.
    /// </summary>
    /// <param name="fromValue">The int value that should be converted to bool.</param>
    /// <returns>The result of conversion.</returns>
    public delegate bool IntToBool(int fromValue);

    /// <summary>
    /// Converts int value to nullable bool.
    /// </summary>
    /// <param name="fromValue">The int value that should be converted to nullable bool.</param>
    /// <returns>The result of conversion.</returns>
    public delegate bool? IntToNullableBool(int fromValue);
}
