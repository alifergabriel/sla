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
		Navigation.PushAsync(new GamePage());
	}

}