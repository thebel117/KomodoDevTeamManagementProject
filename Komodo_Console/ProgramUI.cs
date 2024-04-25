using System;
using Komodo_Developer;
using Komodo_DevTeam;

namespace Komodo_Console
{
   public class ProgramUI // Declaring a public class named ProgramUI
    {
        private DeveloperRepository _developerRepo = new ();
        private DevTeamRepository _devTeamRepo = new ();


        public void Run()
        {
            Console.WriteLine("Welcome to Komodo's Developer Management System:");

            _developerRepo.AddDeveloper(new Developer(1, "Liz Ardd", true));
            _developerRepo.AddDeveloper(new Developer(2, "Bier D. Draco", false));
            _developerRepo.AddDeveloper(new Developer(3, "Sally Amander", true));
            _developerRepo.AddDeveloper(new Developer(4, "Basil Lisk", false));

            _devTeamRepo.AddDevTeam(new DevTeam(1, "Backend Team"));
            _devTeamRepo.AddDevTeam(new DevTeam(2, "Frontend Team"));
            _devTeamRepo.AddDevTeam(new DevTeam(3, "Data Management"));

            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine("Select a menu option:\n" +
                                "1. Manage Developers\n" +
                                "2. Manage Development Teams\n" +
                                "3. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ManageDevelopers();
                        break;
                    case "2":
                        ManageDevelopmentTeams();
                        break;
                    case "3":
                        Console.WriteLine("Goodbye, and thank you for using Komodo's Developer Management System!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void ManageDevelopers()
        {
            {
                bool keepManaging = true;

                while (keepManaging)
                {
                    Console.WriteLine("Developer Management Menu:\n" +
                                        "1. Add Developer\n" +
                                        "2. Remove Developer\n" +
                                        "3. View All Developers\n" +
                                        "4. Go Back");

                    string input = Console.ReadLine();

                    switch (input)
                    {
                        case "1":
                            AddDeveloper();
                            break;
                        case "2":
                            RemoveDeveloper();
                            break;
                        case "3":
                            ViewAllDevelopers();
                            break;
                        case "4":
                            keepManaging = false;
                            break;
                        default:
                            Console.WriteLine("Please use a valid input.");
                            break;
                    }

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

private void ManageDevelopmentTeams()
{
    bool keepManaging = true;

    while (keepManaging)
    {
        Console.WriteLine("Development Team Management Menu:\n" +
                            "1. Add Development Team\n" +
                            "2. Remove Development Team\n" +
                            "3. View All Development Teams\n" +
                            "4. Update Development Team Members\n" +
                            "5. Go Back");

        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                AddDevelopmentTeam();
                break;
            case "2":
                RemoveDevelopmentTeam();
                break;
            case "3":
                ViewAllDevelopmentTeams();
                break;
            case "4":
                UpdateDevelopmentTeamMembers();
                break;
            case "5":
                keepManaging = false;
                break;
            default:
                Console.WriteLine("Please use a valid input.");
                break;
        }

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        Console.Clear();
    }
}

        // Developer management methods
        private void AddDeveloper()
        {
            Console.WriteLine("Please enter new developer details:");

            // Get developer details from user input
            Console.WriteLine("Enter new developer's ID:");
            int developerId = int.Parse(Console.ReadLine());                 //parse makes int work like an int32

            Console.WriteLine("Enter new developer's name:");
            string name = Console.ReadLine();

            Console.WriteLine("Will this developer have Pluralsight access? (true/false):");
            bool hasPluralsightAccess = bool.Parse(Console.ReadLine());

            //  new Developer object with Id, name and if they have pluralsight
            Developer newDeveloper = new Developer(developerId, name, hasPluralsightAccess);

            // Add the new dev to the repo
            _developerRepo.AddDeveloper(newDeveloper);

            Console.WriteLine("Developer added successfully!");
        }

        private void RemoveDeveloper()
        {
            Console.WriteLine("Enter ID of developer you want to remove:");
            int developerId = int.Parse(Console.ReadLine());       
            // Remove the dev from the repo
            _developerRepo.RemoveDeveloper(developerId);

            Console.WriteLine("Developer has been removed successfully.");
        }

        private void ViewAllDevelopers()
        {
            Console.WriteLine("All current Komodo staff developers:");

            // grab all devs from the repository
            IEnumerable<Developer> developers = _developerRepo.GetAllDevelopers();

            foreach (Developer developer in developers)
            {
                Console.WriteLine($"ID: {developer.DeveloperId}, Name: {developer.Name}, Pluralsight Access: {developer.HasPluralsightAccess}");
            }
        }

        // dev team management methods
        private void AddDevelopmentTeam()
        {
            Console.WriteLine("Enter the details of the new development team:");

            // Get dev team details from user 
            Console.WriteLine("Enter team ID:");
            int teamId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter team name:");
            string name = Console.ReadLine();

            // new DevTeam obj with the given details
            DevTeam newTeam = new DevTeam(teamId, name);

            // adds the new dev team to the repository
            _devTeamRepo.AddDevTeam(newTeam);

            Console.WriteLine("Dev team was added successfully!");
        }

        private void RemoveDevelopmentTeam()
        {
            Console.WriteLine("Enter ID of the development team you would like to remove:");
            int teamId = int.Parse(Console.ReadLine());

            // Removes the team from the repo
            _devTeamRepo.RemoveDevTeam(teamId);

            Console.WriteLine("Development team removed successfully!");
        }

private void UpdateDevelopmentTeamMembers()
{
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. Add Developer to Development Team");
    Console.WriteLine("2. Remove Developer from Development Team");
    Console.WriteLine("3. View Development Team Members");
    Console.WriteLine("4. Go Back");

    string input = Console.ReadLine();

    switch (input)
    {
        case "1":
            AddDeveloperToTeam();
            break;
        case "2":
            RemoveDeveloperFromTeam();
            break;
        case "3":
            ViewDevelopmentTeamMembers();
            break;
        case "4":
            return; // Go back, no need to clear console or press any key
        default:
            Console.WriteLine("Please enter a valid option.");
            break;
    }
}

private void AddDeveloperToTeam()
{
    Console.WriteLine("Enter the ID of the Development Team:");
    int teamId = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter the ID of the Developer to add:");
    int developerId = int.Parse(Console.ReadLine());

    _devTeamRepo.AddDeveloperToTeam(teamId, developerId);

    Console.WriteLine("Developer added to the Development Team successfully!");
}

private void RemoveDeveloperFromTeam()
{
    Console.WriteLine("Enter the ID of the Development Team:");
    int teamId = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter the ID of the Developer to remove:");
    int developerId = int.Parse(Console.ReadLine());

    _devTeamRepo.RemoveDeveloperFromTeam(teamId, developerId);

    Console.WriteLine("Developer removed from the Development Team successfully!");
}

private void ViewDevelopmentTeamMembers()
{
    Console.WriteLine("Enter the ID of the Development Team:");
    int teamId = int.Parse(Console.ReadLine());

    DevTeam devTeam = _devTeamRepo.GetDevTeamById(teamId);
    if (devTeam != null)
    {
        Console.WriteLine($"Developers in Team '{devTeam.TeamName}':");

        foreach (int developerId in devTeam.TeamMembers)
        {
            Developer developer = _developerRepo.GetDeveloperById(developerId);
            if (developer != null)
            {
                Console.WriteLine($"ID: {developer.DeveloperId}, Name: {developer.Name}");
            }
        }
    }
    else
    {
        Console.WriteLine($"No team found with ID: {teamId}");
    }
}
        private void ViewAllDevelopmentTeams()
        {
            Console.WriteLine("List of all current Komodo development teams:");

            // grab all teams from the repository
            IEnumerable<DevTeam> teams = _devTeamRepo.GetAllDevTeams();

            foreach (DevTeam team in teams)
            {
                Console.WriteLine($"ID: {team.TeamId}, Name: {team.TeamName}");
            }
        }
    }
};
