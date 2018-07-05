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
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login abrir = new Login();
            abrir.Show();
            Hide();
        }

        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            Registrar_Mercancia abrir = new Registrar_Mercancia();
            abrir.Show();
            Hide();
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
             abrir = new Consultas();
            abrir.Show();
            Hide();

        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            Gestión_de_datos abrir = new Gestión_de_datos();
            abrir.Show();
            Hide();

        }
    }
}
