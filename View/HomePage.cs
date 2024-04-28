using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanceStudioManagementSystem
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        Db db = new Db();

        private void HomePage_Load(object sender, EventArgs e)
        {
            string query = "SELECT Name,Surname,MiddlerName, PhoneNumber, Discount, Adress, Form FROM `студия танцев`.client order by Surname;";
            db.MySqlReturnData(query, ClientsListDataGridView);

        }


        private void ScheduleButton_Click(object sender, EventArgs e)
        {
            new Schedule().Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteClientButton_Click(object sender, EventArgs e)
        {
            string table = "client"; 
            db.DeleteData(table, ClientsListDataGridView);
            string query = "SELECT Name,Surname,MiddlerName, PhoneNumber, Discount, Adress, Form FROM `студия танцев`.client order by Surname;";
            db.MySqlReturnData(query, ClientsListDataGridView);
        }



        private void AttendanceButton_Click(object sender, EventArgs e)
        {
            new Attendance().Show();
        }

        private void StatisticsButton_Click(object sender, EventArgs e)
        {
            new Statistics().Show();
        }

        private void CnahgeButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = ClientsListDataGridView.CurrentRow;

            txtFirstName.Text = selectedRow.Cells["Name"].Value.ToString();
            txtLastName.Text = selectedRow.Cells["Surname"].Value.ToString();
            txtMiddleName.Text = selectedRow.Cells["MiddlerName"].Value.ToString();
            txtPhoneNumber.Text = selectedRow.Cells["PhoneNumber"].Value.ToString();
            txtDiscount.Text = selectedRow.Cells["Discount"].Value.ToString();
            txtAdress.Text = selectedRow.Cells["Adress"].Value.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string newName = txtFirstName.Text;
            string newLastName = txtLastName.Text;
            string newMiddleName = txtMiddleName.Text;
            string newPhone = txtPhoneNumber.Text;
            decimal newDiscount = (decimal)int.Parse(txtDiscount.Text);
            string newAdress = txtAdress.Text;
            byte newForm = new int();
            int newFk = 1;

            if (newDiscount == 5)
            {
                newForm = 1;
            }
            else if (newDiscount == 10)
            {
                newForm = 2;
            }

            if (checkBoxForm.Checked)
            {
                newForm = 1;
            }
            else newForm = 0;

            string table = "client";
            db.AddData(table , newName, newLastName, newMiddleName, newPhone, newDiscount, newAdress, newForm, newFk);

            txtFirstName.Clear();
            txtLastName.Clear();
            txtMiddleName.Clear();
            txtPhoneNumber.Clear();
            txtDiscount.Clear();
            txtAdress.Clear();
            checkBoxForm.Checked = false;

            string query = "SELECT Name,Surname,MiddlerName, PhoneNumber, Discount, Adress, Form FROM `студия танцев`.client order by Surname;";
            db.MySqlReturnData(query, ClientsListDataGridView);


        }

        private void CnahgeButton_DoubleClick(object sender, EventArgs e)
        {
            string newName = txtFirstName.Text;
            string newLastName = txtLastName.Text;
            string newMiddleName = txtMiddleName.Text;
            string newPhone = txtPhoneNumber.Text;
            decimal newDiscount = (decimal)int.Parse(txtDiscount.Text);
            string newAdress = txtAdress.Text;
            byte newForm = new int();
            int newFk = 1;

            if (newDiscount == 5)
            {
                newForm = 1;
            }
            else if (newDiscount == 10)
            {
                newForm = 2;
            }

            if (checkBoxForm.Checked)
            {
                newForm = 1;
            }
            else newForm = 0;


            db.UpdateData(ClientsListDataGridView, newName, newLastName, newMiddleName, newPhone, newDiscount, newAdress, newForm, newFk);

            txtFirstName.Clear();
            txtLastName.Clear();
            txtMiddleName.Clear();
            txtPhoneNumber.Clear();
            txtDiscount.Clear();
            txtAdress.Clear();
            checkBoxForm.Checked = false;
        }


        private DataTable originalDt;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            DataTable dt = ClientsListDataGridView.DataSource as DataTable;

            if (originalDt == null)
            {
                originalDt = dt.Copy();
            }

            if (dt != null)
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    ClientsListDataGridView.DataSource = originalDt;
                }
                else
                {
                    var filteredData = originalDt.AsEnumerable()
                        .Where(row => row.Field<string>("Surname").Contains(textBox1.Text));

                    if (filteredData.Any())
                    {
                        ClientsListDataGridView.DataSource = filteredData.CopyToDataTable();
                    }
                    else
                    {
                        ClientsListDataGridView.DataSource = originalDt;
                    }
                }
            }
        }

        private void SaveChangedButton_Click(object sender, EventArgs e)
        {
            string newName = txtFirstName.Text;
            string newLastName = txtLastName.Text;
            string newMiddleName = txtMiddleName.Text;
            string newPhone = txtPhoneNumber.Text;
            decimal newDiscount = (decimal)int.Parse(txtDiscount.Text);
            string newAdress = txtAdress.Text;
            byte newForm = new int();
            int newFk = 1;

            if (newDiscount == 5)
            {
                newForm = 1;
            }
            else if (newDiscount == 10)
            {
                newForm = 2;
            }

            if (checkBoxForm.Checked)
            {
                newForm = 1;
            }
            else newForm = 0;


            db.UpdateData(ClientsListDataGridView, newName, newLastName, newMiddleName, newPhone, newDiscount, newAdress, newForm, newFk);

            txtFirstName.Clear();
            txtLastName.Clear();
            txtMiddleName.Clear();
            txtPhoneNumber.Clear();
            txtDiscount.Clear();
            txtAdress.Clear();
            checkBoxForm.Checked = false;
        }
    }
}
