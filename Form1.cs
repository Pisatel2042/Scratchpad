using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Scratchpad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();

            MainDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void LoadData()
        {
            DBContext dBContext = new DBContext();
            dBContext.LoadData(MainDataGridView);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(Validate())
            {
            int number = int.Parse(MainNumber_TextBox.Text);
            DateTime selectdate = MaindateTimePicker.Value;
            DBContext dB = new DBContext();
            dB.Insert(MainDataGridView, MainTextBox, number, selectdate);
           
            }
           
        }

        private void UpdateTable_Button_Click(object sender, EventArgs e)
        {
            DBContext dBContext = new DBContext();
            dBContext.Udpdate(MainDataGridView,MainTextBox,MainNumber_TextBox, MaindateTimePicker.Value);
           
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            DBContext dBContext = new DBContext();
            dBContext.Delete(MainDataGridView);
        }
       
        private void MainDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (MainDataGridView.SelectedRows.Count > 0)
            {
                var selectRow = MainDataGridView.SelectedRows[0];
                
                MaindateTimePicker.Value = Convert.ToDateTime(selectRow.Cells["Date"].Value);
                MainTextBox.Text = (selectRow.Cells["Name"].Value.ToString());
                MainNumber_TextBox.Text = (selectRow.Cells["Number"].Value.ToString());
            }
            
        }

        private void MainNumber_TextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MainNumber_TextBox.Text) && string.IsNullOrWhiteSpace(MainNumber_TextBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите значение в поле Number.","ошибка",MessageBoxButtons.OK);
                MainNumber_TextBox.Focus();
                return;
            }
            if(!int.TryParse(MainNumber_TextBox.Text, out int number))
            {
                MessageBox.Show("Пожалуйста, введите корректное число.", "Ошибка", MessageBoxButtons.OK);
                MainNumber_TextBox.Focus();
                return;
            }
        }

       
        private void MainTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MainTextBox.Text) && string.IsNullOrWhiteSpace(MainTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите значение в поле Text.", "ошибка", MessageBoxButtons.OK);
                MainTextBox.Focus();
                return;
            }
        }

        private void MainDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
