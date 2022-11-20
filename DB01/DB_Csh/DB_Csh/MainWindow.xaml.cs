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
using System.Data.OleDb;
using System.Configuration;
using System.Data.Odbc;
using System.Configuration;

namespace DB_Csh
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void EnterName_Click(object sender, RoutedEventArgs e)
        {
            using (OdbcConnection con = new OdbcConnection())
            {
                con.ConnectionString=ConfigurationManager.ConnectionStrings["Connetion"].ToString();
                con.Open();
            }
            using (OdbcCommand cmd = new OdbcCommand()
            {
                cmd.CommandText = "select * from [Employee]";
            cmd.Connetion = Configuration;
            ]

        }



    }
}
