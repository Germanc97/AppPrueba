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

        public string nombre { get; set; }

        public string apellido { get; set; }

        public string edad { get; set; }



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



        #endregion

        public UsuarioModel()
        {
        }
    }
}
