using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SOLID.Models
{
    public class Employee
    {
        public readonly int LOW = 10;

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public double Salary { get; set; }

        public double Quocient { get; set; }

        private double Earnings { get; set; }

        public Employee(string firstName, string lastName, double salary)
        {
           
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }

        public void CheckTheStatusOfVehicle(Vehicle vehicle, Train train)
        {
            if (train.GetCapacity() > 0)
            {
                Earnings += vehicle.GetFare() * Salary;
                train.SetCapacity();
                if (vehicle.TankSize < LOW)
                {
                    Console.WriteLine(FirstName + " " + LastName + " - " + vehicle.Type.ToString() + ", gas size: " + vehicle.TankSize + "% full");
                    Console.WriteLine("Gas is refilling.");
                    vehicle.FullChargedGas();
                    Console.WriteLine(FirstName + " " + LastName + " - " + vehicle.GetType() + " gas size: " + vehicle.TankSize + "% full");

                }
                if (vehicle.BatterySize < LOW)
                {
                    Console.WriteLine(FirstName + " " + LastName + " - " + vehicle.Type.ToString() + " battery size: " + vehicle.BatterySize + "% full");
                    Console.WriteLine("Battery is recharging.");
                    vehicle.FullChargedBattery();
                    Console.WriteLine(FirstName + " " + LastName + " - " + vehicle.BatterySize.ToString() + " battery size: " + vehicle.BatterySize + "% full");

                }

            }
        }


        public void GetEmployeeEarnings()
        {
             Console.WriteLine(FirstName + LastName + " has made " + Salary + " dollars.");
        }
    }
}
