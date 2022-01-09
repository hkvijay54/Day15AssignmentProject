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