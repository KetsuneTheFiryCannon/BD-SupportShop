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
    /// Interaction logic for EmployeeWindow.xaml
    /// </summary>
    public partial class EmployeeWindow : Window
    {
        DataSet1 DataSet1;
        JobTableAdapter JobTableAdapter1;
        EmployeeTableAdapter EmployeeTableAdapter1;
        EmployeeViewTableAdapter EmployeeViewTableAdapter1;

        public EmployeeWindow()
        {
            InitializeComponent();

            DataSet1 = new DataSet1();
            JobTableAdapter1 = new JobTableAdapter();
            EmployeeTableAdapter1 = new EmployeeTableAdapter();  
            EmployeeViewTableAdapter1 = new EmployeeViewTableAdapter();

            JobTableAdapter1.Fill(DataSet1.Job);
            EmployeeTableAdapter1.Fill(DataSet1.Employee);
            EmployeeViewTableAdapter1.Fill(DataSet1.EmployeeView);

            EmployeeList.ItemsSource = DataSet1.EmployeeView.DefaultView;
            EmployeeList.SelectedValuePath = "ID_Employee";
            EmployeeList.CanUserAddRows = false;
            EmployeeList.CanUserDeleteRows = false;
            EmployeeList.SelectionMode = DataGridSelectionMode.Single;

            JobName.ItemsSource = DataSet1.Job.DefaultView;
            JobName.DisplayMemberPath = "Name";
            JobName.SelectedValuePath = "ID_Job";
            JobName.SelectedIndex = 0;
        }

        private void EmployeeAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                EmployeeTableAdapter1.Insert(Firstname.Text, Secondname.Text, Thirdname.Text, (int)JobName.SelectedValue);

                JobTableAdapter1.Fill(DataSet1.Job);
                EmployeeTableAdapter1.Fill(DataSet1.Employee);
                EmployeeViewTableAdapter1.Fill(DataSet1.EmployeeView);
            }
            catch (Exception ex) { }
        }

        private void EmployeeUpd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                EmployeeTableAdapter1.UpdateQuery(Firstname.Text, Secondname.Text, Thirdname.Text, (int)JobName.SelectedValue, (int)EmployeeList.SelectedValue);

                JobTableAdapter1.Fill(DataSet1.Job);
                EmployeeTableAdapter1.Fill(DataSet1.Employee);
                EmployeeViewTableAdapter1.Fill(DataSet1.EmployeeView);
            }
            catch (Exception ex) { }
        }

        private void EmployeeDel_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(EmployeeList.SelectedValue.ToString());
            try
            {
                EmployeeTableAdapter1.DeleteQuery((int)EmployeeList.SelectedValue);


                JobTableAdapter1.Fill(DataSet1.Job);
                EmployeeTableAdapter1.Fill(DataSet1.Employee);
                EmployeeViewTableAdapter1.Fill(DataSet1.EmployeeView);
            }
            catch (Exception ex) { }
        }

        private void EmployeeNext_Click(object sender, RoutedEventArgs e)
        {
            SupportWindow supportWindow = new SupportWindow();
            supportWindow.Show();
            this.Close();
        }

        private void EmployeeFind_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                EmployeeViewTableAdapter1.FillEmployee(DataSet1.EmployeeView, Convert.ToString(JobName.Text));
            }
            catch (Exception ex) { }
        }

        private void EmployeeBack_Click(object sender, RoutedEventArgs e)
        {
            ClientWindow clientWindow = new ClientWindow();
            clientWindow.Show();
            this.Close();
        }
    }
}
