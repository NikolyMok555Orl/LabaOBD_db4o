using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOBD.CarRental.Model
{
    class RatingModel
    {
        int range = 0;
        DiscountModel discount = new DiscountModel();
        int minPoint = 0;
        int maxPoint = 0;

        public RatingModel()
        {
        }

        public RatingModel(int range, DiscountModel discount, int minPoint, int maxPoint)
        {
            this.range = range;
            this.discount = discount;
            this.minPoint = minPoint;
            this.maxPoint = maxPoint;
        }
    }
}
