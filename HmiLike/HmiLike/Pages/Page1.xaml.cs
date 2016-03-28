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
using HmiLike;

namespace HmiLike.Pages
{


    /// <summary>
    /// Logica di interazione per Page1.xaml
    /// </summary>
    public partial class Page1 : UserControl
    {
        public Person person = new Person("Muster", 31);

        // Statische variablen werden nicht instanziert. Auf sie kann man nur direkt über die Klasse zugreifen
        public static ArrayList Personenliste; // = new ArrayList();

        // Der statische Konstruktor wird bei der ersten verwendung der Klasse ausgeführt
        // er wird nur einmal ausgeführt 
        static Page1()
        {
            Personenliste = new ArrayList();
        }

        public Page1()
        {
            InitializeComponent();

        }

        private void btnPageWithParameter_Click(object sender, RoutedEventArgs e)
        {
            //überprüfen ob das Personenlistenarry nicht auf Null steht
            if (Personenliste.Count != 0)
            {         
            PageWithParameter pageWithParameter = new PageWithParameter(Personenliste[Personenliste.Count - 1] as Person);                           
            Switcher.Switch(pageWithParameter);
            }
            else
            {
                MessageBox.Show("sorry there is no entry");
            }
        }

        private void btnCreateNewPerson_Click(object sender, RoutedEventArgs e)
        {
            Personenliste.Add(person);
            WndEditPerson wndEditPerson = new WndEditPerson((Window)this.Parent, Personenliste[Personenliste.Count-1] as Person);
            wndEditPerson.ShowDialog();
            if (wndEditPerson.DialogResult == true)
            {
                person.Age = wndEditPerson.EditedPerson.Age;
                person.Name = wndEditPerson.EditedPerson.Name;
            }
            PageWithParameter pageWithParameter = new PageWithParameter(Personenliste[Personenliste.Count-1] as Person);
            Switcher.Switch(pageWithParameter);
        }

        public ArrayList giveList()
        {
            return Personenliste;
        }
    }
}
