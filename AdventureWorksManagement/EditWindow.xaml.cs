using AWM.BusinessLayer;
using AWM.DataLayer;
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

namespace AdventureWorksManagement
{
    /// <summary>
    /// Interaction logic for EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        ProductLogic pl = new ProductLogic();
        CategoryLogic cl = new CategoryLogic();

        public Product CurrentProduct { get; set; }

        public EditWindow(int id)
        {
            InitializeComponent();

            this.CurrentProduct = pl.GetProductById(id);
            cbxColors.ItemsSource = pl.GetColors();
            cbxSubcategories.ItemsSource = cl.GetAllSubCategories();

            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                pl.SaveProduct(this.CurrentProduct);
                this.DialogResult = true;
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
