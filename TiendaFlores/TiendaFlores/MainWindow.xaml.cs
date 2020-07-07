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
                if (flores.Check1(flores.Name))
                {
                DbContext.context.tiendas.Add(flores.Id, flores.Name);
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
                var decoration = new Decorations
                {
                    Id = Guid.NewGuid(),
                    Name = FlorisName.Text,
                    Material = Decoration.Text,
                    Price = Int32.Parse(DecoPrice.Text)
                };
                DbContext.context.decorations.Add(decoration.Id, decoration);
                int TiendasCount = DbContext.context.tiendas.Count;
                NumTiendas.Content = TiendasCount;
            }
            else { MessageBox.Show("Ya existe una tienda con ese nommbre"); }           
        }
    }       
}

