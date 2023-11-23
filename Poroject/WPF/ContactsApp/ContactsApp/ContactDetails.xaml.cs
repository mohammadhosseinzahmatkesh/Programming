using ContactsApp.Classes;
using SQLite;
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

namespace ContactsApp
{
    /// <summary>
    /// Interaction logic for ContactDetails.xaml
    /// </summary>
    public partial class ContactDetails : Window
    {
        Contact contact = new Contact();
        private Swashbuckle.Swagger.Contact selectedContact;

        public ContactDetails(Contact contact)
        {
            InitializeComponent();

            this.contact = contact;

            NameTextBox.Text = contact.Name;
            EmailTextBox.Text = contact.EmailAddress;
            PhoneNumberTextBox.Text = contact.Phone;
        }

        public ContactDetails(Swashbuckle.Swagger.Contact selectedContact)
        {
            this.selectedContact = selectedContact;
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            contact.Name = NameTextBox.Text;
            contact.EmailAddress = EmailTextBox.Text;
            contact.Phone = PhoneNumberTextBox.Text;
            using (SQLiteConnection connection = new SQLiteConnection(App.databasePath))
            {
                connection.CreateTable<Contact>();
                connection.Update(contact);
            }

            Close();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(App.databasePath))
            {
                connection.CreateTable<Contact>();
                connection.Delete(contact);
            }

            Close();
        }
    }
}
