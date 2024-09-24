﻿namespace nome;

public partial class MainPage : ContentPage
{
	Gerenciador Gerenciador;
    public MainPage()
    {
        InitializeComponent();
        Gerenciador = new Gerenciador(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
        Gerenciador = ProximaPergunta();
    }
    void OnBTNResp01Clicked(object sender, EventArgs args)
    {
        Gerenciador.VerificaCorreto(1);
    }
    void OnBTNResp02Clicked(object sender, EventArgs args)
    {
        Gerenciador.VerificaCorreto(2);
    }
    void OnBTNResp03Clicked(object sender, EventArgs args)
    {
        Gerenciador.VerificaCorreto(3);
    }
    void OnBTNResp04Clicked(object sender, EventArgs args)
    {
        Gerenciador.VerificaCorreto(4);
    }
    void OnBTNResp05Clicked(object sender, EventArgs args)
    {
        Gerenciador.VerificaCorreto(5);
    }
}

