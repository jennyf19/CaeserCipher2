using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CaeserCipher2
{
    class Program
    {
        static void Main(string[] args)
        {
            string alphabet = " ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Cipher myCipher = new Cipher(alphabet);
            myCipher.OffSet(5);
            Console.WriteLine(alphabet);
            Console.WriteLine(myCipher.encodedAlphabet);
            string finalMessage = myCipher.Cypher("RYAN IS SUPER AWESOME");
            Console.WriteLine(finalMessage);
            string decodeMessage = myCipher.Decypher(finalMessage);
            Console.WriteLine(decodeMessage);
            Console.ReadLine();
        }
    }
}
