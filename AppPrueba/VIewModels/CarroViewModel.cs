using System;
using System.Threading.Tasks;
using System.Windows.Input;
using AppPrueba.Models;
using AppPrueba.Services.Database;
using Xamarin.Forms;

namespace AppPrueba.VIewModels
{
    public class CarroViewModel
    {
        #region Properties

        public CarroModel Carro { get; set; }
        public CarroModel CarroVista { get; set; }

        public ICommand ActualizarDatosCommand { get; set; }

        public int DatoGuardado { get; set; }

        //servicios

            public IUsuarioDataBase<UsuarioModel> ServicioUsuarioDB { get; set; }

        #endregion Properties

        #region Initialize

        public CarroViewModel()
        {
            //Carro = new CarroModel()
            //{
            //    Marca = "Audi",
            //    Color = "Azul"
            //};

            //CarroVista = new CarroModel()
            //{
            //    Marca = "Renault",
            //    Color = "Verde"
            //};
            //ActualizarDatosCommand = new Command(() => ActualizarDatos(), () => true);
            //if (Application.Current.Properties.ContainsKey("ValorGuardado"))
            //{
            //    var datoGuardado = (int)Application.Current.Properties["ValorGuardado"];
            //    DatoGuardado = Convert.ToInt32(datoGuardado);
            //}

            ServicioUsuarioDB = new UsuarioDatabase<UsuarioModel>();

        }

        #endregion Initialize

        #region Metodos

        public void ActualizarDatos()
        {
            CarroVista.Marca = Carro.Marca;
            CarroVista.Color = Carro.Color;

        }

        public async Task GuardarUsuario()
        {
            UsuarioModel usuario1 = new UsuarioModel()
            {
                Identificacion = "12345678",
                Nombre = "Carlos",
                Apellido = "Perez",
                Edad = 23,
                Pass = "1234",
                Email = "carlos@email.com"

            };
        }

        #endregion Metodos

    }
}
