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
        }

        private void cmbBoxMainCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

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
    }
}
