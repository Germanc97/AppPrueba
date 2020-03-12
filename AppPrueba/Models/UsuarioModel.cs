using System;
using System.Collections.Generic;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace AppPrueba.Models
{
    public class UsuarioModel : NotificationObject
    {
        #region properties


        private string identificacion;

        private string nombre;

        private string apellido;

        private int edad;

        public string Pass { get; set; }

        private string email;



        [PrimaryKey, AutoIncrement]
        public int UsuarioId { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]

        public List<CarroModel> Carros { get; set; }

        #endregion properties

        #region Getters/Setters

        public string Identificacion
        {
            get { return identificacion; }
            set
            {
                identificacion = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged();
            }
        }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                OnPropertyChanged();
            }
        }

        public string Apellido
        {
            get { return apellido; }
            set
            {
                apellido = value;
                OnPropertyChanged();
            }
        }

        public int Edad
        {
            get { return edad; }
            set
            {
                edad = value;
                OnPropertyChanged();
            }
        }

        #endregion

        public UsuarioModel()
        {
        }
    }
}
