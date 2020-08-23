using System;
using System.Collections.Generic;

namespace Dictionary_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> openWith = new Dictionary<string, string>
            {
                { "txt", "notepad.exe" },
                { "bmp", "paint.exe" },
                { "dib", "paint.exe" },
                { "rtf", "wordpad.exe" }
            };

            //try to duplicate key
            try
            {
                openWith.Add("txt", "winword.exe");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("An element with Key = \"txt\" already exists.");
            }

            // The Item property is another name for the indexer, so you
            // can omit its name when accessing elements.
            Console.WriteLine("For key = \"rtf\", value = {0}.", openWith["rtf"]);

            // The indexer can be used to change the value associated
            // with a key.
            openWith["rtf"] = "winword.exe";
            Console.WriteLine("For key = \"rtf\", value = {0}.", openWith["rtf"]);

            // If a key does not exist, setting the indexer for that key
            // adds a new key/value pair.
            openWith["doc"] = "winword.exe";
            Console.WriteLine("For key = \"doc\", value = {0}.", openWith["doc"]);

            // The indexer throws an exception if the requested key is
            // not in the dictionary.
            try
            {
                Console.WriteLine("For key = \"tif\", value = {0}.", openWith["tif"]);
            }
            catch (KeyNotFoundException)
            {

                Console.WriteLine("Key \"tif\" is not found!");
            }

            // When a program often has to try keys that turn out not to
            // be in the dictionary, TryGetValue can be a more efficient
            // way to retrieve values.
            if (openWith.TryGetValue("tif", out string value))
            {
                Console.WriteLine("Key = \"tif\", value {0}.", value);
            }
            else
            {
                Console.WriteLine("Key \"tif\" is not found!");
            }

            // ContainsKey can be used to test keys before inserting
            // them.
            if (!openWith.ContainsKey("ht"))
            {
                openWith.Add("ht", "hypertrm.exe");
                Console.WriteLine("Value added for key = \"ht\": {0}", openWith["ht"]);
            }

            // When you use foreach to enumerate dictionary elements,
            // the elements are retrieved as KeyValuePair objects.
            Console.WriteLine();
            foreach (KeyValuePair<string, string> item in openWith)
            {
                Console.WriteLine("Key = {0} , Value = {1}", item.Key, item.Value);
            }

            // To get the values alone, use the Values property.
            Console.WriteLine();
            Dictionary<string, string>.ValueCollection values = openWith.Values;
            foreach (var item in values)
            {
                Console.WriteLine("Values of the dictionary are {0}", item);
            }

            // To get the keys alone, use the Keys property.
            Console.WriteLine();
            Dictionary<string, string>.KeyCollection keys = openWith.Keys;
            foreach (string item in keys)
            {
                Console.WriteLine("Keys of the dictionary are {0}", item);
            }

            // Use the Remove method to remove a key/value pair.
            Console.WriteLine();
            Console.WriteLine("\nRemove(\"doc\")");
            openWith.Remove("doc");

            if (!openWith.ContainsKey("doc"))
            {
                Console.WriteLine("Key \"doc\" is not found!");
            }
        }
    }
}
