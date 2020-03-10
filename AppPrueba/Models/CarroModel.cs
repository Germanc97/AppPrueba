using System;
using System.Collections.Generic;
using SQLite;
using SQLiteNetExtensions.Attributes; 

namespace AppPrueba.Models
{
    public class CarroModel : NotificationObject
    {

        #region Properties

        private int pasajeros;

        public string Marca { get; set; }

        private string color;

        public string Year { get; set; }

        public string Modelo { get; set; }

        private double tanque;

        [PrimaryKey, AutoIncrement]
        public int CarroId { get; set; }

        [ForeignKey(typeof(UsuarioModel))]
        public int UsuarioId { get; set; }

        #endregion

        #region Getters/Setters

        public string Color
        {
            get { return color; }
            set
            {
                color = value;
                OnPropertyChanged();
            }
        }

        public int Pasajeros
        {
            get { return pasajeros; }
            set
            {
                pasajeros = value;
                OnPropertyChanged();
            }
        }

        public double Tanque
        {
            get { return tanque; }
            set
            {
                tanque = value;
                OnPropertyChanged();
            }
        }



        #endregion

        public CarroModel()
        {
        }
    }
}
