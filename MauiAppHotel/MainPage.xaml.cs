using System;
using Microsoft.Maui.Controls;

namespace MauiAppHotel
{
    public partial class MainPage : ContentPage
    {
        private int clickCount = 0; // Variável para contar os cliques

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            clickCount++; // Incrementa o contador
            CounterLabel.Text = $"Count: {clickCount}"; // Atualiza o texto do Label
        }

        private void OnSobreButtonClicked(object sender, EventArgs e)
        {
            // Adicione aqui a lógica para o botão "Sobre"
            // Por exemplo, navegar para outra página
        }
    }
}
