﻿using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LabaOBD.Utils;

namespace LabaOBD.CarRepair.Model
{
    /// <summary>
    /// Обращение
    /// </summary>
    public class ServiceModel : DBModel<ServiceModel>, TitleModeInterface
    {

        CarModel car;
        string nameClient;
        string phoneClient;
        DateTime dateStart = DateTime.Now;
        DateTime dateFinal= DateTime.Now.AddDays(-1);

        public ServiceModel()
        {
        }

        public ServiceModel(CarModel car, string nameClient, string phoneClient, DateTime dateStart, DateTime dateFinal)
        {
            this.car = car;
            this.nameClient = nameClient;
            this.phoneClient = phoneClient;
            this.dateStart = dateStart;
            this.dateFinal = dateFinal;
        }

        public override DB4oConection Conection => DB.DB4OConectionSTO;

        public override IObjectContainer GetDB => Conection.Db;

        public Title[] Title => new Title[] { new Title("Авто", typeof(string)), new Title("Клиент", typeof(string)), new Title("Номер", typeof(string)), new Title("Начало", typeof(string)),new Title("Конец", typeof(string)),  };

        public CarModel Car { get => car; set => car = value; }
        public string NameClient { get => nameClient; set => nameClient = value; }
        public string PhoneClient { get => phoneClient; set => phoneClient = value; }
        public DateTime DateStart { get => dateStart; set => dateStart = value; }
        public DateTime DateFinal { get => dateFinal; set => dateFinal = value; }

        public override string[] FieldsAsString()
        {
            return new string[] { car.ToString(), nameClient,  phoneClient, dateStart.ToString(), dateFinal.ToString() };
        }

        public override bool IsEmpty()
        {
            throw new NotImplementedException();
        }
    }
}
