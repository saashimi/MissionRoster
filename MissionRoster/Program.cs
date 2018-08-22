using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            AirCrewRoster person = new AirCrewRoster();
            person.AddSurname("Misaki");
            person.AddFirstName("Shin");
            person.AddCallsign("Cheezit");
            person.PrintRoster();
        }
    }
}
