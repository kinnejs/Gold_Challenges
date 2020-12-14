using _04_KomodoOutings_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_KomodoOutings_Console
{
    public class ProgramUI
    {
        public OutingsRepo _outingsRepo = new OutingsRepo();

        public void Run()
        {
            SeedContent();
            Menu();
        }

        public void SeedContent()
        {
            Outings julyGolf = new Outings("JulyGolf", OutingType.Golf, 30, DateTime.Parse("7/13/20"), 100.00);
            Outings marchBowling = new Outings("MarchBowling", OutingType.Bowling, 25, DateTime.Parse("3/20/20"), 20.00);
            Outings augustAmusement = new Outings("AugustAmusement", OutingType.AmusementPark, 20, DateTime.Parse("8/22/20"), 150.00);
            Outings decemberConcert = new Outings("DecemberConcert", OutingType.Concert, 10, DateTime.Parse("12/15/20"), 75);

            _outingsRepo.AddOuting(julyGolf);
            _outingsRepo.AddOuting(marchBowling);
            _outingsRepo.AddOuting(augustAmusement);
            _outingsRepo.AddOuting(decemberConcert);
        }

        public void Menu()
        {
            bool keepRunning = true;
            while(keepRunning)
            {
                Console.WriteLine("Select an Option from the Following Menu:" +
                    "\n" +
                    "1. Display All Outings\n" +
                    "2. Add Outing to List\n" +
                    "3. Remove Outing from List\n" +
                    "4. See Total Expenses\n" +
                    "5. See Expenses by Outing Type\n" +
                    "0. Exit");

                string input = Console.ReadLine();

                switch(input)
                {
                    case "1":
                        DisplayAllOutings();
                        break;
                    case "2":
                        AddOutingToList();
                        break;
                    case "3":
                        RemoveOutingFromList();
                        break;
                    case "4":
                        TotalExpenses();
                        break;
                    case "5":
                        ExpensesByOutingType();
                        break;
                    case "0":
                        Console.WriteLine("Have a Great Day!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please Enter A Valid Option...");
                        break;
                }
                Console.WriteLine("\nPlease Press any Button to Continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public void DisplayAllOutings()
        {
            Console.Clear();

            var header = String.Format("{0,20}{1,15}{2,35}{3,10}{4,20}{5,20}",
                "Outing Name", "Outing Type", "# Of People", "Date", "Cost Per Person", "Total Cost");
            Console.WriteLine(header);

            foreach(var outing in _outingsRepo.ViewOutings())
            {
                var output = string.Format("{0,20}{1,15}{2,35}{3,10}{4,20}{5,20}", outing.OutingName, outing.TypeOfOuting, outing.NumberOfPeople, outing.Date.Date.ToString("d"), outing.CostPerPerson, outing.TotalCost);
                Console.WriteLine(output);
            }

        }

        public void AddOutingToList()
        {
            Console.Clear();
            Outings newOuting = new Outings();

            Console.Clear();
            Console.WriteLine("Enter the Outing Name:");
            newOuting.OutingName = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Enter the Outing Type:\n" +
                "\n" +
                "1. Golf\n" +
                "2. Bowling\n" +
                "3. Amusement Park\n" +
                "4. Concert");

            string typeAsString = Console.ReadLine();
            int typeAsInt = int.Parse(typeAsString);
            newOuting.TypeOfOuting = (OutingType)typeAsInt;

            Console.Clear();
            Console.WriteLine("Enter the Number of People at the Outing:");
            string numberAsString = Console.ReadLine();
            int numberAsInt = int.Parse(numberAsString);
            newOuting.NumberOfPeople = numberAsInt;

            Console.Clear();
            Console.WriteLine("Enter the Date of the Outing:");
            string dateAsString = Console.ReadLine();
            DateTime dateAsDateTime = DateTime.Parse(dateAsString);
            newOuting.Date = (DateTime)dateAsDateTime;

            Console.Clear();
            Console.WriteLine("Enter the Cost Per Person:");
            string costAsString = Console.ReadLine();
            double costAsDouble = double.Parse(costAsString);
            newOuting.CostPerPerson = costAsDouble;

            _outingsRepo.AddOuting(newOuting);

        }

        public void RemoveOutingFromList()
        {
            DisplayAllOutings();
            Console.WriteLine("\nEnter the Name of the Outing you Want to Remove:");
            string outing = Console.ReadLine();

            bool wasDeleted = _outingsRepo.RemoveOuting(outing);

            if(wasDeleted)
            {
                Console.WriteLine("\nThe Outing was Successfully Removed!");
            }
            else
            {
                Console.WriteLine("\nThe Outing could not be Removed!");
            }
        }

        public void TotalExpenses()
        {
            Console.Clear();
            
        }

        public void ExpensesByOutingType()
        {
            Console.Clear();

        }
    }
}
