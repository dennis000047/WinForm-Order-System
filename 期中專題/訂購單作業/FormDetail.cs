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
    public partial class FormDetail : Form
    {
        public int productID = 0;
        string strMyLuwaconnectionString = "";
        string image_dir = @"luwaimage/";
        string image_name = "";
        bool is已修改圖檔 = false;

        public FormDetail()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void FormDetail_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "myluwa"; //database(資料庫)名稱
            scsb.IntegratedSecurity = true;//整合驗證
            strMyLuwaconnectionString = scsb.ToString();

            if (productID == 0)
            {//新增模式
                groupBox新增商品.Visible = true;//顯示
                groupBox修改商品.Visible = false;//隱藏
            }
            else
            {//修改商品模式
                groupBox新增商品.Visible = false;
                groupBox修改商品.Visible = true;
                顯示商品細項資訊();
            }         
            void 顯示商品細項資訊()
            {
                SqlConnection con = new SqlConnection(strMyLuwaconnectionString);
                con.Open();
                string strSQL = "select * from luwaproducts where id = @SearchId;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchId", productID);
                SqlDataReader reader = cmd.ExecuteReader();

                int i = 0;
                while (reader.Read())
                {
                    lblID.Text = reader["id"].ToString();
                    txt商品名稱.Text = reader["品項"].ToString();
                    txt商品價格.Text = reader["價格"].ToString();
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
        void 清空欄位()
        {
            lblID.Text = "";
            txt商品名稱.Clear();
            txt商品描述.Clear();
            txt商品價格.Clear();
            pictureBox商品圖檔.Image = null;
        }
        private void btn儲存修改_Click(object sender, EventArgs e)
        {
            if ((txt商品名稱.Text != "") && (txt商品描述.Text != "") && (txt商品價格.Text != "") & (pictureBox商品圖檔.Image != null))
            {
                if (is已修改圖檔)
                {
                    pictureBox商品圖檔.Image.Save(image_dir + image_name);//存到設定的檔案路徑
                    is已修改圖檔 = false;
                }

                SqlConnection con = new SqlConnection(strMyLuwaconnectionString);
                con.Open();
                string strSQL = "update luwaproducts set 品項=@NewName, 價格=@NewPrice, 介紹=@NewDesc, pimage=@NewImageNmae where id = @SearchId;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchId", productID);
                cmd.Parameters.AddWithValue("@NewName", txt商品名稱.Text);
                int intPrice = 0;
                Int32.TryParse(txt商品價格.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                cmd.Parameters.AddWithValue("@NewDesc", txt商品描述.Text);
                cmd.Parameters.AddWithValue("@NewImageNmae", image_name);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("資料儲存成功,影響" + rows + "筆資料");
                清空欄位();
            }
            else
            {
                MessageBox.Show("所有欄位必填");
            }          
        }
        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            清空欄位();
        }
        private void btn儲存商品_Click(object sender, EventArgs e)
        {
            if ((txt商品名稱.Text != "") && (txt商品描述.Text != "") && (txt商品價格.Text != "") & (pictureBox商品圖檔.Image != null))
            {
                if (is已修改圖檔)
                {
                    pictureBox商品圖檔.Image.Save(image_dir + image_name);//存到設定的檔案路徑
                    is已修改圖檔 = false; //?
                }                
                SqlConnection con = new SqlConnection(strMyLuwaconnectionString);
                con.Open();
                string strSQL = "insert into luwaproducts values (@品項 , @價格 , @介紹 , 0 , @上架時間 , @圖檔 );";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@品項", txt商品名稱.Text);
                int intPrice = 0;
                Int32.TryParse(txt商品價格.Text, out intPrice);
                cmd.Parameters.AddWithValue("@價格", intPrice);
                cmd.Parameters.AddWithValue("@介紹", txt商品描述.Text);                
                cmd.Parameters.AddWithValue("@上架時間", DateTime.Now);
                cmd.Parameters.AddWithValue("@圖檔", image_name);
                int rows = cmd.ExecuteNonQuery(); //'資料行名稱或提供的數值數量與資料表定義不相符。
                con.Close();
                MessageBox.Show("資料儲存成功,影響" + rows + "筆資料") ;
                清空欄位();
            }
            else
            {
                MessageBox.Show("所有欄位必填");
            }
        }
        private void btn選取商品照片_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "圖檔類型 (*.jpg, *.jpeg , *.png)|*.jpeg;*.jpg;*.png";
            //(左)檔案過濾描述 怎麼寫都行 | (右)過濾的檔案類型用分號隔開 (* . 副檔名)
            DialogResult R = f.ShowDialog();

            if (R == DialogResult.OK)// IF 使用者回傳OK 取得圖檔
            {// Image.FromFile 處理圖片; FileName 目錄加檔名
                pictureBox商品圖檔.Image = Image.FromFile(f.FileName);// 檔案路徑指定到
                string fileExt = System.IO.Path.GetExtension(f.SafeFileName);
                //GetExtension取得副檔名 , SafeFileName(不包含路徑(目錄))
                Random myRadom = new Random();
                image_name = DateTime.Now.ToString("yyyyMMddHHmmss") + myRadom.Next(1000, 10000).ToString() + fileExt;
                //年月份時分秒加四位數亂數 // +random 確保副檔名不會重複
                is已修改圖檔 = true;
                Console.WriteLine(image_name);//除錯測試用
            }
        }
    }
}
