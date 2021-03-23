using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using WpfAppCore.context;
using WpfAppCore.model;

namespace WpfAppCore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        RealtyContext db;
        public MainWindow()
        {
            InitializeComponent();
            db = new RealtyContext();
            db.Lands.Load();
            landGrid.ItemsSource = db.Lands.Local.ToBindingList();
        }

        private void SaveLandButton_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }

        private void DeleteLandButton_Click(object sender, RoutedEventArgs e)
        {
            if (landGrid.SelectedItems.Count > 0) {
                for(var i =0;i< landGrid.SelectedItems.Count;i++) {
                    if (landGrid.SelectedItems[i] != null && landGrid.SelectedItems[i] is Land) {
                        db.Lands.Remove((Land)landGrid.SelectedItems[i]);
                    }
                }
                db.SaveChanges();
            }
        }

        private void landGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.PropertyName == "id")
                e.Cancel = true;
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            db.Dispose();
        }
    }
}
