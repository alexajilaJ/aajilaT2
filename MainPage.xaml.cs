namespace aajilaT2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            string fecha = dpFecha.Date.ToString();
            int nota = Convert.ToInt32(txtNota1.Text);
            int examen = Convert.ToInt32(txtExamen.Text);
            double parcial = (nota * 0.3) + (examen * 0.2);
            int nota1 = Convert.ToInt32(txtNota2.Text);
            int examen1 = Convert.ToInt32(txtExamen1.Text);
            double parcial2 = (nota1 * 0.3) + (examen1 * 0.2);
            double notaFinal = parcial + parcial2;
            if (pkAlumnos.SelectedIndex == -1)
            {
                DisplayAlert("Alerta", "seleccione un Alumno ", "Cerrar");
            /*}else if (nota != null || examen == null && nota1 == null && examen1 == null){
                DisplayAlert("Alerta", "campos de notas vacios ", "Cerrar");*/
            }else if (nota > 10 || nota < 0 || nota1 > 10 || nota1 < 0 || examen > 10 || examen < 0 || examen1 > 10 || examen1 < 0){
                DisplayAlert("Alerta", "notas ingresadas fuera del rago 0-10 ", "Cerrar");
            }else if (notaFinal >= 5 && notaFinal <= 6.9){
                    string dato = pkAlumnos.Items[pkAlumnos.SelectedIndex].ToString();

                    DisplayAlert("Estado ", "Alumno: " + dato + " \nFecha: " + fecha + "\n Parcial 1: " + parcial +
                    " \nParcial 2: " + parcial2 + "\nNota Final: " + notaFinal + "\nComplementario", "Cerrar");
            }else if (notaFinal < 5){
                    string dato = pkAlumnos.Items[pkAlumnos.SelectedIndex].ToString();

                    DisplayAlert("Estado ", "Alumno: " + dato + " \nFecha: " + fecha + "\nParcial 1: " + parcial +
                    " \nParcial 2: " + parcial2 + "\nNota Final: " + notaFinal + "\nReprobado", "Cerrar");
            }else{
                    string dato = pkAlumnos.Items[pkAlumnos.SelectedIndex].ToString();

                    DisplayAlert("Estado ", "Alumno: " + dato + " \nFecha: " + fecha + "\nParcial 1: " + parcial +
                    " \nParcial 2: " + parcial2 + "\nNota Final: " + notaFinal + "\nAprobado ", "Cerrar");
            }
        }
        private void btnRegresar_Clicked(object sender, EventArgs e)
        {
            txtNota1.Text = "";
            txtExamen.Text = "";
            txtNota2.Text = "";
            txtExamen1.Text = "";
        }

    }

}
