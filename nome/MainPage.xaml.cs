namespace nome;

public partial class MainPage : ContentPage
{
	Gerenciador gerenciador;
    public MainPage()
    {
        InitializeComponent();
    }

    public void GORDA(object sender, EventArgs e)
	{
		Application.Current.MainPage = new GamePage();
	}

}