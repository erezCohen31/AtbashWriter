using AtbashWriter;

namespace atbash
{
    class Program
    {
        static void Main(string[] args)
        {
            Cipher cipher = new Cipher();
            string message = Input.InputMessage();
            string messageEncoded = Cipher.CipherMessage(message);
            FileTool.WriteInFile(messageEncoded, "message.txt");
            Console.WriteLine("message encoded from the file:");
            string messageFromFile = FileTool.ReadFromFile("message.txt");
            string messageDecoded = Cipher.CipherMessage(messageFromFile);
            Console.WriteLine("message decoded from the file is:");
            Console.WriteLine(messageDecoded);

        }
    }
}