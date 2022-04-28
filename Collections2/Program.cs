using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRepeatedWordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static void FinDDuplicates(string filepath)
        {
            using (StreamReader reader = new StreamReader(@"E:\TestFolder\Text1.txt"))
            {
                int val = 0;
                Dictionary<string, int> dWords = new Dictionary<string, int>();
                string contents = reader.ReadToEnd();
                string[] strArContents = contents.Split(new string[] { "", " ", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < strArContents.Length; i++)
                {
                    if (dWords.ContainsKey(strArContents[i]))
                    {
                        dWords.TryGetValue(strArContents[i], out val);
                        dWords[strArContents[i]] = val + 1;

                    }
                    else
                    {
                        dWords.Add(strArContents[i], 1);
                    }
                }
                var quer = from n in dWords where (n.Value > 0) select n;
                foreach (var n in quer)
                {
                    Console.Write(n.Key + " : ");
                    Console.WriteLine(n.Value);
                }
            }
            Console.Read();
        }
    }
}