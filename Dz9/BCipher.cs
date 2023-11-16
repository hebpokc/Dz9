using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz9
{
    class BCipher : ICipher
    {
        string inputText;
        public string InputText
        {
            get
            {
                return inputText;
            }
            set
            {
                inputText = value;
            }
        }
        public BCipher(string text)
        {
            InputText = text;
        }

        public string Encode()
        {
            char[] alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
            string cipherText = "";
            foreach (char c in inputText)
            {
                if (char.IsLetter(c))
                {
                    if (char.IsUpper(c))
                    {
                        int index = Array.IndexOf(alphabet, char.ToLower(c));
                        char encryptedChar = alphabet[alphabet.Length - 1 - index];
                        cipherText += char.ToUpper(encryptedChar);
                    }
                    else
                    {
                        int index = Array.IndexOf(alphabet, char.ToLower(c));
                        char encryptedChar = alphabet[alphabet.Length - 1 - index];
                        cipherText += encryptedChar;
                    }
                }
                else
                {
                    cipherText += c;
                }
            }
            return cipherText;
        }
        public string Decode()
        {
            char[] alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
            string cipherText = Encode();
            string encrypteText = "";

            foreach (char c in cipherText)
            {
                if (char.IsLetter(c))
                {
                    if (char.IsUpper(c))
                    {
                        int index = Array.IndexOf(alphabet, char.ToLower(c));
                        char decryptedChar = alphabet[alphabet.Length - 1 - index];
                        encrypteText += char.ToUpper(decryptedChar);
                    }
                    else
                    {
                        int index = Array.IndexOf(alphabet, char.ToLower(c));
                        char decryptedChar = alphabet[alphabet.Length - 1 - index];
                        encrypteText += decryptedChar;
                    }
                }
                else
                {
                    encrypteText += c;
                }
            }
            return encrypteText;
        }
    }
}
