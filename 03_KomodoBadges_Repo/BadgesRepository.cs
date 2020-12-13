
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_KomodoBadges_Repo
{
    public class BadgesRepository
    {
        public Dictionary<int, List<string>> _access = new Dictionary<int, List<string>>();
        
        public Dictionary<int, List<string>> GetBadges()
        {
            return _access;
        }

        //Create a new badge and access
        public void AddBadge(Badges badgeID)
        {
            _access.Add(badgeID.BadgeID, badgeID.Access);
        }

        //Add door to badge
        public void AddDoor(int badgeID, string access)
        {
            List<string> door = _access[badgeID];
            door.Add(access);
        }

        //Remove door to badge
        public void RemoveDoor(int badgeID, string access)
        {
            List<string> door = _access[badgeID];
            door.Remove(access);
        }

        
    }
}
