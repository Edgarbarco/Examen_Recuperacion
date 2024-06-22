using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Examen_Recuperacion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            Alumno alumno = new Alumno
            {
                Nombres = txtNombres.Text,
                Apellidos = txtApellidos.Text,
                Carnet = txtCarnet.Text,
                Telefono = txtTelefono.Text,
                IdCarrera = int.Parse(cbCarreras.SelectedValue?.ToString() ?? "0")
            };
            int result = dataAccess.Update(alumno);
            if (result > 0)
            {
                MessageBox.Show("Alumno guardado correctamente");
            }

            this.Close();
        }

        private void txtCarnet_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}