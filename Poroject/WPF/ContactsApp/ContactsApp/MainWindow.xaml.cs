using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Contact = Swashbuckle.Swagger.Contact;

namespace ContactsApp
{
    public partial class MainWindow : Window
    {
        List<Contact> contacts;
        
        public MainWindow()
        {
            InitializeComponent();

            contacts = new List<Contact>();

           //ReadDatabase();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 newContactWindo = new Window1();
            newContactWindo.ShowDialog();

           ReadDatabase();
        }

        void ReadDatabase()
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.databasePath))
            {
                conn.CreateTable<Contact>();
                var contact = (conn.Table<Contact>().ToList()).OrderBy(c => c.name).ToList();
            }

            if (contacts != null)
            {
                contactsListView.ItemsSource = contacts;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox SearchTextBox = sender as TextBox;

            var FilteredList = contacts.Where(c => c.name.ToLower().Contains(SearchTextBox.Text.ToLower())).ToList();

            contactsListView.ItemsSource = FilteredList;
        }

        private void contactsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Contact selectedContact = (Contact)contactsListView.SelectedItem;

            if (selectedContact != null)
            {
                ContactDetails contactDetails = new ContactDetails(selectedContact);
                contactDetails.ShowDialog();
            }

            ReadDatabase();
        }
    }
}
