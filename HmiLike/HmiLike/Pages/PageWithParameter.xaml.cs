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
using System.Windows.Navigation;
using System.Windows.Shapes; 
#endregion

/*--------------------------------------------------------------------------
 | This is an example of a page that needs a parameter
 |--------------------------------------------------------------------------
 | 
 | This page receive a parameter Person from the button inside Page1.xaml.cs. 
 | The parameter is displayed inside the 2 labels.
 | 
 | To edit this parameter i pass it to a popup; once i close the popup with the 
 | button btnReturnPerson_Click, i access to popup parameter in this way:
 | wndEditPerson.EditedPerson
 | 
 */

namespace HmiLike.Pages
{
    /// <summary>
    /// Logica di interazione per PageWithParameter.xaml
    /// </summary>
    public partial class PageWithParameter : UserControl
    {
        private Person ReceivedPerson { get; set; }

        public PageWithParameter(Person person)
        {
            InitializeComponent();
            ReceivedPerson = person;
            lblAge.Content = ReceivedPerson.Age;
            lblName.Content = ReceivedPerson.Name;
        }

        private void btnEditPopup_Click(object sender, RoutedEventArgs e)
        {
            WndEditPerson wndEditPerson = new WndEditPerson((Window)this.Parent, ReceivedPerson);
            wndEditPerson.ShowDialog();
            if (wndEditPerson.DialogResult == true)
            {
                lblAge.Content = wndEditPerson.EditedPerson.Age;
                lblName.Content = wndEditPerson.EditedPerson.Name;
            }
        }

        private void btnEditPage_Click(object sender, RoutedEventArgs e)
        {
            PageEditPerson pageEditPerson = new PageEditPerson(ReceivedPerson);
            Switcher.Switch(pageEditPerson);            
        }
    }    
}
