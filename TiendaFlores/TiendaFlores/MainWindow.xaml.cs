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
                Name = FlorisName.Text
            };
            DbContext.context.tiendas.Add(flores.Id, flores);
            var arboles = new Arbol
            {
                Id = Guid.NewGuid(),
                Name = FlorisName.Text,
                Height = Int32.Parse(TreeSize.Text),
                Price = Int32.Parse(TreePrice.Text)
            };
            DbContext.context.arbol.Add(arboles.Id, arboles);
            var flor = new Flor
            {
                Id = Guid.NewGuid(),
                Name = FlorisName.Text,
                Color = FlowerColor.Text,
                Price = Int32.Parse(FlowerPrice.Text)

            };
            DbContext.context.flor.Add(flor.Id, flor);

        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {            
        }
        private void casilla_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}
