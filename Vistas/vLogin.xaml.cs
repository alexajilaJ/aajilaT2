namespace aajilaT2.Vistas;

public partial class vLogin : ContentPage
{
    string[] user = { "Carlos", "Ana", "Jose" };
    string[] pass = { "carlos123", "ana123", "jose123" };
    public vLogin()
	{
		InitializeComponent();
	}
    private bool validarUsuarios(string usu, string pas)
    {
        for (int i = 0; i < user.Length; i++)
        {
            if (user[i] == usu && pass[i] == pas)
            {
                return true;
            }
        }
        return false;
    }

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        string usu = txtUsuario.Text;
        string pas = txtContrasena.Text;
        if (validarUsuarios(usu, pas))
        {
            DisplayAlert("Bienvenido", $"Usuario actual , {usu}!", "OK");
            Navigation.PushAsync(new MainPage());
        }
        else
        {
            DisplayAlert("Alerta", "Usuario/contraseña incorrectos", "cerrar");
            txtUsuario.Text = "";
            txtContrasena.Text = "";
        }
       

    }
}