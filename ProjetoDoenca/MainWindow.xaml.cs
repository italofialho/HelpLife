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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;

namespace ProjetoDoenca
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(this.txtEmail.Text) && !string.IsNullOrEmpty(this.txtSenha.Text) && !string.IsNullOrWhiteSpace(this.txtEmail.Text) && !string.IsNullOrWhiteSpace(this.txtSenha.Text))
            {
                Console.WriteLine($"Email: {this.txtEmail.Text} Senha: {this.txtSenha.Text}");
            }
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            Cadastrar cad = new Cadastrar();
            cad.Show();
        }
    }
}
