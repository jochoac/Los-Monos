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
    /// Lógica de interacción para Registrar_Mercancia.xaml
    /// </summary>
    public partial class Registrar_Mercancia : Window
    {
        public Registrar_Mercancia()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Menu abrir = new Menu ();
            abrir.Show();
            Hide();
        }
    }
}
