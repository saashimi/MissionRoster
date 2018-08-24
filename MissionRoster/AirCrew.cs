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
            aircrew = new List<Personnel>();
        }

        public void AddCrew(Personnel crewman)
        {
            aircrew.Add(crewman);
        }
        
        public void PrintCrew()
        {
            foreach(Personnel crew in aircrew)
            {
                crew.PrintPersonnel();
            }
        }
        public void SaveCrew()
        {
            using (StreamWriter file = new StreamWriter("personnel.txt"))
                foreach (Personnel crew in aircrew)
                {
                    crew.SavePersonnel(file);
                }
        }
        
        // Initialize the variable `aircrew`
        public List<Personnel> aircrew;
    }
}
