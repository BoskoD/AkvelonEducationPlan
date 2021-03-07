using System;

namespace HashFunction4StringData
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[50];
            string str;
            string[] keys = new string[] {

        "Bosko",
        "Milica",
        "Balsa",
        "Pantela",
        "Cupic",
        "Cira",
        "Lazar",
        "Jovana",
        "Krajno",
        "Pedja",
        "Tamara"
      };

            int hashCode;

            for (int i = 0; i < keys.Length; i++)
            {
                str = keys[i];
                // function call
                hashCode = HashFunction(str, array);
                // storing keys at their hash index
                array[hashCode] = str;
            }

            // Displaying Hashcodes along with key values 
            for (int i = 0; i < (array.GetUpperBound(0)); i++)
            {
                if (array[i] != null)
                    Console.WriteLine(i + " " + array[i]);
            }
        }

        private static int HashFunction(string str, string[] array)
        {
            int total = 0;
            char[] c;
            c = str.ToCharArray();

            // Summing up all the ASCII values  
            // of each alphabet in the string 
            for (int i = 0; i <= c.GetUpperBound(0); i++)
                total += c[i];

            return total % array.GetUpperBound(0);
        }
    }
}

