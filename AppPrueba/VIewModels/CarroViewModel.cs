using System;
using System.Threading;
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

        public ICommand GuardarDatosCommand { get; set; }

        public ICommand BorrarDatosCommand { get; set; }

        public int DatoGuardado { get; set; }

        public int id { get; set; }

        public UsuarioModel Usuario1 { get; set; }

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
            GuardarDatosCommand = new Command(async () => await GuardarUsuario(), () => true);
            Usuario1 = new UsuarioModel();
            BorrarDatosCommand = new Command(async () => await BorrarUsuario(), () => true);
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
            UsuarioModel usuario2 = new UsuarioModel()
            {
                Identificacion = "12445678",
                Nombre = "Andres",
                Apellido = "Salazar",
                Edad = 25,
                Pass = "1234",
                Email = "andreswebcam@sexy.com"
            };
            int id = await ServicioUsuarioDB.InsertItemAsync(usuario2);
            Thread.Sleep(500);
            UsuarioModel usuario3 = await ServicioUsuarioDB.GetItemAsync(id);

            Usuario1.Identificacion = usuario3.Identificacion;
            Usuario1.Nombre = usuario3.Nombre;
            Usuario1.Apellido = usuario3.Apellido;
            Usuario1.Edad = usuario3.Edad;
            Usuario1.Pass = usuario3.Pass;
            Usuario1.Email = usuario3.Email;

            Usuario1 = new UsuarioModel();

            await Task.FromResult(true);
        }

        public async Task BorrarUsuario()
        {
            Thread.Sleep(500);
            await Task.FromResult(true);
        }



        #endregion Metodos

    }
}
