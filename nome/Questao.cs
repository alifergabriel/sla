namespace nome;

public class Questao
{

    public string Pergunta;
    public string Resposta1;
    public string Resposta2;
    public string Resposta3;
    public string Resposta4;
    public string Resposta5;

    public int RespostaCerta;
    public int NivelResposta;

    private Label LabelPergunta;

    private Button butaoResposta01;
    private Button butaoResposta02;
    private Button butaoResposta03;
    private Button butaoResposta04;
    private Button butaoResposta05;

    public Questao()
    {
        
    }

    public Questao(Label labelpergunta, Button button1, Button button2, Button button3, Button button4, Button button5)
    {
        LabelPergunta = labelpergunta;
        butaoResposta01 = button1;
        butaoResposta02 = button2;
        butaoResposta03 = button3;
        butaoResposta04 = button4;
        butaoResposta05 = button5;
    }

    public void ConfiguraEstruturaDesenho (Label labelpergunta, Button button1, Button button2, Button button3, Button button4, Button button5)
    {
        LabelPergunta = labelpergunta;
        butaoResposta01 = button1;
        butaoResposta02 = button2;
        butaoResposta03 = button3;
        butaoResposta04 = button4;
        butaoResposta05 = button5;
    }

    public void Desenhar()
    {
        LabelPergunta.Text = Pergunta;
        ButtonResposta1.Text = Resposta1;
        ButtonResposta2.Text = Resposta2;
        ButtonResposta3.Text = Resposta3;
        ButtonResposta4.Text = Resposta4;
        ButtonResposta5.Text = Resposta5;
    }

    private Button QualButton(int r)
    {
        if(r == 1)
        {
            return butaoResposta01;
        }
        else if(r == 2)
        {
            return butaoResposta02;
        }
        else if (r == 3)
        {
            return butaoResposta03;
        }
        else if (r == 4)
        {
            return butaoResposta04;
        }
        else if (r == 5 )
        {
            return butaoResposta05;
        }
        else{
            return null;
        }
    }

    public bool VerificaResposta(int rr)
    {
        if(RespostaCerta == rr)
        {
            var button = QualButton(rr);
            button.BackgroundColor = Colors.Green; //"#a1c9ae";
            return true;
        }
        else
        {
            var buttonCorreto = QualButton(RespostaCerta);
            var buttonIncorreto = QualButton(rr);
            buttonCorreto.BackgroundColor = Colors.Green; //"#a1c9ae";
            buttonIncorreto.BackgroundColor = Colors.Red; //#e88e8e;

            return false;
        }
    }
}