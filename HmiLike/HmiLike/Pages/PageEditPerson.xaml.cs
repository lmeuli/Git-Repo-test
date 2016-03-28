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

namespace HmiLike.Pages
{
    /// <summary>
    /// Logica di interazione per PageEditPerson.xaml
    /// </summary>
    public partial class PageEditPerson : UserControl
    {
        public Person EditedPerson { get; set; } // this is public because i will access to this property once the window get closed

        public PageEditPerson(Person person)
        {
            InitializeComponent();
            EditedPerson = person;
            tbName.Text = person.Name;
            tbAge.Text = person.Age.ToString();
        }

        private void btnReturnPerson_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                EditedPerson.Name = tbName.Text;
                EditedPerson.Age = Convert.ToInt32(tbAge.Text);
                Switcher.Switch(new PageWithParameter(EditedPerson));
            }
            catch (Exception exc) { MessageBox.Show("There was an error while returning the person:\n" + exc.Message); }            
        }
    }
}
