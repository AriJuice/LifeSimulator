﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeSimulator
{
    internal class User
    {
        public string Name {  get; set; }
        public int Age { get; set; }
        public string Job { get; set; }
        public int Balance { get; set; }

        public User(string name, int age, string job, int balance)
        {
            Name = name;
            Age = age;
            Job = job;
            Balance = balance;
        }
    }
}
