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
            {
                bool keepManaging = true;

                while (keepManaging)
                {
                    Console.WriteLine("Development Team Management Menu:\n" +
                                        "1. Add Development Team\n" +
                                        "2. Remove Development Team\n" +
                                        "3. View All Development Teams\n" +
                                        "4. Go Back");

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

        // Developer management methods
        private void AddDeveloper()
        {
            Console.WriteLine("Please enter new developer details:");

            // Get developer details from user input
            Console.WriteLine("Enter new developer's ID:");
            int developerId = int.Parse(Console.ReadLine());                 //!parse makes int work like an int32

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

        //Need UI for: Adding Dev, Removing Dev, Viewing Dev, 
        //!Include seed data
        //Fix using errors--> what's wrong with namespaces???