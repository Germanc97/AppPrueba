using System;
using System.IO;
using AppPrueba.Services.Database;
using AppPrueba.Services.Handles;
using AppPrueba.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppPrueba
{
    public partial class App : Application
    {
        #region Properties
        static MemoryDataHandler MemoryHandler;
        static DataBase database;
        #endregion Properties

        #region Getters/Setters
        public static DataBase Database
        {
            get
            {
                if(database == null)
                {
                    database = new DataBase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "AppPrueba.db3"));
                }
                return database;
            }
            
        }



        //public static MemoryDataHandler MemoryHandler
        //{
        //    get
        //    {
        //        if(memoryHandler == null)
        //        {
        //            memoryHandler = new MemoryDataHandler();
        //        }
        //        return memoryHandler;
        //    }
        //}
        #endregion Getters/Setters

        public App()
        {
            InitializeComponent();
            Application.Current.Properties["ValorGuardado"] = 25;
            
            MemoryHandler = new MemoryDataHandler();
        }

        protected override async void OnStart()
        {
            //await MemoryHandler.SaveData("valorGuardado", 25);
            //await MemoryHandler.GetData("perro");
            //await MemoryHandler.GetData("valorGuardado");
            MainPage = new UsuarioView();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
