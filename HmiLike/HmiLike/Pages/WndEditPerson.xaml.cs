#region using
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
using System.Windows.Shapes;

#endregion

/*--------------------------------------------------------------------------
 | This is an example of a popup:
 |--------------------------------------------------------------------------
 | 
 | This window receive a parameter Person inside the constructor and set the person 
 | with the values inside the 2 textboxes.
 | Wpf dialogs must have an owner window specified, or they will be displayed behind 
 | the parent window, blocking the user interface.
 | That's why i specify "Window owner" inside the constructor.
 | 
 | To access the Edited person parameter see the "PageWithParamete.xaml.cs" code.
 */
namespace HmiLike.Pages
{
    /// <summary>
    /// Logica di interazione per WndEditPerson.xaml
    /// </summary>
    public partial class WndEditPerson : Window
    {
        public Person EditedPerson { get; set; } // this is public because i will access to this property once the window get closed

        public WndEditPerson(Window owner, Person person)
        {
            InitializeComponent();
            this.Owner = owner;
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
            }
            catch (Exception exc) { MessageBox.Show("There was an error while returning the person:\n" + exc.Message); }
            this.DialogResult = true;
        }
    }
}
