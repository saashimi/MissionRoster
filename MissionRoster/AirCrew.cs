using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionRoster
{
    class AirCrew
    {
        // Want this to be instantiable 
        public AirCrew()
        {
            aircrew = new List<PersonnelRoster>();
        }

        public void AddCrew(PersonnelRoster crewman)
        {
            aircrew.Add(crewman);
        }

        public void PrintCrew()
        {
            foreach (PersonnelRoster crewman in aircrew)
            {
                Console.WriteLine(crewman);
            }
        }
        // Initialize the variable `airCrewRoster`
        public List<PersonnelRoster> aircrew;
    }
}
