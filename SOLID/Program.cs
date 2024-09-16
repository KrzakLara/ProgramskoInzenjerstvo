using SOLID.Models;
using SOLID.Testing;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Station stationTrainMini = new Station();
            Station stationTrainMaxi = new Station();

            Employee employeeSmallTrain = new Employee("Lara ", "Krzak", 0.1);
            Employee employeeLargeTrain = new Employee("Tea","Krzak", 0.11);


            Vehicle bus = new Vehicle(TypeOfVehicle.Bus, 20, 20, 30);
            Vehicle van = new Vehicle(TypeOfVehicle.Car, 20, 20, 50);
            Vehicle truck = new Vehicle(TypeOfVehicle.Truck, 5, 5, 30);
            Vehicle car = new Vehicle(TypeOfVehicle.Car, 40,40, 5);

            stationTrainMini.GetTicketEarnings();
            stationTrainMaxi.GetTicketEarnings();

            stationTrainMini.ParkTheVehicle(car, employeeSmallTrain);
            stationTrainMini.ParkTheVehicle(van, employeeSmallTrain);
            stationTrainMaxi.ParkTheVehicle(bus, employeeLargeTrain);
            stationTrainMaxi.ParkTheVehicle(truck, employeeLargeTrain);


            employeeSmallTrain.GetEmployeeEarnings();
            employeeLargeTrain.GetEmployeeEarnings();
         

            UnitTest unitTest = new UnitTest();
            unitTest.TestTrainSize();
        }
    }
}
