using _04_KomodoOutings_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_KomodoOutings_Console
{
    class ProgramUI
    {
        private OutingsRepo _outingsRepo = new OutingsRepo();

        public void Run()
        {
            SeedContent();
            Menu();
        }
    }
}
