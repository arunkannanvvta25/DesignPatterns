using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public  class CarFactory: VehicleFactory

    {
        CarRoadTaxService carRoadTaxService;
        public CarFactory(int id)
        {
            carRoadTaxService= new CarRoadTaxService(id);
        }
        public override VehicleRoadTaxService CreateRoadTaxSerive()
        {
            return carRoadTaxService;
        }
    }
}
