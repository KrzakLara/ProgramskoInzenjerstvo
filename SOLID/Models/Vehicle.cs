using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Models
{
    public enum TypeOfVehicle
    {
        [Description("50")]
        Car,
        [Description("80")]
        Van,
        [Description("70")]
        Bus,
        [Description("90")]
        Truck
    }
    public class Vehicle
    {


        public TypeOfVehicle Type { get; set; }
        public int TankSize { get; set; }

        private int fare;
        public int GetFare() => fare;


        public int BatterySize;
        public double GetBatterySize() => BatterySize;
        public void SetBatterySize() => BatterySize = Constants.MAXI_SIZE;

        public void FullChargedBattery()
        {

            this.BatterySize = 100;
        }



        private int GasSize;
        public double GetGasSize() => GasSize;
        public void SetGasSize() => GasSize = Constants.MINI_SIZE;
        public void FullChargedGas()
        {

            this.TankSize = 100;
        }

        public Vehicle(TypeOfVehicle type, int tankSize, int batterySize, int gasSize)
        {
            Type = type;
            TankSize = tankSize;
            BatterySize = batterySize;
            GasSize = gasSize;



            switch (type)
            {
                case TypeOfVehicle.Car:
                    fare = Constants.PRICE_OF_THE_CAR;
                    break;
                case TypeOfVehicle.Van:
                    fare = Constants.PRICE_OF_THE_VAN;
                    break;
                case TypeOfVehicle.Bus:
                    fare = Constants.PRICE_OF_THE_BUS;
                    break;
                case TypeOfVehicle.Truck:
                    fare = Constants.PRICE_OF_THE_TRUCK;
                    break;
                default:
                    fare = Constants.ZERO_NUMB;
                    break;
            }


        }
    }
}
