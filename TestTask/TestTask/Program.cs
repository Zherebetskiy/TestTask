using System;

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


                    return "REPLACE or SWAP ";
                }
            }

            return result;
        }

        static void Main(string[] args)
        {            
            Console.WriteLine(Solution("nice", "niece"));
            Console.ReadKey();
        }
    }
}
