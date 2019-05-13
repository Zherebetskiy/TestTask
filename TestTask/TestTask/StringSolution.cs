using System;
using System.Text;
using TestTask.Extensions;

namespace TestTask
{
    public static class StringSolution
    {
        public static string Solution(string S, string T)
        {
            var result = string.Empty;

            if (string.Equals(S,T))
            {
                return "EQUAL";
            }

            if (Math.Abs(S.Length - T.Length) == 1)
            {
                for (int i = 0; i < S.Length; i++)
                {
                    if (S[i] != T[i])
                    {
                        S = S.Insert(i, T[i].ToString());

                        return string.Equals(S, T) ? $"INSERT {T[i]}" : "IMPOSSIBLE";
                    }
                }
            }

            if (S.Length == T.Length)
            {
                for (int i = 0; i < S.Length; i++)
                {
                    if (S[i] != T[i])
                    {
                        if (S[i] == T[i + 1] && S[i + 1] == T[i])
                        {
                            S = S.Swap(i, i + 1);

                            return string.Equals(S, T) ? $"SWAP {S[i + 1]} {S[i]}" : "IMPOSSIBLE";
                        }

                        StringBuilder stringBuilder = new StringBuilder(S);
                        stringBuilder[i] = T[i];
                        var temp = S[i];
                        S = stringBuilder.ToString();

                        return string.Equals(S, T) ? $"REPLACE {temp} {T[i]}" : "IMPOSSIBLE";
                    }
                }
            }

            return "IMPOSSIBLE";
        }
    }
}
