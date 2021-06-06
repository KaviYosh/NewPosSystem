using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.API;
using DAL;
using System.Data.SqlClient;

namespace POS
{
    public partial class frmSubCategoryAdd : Form
    {
        //create object into class
        SubCategoryDAL subCategoryDAL = new SubCategoryDAL();
        SubCategoryMaster subCatMaster = new SubCategoryMaster();
        SqlConnection con = ConnectionsManager.GetConnection();

        public frmSubCategoryAdd()
        {
            InitializeComponent();
            loadMainCategorydetails();
            loadAllSubCategoryDetails(null);
        }

        private void cmbBoxMainCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /// Create By: Kavinda Yoshana
            /// Create Date : 2021/06/6
            /// Des : Sub Category insert to data based function

            try
            {
                //Open Connection
                con.Open();

                //Start Sql Transaction Block
                SqlTransaction trans = con.BeginTransaction();

                if (txtSubCatName.Text != "" && cmbBoxMainCategory.SelectedValue != null)
                {
                    //get Form  details for insert
                    subCatMaster.MainCatID = cmbBoxMainCategory.SelectedValue.ToString();
                    subCatMaster.SubName = txtSubCatName.Text.Trim();
                    subCatMaster.Active = 1;
                    subCatMaster.CreatedOn = DateTime.Now;
                    subCatMaster.CreatedBy = 1;

                    //call insert function
                    bool status = subCategoryDAL.InsertSubCatDetails(subCatMaster, con, trans);
                    if (status == true)
                    {
                        //commit sql transaction
                        trans.Commit();
                        MessageBox.Show("Sub category Details Saved Successfully ", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    loadAllSubCategoryDetails(null);

                    //close connection
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Please fill all the fields.", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void loadMainCategorydetails()
        {
            /// Create By: Kavinda Yoshana
            /// Create Date : 2021/06/04
            /// Des : load Main Category Item List

            try
            {
                DataTable dtMainCategory = subCategoryDAL.getMainCategoryDetails();
                DataRow dr;

                dr = dtMainCategory.NewRow();
                dr.ItemArray = new object[] { 0, "Select Main Category" };
                dtMainCategory.Rows.InsertAt(dr, 0);

                cmbBoxMainCategory.ValueMember = "MainCatID";

                cmbBoxMainCategory.DisplayMember = "CatName";
                cmbBoxMainCategory.DataSource = dtMainCategory;

                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void loadAllSubCategoryDetails(string subCatName)
        {
            /// Create By: Kavinda Yoshana
            /// Create Date : 2021/05/20
            /// Des : load supplier details to grid view

            try
            {
                DataTable dtCustomer = subCategoryDAL.getSubCategoryDetails(subCatName);

                //clear gridview records
                dGVSubCatDetails.Rows.Clear();

                if (dtCustomer.Rows.Count > 0)
                {
                    for (int count = 0; count < dtCustomer.Rows.Count; count++)
                    {
                        //add rows to gridview
                        dGVSubCatDetails.Rows.Add();
                        dGVSubCatDetails.Rows[count].Cells["CatName"].Value = dtCustomer.Rows[count]["CatName"].ToString();
                        dGVSubCatDetails.Rows[count].Cells["SubName"].Value = dtCustomer.Rows[count]["SubName"].ToString();                        
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Clear()
        {
            /// Create By: Kavinda Yoshana
            /// Create Date : 2021/06/06
            /// Des : clear all textbox in form

            txtSubCatName.Text = "";
            cmbBoxMainCategory.Text = "";
            
        }
    }
}
