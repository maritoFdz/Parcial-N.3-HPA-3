using Ejercicio3.Validar;

namespace Ejercicio3;

public partial class Form1 : Form
{

    public Form1() // aqui puse lo de que los eventos se agreguen porque se me olvida siempre
    {
        InitializeComponent();
        Load += Form1_Load;
        btnRegistrar.Click += btnRegistrar_Click;
        btnLogin.Click += btnLogin_Click;
    }

    private void Form1_Load(object? sender, EventArgs e)
    {
        CargarIntentos();
    }

    private bool DatosCorrectos(bool esRegistro)
    {
        List<(TextBox txt, IValidatorCampo validador)> campos = [ (txtUsuario, new ValidadorTexto()),
            (txtClave, esRegistro ? (IValidatorCampo) new ValidadorClave() : new ValidadorTexto()) ]; // si es registro que valide que la clave es valida

        bool taBien = true;
        foreach (var (txt, validador) in campos) // saca si hubo algun error segun lo que digan los validator y lo tira pal errorProvider
        {
            if (!validador.EsValido(txt.Text))
            {
                errorProvider1.SetError(txt, validador.MensajeError);
                taBien = false;
            }
            else
                errorProvider1.SetError(txt, string.Empty);
        }
        return taBien;
    }

    private void btnRegistrar_Click(object? sender, EventArgs e)
    {
        if (!DatosCorrectos(true)) return;

        try
        {
            string? hash = Utiles.Registrar(txtUsuario.Text.Trim(), txtClave.Text); // produce el hash para ver si existe el user

            if (hash == null) // esto quiere decir que el usuario esta repe
            {
                lblResultado.ForeColor = Color.Red;
                lblResultado.Text = "Ese usuario ya existe";
                return;
            }
            // aqui quiere decir que eta todo bien
            lblResultado.ForeColor = Color.Green;
            lblResultado.Text = "Usuario registrado";
            MessageBox.Show("Hash generado:\n" + hash, "Registro exitoso");
            LimpiarCampos();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }

    private void btnLogin_Click(object? sender, EventArgs e)
    {
        if (!DatosCorrectos(false)) return;

        string user = txtUsuario.Text.Trim();

        try
        {
            if (Utiles.Login(user, txtClave.Text))
            {
                lblResultado.ForeColor = Color.Green;
                lblResultado.Text = $"Bienvenido {user}";
                MessageBox.Show($"Bienvenido {user}", "Exito");
            }
            else
            {
                lblResultado.ForeColor = Color.Red;
                lblResultado.Text = "Usuario o password mal";
            }

            txtClave.Clear();
            CargarIntentos();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }

    private void CargarIntentos()
    {
        try
        {
            dgvIntentos.DataSource = Utiles.ObtenerIntentos();
        }
        catch (Exception ex) // por si no coge la tabla de datos
        {
            MessageBox.Show("No se pudo cargar el historial: " + ex.Message);
        }
    }

    private void LimpiarCampos()
    {
        txtUsuario.Clear();
        txtClave.Clear();
    }
}