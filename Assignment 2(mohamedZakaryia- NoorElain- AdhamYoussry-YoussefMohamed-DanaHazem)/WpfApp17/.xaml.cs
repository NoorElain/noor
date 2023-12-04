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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp17
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        bookstoreEntities1 db = new bookstoreEntities1();
        public Page2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtID.Text != "" && txtName.Text != "")
                {
                    author auth = new author();
                    int id = int.Parse(txtID.Text);
                    if(txtName.Text == "Eman")
                    {
                        auth = db.authors.First(x => x.author_id == id && x.author_name == txtName.Text);
                        Page3 page = new Page3();
                        this.NavigationService.Navigate(page);
                    }
                    else
                    {
                        MessageBox.Show("the use  'Eman' is bloked !");
                    }
                }
                else
                {
                    MessageBox.Show("ENTER!?");
                }
            }
            catch
            {
                MessageBox.Show("NOT FOUND!?");
            }
        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
