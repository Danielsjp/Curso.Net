using DocumentFormat.OpenXml.Office2010.Excel;
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
using TiendaFlores.Class;
using TiendaFlores.DbContext;

namespace TiendaFlores
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
           
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
        InitializeComponent();



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var flores = new Floristeria
            { 

                Id = Guid.NewGuid(),
                Name = casilla.Text

            };
            DbContext.context.Tiendas.Add(flores.Id, flores);
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
