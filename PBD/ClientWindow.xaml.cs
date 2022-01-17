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
using PBD.DataSet1TableAdapters;

namespace PBD
{
    /// <summary>
    /// Interaction logic for ClientWindow.xaml
    /// </summary>
    public partial class ClientWindow : Window
    {
        DataSet1 DataSet1;
        ClientTBTableAdapter ClientTBTableAdapter1;

        public ClientWindow()
        {
            InitializeComponent();
            DataSet1 = new DataSet1();
            ClientTBTableAdapter1 = new ClientTBTableAdapter();
            ClientTBTableAdapter1.Fill(DataSet1.ClientTB);

            ClientList.ItemsSource = DataSet1.ClientTB.DefaultView;
            ClientList.SelectedValuePath = "ID_Client";
            ClientList.CanUserAddRows = false;
            ClientList.CanUserDeleteRows = false;
            ClientList.SelectionMode = DataGridSelectionMode.Single;
        }

        private void ClientAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ClientTBTableAdapter1.Insert(Firstname.Text, Secondname.Text, Thirdname.Text);
                ClientTBTableAdapter1.Fill(DataSet1.ClientTB);
            }
            catch (Exception ex) { }
        }

        private void ClientUpd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ClientTBTableAdapter1.UpdateQuery(Firstname.Text, Secondname.Text, Thirdname.Text, (int)ClientList.SelectedValue);
                ClientTBTableAdapter1.Fill(DataSet1.ClientTB);
            }
            catch (Exception ex) { }
        }

        private void ClientDel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ClientTBTableAdapter1.DeleteQuery((int)ClientList.SelectedValue);
                ClientTBTableAdapter1.Fill(DataSet1.ClientTB);
            }
            catch (Exception ex) { }
        }

        private void ClientNext_Click(object sender, RoutedEventArgs e)
        {
            EmployeeWindow employeeWindow = new EmployeeWindow();
            employeeWindow.Show();
            this.Close();
        }

        private void ClientFind_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ClientTBTableAdapter1.FillClient(DataSet1.ClientTB ,Firstname.Text);
            }
            catch (Exception ex) { }
        }

        private void ClientBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
