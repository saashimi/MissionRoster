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
            Personnel person = new Personnel
            {
                Surname = "Misaki",
                FirstName = "Shin",
                Callsign = "Cheezit",
                Role = "Pilot"
            };
            AirCrew aircrew = new AirCrew();
            aircrew.AddCrew(person);

            Personnel person2 = new Personnel
            {
                Surname = "Chang",
                FirstName = "Kara",
                Callsign = "Flucky",
                Role = "WSO"
            };

            aircrew.AddCrew(person2);
            aircrew.PrintCrew();
            aircrew.SaveCrew();

        }
    }
}