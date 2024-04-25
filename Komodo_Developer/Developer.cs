using System;

namespace Komodo_Developer
{
    public class Developer // public class named Developer.
    {
        // Properties
        public string? Name { get; set; } // Property Name = the name of the indiv dev
        public int DeveloperId { get; set; } // Property DeveloperId = identifier of the developer.
        public bool HasPluralsightAccess { get; set; } // property named HasPluralsightAccess that's T/F if they access Pluralsight

        // Constructor with parameters
        public Developer(int developerId, string name, bool hasPluralsightAccess)
        {
            DeveloperId = developerId;
            Name = name;
            HasPluralsightAccess = hasPluralsightAccess;
        }
    }
};

//Add constructor that takes three args