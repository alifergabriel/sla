using Nome;
namespace Nome;
{
    public partial class GamePage : ContentPage
    {
        Gerenciador gerenciador;

        public GamePage()
        {
            InitializeComponent();
            gerenciador = new Gerenciador(labelpergunta, Button1, Button2, Button3, Button4, Button5);
            gerenciador.ProximaQuestao();
        }   

        void OnButtonResposta01ButtonClicked(object sender, EventArgs args)
        {
            gerenciador.VerificaCorreta(1); // Correção aqui
        }
        void OnButtonResposta02ButtonClicked(object sender, EventArgs args)
        {
            gerenciador.VerificaCorreta(2); // Correção aqui
        }
        void OnButtonResposta03ButtonClicked(object sender, EventArgs args)
        {
            gerenciador.VerificaCorreta(3); // Correção aqui
        }
        void OnButtonResposta04ButtonClicked(object sender, EventArgs args)
        {
            gerenciador.VerificaCorreta(4); // Correção aqui
        }
        void OnButtonResposta05ButtonClicked(object sender, EventArgs args)
        {
            gerenciador.VerificaCorreta(5); // Correção aqui
        }
    }
    int pular = 0;
    void cleiton(object s, EventArgs e)
    {
        if (pular == 3){
             (s as Button).IsVisible = false;
             gerenciador.ProximaQuestao();
        }
       else {
         gerenciador.ProximaQuestao();
         pular ++;
       }
       
    }
}