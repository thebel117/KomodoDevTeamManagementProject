using System; 
using System.Collections.Generic; 
using System.Linq; // System.Linq = gain access to LINQ query capabilities; Lang. Integrated Query. Unique to C#. lets you query and manipulate data from other sources. Uses syntax like SQL's.

namespace Komodo_DevTeam
{
    public class DevTeamRepository 
    {
        private readonly List<DevTeam> _devTeams = new List<DevTeam>(); //  private readonly field holdingg a list of development teams. ("_xxxx" = a private class)

        public void AddDevTeam(DevTeam devTeam) // Method to add a dev team to the repo//
        //!Re: writing variables twice like this is dec'g a variable (devTeam) AND gives it a type (DevTeam)--> "I'm making a box with 'devTeam' sharpie'd on the side, bc it will only hold 'DevTeam' objects"
        {
            if (devTeam == null) // Checks if the provided devTeam parameter is invalid.
                throw new ArgumentNullException(nameof(devTeam)); // Throwing an ArgumentNullException if devTeam has invalid value

            _devTeams.Add(devTeam); // adding the provided devTeam to the list of dev teams.
        }

        public void RemoveDevTeam(int teamId) // Method to remove a development team by ID. --> Remember to add type & var
        {
            DevTeam devTeam = GetDevTeamById(teamId); // Finds the development team by ID.
            if (devTeam != null) // Checking if the dev team exists --> ARE YOU REAL? but in C#
                _devTeams.Remove(devTeam); // !Removes the team from the list!!!.
        }

        public IEnumerable<DevTeam> GetAllDevTeams() // Method to get all dev teams from the repo
        //!IEnumerable<T> is an interface for a set of objects that can be enumerated(ordered). Here it returns a sequence of DevTeam objects. Basically goes through "<this parameter/list>" one by one
        //! and checks if it does something in particular or meets a criteria (like has Pluralsight)
        {
            return _devTeams; // !Returns all development teams stored in the repository.
        }

        public DevTeam GetDevTeamById(int teamId) // Gets a team by its ID
        {
            return _devTeams.FirstOrDefault(t => t.TeamId == teamId); // Find n return the team with the ID entered
        }

        public void AddDeveloperToTeam(int teamId, int developerId) // Method to add a dev to adev team.
        {
            DevTeam? devTeam = GetDevTeamById(teamId); 
            if (devTeam != null && !devTeam.TeamMembers.Contains(developerId)) // If team is NOT REAL or that one dev isn't there...
                devTeam.TeamMembers.Add(developerId); // Add the dev to the team!
        }

        public void RemoveDeveloperFromTeam(int teamId, int developerId) // Method to remove a developer from a team
        {
            DevTeam? devTeam = GetDevTeamById(teamId); 
            if (devTeam != null) // ARE YOU REAL?
                devTeam.TeamMembers.Remove(developerId); // Removing the developer from the team.
        }

        public void AddMultipleDevelopersToTeam(int teamId, List<int> developerIds) // Method to add multiple developers to a development team.
        {
            DevTeam? devTeam = GetDevTeamById(teamId);
            if (devTeam != null)
                devTeam.TeamMembers.AddRange(developerIds); // add range of mult devs to the team.
        }
    }
};
//Still need method to 