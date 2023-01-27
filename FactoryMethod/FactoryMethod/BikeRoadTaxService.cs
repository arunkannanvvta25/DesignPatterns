using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public  class BikeRoadTaxService : VehicleRoadTaxService
    {
        int bikeTypeId;
        public BikeRoadTaxService(int bikeTypeId)
        {
            this.bikeTypeId = bikeTypeId;
        }
        public override int RoadTax
        {
            get {

                return 10;
            }
        }
    }
}
