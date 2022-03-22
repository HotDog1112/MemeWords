using System;
using System.IO;
using System.Security.AccessControl;
using System.Text;

namespace Meme
{

    class Program
    {

        public static void Main()
        {
            string final = "";
            string path = "singular.txt";
            bool FileExists = File.Exists(path);
            if (FileExists == true && path != null)
            {
                try
                {
                    string[] text1 = File.ReadAllLines(path);
                    foreach (string line1 in text1)
                    {
                        foreach (string line2 in File.ReadLines(path))
                        {
                            CompareStrings(line1, line2, final);
                        }
                        MemeTudaSuda(line1);
                    }
                }
                catch (IOException)
                {
                    Console.WriteLine("Error: something went wrong");
                }
                catch (NotSupportedException)
                {
                    Console.WriteLine("Error: wrong file type");
                }
            }
            else
            {
                Console.WriteLine("Error: file doesn't exist");
            }
        }

        public static string CompareStrings(string line1, string line2, string final)
        {
            if (line2 != null && line1 != null && line1.Length > 3 && line2.Length > 3 && line1.Length <= 8 && line2.Length <= 8)
            {
                string endline = line1.Substring(line1.Length - 3);
                line2.StartsWith(endline);
                if (line2.StartsWith(endline) == true)
                {
                    final = line1.Replace(endline, line2);
                    Console.WriteLine(final);
                }
                else
                {
                    return "Error";
                }
            }
            return final;
        }

        public static void MemeTudaSuda(string line1)
        {
            string meme1 = "сюда";
            string meme2 = "суда";
            string result = "";
            if (line1.Contains(meme1) == true)
            {
                result = line1.Replace(meme1, "туда");
                Console.WriteLine(result);
            }
            else if (line1.Contains(meme2) == true)
            {
                result = line1.Replace(meme2, "туда");
                Console.WriteLine(result);
            }
            else
            {
                return;
            }
        }

    }
}
