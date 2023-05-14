using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class CommandCentre
    {
        private List<Runway> _runways = new List<Runway>();
        private List<Aircraft> _aircrafts = new List<Aircraft>();

        public CommandCentre(Runway[] runways, Aircraft[] aircrafts)
        {
            this._runways.AddRange(runways);
            this._aircrafts.AddRange(aircrafts);
        }

        public void Landing(Aircraft aircraft)
        {
            foreach (var runway in this._runways)
            {
                if (!runway.IsBusy)
                {
                    Console.WriteLine($"Aircraft {aircraft.Name} is landing.");
                    Console.WriteLine($"Checking runway.");
                    Console.WriteLine($"Aircraft {aircraft.Name} has landed.");
                    runway.IsBusy = true;
                    runway.HighLightRed();
                    break;
                }
            }
        }

        public void TakingOff(Aircraft aircraft)
        {
            foreach (var runway in this._runways)
            {
                if (runway.IsBusy)
                {
                    Console.WriteLine($"Aircraft {aircraft.Name} is taking off.");
                    runway.IsBusy = false;
                    runway.HighLightGreen();
                    Console.WriteLine($"Aircraft {aircraft.Name} has took off.");
                    break;
                }
            }
        }
    }
}
