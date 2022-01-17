using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOBD.CarRental.Model
{
    class AppealModel
    {
        ClientModel client = new ClientModel();
        CarRentalModel car = new CarRentalModel();
        DateTime dateAppeal = DateTime.Now;
        DateTime dateEndPreliminary = new DateTime();
        DateTime dateEnd = new DateTime();

        List<PenaltiModel> penaltis = new List<PenaltiModel>();

        double initialAmount = 0;
        double finalAmount = 0;

        public AppealModel(ClientModel client, CarRentalModel car, DateTime dateAppeal, DateTime dateEndPreliminary,   
            DateTime dateEnd, List<PenaltiModel> penaltis, double initialAmount, double finalAmount)
        {
            this.client = client;
            this.car = car;
            this.dateAppeal = dateAppeal;
            this.dateEndPreliminary = dateEndPreliminary;
            this.dateEnd = dateEnd;
            this.penaltis = penaltis;
            this.initialAmount = initialAmount;
            this.finalAmount = finalAmount;
        }

        public AppealModel()
        {

        }
    }
}
