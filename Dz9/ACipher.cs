using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz9
{
    class ACipher : ICipher
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
        public ACipher(string text)
        {
            InputText = text;
        }

        public string Encode()
        {
            string cipherText = "";
            for (int i = 0; i < inputText.Length; i++)
            {
                if (char.IsLetter(inputText[i]))
                {
                    if (char.ToLower(inputText[i]) == 'я')
                    {
                        if (char.IsUpper(inputText[i]))
                        {
                            cipherText += 'А';
                        }
                        else
                        {
                            cipherText += 'а';
                        }
                    }
                    else if (char.ToLower(inputText[i]) == 'z')
                    {
                        if (char.IsUpper(inputText[i]))
                        {
                            cipherText += 'A';
                        }
                        else
                        {
                            cipherText += 'a';
                        }
                    }
                    else
                    {
                        cipherText += (char)(inputText[i] + 1);
                    }
                }
                else
                {
                    cipherText += inputText[i];
                }
            }
            return cipherText;
        }

        public string Decode()
        {
            string encryptedText = "";
            string cipherText = Encode();
            for (int i = 0; i < cipherText.Length; i++)
            {
                if (char.IsLetter(cipherText[i]))
                {
                    if (char.ToLower(cipherText[i]) == 'а')
                    {
                        if (char.IsUpper(cipherText[i]))
                        {
                            encryptedText += 'Я';
                        }
                        else
                        {
                            encryptedText += 'я';
                        }
                    }
                    else if (char.ToLower(cipherText[i]) == 'a')
                    {
                        if (char.IsUpper(cipherText[i]))
                        {
                            encryptedText += 'Z';
                        }
                        else
                        {
                            encryptedText += 'z';
                        }
                    }
                    else
                    {
                        encryptedText += (char)(cipherText[i] - 1);
                    }
                }
                else
                {
                    encryptedText += cipherText[i];
                }
            }
            return encryptedText;
        }
    }
}
