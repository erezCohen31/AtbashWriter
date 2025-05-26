using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AtbashWriter
{
    internal static class FileTool
    {
        public static void WriteInFile(string message, string path)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string filePath = Path.Combine(desktopPath, path);
            File.AppendAllText(filePath,$"\n{message}" );


        }

        public static string ReadFromFile(string path)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, path);
            string messageEncoded = File.ReadAllText(filePath);
            Console.WriteLine(messageEncoded);
            return messageEncoded;

        }
    }
}
