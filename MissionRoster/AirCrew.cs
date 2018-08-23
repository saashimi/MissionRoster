using System;
using System.Collections.Generic;
using System.IO;
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
            aircrew = new Dictionary<string, PersonnelRoster>();
        }

        public void AddCrew(string crewid, PersonnelRoster crewman)
        {
            aircrew.Add(crewid, crewman);
        }

        public void PrintCrew()
        {
            foreach(KeyValuePair<string, PersonnelRoster> crew in aircrew)
            {
                Console.WriteLine(crew.Key);
                crew.Value.PrintRoster();
            }
        }
        public void SaveCrew()
        {
            StreamWriter file = new StreamWriter("personnel.txt");
            foreach(KeyValuePair<string, PersonnelRoster> crew in aircrew)
            {
                crew.Value.SaveRoster(file);
            }
            file.Close();
        }

        // Initialize the variable `airCrewRoster`
        public Dictionary<string, PersonnelRoster> aircrew;
    }
}
