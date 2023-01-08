using Microsoft.VisualBasic;
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
using System.Resources;
using System.ComponentModel.Design.Serialization;
using System.ComponentModel;
using System.Reflection;

namespace reg_resource
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            if (txtname.Text == "")
            {
                lblname.Content = "*PLEASE ENTER THE NAME";
                //  lblname.Content= x: Static lang: Resource1.lname;
            }


            int age = Convert.ToInt32(txtage.Text.ToString());
            if (age <  18)
            {
                lblage.Content = "*AGE SHOULD BE ABOVE 18";
                txtage.Clear();
            }


            String email = txtemail.Text.ToString();
            char[] chars1 = email.ToCharArray();
            //int elength = chars1.Length;
            for (int i = 0; i > chars1.Length; i++)
            {
                if (chars1[i] == '@' || chars1[i] == '.')
                                              
                //{
                 //   txtemail.Text.ToString();
               // }
               // else
                {
                    lblemail.Content = "*INVALID EMAIL ID";
                    txtemail.Clear();
                    
                }
            }

            string password = txtpswd.Text.ToString();
            char[] chars = password.ToCharArray();
            int pswdlength = chars.Length;

            if (pswdlength < 8)
            {
                lblpswd.Content = "*PASSWORD SHOULD HAVE 8 CHARACTERS";
                txtpswd.Clear();
            }

            if (txtpswd.Text != txtcpswd.Text)
            {
                lblcpswd.Content = "*PASSWORD ARE NOT MATCHED";
                txtcpswd.Clear();
            }





            ResourceManager rm = new ResourceManager("reg_resource.properties.language.Resource1", Assembly.GetExecutingAssembly());

            if ((txtname.Text != "") && (txtage.Text != "") && (txtemail.Text != "") && (txtpswd.Text != "")  && (txtcpswd.Text != ""))
            {

                MessageBox.Show(rm.GetString("text1") + txtname.Text,"SUCCESS",MessageBoxButton.OK,MessageBoxImage.Information);
                // MessageBox.Show("REGISTERED SUCCESSFULLY","REGISTER" ,MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show(rm.GetString("text2") + txtname.Text,"ERROR",MessageBoxButton.OK,MessageBoxImage.Error);
                //MessageBox.Show("ERROR!!!!!ENTER ALL DETAILS","ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
