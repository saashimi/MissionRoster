using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionRoster
{
    class PersonnelRoster
    {
        // Want this to be instantiable 
        public PersonnelRoster()
        {
            crewman = new Dictionary<string, string>();
        }

        public void AddSurname(string surname)
        {
            crewman.Add("Surname", surname);
        }

        public void AddFirstName(string firstName)
        {
            crewman.Add("First Name", firstName);
        }

        public void AddCallsign(string callsign)
        {
            crewman.Add("Callsign", callsign);
        }

        public void PrintRoster()
        {
            foreach(KeyValuePair<string, string> kvp in crewman)
            {
                Console.WriteLine("{0} : {1}", kvp.Key, kvp.Value);
            }
        }
        public void SaveRoster(StreamWriter file)
        {
            foreach (KeyValuePair<string, string> kvp in crewman)
            {
                file.WriteLine("{0} : {1}", kvp.Key, kvp.Value);
            }
        }

        // Initialize the variable `airCrewRoster`
        public Dictionary<string, string> crewman;
    }
}
