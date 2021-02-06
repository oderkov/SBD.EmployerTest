using System;

namespace SBD.EmployerTest.Tools
{
    internal static class MathHelper
    {
        public static bool IsPowerOfThree(int n)
        {
            return 1162261467 % n == 0;
        }
    }
}
