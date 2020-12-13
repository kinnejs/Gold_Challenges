using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_KomodoOutings_Repo
{
    public class OutingsRepo
    {
        private List<Outings> _listOfOutings = new List<Outings>();

        //Create Outing
        public void AddOuting(Outings outing)
        {
            _listOfOutings.Add(outing);
        }

        //Read
        public List<Outings> ViewOutings()
        {
            return _listOfOutings;
        }

        //Delete
        public bool RemoveOuting(string name)
        {
            Outings outing = GetOutingByName(name);

            if (outing == null)
            {
                return false;
            }

            int initialCount = _listOfOutings.Count;
            _listOfOutings.Remove(outing);

            if(initialCount > _listOfOutings.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        } 
        
        //Helper Method
        public Outings GetOutingByName(string name)
        {
            foreach(Outings outing in _listOfOutings)
            {
                if(outing.OutingName == name)
                {
                    return outing;
                }
            }
            return null;
        }

    }
}
