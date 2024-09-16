using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Models
{
    public class Station
    {
        private Train mini_train = new Train(Train.SizeOfTheTrain.Mini);
        private Train maxi_train = new Train(Train.SizeOfTheTrain.Maxi);

        private int ticketEarnings = 0;

      
        public void ParkTheVehicle(Vehicle vehicle, Employee employee)
        {
            if (MiniVehicle(vehicle))
            {
                employee.CheckTheStatusOfVehicle(vehicle, mini_train);
            }
            else
            {
                employee.CheckTheStatusOfVehicle(vehicle, maxi_train);
            }
         

            ticketEarnings += vehicle.GetFare();
            Console.WriteLine();
        }
        private static bool MiniVehicle(Vehicle vehicle)
        {
            return vehicle.Type == TypeOfVehicle.Car || vehicle.Type == TypeOfVehicle.Van;
        }
        public void GetTicketEarnings()
        {
            Console.WriteLine("The total from selling tickets at this station in $: " + ticketEarnings);

        }
    }
}
