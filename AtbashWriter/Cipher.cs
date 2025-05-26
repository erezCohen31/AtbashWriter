using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtbashWriter
{
    internal  class Cipher
    {
        public static Dictionary<char, char> atbash;

        public Cipher()
        {
            atbash= new Dictionary<char, char>();
            InitializeDictionnary();

        }
        public  void InitializeDictionnary()
        {
            for (char c = 'a'; c <= 'z'; c++)
            {
                atbash[c] = (char)('z' - (c - 'a'));
            }
            for (char c = 'A'; c <= 'Z'; c++)
            {
                atbash[c] = (char)('Z' - (c - 'A'));
            }
        }
        public static string CipherMessage(string input)
        {
            

             
                string messageDecrypted = "";

                foreach (char c in input)
                {
                    if (atbash.ContainsKey(c))
                    {
                        messageDecrypted += atbash[c];
                    }
                    else
                    {
                        messageDecrypted += c;
                    }
                }
                return messageDecrypted;
            
        }
    }
}
