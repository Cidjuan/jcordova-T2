using static System.Runtime.InteropServices.JavaScript.JSType;

namespace jcordova_T2.Vistas;

public partial class Login : ContentPage
{
    string usuario1;
    string contrase�a1;
	public Login()
	{
		InitializeComponent();
	}

    public Login(string usuario, string contrase�a)
    {
        InitializeComponent();
        usuario1 = usuario;
        contrase�a1 = contrase�a;
    }

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
		

        if (txtUsuario.Text == usuario1 && txtContraase�a.Text == contrase�a1)
			{
			Navigation.PushAsync(new VNotas(usuario1));
			}
        else
        {
            DisplayAlert("Alerta", "Usuario o Contrase�a incorrectos", "Cerrar");
        }
    }

    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new vRegistro());
    }
}