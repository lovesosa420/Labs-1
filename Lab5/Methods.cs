using System;

namespace Lab5
{
    public static class Methods
    {
        private static int D(int i, int j, string s1, string s2)
        {
            static int ToInt(bool input) =>
                input ? 1 : 0;

            if (i > 0)
                if (j > 0)
                    return Math.Min(Math.Min(D(i, j - 1, s1, s2) + 1, D(i - 1, j, s1, s2) + 1), D(i - 1, j - 1, s1, s2) + ToInt(s1[i - 1] != s2[j - 1]));
                else
                    return i;
            else
                if (j > 0)
                return j;
            else
                return 0;
        }

        public static int LevenshteinDistance(string m, string n) =>
            D(m.Length, n.Length, m, n);
    }
}
