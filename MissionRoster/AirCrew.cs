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
            aircrew = new Dictionary<string, Personnel>();
        }

        public void AddCrew(string crewid, Personnel crewman)
        {
            aircrew.Add(crewid, crewman);
        }
        
        public void PrintCrew()
        {
            foreach(KeyValuePair<string, Personnel> crew in aircrew)
            {
                Console.WriteLine(crew.Key);
                crew.Value.PrintPersonnel();
            }
        }
        public void SaveCrew()
        {
            StreamWriter file = new StreamWriter("personnel.txt");
            foreach(KeyValuePair<string, Personnel> crew in aircrew)
            {
                crew.Value.SavePersonnel(file);
            }
            file.Close();
        }
        
        // Initialize the variable `airCrewRoster`
        public Dictionary<string, Personnel> aircrew;
    }
}
