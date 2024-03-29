﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL
{
    public class Driver
    {
        public int ID { get; set; }
        public int Number { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public Team Team { get; set; }

        public Driver(int iD, int number, string firstName, string lastName, DateOnly dateOfBirth, Team team)
        {
            ID = iD;
            Number = number;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Team = team;
        }

        public Driver()
        {
        }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
