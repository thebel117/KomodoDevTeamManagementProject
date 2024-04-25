using System;
using System.Collections.Generic;
using System.Linq;

namespace Komodo_Developer
{
    public class DeveloperRepository // pub class DeveloperRepository.
    {
        private readonly List<Developer> _developers = new List<Developer>(); // private readonly field to store a list of developers, same as DevTeamRepo (can just Copy/Paste/Edit these)

        public void AddDeveloper(Developer developer) // add dev to the repo --> All this can be the same as on DevTeam just change the classes n such
        {
            if (developer == null) 
                throw new ArgumentNullException(nameof(developer)); 

            _developers.Add(developer);
        }

        public void RemoveDeveloper(int developerId) // To remove a dev from the repo by ID...
        {
            Developer developer = GetDeveloperById(developerId); // ...Get them by ID. 
            if (developer != null) // ...ARE YOU REAL? (if so)
                _developers.Remove(developer); // ...then removes them from the repo.
        }

        public IEnumerable<Developer> GetAllDevelopers() // Get all devs from the repo.
        {
            return _developers; // Returns all devs stored in the repo.
        }
//Why this one really matters--> It's getting a list of devs; need this to verify who is or isn't in it. IEnumerable = very useful!!!
        public Developer GetDeveloperById(int developerId) //Grab a dev by ID
        {
            return _developers.FirstOrDefault(dev => dev.DeveloperId == developerId); // Finding & returning the developer with the provided ID. (lambda exp 'dev => dev.DeveloperId == developerId )
        }                                                                             // tells method what to look for; 'dev' made to refer to 'Developer' objs; LINQ thing
//                                                   'FirstOrDefault' --> 'Returns the first element of the sequence that satisfies a condition, or a specified default value if no such element is found'
        public IEnumerable<Developer> GetDevelopersWithoutPluralsightAccess() // looks for devs without Pluralsight
        {
            return _developers.Where(dev => !dev.HasPluralsightAccess); // Filtering + returning developers without Pluralsight
        }   //! "Where" can go pretty much w/e in a query expression like this, just not first or last (think Ricky Bobby!)
    }       //! TLDR: 'Where' can filter elements based off (conditions == xyz) and returns sequence based off that.
};

