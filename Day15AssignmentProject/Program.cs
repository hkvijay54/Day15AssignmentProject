using System;
using System.Linq;

namespace Day15AssignmentProject
{
    internal class MyMapnode
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hash Table Program");


            //UC1
            MyMapNode<string, string> hash1 = new MyMapNode<string, string>(5);
            hash1.Add("0", "to");
            hash1.Add("1", "be");
            hash1.Add("2", "or");
            hash1.Add("3", "not");
            hash1.Add("4", "to");
            hash1.Add("5", "be");

            string hash5 = hash.Get("5");
            Console.WriteLine("5th index value: " + hash5);
            hash.Remove("2");

            string hash2 = hash.Get("2");
            Console.WriteLine("2th index value: " + hash2);

            Console.WriteLine("Frequency of word \'to\' is : " + hash1.GetFrequencyOfWords("to"));
            Console.WriteLine("Frequency of word \'be\' is : " + hash1.GetFrequencyOfWords("be"));
            Console.WriteLine("Frequency of word \'or\' is : " + hash1.GetFrequencyOfWords("or"));
            Console.WriteLine("Frequency of word \'not\' is : " + hash1.GetFrequencyOfWords("not"));

            Console.WriteLine("\n*****End Of UC1 Program*****\n");

            //uc2
            string temp = "Paranoids are not paranoid because they are paranoid but because " +
                "they keep putting themselves deliberately into paranoid avoidable situations";
            string[] samplephrase = temp.ToLower().Split(" ");

            var phrase = samplephrase.Distinct();

            int length = 0;
            foreach (var item in phrase) { length++; }

            MyMapNode<string, int> hash = new MyMapNode<string, int>(length);


            int count = 1;
            foreach (string word in samplephrase)
            {
                if (hash.ContainsKey(word))
                {
                    count = hash.GetValue(word) + 1;
                    hash.Remove(word);
                    hash.Add(word, count);
                }
                else
                {
                    hash.Add(word, 1);
                }
            }


            Console.WriteLine($"{"Frequency",20} | {"Count",10}\n");
            foreach (string key in phrase)
            {
                Console.WriteLine($"{key,20} | {hash.GetValue(key),10}");
            }

            //uc3

            Console.WriteLine("After removing 'avoidable' word from phrase: \n");
            string temp2 = "Paranoids are not paranoid because they are paranoid but because " +
                "they keep putting themselves deliberately into paranoid avoidable situations";
            string[] samplephrase2 = temp2.ToLower().Split(" ");

            var phrase2 = samplephrase2.Distinct();

            int length2 = 0;
            foreach (var item in phrase) { length2++; }

            MyMapNode<string, int> hash2 = new MyMapNode<string, int>(length2);

            foreach (string word in samplephrase)
            {
                if (word == "avoidable")
                {
                    continue;
                }
                else if (hash2.ContainsKey(word))
                {
                    count = hash2.GetValue(word) + 1;
                    hash2.Remove(word);
                    hash2.Add(word, count);
                }
                else
                {
                    hash2.Add(word, 1);
                }
            }

            Console.WriteLine($"{"Frequency",20} | {"Count",10}\n");
            foreach (string key in phrase2)
            {
                Console.WriteLine($"{key,20} | {hash2.GetValue(key),10}");
            }
        }
    }
}