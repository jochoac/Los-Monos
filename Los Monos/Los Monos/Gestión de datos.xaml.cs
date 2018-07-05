using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Los_Monos
{
    /// <summary>
    /// Lógica de interacción para Gestión_de_datos.xaml
    /// </summary>
    public partial class Gestión_de_datos : Window
    {
        public Gestión_de_datos()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Menu abrir = new Menu();
            abrir.Show();
            Hide();
        }
    }
}
