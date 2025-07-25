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
using WpfMVVMProject.ViewModels;

namespace WpfMVVMProject
{
    /// <summary>
    /// Interaction logic for MyForm.xaml
    /// </summary>
    public partial class MyForm : Window
    {
        public MyForm()
        {
            InitializeComponent();
            DataContext = new BaseViewModel(); // Connecting the view with the View Model
        }
    }
}
