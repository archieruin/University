using System;

namespace Lab_5_1
{
    class CarManufacturing // Facade class
    {
        private readonly string _fullName;
        public CarManufacturing(string fullName)
        {
            _fullName = fullName;
        }

        public string ManufactureCar()
        {
            string result = "";
            CarBodyAssembling carBodyAssembling = new CarBodyAssembling();
            CarEngineAssembling carEngineAssembling = new CarEngineAssembling();
            CarShipment carShipment = new CarShipment();
            result += carBodyAssembling.AddCarBody();
            result += "\n\n";
            result += carEngineAssembling.AddEngіne();
            result += "\n\n";
            result += carShipment.ShіpToCargo();
            return result;
        }
    }

    class CarBodyAssembling
    {
        public string AddCarBody()
        {
            string result = "Car body has been added.\n";
            result += "Body type: Coupe\n";
            result += "Color: Red\n";
            result += "Chassis: Light";
            return result;
        }
    }

    class CarEngineAssembling
    {
        public string AddEngіne()
        {
            return "Engine for light car has been added.\nMaximum KM/H: 500";
        }
    }

    class CarShipment
    {
        public string ShіpToCargo()
        {
            DateTime dateOfShipment = DateTime.Now.AddDays(10);
            return $"Date of shipment: {dateOfShipment}";
        }
    }
}