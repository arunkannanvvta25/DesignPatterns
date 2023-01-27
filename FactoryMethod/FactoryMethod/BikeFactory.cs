using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class BikeFactory:VehicleFactory
    {
        public BikeRoadTaxService bikeRoadTaxService;
        public BikeFactory(int id)
        {
            bikeRoadTaxService= new BikeRoadTaxService(id);
        }
        public override VehicleRoadTaxService CreateRoadTaxSerive()
        {
            return bikeRoadTaxService;
        }
    }
}
