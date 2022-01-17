using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using PBD.DataSet1TableAdapters;

namespace PBD
{
    /// <summary>/
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataSet1 dataSet1;
        JobTableAdapter jobTableAdapter1;
        public MainWindow()
        {
            InitializeComponent();
            dataSet1 = new DataSet1();
            jobTableAdapter1 = new JobTableAdapter();

            jobTableAdapter1.Fill(dataSet1.Job);

            JobList.ItemsSource = dataSet1.Job.DefaultView;
            JobList.SelectedValuePath = "ID_Job";
            JobList.CanUserAddRows = false;
            JobList.CanUserDeleteRows = false;
            JobList.SelectionMode = DataGridSelectionMode.Single;
        }

        private void JobAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(JobName.Text) && !String.IsNullOrEmpty(JobSalary.Text)) jobTableAdapter1.Insert(JobName.Text, decimal.Parse(JobSalary.Text));
                jobTableAdapter1.Fill(dataSet1.Job);
        }
          catch (Exception ex) { }
}

        private void JobUpd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(JobName.Text) && !String.IsNullOrEmpty(JobSalary.Text)) jobTableAdapter1.UpdateQuery(JobName.Text, decimal.Parse(JobSalary.Text), (int)JobList.SelectedValue);
                jobTableAdapter1.Fill(dataSet1.Job);
            }
            catch (Exception ex) { }
        }

        private void JobDel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                jobTableAdapter1.DeleteQuery((int)JobList.SelectedValue);
                jobTableAdapter1.Fill(dataSet1.Job);
            }
            catch (Exception ex) { }
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            ClientWindow clientWindow = new ClientWindow();
            clientWindow.Show();
            this.Close();
        }

        private void JobFind_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                jobTableAdapter1.FillJob(dataSet1.Job, JobName.Text);
            }
            catch { }
        }

        private void JobNext_Click(object sender, RoutedEventArgs e)
        {
            ClientWindow clientWindow = new ClientWindow();
            clientWindow.Show();
            this.Hide();
        }

        private void JobBack_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
