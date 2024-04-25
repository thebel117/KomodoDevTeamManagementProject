using System;

namespace Komodo_Developer
{
    public class Developer // public class named Developer.
    {
        // Properties
        public string? Name { get; set; } // Property Name = the name of the indiv dev
        public int DeveloperId { get; set; } // Property DeveloperId = ID of the developer.
        public bool HasPluralsightAccess { get; set; } // property named HasPluralsightAccess that's T/F if they can access Pluralsight

        // Constructor with 3 args
        public Developer(int developerId, string name, bool hasPluralsightAccess)
        {
            DeveloperId = developerId;
            Name = name;
            HasPluralsightAccess = hasPluralsightAccess;
        }
    }
};

