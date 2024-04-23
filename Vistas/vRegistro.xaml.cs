namespace jcordova_T2.Vistas;

public partial class vRegistro : ContentPage
{
	public vRegistro()
	{
		InitializeComponent();
	}

    private void btnRegistrar_Clicked(object sender, EventArgs e)
    {
		string usuario = txtUsuario.Text;
		string contraseña = txtContraseña.Text;

		Navigation.PushAsync(new Login(usuario, contraseña));
    }
}