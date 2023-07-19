namespace Numeration_System
{
    class Program
    {
        static void Main()
        {
            int newnumber = ParseInt("cbbaab", new char[] { 'a', 'b', 'c' });
        }
        static int ParseInt(string number, char[] bases)
        {
            int parse = 0;
            for (int i = 0; i < number.Length; i++)
            {
                for (int j = 0; j < bases.Length; j++)
                {
                    if (number[i] == bases[j])
                    {
                        parse += (int)(j * Math.Pow(bases.Length, number.Length - 1 - i));
                        break;
                    }
                }
            }
            return parse;
        }
    }
}