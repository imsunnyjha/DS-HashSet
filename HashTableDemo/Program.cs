using System;

namespace HashTableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int frequency;
            Console.WriteLine("Welcome To Hash Table Program");
            MyMapNode<string, int> hash = new MyMapNode<string, int>(5);
            string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] words = paragraph.Split(" ");
            for (int i = 0; i < words.Length; i++)
            {
                if (hash.GetFrequency(words[i]) == default)
                {
                    frequency = 1;
                    hash.Add(words[i], frequency);
                }
                else
                {
                    frequency = hash.GetFrequency(words[i]);
                    hash.SetFrequency(words[i], ++frequency);
                }
            }
            Console.WriteLine("Frequency :" + hash.GetFrequency("avoidable"));
            hash.Remove("avoidable");
            Console.WriteLine("Frequency after removing :" + hash.GetFrequency("avoidable"));
        }
    }
}