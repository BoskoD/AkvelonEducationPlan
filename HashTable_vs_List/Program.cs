using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace HashTable_vs_List
{
    class Program
    {
        static Hashtable userInfoHash;
        static List<UserInfo> userInfoList;
        static Stopwatch sw;

        static void Main(string[] args)
        {
            userInfoHash = new Hashtable();
            userInfoList = new List<UserInfo>();

            // Adding elements
            for (int i = 0; i < 4000000; i++)
            {
                userInfoHash.Add(i, "user" + i);
                userInfoList.Add(new UserInfo(i, "user" + i));
                sw = new Stopwatch();
            }

            // Removing elements
            if (userInfoHash.ContainsKey(0))
            {
                userInfoHash.Remove(0);
            }

            // Setting values
            if (userInfoHash.ContainsKey(1))
            {
                userInfoHash[1] = "replacedName";
            }

            // Looping through
            //foreach (DictionaryEntry entry in userInfoHash)
            //{
            //    Console.WriteLine("Key" + entry.Key + "/ Value:" + entry.Value);
            //}

            // Access
            Random rnd = new Random();
            int randomUser = -1;

            sw.Start();

            float startTime;
            float endTime;
            float deltaTime;

            int cycles = 5;
            int cycle = 0;
            string userName = string.Empty;

            while (cycle < cycles)
            {
                randomUser = rnd.Next(3000000, 4000000);

                // List retrieve
                startTime = sw.ElapsedMilliseconds;
                //access from list
                userName = GetUserFromList(randomUser);
                endTime = sw.ElapsedMilliseconds;
                deltaTime = endTime - startTime;
                Console.WriteLine("Time taken to retrieve " + userName + " from list took |" + string.Format(" {0:0.##}", deltaTime) + "ms");

                // Hash retrieve
                startTime = sw.ElapsedMilliseconds;
                //access from hashtable
                userName = (string)userInfoHash[randomUser];
                endTime = sw.ElapsedMilliseconds;
                deltaTime = endTime - startTime;
                Console.WriteLine("Time taken to retrieve " + userName + " from hash took |" + string.Format(" {0:0.##}", deltaTime) + "ms");
                Console.WriteLine();
                cycle++;
            }
        }

        static string GetUserFromList(int userId)
        {
            for (int i = 0; i < userInfoList.Count; i++)
            {
                if (userInfoList[i].Id == userId)
                {
                    return userInfoList[i].userName;
                }
            }
            return string.Empty;
        }
    }
}