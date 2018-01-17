﻿using System;

namespace ConsoleGitTest
{
    public class Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = "Manager" + firstName;
            LastName = lastName;
        }

        public bool IsManager { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public double YearlyBonus { get; set; }
    }
}
