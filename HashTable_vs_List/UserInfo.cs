using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable_vs_List
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string userName { get; set; }

        public UserInfo(int id, string name)
        {
            Id = id;
            userName = name;
        }
    }
}
