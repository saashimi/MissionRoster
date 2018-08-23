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
            PersonnelRoster person = new PersonnelRoster();
            person.AddSurname("Misaki");
            person.AddFirstName("Shin");
            person.AddCallsign("Cheezit");
            person.PrintRoster();
            AirCrew aircrew = new AirCrew();
            aircrew.AddCrew(person);
            aircrew.PrintCrew();
        }
    }
}
