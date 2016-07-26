using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CaeserCipher2
{
    public class Cipher

    {
        #region Properties
        //data inside the class is the property

        public string alphabet;
        public string encodedAlphabet;
        #endregion

        public Cipher(string Alphabet)
        {
            alphabet = Alphabet;
        }

        #region Methods

        public void OffSet(int num)
        {
            string firstPartOfAlphabet = alphabet.Substring(0, num);
            string secondPartOfAlphabet = alphabet.Substring(num);
            encodedAlphabet = secondPartOfAlphabet + firstPartOfAlphabet;
        }

        // TODO: Encode the message from the user.
        public string Cypher(string message)
        {
            string newMessage = String.Empty;
            for (int i = 0; i < message.Length; i++)
            {
                string letter = message.Substring(i, 1);
                int index = alphabet.IndexOf(letter);

                //TODO: input validation
                if (index < 0) continue;

                string encodedLetter = encodedAlphabet.Substring(index, 1);
                newMessage = newMessage + encodedLetter;
            }
            return newMessage;
        }

        //TODO: decypher a string
        public string Decypher(string encodedMessage)
        {
            string decipheredMessage = String.Empty;
            for (int i = 0; i < encodedMessage.Length; i++)
            {
                string encodedLetter = encodedMessage.Substring(i, 1);
                int index = encodedAlphabet.IndexOf(encodedLetter);

                //TODO: input validation
                if (index < 0) continue;

                string decipheredLetter = alphabet.Substring(index, 1);
                decipheredMessage = decipheredMessage + decipheredLetter;
            }
            return decipheredMessage;
        }

        /*public void OffSet(int num)
        {
            char[] theNameOfMyArray = input.ToCharArray();
            for (int i = 0; i < input.Length; i++)
            {
                char firstCharacter = theNameOfMyArray[i];
                int offSetNumber = input.Length - num;
                theNameOfMyArray[offSetNumber] = firstCharacter;
                
                
                theNameOfMyArray[3] = 'c';
                char aSingleElementOfMyArray = theNameOfMyArray[12];
                
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < theNameOfMyArray.Length; i++)
            {
                sb.Append(theNameOfMyArray[i]);
            }
            input = sb.ToString();

        }*/

        #endregion
    }
}
