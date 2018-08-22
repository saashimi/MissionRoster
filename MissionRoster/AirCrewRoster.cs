using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionRoster
{
    class AirCrewRoster
    {
        // Want this to be instantiable 
        public AirCrewRoster()
        {
            airCrewRoster = new Dictionary<string, string>();
        }

        public void AddSurname(string surname)
        {
            airCrewRoster.Add("Surname", surname);
        }

        public void AddFirstName(string firstName)
        {
            airCrewRoster.Add("First Name", firstName);
        }

        public void AddCallsign(string callsign)
        {
            airCrewRoster.Add("Callsign", callsign);
        }

        public void PrintRoster()
        {
            foreach(KeyValuePair<string, string> kvp in airCrewRoster)
            {
                Console.WriteLine("{0} : {1}", kvp.Key, kvp.Value);
            }
        }
        // Initialize the variable `airCrewRoster`
        public Dictionary<string, string> airCrewRoster;
    }
}
