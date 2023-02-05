using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TemperatureConverter
{
   
    public partial class History : Form
    {
        SqlConnection DBconnection = new SqlConnection(Properties.Settings.Default.con);
        public History()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            TempConverter tempConverter = new TempConverter();
            tempConverter.Show();
        }

        private void History_Load(object sender, EventArgs e)
        {
            DisplayHistory();
            DatagridviewHistory.ClearSelection();
        }

        public void DisplayHistory()
        {
            string HistoryShow = "SELECT convert_id AS ID, " +
                "converted_from AS 'From', " +
                "converted_to AS 'TO', " +
                "converted_number AS 'Input',  " +
                "result AS Result, " +
                "converted_datetime AS 'Date Time' " +
                "FROM temperature_convert_history";
            SqlDataAdapter SQLselectQuery = new SqlDataAdapter(HistoryShow, DBconnection);
            DataTable HistoryDataTable = new DataTable();
            SQLselectQuery.Fill(HistoryDataTable);
            DatagridviewHistory.DataSource = HistoryDataTable;
            this.DatagridviewHistory.Columns["ID"].Visible = false;
            DatagridviewHistory.AutoResizeColumns();
        }       

        private void dateTimePickerSearch_ValueChanged(object sender, EventArgs e)
        {
            string SearchDate = dateTimePickerSearch.Value.ToShortDateString().ToLower();
            foreach (DataGridViewRow row in DatagridviewHistory.Rows)
            {
                string GridViewDateTime = row.Cells[5].Value.ToString().ToLower();
                string[] SplitGridViewDateTime = GridViewDateTime.Split(' ');
                string GridViewDate = SplitGridViewDateTime[0].ToString().ToLower();
                if (!GridViewDate.Contains(SearchDate))
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[DatagridviewHistory.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                }
                else
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[DatagridviewHistory.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = true;
                    currencyManager1.ResumeBinding();
                }
            }
            DatagridviewHistory.ClearSelection();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string Ids = string.Empty;
            foreach (DataGridViewRow row in DatagridviewHistory.SelectedRows)
            {
                int id = (int)row.Cells[0].Value;
                Ids += id.ToString() + ",";
            }
            Ids = Ids.TrimEnd(',');
            if (Ids == "")
            {
                MessageBox.Show("Select a history frist.");
            }
            else
            {
                string DeleteQuerry = "DELETE FROM temperature_convert_history WHERE convert_id IN (" + Ids + ")";
                DBconnection.Open();
                SqlCommand deleteCommand = new SqlCommand(DeleteQuerry, DBconnection);
                if (deleteCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Selected history deleted successfully.");
                    DatagridviewHistory.ClearSelection();
                }
                DBconnection.Close();
                DisplayHistory();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string DeleteQuerry = "DELETE FROM temperature_convert_history";
            DBconnection.Open();
            SqlCommand deleteCommand = new SqlCommand(DeleteQuerry, DBconnection);
            if (deleteCommand.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("All history deleted successfully.");
                DatagridviewHistory.ClearSelection();
            }
            DBconnection.Close();
            DisplayHistory();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            DisplayHistory();
        }
    }
}
