using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_KomodoOutings_Repo
{
    public enum OutingType
    {
        Golf = 1,
        Bowling,
        AmusementPark,
        Concert
    }
    //POCO
    public class Outings
    {
        public string OutingName { get; set; }
        public OutingType TypeOfOuting { get; set; }
        public int NumberOfPeople { get; set; }
        public DateTime Date { get; set; }
        public double CostPerPerson { get; set; }
        public double TotalCost
        {
            get
            {
                return NumberOfPeople * CostPerPerson;
            }

        }

        public Outings() { }
        public Outings(string outingName, OutingType outingType, int numberOfPeople, DateTime date, double costPerPerson)
        {
            OutingName = outingName;
            TypeOfOuting = outingType;
            NumberOfPeople = numberOfPeople;
            Date = date;
            CostPerPerson = costPerPerson;
        }
        
    }
}
