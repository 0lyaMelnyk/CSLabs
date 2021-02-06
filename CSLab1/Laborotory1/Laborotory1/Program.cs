using System;
using System.IO;
using System.Text;

namespace Laborotory1
{
    class Program
    {
        private static readonly string[] sampleTexts = new[] { "Example1.txt", "Example2.txt", "Example3.txt" };
        private static readonly string textDirectory = @"..\..\..\..\..\TextExamples\";
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            foreach (var fileName in sampleTexts)
            {
                Console.WriteLine($"{fileName} \n {TextAnalyzer.Analyze(textDirectory + fileName)} ");
            }

            string testFilePath = textDirectory+"Example1.txt";
            string customEncodedPath = textDirectory+"CustomBase64.txt";
            Base64Encoder.Encode(testFilePath, customEncodedPath);

            string customEncoding = File.ReadAllText(customEncodedPath);
            string base64Encoding = Convert.ToBase64String(File.ReadAllBytes(testFilePath));
            Console.WriteLine($"Custom base64: {customEncoding } \n\nConvert.Base64: {base64Encoding}\n");
            Console.WriteLine($"Base64 check: {base64Encoding.Equals(customEncoding)}");

            Console.WriteLine($"CustomBase64.txt \n {TextAnalyzer.Analyze(customEncodedPath)} ");
            Console.ReadKey();
        }
    }
}
