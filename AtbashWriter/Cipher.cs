using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtbashWriter
{
    internal static class Cipher
    {
        
        public static string CipherMessage(string input)
        {
            
                Dictionary<char, char> atbash = new Dictionary<char, char>();

                for (char c = 'a'; c <= 'z'; c++)
                {
                    atbash[c] = (char)('z' - (c - 'a'));
                }
                for (char c = 'A'; c <= 'Z'; c++)
                {
                    atbash[c] = (char)('Z' - (c - 'A'));
                }
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
