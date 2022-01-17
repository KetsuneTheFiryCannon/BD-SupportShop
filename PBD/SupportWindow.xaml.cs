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
    /// Interaction logic for SupportWindow.xaml
    /// </summary>
    public partial class SupportWindow : Window
    {
        DataSet1 DataSet1;
        ClientTBTableAdapter ClientTBTableAdapter1;
        EmployeeTableAdapter EmployeeTableAdapter1;
        SupportTableAdapter SupportTableAdapter1;
        EmployeeViewTableAdapter EmployeeViewTableAdapter1;
        SupportViewTableAdapter SupportViewTableAdapter1;

        public SupportWindow()
        {
            InitializeComponent();
            DataSet1 = new DataSet1();
            ClientTBTableAdapter1 = new ClientTBTableAdapter();
            EmployeeTableAdapter1 = new EmployeeTableAdapter();
            SupportTableAdapter1 = new SupportTableAdapter();
            EmployeeViewTableAdapter1 = new EmployeeViewTableAdapter();
            SupportViewTableAdapter1 = new SupportViewTableAdapter();

            ClientTBTableAdapter1.Fill(DataSet1.ClientTB);
            EmployeeTableAdapter1.Fill(DataSet1.Employee);
            SupportTableAdapter1.Fill(DataSet1.Support);
            EmployeeViewTableAdapter1.Fill(DataSet1.EmployeeView);
            SupportViewTableAdapter1.Fill(DataSet1.SupportView);

            SupportList.ItemsSource = DataSet1.SupportView.DefaultView;
            SupportList.SelectedValuePath = "ID_Support";
            SupportList.CanUserAddRows = false;
            SupportList.CanUserDeleteRows = false;
            SupportList.SelectionMode = DataGridSelectionMode.Single;

            EmployeeCB.ItemsSource = DataSet1.Employee.DefaultView;
            EmployeeCB.DisplayMemberPath = "Firstname";
            EmployeeCB.SelectedValuePath = "ID_Employee";
            EmployeeCB.SelectedIndex = 0;

            ClientCB.ItemsSource = DataSet1.ClientTB.DefaultView;
            ClientCB.DisplayMemberPath = "Firstname";
            ClientCB.SelectedValuePath = "ID_Client";
            ClientCB.SelectedIndex = 0;
        }

        private void SupportBack_Click(object sender, RoutedEventArgs e)
        {
            EmployeeWindow employeeWindow = new EmployeeWindow();
            employeeWindow.Show();
            this.Close();
        }

        private void SupportFind_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SupportViewTableAdapter1.FillB(DataSet1.SupportView, Convert.ToString(Number.Text));
            }
            catch (Exception ex) { }
        }

        private void SupportNext_Click(object sender, RoutedEventArgs e)
        {
            ChequeWindow chequeWindow = new ChequeWindow();
            chequeWindow.Show();
            this.Close();
        }

        private void SupportDel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SupportTableAdapter1.DeleteQuery((int)SupportList.SelectedValue);

                ClientTBTableAdapter1.Fill(DataSet1.ClientTB);
                EmployeeTableAdapter1.Fill(DataSet1.Employee);
                SupportTableAdapter1.Fill(DataSet1.Support);
                EmployeeViewTableAdapter1.Fill(DataSet1.EmployeeView);
                SupportViewTableAdapter1.Fill(DataSet1.SupportView);
            }
            catch (Exception ex) { }
        }

        private void SupportUpd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SupportTableAdapter1.UpdateQuery((int)EmployeeCB.SelectedValue, (int)ClientCB.SelectedValue, Number.Text, (int)SupportList.SelectedValue);

                ClientTBTableAdapter1.Fill(DataSet1.ClientTB);
                EmployeeTableAdapter1.Fill(DataSet1.Employee);
                SupportTableAdapter1.Fill(DataSet1.Support);
                EmployeeViewTableAdapter1.Fill(DataSet1.EmployeeView);
                SupportViewTableAdapter1.Fill(DataSet1.SupportView);
            }
            catch (Exception ex) { }
        }

        private void SupportAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SupportTableAdapter1.Insert((int)EmployeeCB.SelectedValue, (int)ClientCB.SelectedValue, Number.Text);

                ClientTBTableAdapter1.Fill(DataSet1.ClientTB);
                EmployeeTableAdapter1.Fill(DataSet1.Employee);
                SupportTableAdapter1.Fill(DataSet1.Support);
                EmployeeViewTableAdapter1.Fill(DataSet1.EmployeeView);
                SupportViewTableAdapter1.Fill(DataSet1.SupportView);
            }
            catch (Exception ex) { }
        }
    }
}
