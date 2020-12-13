using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_KomodoBadges_Repo
{
    //POCO
    public class Badges
    {
        public int BadgeID { get; set; }
        public List<string> Access { get; set; }

        public Badges() { }

        public Badges(int badgeID, List<string> access)
        {
            BadgeID = badgeID;
            Access = access;
        }
    }
}
