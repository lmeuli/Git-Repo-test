using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HmiLike.Pages;

namespace HmiLike
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Page1 myPage1 = new Page1();

        public MainWindow()
        {
            InitializeComponent();
            Switcher.pageSwitcher = this;          
            Switcher.Switch(new Page1());     //legt die Startseite fest  
        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;

        }    
        

    }
}
