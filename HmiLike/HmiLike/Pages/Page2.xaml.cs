using System;
using System.Collections;
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

namespace HmiLike.Pages
{
    /// <summary>
    /// Logica di interazione per Page2.xaml
    /// </summary>
    public partial class Page2 : UserControl
    {
        public Page2()
        {
            InitializeComponent();           
        }

        private void Annabtn_Click(object sender, RoutedEventArgs e)
        {
            //code für Annabtn
            MessageBox.Show("hier ist anna");
            textBox.Clear();

            if (Page1.Personenliste.Count != 0)
            {
                for (int i = 0; i < Page1.Personenliste.Count; i++)
                {
                    Person person = (Page1.Personenliste[i]) as Person;
                    textBox.AppendText("Name: " + person.Name + " Alter: " + person.Age + "\n");
                }

            }
            else
            {
                MessageBox.Show("sorry there is no entry");
            }
                 
            
        }
    }
}
