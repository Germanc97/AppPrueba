using System;
using System.Collections.Generic;
using AppPrueba.VIewModels;
using Xamarin.Forms;

namespace AppPrueba.Views
{
    public partial class UsuarioView : ContentPage
    {
        CarroViewModel context = new CarroViewModel();

        public UsuarioView()
        {
            InitializeComponent();
            BindingContext = context;
        }
    }
}
