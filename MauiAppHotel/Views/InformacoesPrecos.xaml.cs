namespace MauiAppHotel.Views;

public partial class InformacoesPrecos : ContentPage
{
	public InformacoesPrecos()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            await Navigation.PopAsync();
        }
        catch (Exception ex)
        {
            await DisplayAlertAsync("Ops", ex.Message, "Fechar");
        }
    }
}