using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Maui.Controls;
using Cardapio.View;
namespace Cardapio
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Entrar(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tela1());
        }
    }
}
