using System;
using System.Text;
using TestTask.Extensions;

namespace TestTask
{
    class Program
    {
        public static string Solution(string S, string T)
        {
            var result = string.Empty;

            if (Math.Abs(S.Length - T.Length) > 1)
            {
                return "IMPOSSIBLE";
            }

            if (Math.Abs(S.Length - T.Length) == 1)
            {
                for (int i = 0; i < S.Length; i++)
                {
                    if (S[i] != T[i])
                    {
                       S = S.Insert(i, T[i].ToString());

                        return string.Equals(S,T) ? $"INSERT {T[i]}" : "IMPOSSIBLE";
                    }
                }
            }

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
                    S = stringBuilder.ToString();
                    return string.Equals(S, T) ? $"REPLACE {S[i]} {T[i]}" : "IMPOSSIBLE";
                }
            }

            return result;
        }

        static void Main(string[] args)
        {            
            Console.WriteLine(Solution("nice", "niece"));
            Console.WriteLine(Solution("test", "tent"));
            Console.WriteLine(Solution("form", "from"));
            Console.WriteLine(Solution("o", "odd"));
            Console.ReadKey();
        }
    }
}
