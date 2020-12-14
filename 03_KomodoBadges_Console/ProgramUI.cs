
using _03_KomodoBadges_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_KomodoBadges_Console
{
    class ProgramUI
    {
        private BadgesRepository _badgesRepo = new BadgesRepository();

        //Method that starts App
        public void Run()
        {
            SeedContent();
            Menu();
        }

        public void SeedContent()
        {
            Badges oneTwoThree = new Badges(123, new List<string> { "A1", "A2", "A3" });
            Badges oneThreeThree = new Badges(133, new List<string> { "A1", "A3", "A2", "A4" });
            Badges oneFourThree = new Badges(143, new List<string> { "A1", "A3" });
            _badgesRepo.AddBadge(oneTwoThree);
            _badgesRepo.AddBadge(oneThreeThree);
            _badgesRepo.AddBadge(oneFourThree);
        }

        public void Menu()
        {
            bool keepRunning = true;
            while(keepRunning)
            {
                Console.Clear();
                Console.WriteLine("Security Key Card Access\n" +
                    "\n" +
                    "Please Choose an Option:\n" +
                    "1. Add a Badge with Access\n" +
                    "2. Edit a Badge's Access\n" +
                    "3. View All Badges\n" +
                    "0. Exit");

                string input = Console.ReadLine();

                switch(input)
                {
                    case "1":
                        CreateABadge();
                        break;
                    case "2":
                        UpdateABadge();
                        break;
                    case "3":
                        ViewAllBadges();
                        break;
                    case "0":
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please Enter a Valid Response!");
                        break;
                }
            }
        }

        public void CreateABadge()
        {
            Console.Clear();
            Badges badge = new Badges();
            badge.Access = new List<string>();

            Console.WriteLine("Please Enter the New Badge ID");
            badge.BadgeID = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Which Door Should this Badge have Access to?");
            badge.Access.Add(Console.ReadLine());
            Console.WriteLine("Badge Successfully Given Access to Door");

            bool running = true;
            while(running)
            {
                Console.WriteLine("Would You Like to Add Another Door? (y/n)");
                string answer = Console.ReadLine().ToLower();
                
                if(answer == "y")
                {
                    Console.WriteLine("Enter Another Door for The Badge:");
                    badge.Access.Add(Console.ReadLine());
                }
                else if(answer == "n")
                {
                    running = false;
                }
                else
                {
                    Console.WriteLine("Please Enter a Valid Response");
                }
            }

            _badgesRepo.AddBadge(badge);
        }

        public void UpdateABadge()
        {
            Badges badge = new Badges();
            badge.Access = new List<string>();

            Console.Clear();
            Console.WriteLine("Enter the Badge that You Would Like to Update:");
            badge.BadgeID = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("How Do You Want To Update the Badge?\n" +
                "1. Add a Door\n" +
                "2. Remove a Door\n" +
                "0. Exit");

            string input = Console.ReadLine();

            switch(input)
            {
                case "1":
                    AddDoorProgram(badge.BadgeID);
                    break;
                case "2":
                    //Remove a door
                    RemoveDoorProgram(badge.BadgeID);
                    break;
                case "3":
                    Menu();
                    break;
        } 
        }

        public void AddDoorProgram(int badgeID)
        {
            Console.WriteLine("Enter Door to Add:");
            string input = Console.ReadLine();
            _badgesRepo.AddDoor(badgeID, input);
            Console.WriteLine("Badge has Been Updated!\n" +
                "Press any Button to Continue...");
            Console.ReadKey();
        }

        public void RemoveDoorProgram(int badgeID)
        {
            Console.WriteLine("Enter Door to Remove:");
            string input = Console.ReadLine();
            _badgesRepo.RemoveDoor(badgeID, input);
            Console.WriteLine("Badge has Been Updated!\n" +
                "Press any Button to Continue...");
            Console.ReadKey();
        }

        public void ViewAllBadges()
        {
            Dictionary<int, List<string>> List = _badgesRepo.GetBadges();
            foreach (KeyValuePair<int, List<string>> badge in List)
            {
                Console.WriteLine($"Badge: {badge.Key}");

                foreach(string door in badge.Value)
                {
                    Console.WriteLine(door);
                }

            }

            Console.WriteLine("Press any Key to Contine:");
            Console.ReadKey();
        }
    }
}
