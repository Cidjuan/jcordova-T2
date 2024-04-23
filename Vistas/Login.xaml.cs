using static System.Runtime.InteropServices.JavaScript.JSType;

namespace jcordova_T2.Vistas;

public partial class Login : ContentPage
{
    string usuario1;
    string contraseña1;
	public Login()
	{
		InitializeComponent();
	}

    public Login(string usuario, string contraseña)
    {
        InitializeComponent();
        usuario1 = usuario;
        contraseña1 = contraseña;
    }

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
		

        if (txtUsuario.Text == usuario1 && txtContraaseña.Text == contraseña1)
			{
			Navigation.PushAsync(new VNotas(usuario1));
			}
        else
        {
            DisplayAlert("Alerta", "Usuario o Contraseña incorrectos", "Cerrar");
        }
    }

    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new vRegistro());
    }
}