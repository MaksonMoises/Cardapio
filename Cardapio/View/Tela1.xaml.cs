using System.Threading.Tasks;

namespace Cardapio.View;

public partial class Tela1 : ContentPage
{
	public Tela1()
	{
		InitializeComponent();
	}

    private async void In_cardapio(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new Tela2());
    }

	private void Esqueci(object sender, EventArgs e)
	{
		DisplayAlert("Aviso", "Se você não sabe sua senha, imagine eu...", "?????");
	}
}