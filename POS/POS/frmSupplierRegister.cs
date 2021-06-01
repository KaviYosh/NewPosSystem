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
    public partial class frmSupplierRegister : Form
    {
        //create object into class
        SupplierDAL SupplierDAL = new SupplierDAL();
        SupplierMaster Supplier = new SupplierMaster();
        SqlConnection con = ConnectionsManager.GetConnection();
            
        public frmSupplierRegister()
        {
            InitializeComponent();
            loadAllSupplierDetails(null);
        }

        //private void panel2_Paint(object sender, PaintEventArgs e)
        //{

        //}      

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Open Connection
                con.Open();

                //Start Sql Transaction Block
                SqlTransaction trans = con.BeginTransaction();

                Supplier.SupName = txtSupplierCompanyName.Text.Trim();
                Supplier.TeleNoLand = txtSupplierTeleLandNo.Text.Trim();
                Supplier.MobileNo = txtSupplierMobileNo.Text.Trim();
                Supplier.FaxNo = txtSupplierFaxNo.Text.Trim();
                Supplier.SupAddressLine1 = txtSupplierStreetAddress.Text.Trim();
                Supplier.SupAddressLine2 = txtSupplierStreetAddLine2.Text.Trim();
                Supplier.SupAddressLine3 = txtSupplierCity.Text.Trim();
                Supplier.SupAddressLine1 = txtSupplierStreetAddress.Text.Trim();
                Supplier.SupAddressLine1 = txtSupplierStreetAddress.Text.Trim();

                //call insert function
                int id = SupplierDAL.InsertSupplierDetails(Supplier, con, trans);
                if (id != 0)
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
                loadAllSupplierDetails(null);

                //close connection
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        public void loadAllSupplierDetails(string supplierName)
        {
            try
            {
                DataTable dtCustomer = SupplierDAL.getSupplierDetails(supplierName);

                //clear gridview records
                dGVSupplierDetails.Rows.Clear();

                if (dtCustomer.Rows.Count > 0)
                {
                    for (int count = 0; count < dtCustomer.Rows.Count; count++)
                    {
                        //add rows to gridview
                        dGVSupplierDetails.Rows.Add();
                        dGVSupplierDetails.Rows[count].Cells["SupName"].Value = dtCustomer.Rows[count]["SupName"].ToString();
                        dGVSupplierDetails.Rows[count].Cells["SupAddressLine1"].Value = dtCustomer.Rows[count]["SupAddressLine1"].ToString();
                        dGVSupplierDetails.Rows[count].Cells["SupAddressLine2"].Value = dtCustomer.Rows[count]["SupAddressLine2"].ToString();
                        dGVSupplierDetails.Rows[count].Cells["SupAddressLine3"].Value = dtCustomer.Rows[count]["SupAddressLine3 "].ToString();
                        dGVSupplierDetails.Rows[count].Cells["TeleNoLand"].Value = dtCustomer.Rows[count]["TeleNoLand"].ToString();
                        dGVSupplierDetails.Rows[count].Cells["MobileNo"].Value = dtCustomer.Rows[count]["MobileNo"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dGVSupplierDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                //call clear function
                Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Clear()
        {
            //// Created By : Kasun
            ////Created Date:

            txtSupplierCompanyName.Text = "";
            txtSupplierTeleLandNo.Text = "";
            txtSupplierMobileNo.Text = "";
            txtSupplierFaxNo.Text = "";
            txtSupplierStreetAddress.Text = "";
            txtSupplierStreetAddLine2.Text = "";
            txtSupplierCity.Text = "";
            txtSupplierContactPersonName.Text = "";
            txtSupplierDesignation.Text = "";
            txtSupplierPersonOfficePhoneNo.Text = "";
            txtSupplierPersonMobileNo.Text = "";
            txtSupplierRemarks.Text = "";
        }
    }
}
