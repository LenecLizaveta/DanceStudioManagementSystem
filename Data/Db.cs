using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace DanceStudioManagementSystem
{
    public class Db
    {
        public Db()
        {

        }

        static string connectionString = "server=127.0.0.1;uid=root;pwd=1111;database=студия танцев";
        static public MySqlDataAdapter adapter;
        static MySqlConnection connection = new MySqlConnection(connectionString);


        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }



        public DataTable MySqlReturnData(string query, DataGridView grid)
        {
            try
            {

                OpenConnection();

                using (adapter = new MySqlDataAdapter(query, connection))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    grid.DataSource = dt;
                    CloseConnection();
                    return dt;

                }


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return null;
            }

        }


        public void AddData(string table, string name, string surname, string middleName, string phoneNumber, decimal discount, string adress, int form, int discound_Id)
        {


            try
            {
                OpenConnection();
                string sql = "INSERT INTO " + $"{table} " +"(Name, Surname, MiddlerName, PhoneNumber, Discount, Adress, Form, Discount_ID_Discount)" +
                $"VALUES ('{name}', '{surname}', '{middleName}', '{phoneNumber}', {discount}, '{adress}', {form}, {discound_Id})";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Данные добавлены!");
                CloseConnection();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        public void DeleteData(string table, DataGridView grid)
        {
            try
            {
                OpenConnection();

                int selectedRowIndex = grid.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = grid.Rows[selectedRowIndex];

                string clientName = selectedRow.Cells["Name"].Value.ToString();
                string clientSurname = selectedRow.Cells["Surname"].Value.ToString();
                string clientPhoneNumber = selectedRow.Cells["PhoneNumber"].Value.ToString();

                string sql = "DELETE FROM " + $"{table} " +" WHERE Name = @name AND Surname = @surname AND PhoneNumber = @phoneNumber";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@name", clientName);
                cmd.Parameters.AddWithValue("@surname", clientSurname);
                cmd.Parameters.AddWithValue("@phoneNumber", clientPhoneNumber);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Данные удалены!");

                string query = "SELECT Name,Surname,MiddlerName, PhoneNumber, Discount, Adress, Form FROM `студия танцев`.client order by Surname;";
                MySqlReturnData(query, grid);

                CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        public void UpdateData(DataGridView dataGridView, string name, string surname, string middleName, string phoneNumber, decimal discount, string adress, int form, int discound_Id)
        {
            try
            {
                OpenConnection();

                string sql = "UPDATE client SET Name = @name, Surname = @surname, MiddlerName = @middleName, PhoneNumber = @phoneNumber, Discount = @discount, Adress = @adress, Form = @form, Discount_ID_Discount = @discount_Id WHERE Name = @name AND Surname = @surname AND PhoneNumber = @phoneNumber";

                MySqlCommand command = new MySqlCommand(sql, connection);

                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@surname", surname);
                command.Parameters.AddWithValue("@middleName", middleName);
                command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                command.Parameters.AddWithValue("@discount", discount);
                command.Parameters.AddWithValue("@adress", adress);
                command.Parameters.AddWithValue("@form", form);
                command.Parameters.AddWithValue("@discount_Id", discound_Id);

                command.ExecuteNonQuery();

                MessageBox.Show("Данные изменены!");

                string query = "SELECT Name,Surname,MiddlerName, PhoneNumber, Discount, Adress, Form FROM `студия танцев`.client order by Surname;";
                MySqlReturnData(query, dataGridView);

                CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
    }
}           

            
        
   
