using System.IO;

namespace TestService
{
    public static class TextGenerator
    {
        public static void WriteMessage(string message)
        {
            using (StreamWriter outputWriter = File.CreateText(
                @"C:\ProgramData\TestService\Testoutput.txt"))
            {
                outputWriter.WriteLine(message);
                outputWriter.Flush();
            }
        }
    }
}
