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
    public partial class frmMainCategoryAdd : Form
    {
        //create object into class
        MainCategoryDAL mainCategoryDAL = new MainCategoryDAL();
        ItemMaster itemMaster = new ItemMaster();
        SqlConnection con = ConnectionsManager.GetConnection();

        public frmMainCategoryAdd()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMainCategoryAdd_Load(object sender, EventArgs e)
        {

        }

        private void lblSubCategoryName_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
