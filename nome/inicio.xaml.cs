using Microsoft.Maui.Controls;

namespace nome
{
    public partial class inicio : ContentPage
    {
        public nome()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // Aqui você colocaria a lógica para quando o botão "Sim" for clicado
            // Por exemplo, exibir uma mensagem ou navegar para outra página
            DisplayAlert("Resposta", "Você escolheu participar!", "OK");
        }
    }
}