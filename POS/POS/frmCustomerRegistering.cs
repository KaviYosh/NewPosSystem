using BLL.API;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class frmCustomerRegistering : Form
    {
        //create object into class
        CustomerDAL CustomerDAL = new CustomerDAL();
        CustomerMaster Customer = new CustomerMaster();
        SqlConnection con = ConnectionsManager.GetConnection();

        public frmCustomerRegistering()
        {
            InitializeComponent();
            loadAllMainCategoryDetails(null);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        public void loadAllMainCategoryDetails(string customerName)
        {
            try
            {
                DataTable dtCustomer = CustomerDAL.getCustomerDetails(customerName);

                //clear gridview records
                dGVCustomerDetails.Rows.Clear();

                if (dtCustomer.Rows.Count > 0)
                {
                    for (int count = 0; count < dtCustomer.Rows.Count; count++)
                    {
                        //add rows to gridview
                        dGVCustomerDetails.Rows.Add();
                        dGVCustomerDetails.Rows[count].Cells["FirstName"].Value = dtCustomer.Rows[count]["FirstName"].ToString();
                        dGVCustomerDetails.Rows[count].Cells["LastName"].Value = dtCustomer.Rows[count]["LastName"].ToString();
                        dGVCustomerDetails.Rows[count].Cells["NIC"].Value = dtCustomer.Rows[count]["NIC"].ToString();
                        dGVCustomerDetails.Rows[count].Cells["AddressLine_1"].Value = dtCustomer.Rows[count]["AddressLine_1"].ToString();
                        dGVCustomerDetails.Rows[count].Cells["AddressLine_2"].Value = dtCustomer.Rows[count]["AddressLine_2"].ToString();
                        dGVCustomerDetails.Rows[count].Cells["TeleNo"].Value = dtCustomer.Rows[count]["TeleNo"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                //call clear function
                Clear();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        //common clear function
        public void Clear()
        {
            txtCustFirstName.Text = "";
            txtCustLastName.Text = "";
            txtCustMobileNo.Text = "";
            txtCustStreetAddLine2.Text = "";
            txtCustStreetAddress.Text = "";
            txtCustUserNICNo.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Open Connection
                con.Open();

                //Start Sql Transaction Block
                SqlTransaction trans = con.BeginTransaction();

                //get Form  details for insert
                Customer.FristName = txtCustFirstName.Text;
                Customer.LastName = txtCustLastName.Text;
                Customer.MobileNo = txtCustMobileNo.Text;
                Customer.AddLine1 = txtCustStreetAddress.Text;
                Customer.AddLine2 = txtCustStreetAddLine2.Text;
                Customer.NIC = txtCustUserNICNo.Text;
                Customer.Active = 1;
                Customer.CreatedOn = DateTime.Now;
                Customer.CreatedBy = 1;

                //call insert function
                bool status = CustomerDAL.InsertCustomerDetails(Customer, con, trans);
                if (status == true)
                {
                    //commit sql transaction
                    trans.Commit();
                    MessageBox.Show("Customer Details Saved Successfully ", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //rallback sql transaction
                    trans.Rollback();
                    MessageBox.Show("Saved Failed. Retry again.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //clear already filled data
                Clear();

                //load data to a grid view user can confirm his data insert or no
                loadAllMainCategoryDetails(null);

                //close connection
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCustFirstName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                loadAllMainCategoryDetails(txtCustFirstName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
