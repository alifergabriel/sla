namespace nome;

public class Gerenciador
{

    List<Questao> listaQuestoes = new List<Questao>();
    List<int> listaQuestaoRespondida = new List<int>();
    Questao questaoAtual;
    public Gerenciador(Label labelPergunta, Button buttonResposta01, Button buttonResposta02, Button buttonResposta03, Button buttonResposta04, Button buttonResposta05){
        CriarQuestoes(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
    }

    void CriarQuestoes(Label labelPergunta, Button buttonResposta01, Button buttonResposta02, Button buttonResposta03, Button buttonResposta04, Button buttonResposta05){
        var q1 = new Questao();

        q1.Pergunta = "Quanto é 2 + 2";
        q1.Resposta1 = "Bolsonaro";
        q1.Resposta2 = "Lula";
        q1.Resposta3 = "não fui nessa aula de matematica";
        q1.Resposta4 = "Pablo marçal";
        q1.Resposta5 = ",2,2,2,2,22,2,2,";

        q1.RespostaCerta = 3;
        q1.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q1);

        var q2 = new Questao();
        q2.Pergunta = "qual é a cidade com o nome mais zoado do Brasil?";
        q2.Resposta1 = "xique xique Bahia";
        q2.Resposta2 = "Ponta grossa";
        q2.Resposta3 = "gfjgfdjh";
        q2.Resposta4 = "não tem";
        q2.Resposta5 = "fds?";

        q2.RespostaCerta = 2;
        q2.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q2);

        var q3 = new Questao();
        q3.Pergunta = "Qual é a cor do céu em um dia limpo?";
        q3.Resposta1 = "Verde";
        q3.Resposta2 = "Azul";
        q3.Resposta3 = "Amarelo";
        q3.Resposta4 = "cor da cabeça de um negão... e não é a de cima";
        q3.Resposta5 = "Preto Isbranquiçado";

        q3.RespostaCerta = 5;
        q3.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q3);

        var q4 = new Questao();
        q4.Pergunta = "Qual é o maior planeta do sistema solar? ou pessoa";
        q4.Resposta1 = "Terra";
        q4.Resposta2 = "Marte";
        q4.Resposta3 = "thais plodindo";
        q4.Resposta4 = "Saturno";
        q4.Resposta5 = "jupiter";

        q4.RespostaCerta = 3;
        q4.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q4);

        var q5 = new Questao();
        q5.Pergunta = "Qual time o carlinhos torce?";
        q5.Resposta1 = "corinthians";
        q5.Resposta2 = "vasco";
        q5.Resposta3 = "PALmeiras";
        q5.Resposta4 = "Santos";
        q5.Resposta5 = "PSG";

        q5.RespostaCerta = 1;
        q5.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q5);

        var q6 = new Questao();
        q6.Pergunta = "Quantos continentes existem?";
        q6.Resposta1 = "5";
        q6.Resposta2 = "6";
        q6.Resposta3 = "7";
        q6.Resposta4 = "4";
        q6.Resposta5 = "49.690.356.876,02";

        q6.RespostaCerta = 3;
        q6.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q6);

        var q7 = new Questao();
        q7.Pergunta = "Qual é a fórmula da água?";
        q7.Resposta1 = "H2O";
        q7.Resposta2 = "69";
        q7.Resposta3 = "CO2";
        q7.Resposta4 = "NaCl";
        q7.Resposta5 = "CUM";

        q7.RespostaCerta = 1;
        q7.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q7);

        var q8 = new Questao();
        q8.Pergunta = "Qual é a língua mais falada do mundo?";
        q8.Resposta1 = "Inglês";
        q8.Resposta2 = "Mandarim";
        q8.Resposta3 = "XINXONUN";
        q8.Resposta4 = "Francês";
        q8.Resposta5 = "Árabe = lingua do jabibis";

        q8.RespostaCerta = 5;
        q8.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q8);

        var q9 = new Questao();
        q9.Pergunta = "você pintou a Mãona Lisa?";
        q9.Resposta1 = "sim";
        q9.Resposta2 = "Leonardo da Vinci";
        q9.Resposta3 = "não";
        q9.Resposta4 = "talvez";
        q9.Resposta5 = "20 conto no pix eu pinto dnv";

        q9.RespostaCerta = 5;
        q9.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q9);

        var q10 = new Questao();
        q10.Pergunta = "Qual é o maior oceano do mundo?";
        q10.Resposta1 = "Oceano Atlântico";
        q10.Resposta2 = "Oceano Índico";
        q10.Resposta3 = "Oceano Pacífico";
        q10.Resposta4 = "Oceano Ártico";
        q10.Resposta5 = "Oceano Antártico";

        q10.RespostaCerta = 3;
        q10.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q10);

        var q11 = new Questao();
        q11.Pergunta = "Qual é o elemento químico com símbolo O?";
        q11.Resposta1 = "Osvaldo";
        q11.Resposta2 = "Ouro";
        q11.Resposta3 = "Prata";
        q11.Resposta4 = "Cálcio";
        q11.Resposta5 = "Nitrogênio";

        q11.RespostaCerta = 1;
        q11.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q11);

        var q12 = new Questao();
        q12.Pergunta = "Qual animal é conhecido como o 'rei da selva'?";
        q12.Resposta1 = "Elefante";
        q12.Resposta2 = "Tigre";
        q12.Resposta3 = "um africano com fome";
        q12.Resposta4 = "Urso";
        q12.Resposta5 = "ou um pokemon muito doido";

        q12.RespostaCerta = 3;
        q12.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q12);

        var q13 = new Questao();
        q13.Pergunta = "Qual é a moeda do Japão?";
        q13.Resposta1 = "Yuan";
        q13.Resposta2 = "Won";
        q13.Resposta3 = "Yen";
        q13.Resposta4 = "Dólar";
        q13.Resposta5 = "Euro";

        q13.RespostaCerta = 3;
        q13.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q13);

        var q14 = new Questao();
        q14.Pergunta = "Qual é o nome do famoso relógio de Londres?";
        q14.Resposta1 = "Big Ben";
        q14.Resposta2 = "Tower Bridge";
        q14.Resposta3 = "London Eye";
        q14.Resposta4 = "Buckingham Palace";
        q14.Resposta5 = "Westminster Abbey";

        q14.RespostaCerta = 1;
        q14.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q14);

        var q15 = new Questao();
        q15.Pergunta = "Quem é o autor de 'A Moreninha'?";
        q15.Resposta1 = "Joaquim Manuel de Macedo";
        q15.Resposta2 = "Machado de Assis";
        q15.Resposta3 = "José de Alencar";
        q15.Resposta4 = "Aluísio Azevedo";
        q15.Resposta5 = "Eça de Queirós";

        q15.RespostaCerta = 1;
        q15.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q15);

        var q16 = new Questao();
        q16.Pergunta = "Qual planeta é conhecido como o 'planeta vermelho'?";
        q16.Resposta1 = "Marte";
        q16.Resposta2 = "Vênus";
        q16.Resposta3 = "Júpiter";
        q16.Resposta4 = "Saturno";
        q16.Resposta5 = "Mercúrio";

        q16.RespostaCerta = 1;
        q16.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q16);

        var q17 = new Questao();
        q17.Pergunta = "Qual é o maior mamífero do mundo?";
        q17.Resposta1 = "Elefante";
        q17.Resposta2 = "Baleia Azul";
        q17.Resposta3 = "Girafa";
        q17.Resposta4 = "Tubarão-Baleia";
        q17.Resposta5 = "Orca";

        q17.RespostaCerta = 2;
        q17.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q17);

        var q18 = new Questao();
        q18.Pergunta = "Qual é a capital da Itália?";
        q18.Resposta1 = "Roma";
        q18.Resposta2 = "Milão";
        q18.Resposta3 = "Nápoles";
        q18.Resposta4 = "Florença";
        q18.Resposta5 = "Veneza";

        q18.RespostaCerta = 1;
        q18.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q18);

        var q19 = new Questao();
        q19.Pergunta = "Quem descobriu a penicilina?";
        q19.Resposta1 = "Louis Pasteur";
        q19.Resposta2 = "Alexander Fleming";
        q19.Resposta3 = "Marie Curie";
        q19.Resposta4 = "Isaac Newton";
        q19.Resposta5 = "Charles Darwin";

        q19.RespostaCerta = 2;
        q19.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q19);

        var q20 = new Questao();
        q20.Pergunta = "Qual é o país famoso por seus cangurus?";
        q20.Resposta1 = "Austrália";
        q20.Resposta2 = "Canadá";
        q20.Resposta3 = "África do Sul";
        q20.Resposta4 = "Brasil";
        q20.Resposta5 = "Nova Zelândia";

        q20.RespostaCerta = 1;
        q20.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q20);

        var q21 = new Questao();
        q21.Pergunta = "Qual é a principal religião da Índia?";
        q21.Resposta1 = "Cristianismo";
        q21.Resposta2 = "Hinduísmo";
        q21.Resposta3 = "Islamismo";
        q21.Resposta4 = "Budismo";
        q21.Resposta5 = "Judaísmo";

        q21.RespostaCerta = 2;
        q21.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q21);

        var q22 = new Questao();
        q22.Pergunta = "Qual é a língua oficial do Brasil?";
        q22.Resposta1 = "Espanhol";
        q22.Resposta2 = "Inglês";
        q22.Resposta3 = "Francês";
        q22.Resposta4 = "Português";
        q22.Resposta5 = "Italiano";

        q22.RespostaCerta = 4;
        q22.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q22);

        var q23 = new Questao();
        q23.Pergunta = "Qual é o menor país do mundo?";
        q23.Resposta1 = "Mônaco";
        q23.Resposta2 = "Vaticano";
        q23.Resposta3 = "San Marino";
        q23.Resposta4 = "Nauru";
        q23.Resposta5 = "Liechtenstein";

        q23.RespostaCerta = 2;
        q23.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q23);

        var q24 = new Questao();
        q24.Pergunta = "Quem foi o primeiro homem a pisar na Lua?";
        q24.Resposta1 = "Buzz Aldrin";
        q24.Resposta2 = "jailson mands";
        q24.Resposta3 = "Yuri Gagarin";
        q24.Resposta4 = "John Glenn";
        q24.Resposta5 = "Michael Collins";

        q24.RespostaCerta = 2;
        q24.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q24);

        var q25 = new Questao();
        q25.Pergunta = "é essa peça que você queria?";
        q25.Resposta1 = "essa mesmo?";
        q25.Resposta2 = "F";
        q25.Resposta3 = "Ir";
        q25.Resposta4 = "Fr";
        q25.Resposta5 = "Ff";

        q25.RespostaCerta = 1;
        q25.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q25);

        var q26 = new Questao();
        q26.Pergunta = "Qual é a maior floresta tropical do mundo?";
        q26.Resposta1 = "PNEUMOULTRAMICROSCOPICOSSILICOVULCANOCONIOSE. ";
        q26.Resposta2 = "Floresta do Congo";
        q26.Resposta3 = "Floresta Boreal";
        q26.Resposta4 = "Floresta da Taiga";
        q26.Resposta5 = "Floresta Atlântica";

        q26.RespostaCerta = 1;
        q26.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q26);

        var q27 = new Questao();
        q27.Pergunta = "Quem foi o autor de 'A Divina Comédia'?";
        q27.Resposta1 = "Virgílio";
        q27.Resposta2 = "tá se achando o odom comédia fdp?";
        q27.Resposta3 = "Homero";
        q27.Resposta4 = "Shakespeare";
        q27.Resposta5 = "Cervantes";

        q27.RespostaCerta = 2;
        q27.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q27);

        var q28 = new Questao();
        q28.Pergunta = "Qual a frase que você usaria se visse uma pessoa se decompondo em fezes ao ar livre?";
        q28.Resposta1 = "Rio Nilo";
        q28.Resposta2 = "Concentre-se em cada passo. Um de cada vez. Você vai conseguir.";
        q28.Resposta3 = "Essa é apenas uma situação momentânea. Logo isso vai passar e você poderá seguir com seu dia.";
        q28.Resposta4 = "CAGÃO, CAGÃO, CAGÃO, CAGÃO, CAGÃO";
        q28.Resposta5 = "osvaldo";

        q28.RespostaCerta = 1;
        q28.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q28);

        var q29 = new Questao();
        q29.Pergunta = "Qual é a montanha mais alta do mundo?";
        q29.Resposta1 = "K2";
        q29.Resposta2 = "Kangchenjunga";
        q29.Resposta3 = "as torres gemeas";
        q29.Resposta4 = "Lhotse";
        q29.Resposta5 = "Makalu";

        q29.RespostaCerta = 3;
        q29.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q29);

        var q30 = new Questao();
        q30.Pergunta = "Qual é o maior deserto do mundo?";
        q30.Resposta1 = "Deserto do Saara";
        q30.Resposta2 = "Deserto de Gobi";
        q30.Resposta3 = "Deserto de Atacama";
        q30.Resposta4 = "a boca de um africano";
        q30.Resposta5 = "Deserto do Kalahari";

        q30.RespostaCerta = 4;
        q30.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q30);

        var q31 = new Questao();
        q31.Pergunta = "Qual é a principal vitamina encontrada nas laranjas?";
        q31.Resposta1 = "Vitamina A";
        q31.Resposta2 = "Vitamina B12";
        q31.Resposta3 = "Vitamina de um pa-";
        q31.Resposta4 = "Vitamina D";
        q31.Resposta5 = "Vitamina E";

        q31.RespostaCerta = 3;
        q31.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q31);

        var q32 = new Questao();
        q32.Pergunta = "Qual animal é conhecido por sua habilidade de imitar sons?";
        q32.Resposta1 = "Papagaio";
        q32.Resposta2 = "Cão";
        q32.Resposta3 = "Gato";
        q32.Resposta4 = "Cavalo";
        q32.Resposta5 = "Coelho";

        q32.RespostaCerta = 1;
        q32.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q32);

        var q33 = new Questao();
        q33.Pergunta = "Qual é o nome da maior cadeia de montanhas do mundo?";
        q33.Resposta1 = "Andes";
        q33.Resposta2 = "meu pa-";
        q33.Resposta3 = "Alpes";
        q33.Resposta4 = "Rocosas";
        q33.Resposta5 = "Pirineus";

        q33.RespostaCerta = 2;
        q33.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q33);

        var q34 = new Questao();
        q34.Pergunta = "Quem é conhecido como o 'pai da psicanálise'?";
        q34.Resposta1 = "Carl Jung";
        q34.Resposta2 = "Sigma Freud";
        q34.Resposta3 = "B.F. Skinner";
        q34.Resposta4 = "Wilhelm Wundt";
        q34.Resposta5 = "Jean Piaget";

        q34.RespostaCerta = 2;
        q34.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q34);

        var q35 = new Questao();
        q35.Pergunta = "Qual é a capital da Espanha?";
        q35.Resposta1 = "Barcelona";
        q35.Resposta2 = "Madrid";
        q35.Resposta3 = "nacho?";
        q35.Resposta4 = "Valência";
        q35.Resposta5 = "Bilau";

        q35.RespostaCerta = 2;
        q35.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q35);

        var q36 = new Questao();
        q36.Pergunta = "Qual é o nome do continente onde está a maioria dos países árabes?";
        q36.Resposta1 = "granada";
        q36.Resposta2 = "África";
        q36.Resposta3 = "Europa";
        q36.Resposta4 = "América do Sul";
        q36.Resposta5 = "Oceania";

        q36.RespostaCerta = 1;
        q36.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q36);

        var q37 = new Questao();
        q37.Pergunta = "Qual é o nome do famoso festival de música que acontece em Woodstock?";
        q37.Resposta1 = "Lollapalooza";
        q37.Resposta2 = "Coachella";
        q37.Resposta3 = "Glastonbury";
        q37.Resposta4 = "cocaín-";
        q37.Resposta5 = "Tomorrowland";

        q37.RespostaCerta = 4;
        q37.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q37);

        var q38 = new Questao();
        q38.Pergunta = "Qual é o principal gás encontrado na atmosfera terrestre?";
        q38.Resposta1 = "Oxigênio";
        q38.Resposta2 = "Dióxido de Carbono";
        q38.Resposta3 = "peido de velhos beirando seus 90 anos ";
        q38.Resposta4 = "Hélio";
        q38.Resposta5 = "Argônio";

        q38.RespostaCerta = 3;
        q38.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q38);

        var q39 = new Questao();
        q39.Pergunta = "Qual é o nome do famoso quadro de Edvard Munch?";
        q39.Resposta1 = "A Noite Estrelada";
        q39.Resposta2 = "O Grito";
        q39.Resposta3 = "O Beijo grego";
        q39.Resposta4 = "A Persistência da Memória";
        q39.Resposta5 = "Guernica";

        q39.RespostaCerta = 2;
        q39.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q39);

        var q40 = new Questao();
        q40.Pergunta = "Qual é a capital da Rússia?";
        q40.Resposta1 = "São Petersburgo";
        q40.Resposta2 = "vodka";
        q40.Resposta3 = "Kiev";
        q40.Resposta4 = "Minsk";
        q40.Resposta5 = "Tóquio";

        q40.RespostaCerta = 2;
        q40.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q40);

        var q41 = new Questao();
        q41.Pergunta = "Qual é o maior mamífero terrestre?";
        q41.Resposta1 = "Rinoceronte";
        q41.Resposta2 = "sua irmã";
        q41.Resposta3 = "Girafa";
        q41.Resposta4 = "Urso Polar";
        q41.Resposta5 = "Hipopótamo";

        q41.RespostaCerta = 2;
        q41.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q41);

        var q42 = new Questao();
        q42.Pergunta = "Quem foi o primeiro presidente dos Estados Unidos?";
        q42.Resposta1 = "Abraham Lincoln";
        q42.Resposta2 = "não sei num tava lá";
        q42.Resposta3 = "Thomas Jefferson";
        q42.Resposta4 = "Franklin D. Roosevelt";
        q42.Resposta5 = "John Adams";

        q42.RespostaCerta = 2;
        q42.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q42);

        var q43 = new Questao();
        q43.Pergunta = "Qual é a capital da Argentina?";
        q43.Resposta1 = "pobreza ";
        q43.Resposta2 = "São Paulo";
        q43.Resposta3 = "Santiago";
        q43.Resposta4 = "Montevidéu";
        q43.Resposta5 = "Lima";

        q43.RespostaCerta = 1;
        q43.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q43);

        var q44 = new Questao();
        q44.Pergunta = "Qual é a primeira letra do alfabeto grego?";
        q44.Resposta1 = "beijo";
        q44.Resposta2 = "Alfa";
        q44.Resposta3 = "Gama";
        q44.Resposta4 = "Delta";
        q44.Resposta5 = "Épsilon";

        q44.RespostaCerta = 2;
        q44.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q44);

        var q45 = new Questao();
        q45.Pergunta = "Qual é o nome do famoso personagem de Sherlock Holmes?";
        q45.Resposta1 = "Dr. jacinto leite quente aq no rego";
        q45.Resposta2 = "Hercule Poirot";
        q45.Resposta3 = "Philip Marlowe";
        q45.Resposta4 = "James Bond";
        q45.Resposta5 = "Miss Marple";

        q45.RespostaCerta = 1;
        q45.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q45);

        var q46 = new Questao();
        q46.Pergunta = "Qual é a capital do Egito?";
        q46.Resposta1 = "Cairo";
        q46.Resposta2 = "Tunis";
        q46.Resposta3 = "Riad";
        q46.Resposta4 = "Beirute";
        q46.Resposta5 = "Cartum";

        q46.RespostaCerta = 1;
        q46.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q46);

        var q47 = new Questao();
        q47.Pergunta = "Qual é a moeda da União sovietica?";
        q47.Resposta1 = "Dólar";
        q47.Resposta2 = "Libra";
        q47.Resposta3 = "negr....";
        q47.Resposta4 = "Franco";
        q47.Resposta5 = "Yen";

        q47.RespostaCerta = 3;
        q47.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q47);

        var q48 = new Questao();
        q48.Pergunta = "Qual é o famoso festival de música que acontece na Alemanha?";
        q48.Resposta1 = "Oktoberfest";
        q48.Resposta2 = "Glastonbury";
        q48.Resposta3 = "Tomorrowland";
        q48.Resposta4 = "Coachella";
        q48.Resposta5 = "Lollapalooza";

        q48.RespostaCerta = 1;
        q48.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q48);

        var q49 = new Questao();
        q49.Pergunta = "Qual é o nome do famoso físico que formulou a teoria da relatividade?";
        q49.Resposta1 = "Isaac Newton";
        q49.Resposta2 = "Albert Einstein";
        q49.Resposta3 = "Galileu Galilei";
        q49.Resposta4 = "Stephen Hawking";
        q49.Resposta5 = "Nikola Tesla";

        q49.RespostaCerta = 2;
        q49.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q49);

        var q50 = new Questao();
        q50.Pergunta = "Qual é o país famoso por seus chocolates e relógios?";
        q50.Resposta1 = "Alemanha";
        q50.Resposta2 = "França";
        q50.Resposta3 = "Suíça";
        q50.Resposta4 = "Bélgica";
        q50.Resposta5 = "Holanda";

        q50.RespostaCerta = 3;
        q50.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q50);

        var q51 = new Questao();
        q51.Pergunta = "Qual é a capital do Canadá?";
        q51.Resposta1 = "Toronto";
        q51.Resposta2 = "Vancouver";
        q51.Resposta3 = "Ottawa";
        q51.Resposta4 = "Montreal";
        q51.Resposta5 = "Calgary";

        q51.RespostaCerta = 3;
        q51.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q51);

        var q52 = new Questao();
        q52.Pergunta = "Qual é o nome do famoso carro esportivo da Ferrari?";
        q52.Resposta1 = "Mustang";
        q52.Resposta2 = "Civic";
        q52.Resposta3 = "F40";
        q52.Resposta4 = "Corvette";
        q52.Resposta5 = "Porsche 911";

        q52.RespostaCerta = 3;
        q52.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q52);

        var q53 = new Questao();
        q53.Pergunta = "Qual é o país conhecido por sua cultura do chá?";
        q53.Resposta1 = "Índia";
        q53.Resposta2 = "Japão";
        q53.Resposta3 = "China";
        q53.Resposta4 = "Reino Unido";
        q53.Resposta5 = "Turquia";

        q53.RespostaCerta = 3;
        q53.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q53);

        var q54 = new Questao();
        q54.Pergunta = "Qual é o nome do sistema esquelético de um polvo?";
        q54.Resposta1 = "Monarquia";
        q54.Resposta2 = "Ditadura";
        q54.Resposta3 = "República";
        q54.Resposta4 = "Democracia";
        q54.Resposta5 = "Teocracia";

        q54.RespostaCerta = 1;
        q54.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q54);

        var q55 = new Questao();
        q55.Pergunta = "Qual é a fórmula da glicose?";
        q55.Resposta1 = "docin";
        q55.Resposta2 = "C2H5OH";
        q55.Resposta3 = "NaCl";
        q55.Resposta4 = "H2O";
        q55.Resposta5 = "CO2";

        q55.RespostaCerta = 1;
        q55.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q55);

        var q56 = new Questao();
        q56.Pergunta = "Qual é a capital da Alemanha?";
        q56.Resposta1 = "auschwitz";
        q56.Resposta2 = "Munique";
        q56.Resposta3 = "Frankfurt";
        q56.Resposta4 = "Hamburgo";
        q56.Resposta5 = "Colônia";

        q56.RespostaCerta = 1;
        q56.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q56);

        var q57 = new Questao();
        q57.Pergunta = "Qual é a capital da Grécia?";
        q57.Resposta1 = "beijo grego novamente....";
        q57.Resposta2 = "Salônica";
        q57.Resposta3 = "Heraclión";
        q57.Resposta4 = "Patras";
        q57.Resposta5 = "Náuplia";

        q57.RespostaCerta = 1;
        q57.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q57);

        var q58 = new Questao();
        q58.Pergunta = "Qual é o maior lago do mundo?";
        q58.Resposta1 = "Lago Superior";
        q58.Resposta2 = "Lago Baikal";
        q58.Resposta3 = "Lago Vitória";
        q58.Resposta4 = "a cabeça de uma criança com hidrocefalia";
        q58.Resposta5 = "Lago Tanganica";

        q58.RespostaCerta = 4;
        q58.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q58);

        var q59 = new Questao();
        q59.Pergunta = "Qual é a língua oficial da China?";
        q59.Resposta1 = "Inglês";
        q59.Resposta2 = "trabalho infantil";
        q59.Resposta3 = "Cantonês";
        q59.Resposta4 = "Tibetano";
        q59.Resposta5 = "Hakka";

        q59.RespostaCerta = 2;
        q59.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q59);

        var q60 = new Questao();
        q60.Pergunta = "Qual é o famoso monumento de Paris?";
        q60.Resposta1 = "meu pau";
        q60.Resposta2 = "Coliseu";
        q60.Resposta3 = "Torre de Pisa";
        q60.Resposta4 = "Big Ben";
        q60.Resposta5 = "Estátua da Liberdade";

        q60.RespostaCerta = 1;
        q60.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q60);

        var q61 = new Questao();
        q61.Pergunta = "Qual é o elemento químico com símbolo Na?";
        q61.Resposta1 = "não cuzinho não";
        q61.Resposta2 = "Nitrogênio";
        q61.Resposta3 = "Cloro";
        q61.Resposta4 = "Cálcio";
        q61.Resposta5 = "Fósforo";

        q61.RespostaCerta = 1;
        q61.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q61);

        var q62 = new Questao();
        q62.Pergunta = "Qual é a capital do Brasil?";
        q62.Resposta1 = "Rio de Janeiro";
        q62.Resposta2 = "São Paulo";
        q62.Resposta3 = "corrupção";
        q62.Resposta4 = "Belo Horizonte";
        q62.Resposta5 = "Salvador";

        q62.RespostaCerta = 3;
        q62.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q62);

        var q63 = new Questao();
        q63.Pergunta = "Qual é o famoso documento que declarou a independência dos Estados Unidos?";
        q63.Resposta1 = "Constituição";
        q63.Resposta2 = "Declaração dos Direitos";
        q63.Resposta3 = "Declaração de Independência para agressão de pessoas negras";
        q63.Resposta4 = "Bill of Rights";
        q63.Resposta5 = "Federalist Papers";

        q63.RespostaCerta = 3;
        q63.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q63);

        var q64 = new Questao();
        q64.Pergunta = "Qual é o nome do movimento artístico que enfatizou a razão e a ciência?";
        q64.Resposta1 = "Romantismo";
        q64.Resposta2 = "Realismo";
        q64.Resposta3 = "punheta";
        q64.Resposta4 = "Barroco";
        q64.Resposta5 = "Modernismo";

        q64.RespostaCerta = 3;
        q64.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q64);

        var q65 = new Questao();
        q65.Pergunta = "Qual é o famoso romance de Jane Austen?";
        q65.Resposta1 = "homofobia e Preconceito";
        q65.Resposta2 = "Jane Eyre";
        q65.Resposta3 = "O Morro dos Ventos Uivantes";
        q65.Resposta4 = "Crime e Castigo";
        q65.Resposta5 = "A Revolução dos Bichos";

        q65.RespostaCerta = 1;
        q65.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q65);

        var q66 = new Questao();
        q66.Pergunta = "Qual é o continente onde está localizado o deserto do Saara?";
        q66.Resposta1 = "África";
        q66.Resposta2 = "Ásia";
        q66.Resposta3 = "América do Sul";
        q66.Resposta4 = "Oceania";
        q66.Resposta5 = "Europa";

        q66.RespostaCerta = 1;
        q66.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q66);

        var q67 = new Questao();
        q67.Pergunta = "Qual é a capital da Índia?";
        q67.Resposta1 = "Bombaim";
        q67.Resposta2 = "आनन्द संघर्ष मे, प्रयास मे, एहि मे शामिल दुख मे होइत छैक आ स्वयं जीत मे नहि";
        q67.Resposta3 = "fome";
        q67.Resposta4 = "Chennai";
        q67.Resposta5 = "Hyderabad";

        q67.RespostaCerta = 2;
        q67.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q67);

        var q68 = new Questao();
        q68.Pergunta = "Qual é o maior oceano do mundo?";
        q68.Resposta1 = "Oceano Atlântico";
        q68.Resposta2 = "Oceano Pacífico";
        q68.Resposta3 = "Oceano Índico";
        q68.Resposta4 = "Oceano Ártico";
        q68.Resposta5 = "Oceano Antártico";

        q68.RespostaCerta = 2;
        q68.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q68);

        var q69 = new Questao();
        q69.Pergunta = "Qual é a capital da França?";
        q69.Resposta1 = "Londres";
        q69.Resposta2 = "Berlim";
        q69.Resposta3 = "Madri";
        q69.Resposta4 = "PSG";
        q69.Resposta5 = "Roma";

        q69.RespostaCerta = 4;
        q69.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q69);

        var q70 = new Questao();
        q70.Pergunta = "Qual é o nome do primeiro satélite lançado ao espaço?";
        q70.Resposta1 = "Apollo 11";
        q70.Resposta2 = "Vostok 1";
        q70.Resposta3 = "sla man, pergunta para ele";
        q70.Resposta4 = "Explorer 1";
        q70.Resposta5 = "Hubble";

        q70.RespostaCerta = 3;
        q70.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q70);

        var q71 = new Questao();
        q71.Pergunta = "Qual é a fórmula química da água?";
        q71.Resposta1 = "H2O";
        q71.Resposta2 = "CO2";
        q71.Resposta3 = "NaCl";
        q71.Resposta4 = "C6H12O6";
        q71.Resposta5 = "CH4";

        q71.RespostaCerta = 1;
        q71.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q71);

        var q72 = new Questao();
        q72.Pergunta = "Qual é a capital da Suécia?";
        q72.Resposta1 = "Estocolmo";
        q72.Resposta2 = "Helsinque";
        q72.Resposta3 = "Oslo";
        q72.Resposta4 = "Copenhague";
        q72.Resposta5 = "Reykjavique";

        q72.RespostaCerta = 1;
        q72.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q72);

        var q73 = new Questao();
        q73.Pergunta = "Qual é a moeda da Rússia?";
        q73.Resposta1 = "Dólar";
        q73.Resposta2 = "Euro";
        q73.Resposta3 = "rublo";
        q73.Resposta4 = "Yen";
        q73.Resposta5 = "Franco";

        q73.RespostaCerta = 3;
        q73.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q73);

        var q74 = new Questao();
        q74.Pergunta = "Quem é o famoso personagem da Disney que é um pato?";
        q74.Resposta1 = "Pato Donald vstido de hitl-";
        q74.Resposta2 = "Mickey Mouse";
        q74.Resposta3 = "Pateta";
        q74.Resposta4 = "Pato Lucas";
        q74.Resposta5 = "Tico e Teco";

        q74.RespostaCerta = 1;
        q74.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q74);

        var q75 = new Questao();
        q75.Pergunta = "Qual é o nome do famoso super-herói da Marvel que é um Homem de Ferro?";
        q75.Resposta1 = "Thor";
        q75.Resposta2 = "Capitão América";
        q75.Resposta3 = "Hulk";
        q75.Resposta4 = "Iron Dick Man";
        q75.Resposta5 = "Spider-cook";

        q75.RespostaCerta = 4;
        q75.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q75);

        var q76 = new Questao();
        q76.Pergunta = "Qual é o nome do famoso cientista que descobriu a penicilina?";
        q76.Resposta1 = "Louis Pasteur";
        q76.Resposta2 = "Marie Curie";
        q76.Resposta3 = "Alexander Fleming";
        q76.Resposta4 = "Gregor Mendel";
        q76.Resposta5 = "Charles Darwin";

        q76.RespostaCerta = 3;
        q76.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q76);

        var q77 = new Questao();
        q77.Pergunta = "Qual é o nome da famosa obra de arte de Leonardo da Vinci?";
        q77.Resposta1 = "não confie no judas";
        q77.Resposta2 = "O Nascimento de Vênus";
        q77.Resposta3 = "A Criação de Adão";
        q77.Resposta4 = "A Noite Estrelada";
        q77.Resposta5 = "O Grito";

        q77.RespostaCerta = 1;
        q77.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q77);

        var q78 = new Questao();
        q78.Pergunta = "Qual é a capital da Nova Zelândia?";
        q78.Resposta1 = "Auckland";
        q78.Resposta2 = "Wellington";
        q78.Resposta3 = "Christchurch";
        q78.Resposta4 = "Hamilton";
        q78.Resposta5 = "Dunedin";

        q78.RespostaCerta = 2;
        q78.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q78);

        var q79 = new Questao();
        q79.Pergunta = "Qual é o nome do famoso detetive criado por Arthur Conan Doyle?";
        q79.Resposta1 = "Hercule Poirot";
        q79.Resposta2 = "Miss Marple";
        q79.Resposta3 = "Sherlock Holmes";
        q79.Resposta4 = "Philip Marlowe";
        q79.Resposta5 = "Sam Spade";

        q79.RespostaCerta = 3;
        q79.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q79);

        var q80 = new Questao();
        q80.Pergunta = "Qual é o principal ingrediente do guacamole?";
        q80.Resposta1 = "Tomate";
        q80.Resposta2 = "Cebola";
        q80.Resposta3 = "Abacate";
        q80.Resposta4 = "Pimentão";
        q80.Resposta5 = "porra de um mexicano mucho loco";

        q80.RespostaCerta = 3;
        q80.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q80);

        var q81 = new Questao();
        q81.Pergunta = "Qual é a capital do Japão?";
        q81.Resposta1 = "goku";
        q81.Resposta2 = "Seul";
        q81.Resposta3 = "Pequim";
        q81.Resposta4 = "Banguecoque";
        q81.Resposta5 = "Hanoí";

        q81.RespostaCerta = 1;
        q81.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q81);

        var q82 = new Questao();
        q82.Pergunta = "Qual é a famosa obra do dramaturgo William Shakespeare?";
        q82.Resposta1 = "Romeu e Julieta";
        q82.Resposta2 = "Dom Quixote d' FLAMENGO";
        q82.Resposta3 = "Divina facínora";
        q82.Resposta4 = "O Morro dos Ventos Uivantes";
        q82.Resposta5 = "Crime e Castigo";

        q82.RespostaCerta = 1;
        q82.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q82);

        var q83 = new Questao();
        q83.Pergunta = "Qual é a capital da Turquia?";
        q83.Resposta1 = "Istambul";
        q83.Resposta2 = "Ancara";
        q83.Resposta3 = "Izmir";
        q83.Resposta4 = "Antália";
        q83.Resposta5 = "Bursa";

        q83.RespostaCerta = 2;
        q83.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q83);

        var q84 = new Questao();
        q84.Pergunta = "Qual é o famoso prato italiano feito com massa e molho?";
        q84.Resposta1 = "Sushi";
        q84.Resposta2 = "Tacos";
        q84.Resposta3 = "Pizza";
        q84.Resposta4 = "temporrad'chefe";
        q84.Resposta5 = "Curry";

        q84.RespostaCerta = 4;
        q84.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q84);

        var q85 = new Questao();
        q85.Pergunta = "Qual é a principal função do fígado no corpo humano?";
        q85.Resposta1 = "Respiração";
        q85.Resposta2 = "Filtração de sangue";
        q85.Resposta3 = "reprodução sexual de jegues";
        q85.Resposta4 = "Movimentação";
        q85.Resposta5 = "Digestão";

        q85.RespostaCerta = 3;
        q85.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q85);

        var q86 = new Questao();
        q86.Pergunta = "Qual é o nome da famosa canção de John Lennon que fala sobre paz?";
        q86.Resposta1 = "Imagine";
        q86.Resposta2 = "Hey Jude";
        q86.Resposta3 = "Let It Be";
        q86.Resposta4 = "Yesterday";
        q86.Resposta5 = "Come Together";

        q86.RespostaCerta = 1;
        q86.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q86);

        var q87 = new Questao();
        q87.Pergunta = "Qual é a capital da Itália?";
        q87.Resposta1 = "Veneza";
        q87.Resposta2 = "croissant";
        q87.Resposta3 = "Milão";
        q87.Resposta4 = "Florença";
        q87.Resposta5 = "Nápoles";

        q87.RespostaCerta = 2;
        q87.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q87);

        var q88 = new Questao();
        q88.Pergunta = "Qual é o nome do famoso super-herói da DC que é conhecido como Homem fimose?";
        q88.Resposta1 = "Superman";
        q88.Resposta2 = "Batpica";
        q88.Resposta3 = "Aquaman";
        q88.Resposta4 = "Flash";
        q88.Resposta5 = "Lanterna Verde";

        q88.RespostaCerta = 2;
        q88.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q88);

        var q89 = new Questao();
        q89.Pergunta = "Qual é a capital da Coreia do Sul?";
        q89.Resposta1 = "Kim Jong-Un";
        q89.Resposta2 = "Pyongyang";
        q89.Resposta3 = "Tóquio";
        q89.Resposta4 = "Pequim";
        q89.Resposta5 = "Banguecoque";

        q89.RespostaCerta = 1;
        q89.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q89);

        var q90 = new Questao();
        q90.Pergunta = "Qual é o nome do famoso deus da mitologia grega que é o deus do trovão?";
        q90.Resposta1 = "comedor de casadas e casados vulgo qm nega buraco é prefeitura";
        q90.Resposta2 = "Poseidon";
        q90.Resposta3 = "Hades";
        q90.Resposta4 = "Apolo";
        q90.Resposta5 = "Atena";

        q90.RespostaCerta = 1;
        q90.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q90);

        var q91 = new Questao();
        q91.Pergunta = "Qual é a famosa obra de arte de Edvard Munch?";
        q91.Resposta1 = "A Noite Estrelada";
        q91.Resposta2 = "O Grito";
        q91.Resposta3 = "A Última Ceia";
        q91.Resposta4 = "O Nascimento de Vênus";
        q91.Resposta5 = "A Criação de Adão";

        q91.RespostaCerta = 2;
        q91.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q91);

        var q92 = new Questao();
        q92.Pergunta = "Qual é a capital da Noruega?";
        q92.Resposta1 = "Oslo";
        q92.Resposta2 = "Estocolmo";
        q92.Resposta3 = "Helsinque";
        q92.Resposta4 = "Copenhague";
        q92.Resposta5 = "Reykjavique";

        q92.RespostaCerta = 1;
        q92.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q92);

        var q93 = new Questao();
        q93.Pergunta = "Qual é a maior floresta tropical do mundo?";
        q93.Resposta1 = "os pentelhos da bunda do joabe";
        q93.Resposta2 = "Floresta do Congo";
        q93.Resposta3 = "Floresta Boreal";
        q93.Resposta4 = "Floresta Negra";
        q93.Resposta5 = "Floresta de Taiga";

        q93.RespostaCerta = 1;
        q93.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q93);

        var q94 = new Questao();
        q94.Pergunta = "Qual é a capital da Áustria?";
        q94.Resposta1 = "fome";
        q94.Resposta2 = "Budapeste";
        q94.Resposta3 = "Praga";
        q94.Resposta4 = "Bratislava";
        q94.Resposta5 = "Zurique";

        q94.RespostaCerta = 1;
        q94.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q94);

        var q95 = new Questao();
        q95.Pergunta = "Qual é a famosa série de livros de J.K. Rowling?";
        q95.Resposta1 = "O Senhor dos Anéis";
        q95.Resposta2 = "As Crônicas de Nárnia";
        q95.Resposta3 = "Harry Potter";
        q95.Resposta4 = "O Hobbit";
        q95.Resposta5 = "Percy Jackson";

        q95.RespostaCerta = 3;
        q95.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q95);

        var q96 = new Questao();
        q96.Pergunta = "Qual é a capital da Finlândia?";
        q96.Resposta1 = "Fin hora de aventura";
        q96.Resposta2 = "Oslo";
        q96.Resposta3 = "Estocolmo";
        q96.Resposta4 = "Copenhague";
        q96.Resposta5 = "Reykjavique";

        q96.RespostaCerta = 1;
        q96.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q96);

        var q97 = new Questao();
        q97.Pergunta = "Qual é a capital da Islândia?";
        q97.Resposta1 = "Reykjavique";
        q97.Resposta2 = "Oslo";
        q97.Resposta3 = "Helsinque";
        q97.Resposta4 = "Copenhague";
        q97.Resposta5 = "Estocolmo";

        q97.RespostaCerta = 1;
        q97.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q97);

        var q98 = new Questao();
        q98.Pergunta = "Qual é a moeda da Índia?";
        q98.Resposta1 = "vacas";
        q98.Resposta2 = "Dólar";
        q98.Resposta3 = "Euro";
        q98.Resposta4 = "Yen";
        q98.Resposta5 = "Libra";

        q98.RespostaCerta = 1;
        q98.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q98);

        var q99 = new Questao();
        q99.Pergunta = "Qual é o nome da famosa cerveja belga?";
        q99.Resposta1 = "Heineken";
        q99.Resposta2 = "Stella Artois";
        q99.Resposta3 = "Budweiser";
        q99.Resposta4 = "Corona";
        q99.Resposta5 = "Guinness";

        q99.RespostaCerta = 2;
        q99.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q99);

        var q100 = new Questao();
        q100.Pergunta = "Qual é a capital da Escócia?";
        q100.Resposta1 = "albion online é um MMO RPG estilo sandbox onde vc cria seu proprio mundo...";
        q100.Resposta2 = "Glasgow";
        q100.Resposta3 = "Aberdeen";
        q100.Resposta4 = "Inverness";
        q100.Resposta5 = "Dundee";

        q100.RespostaCerta = 1;
        q100.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q100);
    }

    public void ProximaQuestao(){
        var numRandom = Random.Shared.Next(0, listaQuestoes.Count- 1);

        while(listaQuestaoRespondida.Contains(numRandom)){
            numRandom = Random.Shared.Next(0,listaQuestoes.Count - 1);
        } 

        listaQuestaoRespondida.Add(numRandom);
        questaoAtual = listaQuestoes[numRandom];
        questaoAtual.Desenhar();
    }

    public async void VerificaCorreta(int rr)
    {
        if(questaoAtual.VerificaResposta(rr)){
            await Task.Delay(1000);
            ProximaQuestao();
        }
    }
}
        