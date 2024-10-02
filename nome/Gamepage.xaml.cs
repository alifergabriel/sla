namespace nome;

public partial class GamePage
{
    Gerenciador gerenciador;
	public GamePage()
    {
        InitializeComponent();

        gerenciador = new Gerenciador (labelPergunta, butaoResposta01, butaoResposta02, butaoResposta03, butaoResposta04, butaoResposta05);
        gerenciador.ProximaQuestao();
    }

    void ClicouBotaoResposta01(object sender, EventArgs args)
    {
        gerenciador.VerificaCorreta(1);
    }

    void ClicouBotaoResposta02(object sender, EventArgs args)
    {
        gerenciador.VerificaCorreta(2);
    }
    
    void ClicouBotaoResposta03(object sender, EventArgs args)
    {
        gerenciador.VerificaCorreta(3);
    }
    
    void ClicouBotaoResposta04(object sender, EventArgs args)
    {
        gerenciador.VerificaCorreta(4);
    }
    
    void ClicouBotaoResposta05(object sender, EventArgs e)
    {
        gerenciador.VerificaCorreta(5);
    }
}