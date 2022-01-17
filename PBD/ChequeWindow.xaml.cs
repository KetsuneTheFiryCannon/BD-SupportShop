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
    public partial class ChequeWindow : Window
    {
        DataSet1 dataSet1;
        ChequeTableAdapter chequeTableAdapter1;
        SupportTableAdapter supportTableAdapter1;
        ChequeViewTableAdapter chequeViewAdapter1;

        public ChequeWindow()
        {
            InitializeComponent();
            dataSet1 = new DataSet1();
            chequeTableAdapter1 = new ChequeTableAdapter();
            supportTableAdapter1 = new SupportTableAdapter();
            chequeViewAdapter1 = new ChequeViewTableAdapter();

            chequeTableAdapter1.Fill(dataSet1.Cheque);
            supportTableAdapter1.Fill(dataSet1.Support);
            chequeViewAdapter1.Fill(dataSet1.ChequeView);

            ChequeList.ItemsSource = dataSet1.ChequeView.DefaultView;
            ChequeList.SelectedValuePath = "ID_Cheque";
            ChequeList.CanUserAddRows = false;
            ChequeList.CanUserDeleteRows = false;
            ChequeList.SelectionMode = DataGridSelectionMode.Single;

            Numbercb.ItemsSource = dataSet1.Support.DefaultView;
            Numbercb.DisplayMemberPath = "Number";
            Numbercb.SelectedValuePath = "ID_Support";
            Numbercb.SelectedIndex = 0;
        }

        private void ChequeAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                chequeTableAdapter1.Insert((int)Numbercb.SelectedValue, decimal.Parse(Price.Text));

                chequeTableAdapter1.Fill(dataSet1.Cheque);
                supportTableAdapter1.Fill(dataSet1.Support);
                chequeViewAdapter1.Fill(dataSet1.ChequeView);
            }
            catch (Exception ex) { }
        }

        private void ChequeUpd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                chequeTableAdapter1.UpdateQuery((int)Numbercb.SelectedValue, decimal.Parse(Price.Text), (int)ChequeList.SelectedValue);

                chequeTableAdapter1.Fill(dataSet1.Cheque);
                supportTableAdapter1.Fill(dataSet1.Support);
                chequeViewAdapter1.Fill(dataSet1.ChequeView);
            }
            catch (Exception ex) { }
        }

        private void ChequeDel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                chequeTableAdapter1.DeleteQuery((int)ChequeList.SelectedValue);

                chequeTableAdapter1.Fill(dataSet1.Cheque);
                supportTableAdapter1.Fill(dataSet1.Support);
                chequeViewAdapter1.Fill(dataSet1.ChequeView);
            }
            catch (Exception ex) { }
        }

        private void ChequeNext_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void ChequeFind_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                chequeViewAdapter1.FillCheque(dataSet1.ChequeView, Convert.ToString(Numbercb.Text));
            }
            catch (Exception ex) { }
        }

        private void ChequeBack_Click(object sender, RoutedEventArgs e)
        {
            SupportWindow supportWindow = new SupportWindow();
            supportWindow.Show();
            this.Close();
        }
    }
}
