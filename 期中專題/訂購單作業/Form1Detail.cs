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

namespace 訂購單作業
{
    public partial class Form1Detail : Form
    {
        public int productID = 0;
        string strMyLuwaconnectionString = "";
        string image_dir = @"luwaimage/";
        string image_name = "";
        public Form1Detail()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Form1Detail_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "myluwa"; //database(資料庫)名稱
            scsb.IntegratedSecurity = true;//整合驗證
            strMyLuwaconnectionString = scsb.ToString();
            
            顯示商品細項資訊();

            void 顯示商品細項資訊()
            {
                SqlConnection con = new SqlConnection(strMyLuwaconnectionString);
                con.Open();
                string strSQL = "select * from luwaproducts where id = @SearchId;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchId",productID);
                SqlDataReader reader = cmd.ExecuteReader();

                int i = 0;
                while (reader.Read())
                {
                    lblID.Text = reader["id"].ToString();                  
                    txt商品描述.Text = reader["介紹"].ToString();
                    image_name = reader["pimage"].ToString();
                    pictureBox商品圖檔.Image = Image.FromFile(image_dir + image_name);
                    i++;
                }
                Console.WriteLine("查詢" + i + "筆資料");//除錯用
                reader.Close();
                con.Close();
            }
        }      
    }
}
