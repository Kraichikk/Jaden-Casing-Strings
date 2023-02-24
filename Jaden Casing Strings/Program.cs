using System;

namespace Jaden_Casing_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToJadenCase("pisiun yobany"));
        }
        public static string ToJadenCase( string phrase)
        {
            int count = 0;
            string result = "";

            for (int i = 0; i < phrase.Length; i++)
            {

                switch (count)
                {
                    case 0:
                        if (i != 0)
                        {
                            result += phrase[i];
                        }
                        else
                        {
                            result += phrase[i].ToString().ToUpper();
                        }
                            break;
                        
                    default:
                        result += phrase[i].ToString().ToUpper();
                        count = 0;
                        break;
                }            
                if (phrase[i] == ' ')
                {
                    count++;
                }
            }
            return result;
        }
    } 
}
