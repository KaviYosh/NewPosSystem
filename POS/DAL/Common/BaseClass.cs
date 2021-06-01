using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace DAL.Common
{
    public class BaseClass
    {
        #region Common transaction Functions

        //insert normal way
        public bool Insert(string sql, SqlConnection connection, SqlTransaction transaction)
        {
            bool status = false;
            try
            {
                SqlCommand command = new SqlCommand(sql, connection, transaction);
                command.CommandText = sql;
                command.Connection = connection;
                command.Transaction = transaction;
                int insertStatus =  command.ExecuteNonQuery();
                if(insertStatus != 0)
                {
                    status = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return status;
        }

        //insert normal way and get inserted id
        public int InsertandReturnId(string sql, SqlConnection connection, SqlTransaction transaction)
        {
            int id = 0;
            try
            {
                SqlCommand command = new SqlCommand(sql, connection, transaction);
                command.CommandText = sql;
                command.Connection = connection;
                command.Transaction = transaction;
                id = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return id;
        }

        //update normal way
        public bool Update(string sql, SqlConnection connection, SqlTransaction transaction)
        {
            bool status = false;
            try
            {
                SqlCommand command = new SqlCommand(sql, connection, transaction);
                command.CommandTimeout = 0;
                command.CommandText = sql;
                command.Connection = connection;
                command.Transaction = transaction;
                int UpdateStatus = command.ExecuteNonQuery();
                if (UpdateStatus > 0)
                {
                    status = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return status;
        }

        //delete normal way
        public bool Delete(string sql, SqlConnection connection, SqlTransaction transaction)
        {
            bool status = false;
            try
            {
                SqlCommand command = new SqlCommand(sql, connection, transaction);
                command.CommandText = sql;
                command.Connection = connection;
                command.Transaction = transaction;
                int DeleteStatus = command.ExecuteNonQuery();
                if (DeleteStatus > 0)
                {
                    status = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return status;
        }

        //select  normal way (return data table format)
        public DataTable Select(string sql)
        {
            DataTable dt = new DataTable(); 
            SqlConnection connection = ConnectionsManager.GetConnection();
            try
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.CommandText = sql;
                command.Connection = connection;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(ds);
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        // bind drop down menu
        public void BindComboBox(ComboBox comboBox, string dataText, string dataValue, string defaultText, string sql)
        {
            try
            {
                DataTable dt = Select(sql);

                DataRow dr = dt.NewRow();
                dr[1] = dataValue;
                dr[0] = dataText;


                comboBox.DataSource = dt;
                comboBox.DisplayMember = dataText;
                comboBox.ValueMember = dataValue;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
      
        //checked item already exsists
        public bool ExsitsValue(string sql)
        {
            bool exsits = false;
            try
            {
                DataTable dt = Select(sql);
                if(dt.Rows.Count > 0)
                {
                    exsits = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return exsits;
        }

        public int InsertAndGetId(string sql, SqlConnection connection, SqlTransaction transaction)
        {
            int id = 0;
            try
            {
                SqlCommand command = new SqlCommand(sql, connection, transaction);
                command.CommandText = sql;
                command.Connection = connection;
                command.Transaction = transaction;
                id = Convert.ToInt16(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return id;
        }

        #endregion
    }
}
