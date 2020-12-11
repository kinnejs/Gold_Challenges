using _02_KomodoClaims_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_KomodoClaims_Console
{
    class ProgramUI
    {
        private ClaimsRepository _claimsRepo = new ClaimsRepository();

        public void Run()
        {
            SeedClaimsQueue();
            Menu();
        }

        //Menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                //Display Options to User
                Console.WriteLine("Select a Menu Option:\n" +
                    "1. See All Claims\n" +
                    "2. Take Care of Next Claim\n" +
                    "3. Enter a New Claim\n" +
                    "0. Exit");
                //Get User Input
                string input = Console.ReadLine();
                //Evaluate
                switch(input)
                {
                    case "1":
                        SeeAllClaims();
                        break;
                    case "2":
                        TakeCareOfClaim();
                        break;
                    case "3":
                        AddNewClaim();
                        break;
                    case "0":
                        Console.WriteLine("GoodBye!!!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please Enter a Valid Input");
                        break;
                }
                Console.WriteLine("Please Press any Key to Continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        private void SeeAllClaims()
        {
            Console.Clear();

            var header = String.Format("{0,-12}{1,8}{2,12}{1,8}{2,12}{3,14}{2,12}\n" +
                "ClaimID", "Type", "Description", "Amount", "DateOfAccident", "DateOfClaim", "IsValid");
            Console.WriteLine(header);

            foreach(var claim in Claims)
            {
                var output = String.Format("{0,-12}{1,8}{2,12}{1,8}{2,12}{3,14}{2,12}"), 
            }

        }

        private void TakeCareOfClaim()
        {
            Console.Clear();

        }

        public void AddNewClaim()
        {
            Console.Clear();
            Claims newClaim = new Claims();


            Console.WriteLine("Please Enter the Claim ID:");
            string idAsString = Console.ReadLine();
            int idAsInt = int.Parse(idAsString);
            newClaim.ClaimID = idAsInt;

            Console.Clear();
            Console.WriteLine("Please Enter the Claim Type:\n" +
                "1. Car\n" +
                "2. Home\n" +
                "3. Theft");
            string typeAsString = Console.ReadLine();
            int typeAsInt = int.Parse(typeAsString);
            newClaim.TypeOfClaim = (ClaimType)typeAsInt;

            Console.Clear();
            Console.WriteLine("Please Enter a Claim Description:");
            newClaim.Description = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Please Enter Amount of Damage (e.g 4875.78):");
            string damageAsString = Console.ReadLine();
            double damageAsDouble = double.Parse(damageAsString);
            newClaim.ClaimAmount = damageAsDouble;

            Console.Clear();
            Console.WriteLine("Please Enter the Date of the Accident:");
            string accidentDateAsString = Console.ReadLine();
            DateTime accidentDateAsDateTime = DateTime.Parse(accidentDateAsString);
            newClaim.DateOfIncident = (DateTime)accidentDateAsDateTime;

            Console.Clear();
            Console.WriteLine("Please Enter the Date of the Claim:");
            string claimDateAsString = Console.ReadLine();
            DateTime claimDateAsDateTime = DateTime.Parse(claimDateAsString);
            newClaim.DateOfClaim = (DateTime)claimDateAsDateTime;


        }

        //Seed Method
        private void SeedClaimsQueue()
        {
            Claims one = new Claims(1, ClaimType.Car, "Car accident on 465.", 400.00, DateTime.Parse("4/25/18"), DateTime.Parse("4/27/18"));
            Claims two = new Claims(2, ClaimType.Home, "House fire in kitchen.", 4000.00, DateTime.Parse("4/11/18"), DateTime.Parse("4/12/18"));
            Claims three = new Claims(3, ClaimType.Theft, "Stolen pancakes.", 4.00, DateTime.Parse("4/27/18"), DateTime.Parse("6/01/18"));
            _claimsRepo.AddClaimToQueue(one);
            _claimsRepo.AddClaimToQueue(two);
            _claimsRepo.AddClaimToQueue(three);

        }


    }
}
