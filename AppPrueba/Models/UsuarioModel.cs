using System;
using System.Collections.Generic;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace AppPrueba.Models
{
    public class UsuarioModel
    {
        #region properties

        [PrimaryKey, AutoIncrement]
        public int UsuarioId { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]

        public List<CarroModel> Carros { get; set; }

    


        #endregion properties




        public UsuarioModel()
        {
        }
    }
}
