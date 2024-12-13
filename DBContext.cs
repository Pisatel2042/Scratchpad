using System;
using Dapper;
using Scratchpad.Model;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Windows.Forms;
using SqlConnection = Microsoft.Data.SqlClient.SqlConnection;
using Microsoft.Identity.Client;




namespace Scratchpad
{
    public  class DBContext 
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
       
        public void LoadData(DataGridView dataGridView)
        {
           

            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    IEnumerable<Notes> notes = connection.Query<Notes>("Select ID, Date, Name, Number  from TimeEvent");
                    dataGridView.DataSource = notes;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных: " + ex.Message );
                }
            }
        }

        public void Insert(DataGridView dataGridView, TextBox text, int number, DateTime date)
        {

            if( text == null)
            {
               text.ForeColor = System.Drawing.Color.Red;
            }


            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    var parameters = new { TextValue = text.Text ,DNumber=number, Date = date };
                    var sql = "INSERT INTO TimeEvent (Date, Name, Number) VALUES (@Date, @TextValue, @DNumber)";

                    connection.Execute(sql, parameters);
                    LoadData(dataGridView);
                }
                catch (System.Data.SqlClient.SqlException ex) 
                {
                    MessageBox.Show("Ошибка при добавление  данных: " + ex.Message);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Ошибка формата: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Неизвестная ошибка: " + ex.Message);
                }
            }
        }
        public void Udpdate(DataGridView dataGridView, TextBox text, TextBox number, DateTime date)
        {
            if(dataGridView.SelectedRows.Count > 0) 
            {
                var selectRow = dataGridView.SelectedRows[0];
                int Id = Convert.ToInt32(selectRow.Cells["Id"].Value);

                using (var connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        var parameters = new { TextValue = text.Text, DNumber =int.Parse(number.Text), Date = date, id  = Id };

                        var sql = "UPDATE TimeEvent SET Date = @Date, Name = @TextValue ,Number = @DNumber  WHERE Id = @id";

                        connection.Execute(sql, parameters);
                       
                    }
                    catch (System.Data.SqlClient.SqlException){ }
                    
                }
                LoadData(dataGridView);

            }



        }

        public void Delete(DataGridView dataGridView)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var selectRow = dataGridView.SelectedRows[0];
                int Id = Convert.ToInt32(selectRow.Cells["Id"].Value);

                using (var connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        var parameters = new {  id = Id };

                        var sql = "delete from TimeEvent WHERE Id = @id";

                        connection.Execute(sql, parameters);

                    }
                    catch (System.Data.SqlClient.SqlException) { }

                }
                LoadData(dataGridView);

            }

        }

    }

}
