﻿using System;
using System.Linq;
using System.Collections.Generic;
using DefiningPersonClass;

namespace OldestFamilyMember
{
    public class Family
    {
        public List<Person> Members { get; set; }

        public Family()
        {
            this.Members = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.Members.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.Members.OrderByDescending(m => m.Age).First();
        }
    }
}