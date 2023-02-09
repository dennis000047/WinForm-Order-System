using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Windows.Documents;

namespace 訂購單作業
{
    public partial class Form1 : Form
    {
        public int v = 0;
        SqlConnectionStringBuilder scsb;
        string strMyLuwaConnectionString = "";      
        List<int> listId = new List<int>();
        //List<int> SearchIDs = new List<int>(); //進階搜尋的結果
        List<string> list品項 = new List<string>();
        List<int> list價格 = new List<int>();           
        Dictionary<string, int> drinkPrice = new Dictionary<string, int>();
        
        int 單價 = 0;            
        int 所選滷味數量;
        int 所選單價;
        int 所選品項總價;
        string 所選品項;      
        string 所選品項單點飲料;       
        int 所選品項drinkPrice;
        
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "myluwa"; //database(資料庫)名稱
            scsb.IntegratedSecurity = true;//整合驗證
            strMyLuwaConnectionString = scsb.ToString();
    
            btn登出.Visible = false;       
            //滷味品項();           
            單點飲料();
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
            //Console.WriteLine("讀取{0}筆資料", i);
            reader.Close();
            con.Close();
        }
        void showListView圖片模式()
        {
            listView商品展示.Clear();
            listView商品展示.View = View.LargeIcon;
            imageList商品圖檔.ImageSize = new Size(120, 120);
            listView商品展示.LargeImageList = imageList商品圖檔; //LargeIcon, Tile
            listView商品展示.SmallImageList = imageList商品圖檔;//SmallIcon, List

            for (int i = 0; i < imageList商品圖檔.Images.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i; //listview單元需要索引值對應
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Text = list品項[i] + " " + list價格[i] + "元";
                item.Tag = listId[i]; //tag 不用給使用者看到
                listView商品展示.Items.Add(item);
            }
        }
        void 滷味品項()// listbox資訊 沒用到
        {
            SqlConnection con = new SqlConnection(strMyLuwaConnectionString);
            con.Open();
            string strSQL = "select *  from  luwaproducts;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {               
                string strMsg = "";
                string Luwa品項 = reader["品項"].ToString();
                string Luwa價格 = reader["價格"].ToString();
                strMsg += string.Format(" {0} {1}元",Luwa品項, Luwa價格);
                listBox滷味品項.Items.Add(strMsg);                
            }
            reader.Close();
            con.Close();
        }       
        void 單點飲料()
        {
            SqlConnection con = new SqlConnection(strMyLuwaConnectionString);
            con.Open();
            string strSQL = "select *  from  luwa飲料;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string strMsg = "";
                string 品項 = reader["單點飲料"].ToString();
                string 價格 = reader["飲料價格"].ToString();
                strMsg += string.Format("{0} {1}元", 品項, 價格);
                comboBox單點飲料.Items.Add(strMsg);
                drinkPrice.Add(品項, Convert.ToInt32(價格));
                Console.WriteLine(品項+"------------嗯嗯嗯嗯--------");
                Console.WriteLine(價格 + "------------嗯嗯嗯嗯--------");

            }
            txt數量.Text = "";
            comboBox單點飲料.SelectedIndex = 0;
            reader.Close();
            con.Close();
        }
        private void listBox滷味品項_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox滷味品項.SelectedIndex > -1)
            {
                所選品項 = list品項[listBox滷味品項.SelectedIndex];
                所選單價 = list價格[listBox滷味品項.SelectedIndex];
            }
        }

        private void comboBox單點飲料_SelectedIndexChanged(object sender, EventArgs e)
        {
            所選品項單點飲料 = drinkPrice.ElementAt(comboBox單點飲料.SelectedIndex).Key;
            所選品項drinkPrice = drinkPrice.ElementAt(comboBox單點飲料.SelectedIndex).Value;  
            小計();
        }

        private void txt數量_TextChanged(object sender, EventArgs e)
        {
            小計();
        }
        void 清除選擇欄位()
        {
            txt數量.Text = "";
            comboBox單點飲料.SelectedIndex = 0;
            lbl單價.Text = "";
            lbl品項總價.Text = ""; 
        }
        private void btn加入購物車_Click(object sender, EventArgs e)
        {
            if (txt數量.Text != "")
            {
                /*char[] 放一個值 = txt數量.Text.ToCharArray(); //01
                int 變數 = 0;
                for (變數 = 0; 變數 < 1; 變數++)
                {
                    string b = 放一個值[變數].ToString();
                    if (b != "0") 
                    { 
                        break; 
                    }
                    else 
                    { 
                        MessageBox.Show("首字不為0"); 
                        txt數量.Text = "";
                    }
                }*/
                try
                {
                    int 單價 = Convert.ToInt32(txt數量.Text);
                    if (單價 <= 0)
                    {                       
                        MessageBox.Show("請選擇商品並輸入數量");
                        清除選擇欄位();
                    }
                    else
                    {
                        ArrayList order = new ArrayList();
                        order.Add(所選品項);
                        order.Add(所選單價);
                        order.Add(所選滷味數量);
                        order.Add(所選品項單點飲料);
                        order.Add(所選品項drinkPrice);
                        order.Add(所選品項總價);                    

                        globalVar.list訂購品資訊列表.Add(order);
                        MessageBox.Show("已加入到訂購單");
                    }
                    所選滷味數量 = Convert.ToInt32(txt數量.Text);
                    小計();
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message);
                    txt數量.Text = "";
                }               
            }
            else
            {
                txt數量.Text = "0";
                MessageBox.Show("錯誤");
            }
        }
 
        private void btn查看購物車_Click(object sender, EventArgs e)
        {                                
                FromOrderList fromOrderList = new FromOrderList();
                fromOrderList.ShowDialog();
        }       
        private void btn內部商品管理_Click(object sender, EventArgs e)
        {          
                     
        }       
        static public bool x = false; //全域靜態布林值 true => false 

        private void listView商品展示_ItemActivate(object sender, EventArgs e)
        {
            int productID = Convert.ToInt32(listView商品展示.SelectedItems[0].Tag);
            //Console.WriteLine(productID);
            if (productID > 0)
            {
                btn查看商品介紹.Visible = true; //可看見
                SqlConnection con = new SqlConnection(strMyLuwaConnectionString);
                con.Open();
                string strSQL = "select * from luwaproducts where id = @SearchID";               
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", productID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    所選品項 = ((string)reader["品項"]);
                    單價 = ((int)reader["價格"]);              
                }
                lbl單價.Text = Convert.ToString(單價);
                
                x = true;
                
                reader.Close();
                con.Close();
                小計();
            }
            else 
            {
                btn查看商品介紹.Visible = false;
            }
        }
        void 小計()
        {
            int.TryParse(txt數量.Text, out int count);     
            int.TryParse(lbl單價.Text, out int price);
            所選滷味數量 = count;
            所選單價 = price;

            所選品項總價 = (所選滷味數量 * 所選單價) + 所選品項drinkPrice ;
            lbl品項總價.Text = String.Format("{0}元", 所選品項總價 ).ToString();        
        }
        private void btn重新載入_Click(object sender, EventArgs e)
        {
            listId.Clear();
            list品項.Clear();
            list價格.Clear();
            imageList商品圖檔.Images.Clear();
            讀取資料庫();
            showListView圖片模式();           
        }
        private void btn查看商品介紹_Click(object sender, EventArgs e)
        {          
            if (x) // x = true
            {              
                Form1Detail productDetail = new Form1Detail();
                int productID = Convert.ToInt32(listView商品展示.SelectedItems[0].Tag);
                productDetail.productID = productID;
                productDetail.Show();
                x = false; // x = false                
            }
            else 
            {
                MessageBox.Show("要選圖片喔~ 親");
            }            
        }
        static public int y;
        public int c;
     
        private void btn登入_Click(object sender, EventArgs e)
        {
            Login 登入 = new Login();
            登入.ShowDialog();
            if (globalVar.t > 1)
            {
                btn登出.Visible = true;
                btn登入.Visible = false;
            }        
        }

        private void btn登出_Click(object sender, EventArgs e)
        {
            MessageBox.Show("登出成功");
            globalVar.t = 1;
            //Close();
            if (globalVar.t == 1)
            {
                btn登入.Visible = true;
                btn登出.Visible = false;
            }          
        }

        private void timer跑燈_Tick(object sender, EventArgs e)
        {
            if(label4.Left + label4.Width > 0)
            {
                label4.Left = label4.Left -30;
            }
            else if(label4.Left < 1)
            {
                label4.Left = 800;
            }           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Maintain 維護 = new Maintain();
            維護.Show();
        }
    }
}
