namespace nome;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    public void FDS(object sender, EventArgs e)
    {
        Application.Current.MainPage = new GamePage();
    }
}