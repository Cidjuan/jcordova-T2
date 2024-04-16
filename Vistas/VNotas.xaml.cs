namespace jcordova_T2.Vistas;

public partial class VNotas : ContentPage
{
    public VNotas()
    {
        InitializeComponent();
    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        Double notaParcial1 = Convert.ToDouble(txtNotaPar1.Text);
        Double notaParcial2 = Convert.ToDouble(txtNotaPar2.Text);
        Double notaFinal = Convert.ToDouble(txtNotaFinal.Text);
        string nombre = pkEstudiantes.SelectedItem.ToString();
        string fecha = dpFecha.Date.ToString("dd/MM/yyyy");
        string estado = "";
        if (notaFinal >= 7)
        {
            estado = "APROBADO";
        }
        else if (notaFinal >= 5 && notaFinal <= 6.9)
        {
            estado = "COMPLEMENTARIO";
        }
        else
        {
            estado = "REPROBADO";
        }
        DisplayAlert("Resultado", "Nombre: " + nombre + "\nFecha: " + fecha +
            "\nNota Parcial 1: " + notaParcial1 + "\nNota Parcial 2: " + notaParcial2 +
            "\nNota Final: " + notaFinal + "\nEstado: " + estado, "Cancelar");

    }

    private void txtNotaSeg1_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (txtNotaSeg1.Text != "")
        {
            ValidacionEntradas(txtNotaSeg1.Text);
            ActualizarNotaParcial1();
        }
    }

    private void txtNotaExam1_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (txtNotaExam1.Text != "")
        {
            ValidacionEntradas(txtNotaExam1.Text);
            ActualizarNotaParcial1();
        }
    }

    private void txtNotaSeg2_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (txtNotaSeg2.Text != "")
        {
            ValidacionEntradas(txtNotaSeg2.Text);
            ActualizarNotaParcial2();
        }
    }

    private void txtNotaExam2_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (txtNotaExam2.Text != "")
        {
            ValidacionEntradas(txtNotaExam2.Text);
            ActualizarNotaParcial2();
        }
    }

    private void ActualizarNotaParcial1()
    {
        Double notaParcial1 = (Convert.ToDouble(txtNotaSeg1.Text) * 0.3) +
            (Convert.ToDouble(txtNotaExam1.Text) * 0.2);
        txtNotaPar1.Text = Convert.ToString(notaParcial1);
    }

    private void ActualizarNotaParcial2()
    {
        Double notaParcial2 = (Convert.ToDouble(txtNotaSeg2.Text) * 0.3) +
            (Convert.ToDouble(txtNotaExam2.Text) * 0.2);
        txtNotaPar2.Text = Convert.ToString(notaParcial2);
    }

    private void ValidacionEntradas(string nota)
    {
        Double calificacion = Convert.ToDouble(nota);
        if (calificacion > 10 || calificacion < 0)
        {
            DisplayAlert("Error", "Valor ingresado no permitido\n" +
                "Solo se aceptan valores entre 0.1-10", "Cerrar");
        }
    }

    private void txtNotaPar1_TextChanged(object sender, TextChangedEventArgs e)
    {
        ActualizarNotaFinal();
    }

    private void txtNotaPar2_TextChanged(object sender, TextChangedEventArgs e)
    {
        ActualizarNotaFinal();
    }

    private void ActualizarNotaFinal()
    {
        Double notaFinal = Convert.ToDouble(txtNotaPar1.Text) +
        Convert.ToDouble(txtNotaPar2.Text);
        txtNotaFinal.Text = Convert.ToString(notaFinal);
    }

    private void LimpiarDatos()
    {
        txtNotaSeg1.Text = "0";
        txtNotaSeg2.Text = "0";
        txtNotaExam1.Text = "0";
        txtNotaExam2.Text = "0";
        txtNotaPar1.Text = "0";
        txtNotaPar2.Text = "0";
        txtNotaFinal.Text = "0";
        dpFecha.Date = DateTime.Now;
    }

    private void pkEstudiantes_SelectedIndexChanged(object sender, EventArgs e)
    {
        LimpiarDatos();
    }
}