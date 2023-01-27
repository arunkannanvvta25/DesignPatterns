using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class CarRoadTaxService:VehicleRoadTaxService
    {
        int carTypeid;
        public CarRoadTaxService(int carTypeid)
        {
            this.carTypeid = carTypeid;
        }
        public override int RoadTax
        {
            get
            {
                return 20;
            }
        }
    }
}
