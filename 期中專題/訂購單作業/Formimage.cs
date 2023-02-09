using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 訂購單作業
{
    public partial class Formimage : Form
    {
        public int intID = 0;
        string strMyLuwaConnectionString = "";
        List<string>list品項 = new List<string>();
        List<int>list價格 = new List<int>();
        List<int> listId = new List<int>();
       
        public Formimage()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Formimage_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "myluwa";
            scsb.IntegratedSecurity = true;
            strMyLuwaConnectionString = scsb.ToString();
            讀取資料庫();
            showListView圖片模式();
        }
        void 讀取資料庫()
        {
            SqlConnection con = new SqlConnection(strMyLuwaConnectionString);
            con.Open();
            string strSQL = "select top 100 * from luwaproducts";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            string image_dir = @"luwaimage/";
            string image_name = "";
            int i = 0;

            while (reader.Read())
            {
                listId.Add((int)reader["id"]);
                list品項.Add(reader["品項"].ToString());
                list價格.Add((int)reader["價格"]);
                image_name = reader["pimage"].ToString();
                imageList商品圖檔.Images.Add(Image.FromFile(image_dir + image_name));
                i++;
            }
            Console.WriteLine("讀取{0}筆資料", i);
            reader.Close();
            con.Close();
        }
        private void btn圖片模式_Click(object sender, EventArgs e)
        {
            showListView圖片模式();
        }
        void showListView圖片模式()
        {
            listView商品展示.Clear();
            listView商品展示.View = View.LargeIcon;
            imageList商品圖檔.ImageSize = new Size(120, 120);
            listView商品展示.LargeImageList = imageList商品圖檔; //LargeIcon, Tile
            listView商品展示.SmallImageList = imageList商品圖檔;//SmallIcon, List

            for(int i = 0; i < imageList商品圖檔.Images.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i; //listview單元需要索引值對應
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Text = list品項[i] + " " + list價格[i] + "元";
                item.Tag = listId[i]; //tag 不用給使用者看到
                listView商品展示.Items.Add(item);
            }
        }
        private void btn列表模式_Click(object sender, EventArgs e)
        {
            showListView列表模式();
        }

        void showListView列表模式()
        {
            listView商品展示.Clear();
            listView商品展示.LargeImageList = null;
            listView商品展示.SmallImageList = null;
            listView商品展示.View = View.Details;
            listView商品展示.Columns.Add("id", 100); //名稱 寬度          
            listView商品展示.Columns.Add("商品名稱", 200);
            listView商品展示.Columns.Add("商品價格", 80);
            listView商品展示.FullRowSelect = true;
            listView商品展示.GridLines = true; //格線

            for (int i = 0; i < listId.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Text = listId[i].ToString();
                //  SubItems的 子項目
                item.SubItems.Add(list品項[i]);
                item.SubItems.Add(list價格[i].ToString());
                item.Tag = listId[i];

                listView商品展示.Items.Add(item);
            }
        }
            private void btn新增商品_Click(object sender, EventArgs e)
        {
            FormDetail 新增商品 = new FormDetail();
            新增商品.ShowDialog();
        }

        private void btn重新載入_Click(object sender, EventArgs e)
        {
            listId.Clear();
            list品項.Clear();
            list價格.Clear();
            imageList商品圖檔.Images.Clear();
            讀取資料庫();

            if (listView商品展示.View == View.Details)
            {
                showListView列表模式();
            }
            else
            {
                showListView圖片模式();
            }
        }    

        private void listView商品展示_ItemActivate(object sender, EventArgs e)
        {
            FormDetail myFormDetail = new FormDetail();
            myFormDetail.productID = Convert.ToInt32(listView商品展示.SelectedItems[0].Tag);
            myFormDetail.ShowDialog();
        }

        private void btn刪除商品_Click(object sender, EventArgs e)
        {
            //int intID = 0;
            int productID = Convert.ToInt32(listView商品展示.SelectedItems[0].Tag);
            Console.WriteLine(productID);
            MessageBox.Show("您確認要刪除?", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if ((productID > 0))
            {
                SqlConnection con = new SqlConnection(strMyLuwaConnectionString);
                con.Open();
                string strSQL = "delete from luwaproducts where id=@DeleteId";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@DeleteId", productID);
                //只執行不查詢 像ssms的update 顯示受影響有幾筆但不查詢
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                //清空欄位();
                MessageBox.Show(String.Format("刪除成功, {0} 個資料列受到影響", rows));
            }
        }

        private void btn會員維護_Click(object sender, EventArgs e)
        {
            Maintain 管理員維護 = new Maintain();
            管理員維護.Show();
        }
    }
}
