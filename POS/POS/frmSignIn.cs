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
    public partial class frmSignIn : Form
    {
        // create objects into class
        ShopNameDAL ShopDAL = new ShopNameDAL();
        ShopNamemaster Shopname = new ShopNamemaster();
        SqlConnection con = ConnectionsManager.GetConnection();        
        List<ShopNamemaster> shopnamelist = new List<ShopNamemaster>();

       
        public frmSignIn()
        {
            InitializeComponent();

        }

        private void frmSignIn_Load(object sender, EventArgs e)
        {
            /// Call loadshopName function
            shopnamelist = loadShopname();

            if (shopnamelist != null)
            {
                foreach (var item in shopnamelist)
                {
                    lblShopName.Text = item.ShopFIrstName;
                    lblshopSecondName.Text = item.ShopSecondName;
                }
            }
            
        }
        public List <ShopNamemaster>  loadShopname()
        {
            /// Create By: Kavinda Yoshana
            /// Create Date : 2021/06/04
            /// Des : get shop name from data base

            try
            {
                DataTable dtshopname = ShopDAL.getShopName();

                if (dtshopname != null)
                {
                    for (int i = 0; i < dtshopname.Rows.Count; i++)
                    {

                        Shopname.ShopFIrstName = dtshopname.Rows[i]["ShopFIrstName"].ToString();
                        Shopname.ShopSecondName = dtshopname.Rows[i]["ShopSecondName"].ToString();
                        Shopname.ShopLastName = dtshopname.Rows[i]["ShopLastName"].ToString();

                        shopnamelist.Add(Shopname);
                    }
                }
                              
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return shopnamelist;
        }
    }
}
