using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace 訂購單作業
{
    public partial class FromOrderList : Form
    {
        SqlConnectionStringBuilder scsb;
        string strMyLuwaConnectionString = "";
        Random Random = new Random();
        List<string> list品項 = new List<string>();
        List<int> list單價 = new List<int>();
        List<int> list數量 = new List<int>();
        List<string> list辣度 = new List<string>();
        List<string> list醬料 = new List<string>();
        List<string> list額外配料 = new List<string>();
        List<string> list飲料品名 = new List<string>();
        List<int> list飲料價格 = new List<int>();

        int 訂單編號 = 0;
        int 總價;

        public string 所選品項辣度;
        public string 所選品項醬料;
        public string 所選品項額外配料;

        public FromOrderList()
        {
            InitializeComponent();
            CenterToScreen();
        }
        
        private void FromOrderList_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "myluwa"; //database(資料庫)名稱
            scsb.IntegratedSecurity = true;//整合驗證
            strMyLuwaConnectionString = scsb.ToString();

            foreach (ArrayList 訂購品項 in globalVar.list訂購品資訊列表)
            {                
                string 所選品項 = (string)訂購品項[0];
                int 單價 = (int)訂購品項[1];
                int 數量 = (int)訂購品項[2];
                string 單點飲料 = (string)訂購品項[3];
                int 單點飲料價錢 = (int)訂購品項[4];
                int 品項總價 = (int)訂購品項[5];

                list品項.Add(所選品項);
                list單價.Add(單價);
                list數量.Add(數量);
                list飲料品名.Add(單點飲料);
                list飲料價格.Add(單點飲料價錢);
                
                string str品項資訊 = string.Format("{0} 單價:{1} {2}份  單點飲料:{3}+{4}元 品項總價:{5} ", 所選品項, 單價, 數量, 單點飲料, 單點飲料價錢, 品項總價);
                listBox訂購品項列表.Items.Add(str品項資訊);
            }
            辣度();
            醬料選擇();
            額外配料();
            計算訂單總價();
        }
        void 辣度()
        {
            SqlConnection con = new SqlConnection(strMyLuwaConnectionString);
            con.Open();
            string strSQL = "select *  from  luwa辣度 ;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string strMsg = "";
                string 品項 = reader["辣度"].ToString();
                strMsg += string.Format("{0}", 品項);
                comboBox辣度.Items.Add(strMsg);
                list辣度.Add(品項);
            }
            comboBox辣度.SelectedIndex = 0;
            reader.Close();
            con.Close();
        }
        void 醬料選擇()
        {
            SqlConnection con = new SqlConnection(strMyLuwaConnectionString);
            con.Open();
            string strSQL = "select *  from  luwa醬料;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string strMsg = "";
                string 品項 = reader["醬料"].ToString();
                strMsg += string.Format("{0}", 品項);
                comboBox醬料.Items.Add(strMsg);
                list醬料.Add(品項);
            }
            comboBox醬料.SelectedIndex = 0;
            reader.Close();
            con.Close();
        }

        void 額外配料()
        {
            SqlConnection con = new SqlConnection(strMyLuwaConnectionString);
            con.Open();
            string strSQL = "select *  from  luwa額外配料;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string strMsg = "";
                string 品項 = reader["額外配料"].ToString();
                strMsg += string.Format("{0}", 品項);
                comboBox額外配料.Items.Add(strMsg);
                list額外配料.Add(品項);
            }
            comboBox額外配料.SelectedIndex = 0;
            reader.Close();
            con.Close();
        }
        private void listBox訂購品項列表_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btn移除所選品項_Click(object sender, EventArgs e)
        {
            if (listBox訂購品項列表.SelectedIndex > -1)
            {
                int selIndex = listBox訂購品項列表.SelectedIndex;
                // 移除全域資料
                globalVar.list訂購品資訊列表.RemoveAt(selIndex);
                listBox訂購品項列表.Items.RemoveAt(selIndex);
                計算訂單總價();
            }
        }
        private void btn清除所有品項_Click(object sender, EventArgs e)
        {           
            listBox訂購品項列表.Items.Clear();
            globalVar.list訂購品資訊列表.Clear();
            //globalVar.訂購人資訊 = "";
            計算訂單總價();
        }      
        void 計算訂單總價()
        {
            int 訂單總價 = 0;

            foreach (ArrayList 訂購品項 in globalVar.list訂購品資訊列表)
            {               
                string 滷味品項 = (string)訂購品項[0];
                int 單價 = (int)訂購品項[1];
                int 數量 = (int)訂購品項[2];                
                string 單點飲料 = (string)訂購品項[3];
                int 單點飲料價錢 = (int)訂購品項[4];
                int 品項總價 = (int)訂購品項[5];
                訂單總價 += 品項總價 ;
                if (globalVar.t > 1)
                {
                    
                    訂單總價 = Convert.ToInt32(訂單總價 *0.95 );//會員打折
                }               
            }
            lbl訂單總價.Text = String.Format("訂單總價:{0}", 訂單總價);
            總價 = 訂單總價;
        }
        void 清除()
        {
            txt訂購人姓名.Clear();
            txt訂購人手機.Clear();
            listBox訂購品項列表.Items.Clear();
            globalVar.list訂購品資訊列表.Clear();           
            計算訂單總價();
        }       
        void 讀取編號()
        {
            SqlConnection con = new SqlConnection(strMyLuwaConnectionString);
            con.Open();
            string strSQL = "select top 1 * from luwa訂單資訊 order by 訂單編號 desc";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                訂單編號 = ((int)reader["訂單編號"]);               
            }
            reader.Close();
            con.Close();
        }
        void 放入產品()
        {
            for (int i = 0; i < list品項.Count; i++) {
                SqlConnection con = new SqlConnection(strMyLuwaConnectionString);
                con.Open();
                string strSQL = "insert into luwa訂單細項 values(@訂單編號,@Product,@單價,@數量,@辣度,@醬料,@額外配料,@飲料品名,@飲料價格)";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@訂單編號", 訂單編號);
                cmd.Parameters.AddWithValue("@Product", list品項[i]);
                cmd.Parameters.AddWithValue("@單價", list單價[i]);
                cmd.Parameters.AddWithValue("@數量", list數量[i]);
                cmd.Parameters.AddWithValue("@辣度", comboBox辣度.Text);
                cmd.Parameters.AddWithValue("@醬料", comboBox醬料.Text);
                cmd.Parameters.AddWithValue("@額外配料", comboBox額外配料.Text);
                cmd.Parameters.AddWithValue("@飲料品名", list飲料品名[i]);
                cmd.Parameters.AddWithValue("@飲料價格", list飲料價格[i]);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        private void btn送出訂單_Click(object sender, EventArgs e)
        {           
            string strPhone = txt訂購人手機.Text;
            bool Phone = Regex.IsMatch(strPhone, @"^09[0-9]{8}$");

            if (strPhone == txt訂購人手機.Text &&  Phone == true)
            {
                if ((txt訂購人姓名.Text != "") && (txt訂購人手機.Text != ""))
                {                   
                        SqlConnection con = new SqlConnection(strMyLuwaConnectionString);
                        con.Open();
                        string strSQL = "insert into luwa訂單資訊 values(@會員ID,@會員權限,@姓名,@手機,@總價,@購買時間)";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@會員ID", globalVar.id);
                        cmd.Parameters.AddWithValue("@會員權限", globalVar.t);
                        cmd.Parameters.AddWithValue("@姓名", txt訂購人姓名.Text);
                        cmd.Parameters.AddWithValue("@手機", txt訂購人手機.Text);                      
                        cmd.Parameters.AddWithValue("@總價",總價);
                        cmd.Parameters.AddWithValue("@購買時間", DateTime.Now);                      
                        int rows = cmd.ExecuteNonQuery();
                        con.Close();                        
                        MessageBox.Show(String.Format("新增成功, {0} 個資料列受到影響", rows));                   
                        清除();
                        讀取編號();
                        放入產品();
                        Close();
                }              
            }
            else
            {
                MessageBox.Show("姓名手機輸入錯誤請檢察");
            }
        }
        private void comboBox辣度_SelectedIndexChanged(object sender, EventArgs e)
        {
            所選品項辣度 = list辣度[comboBox辣度.SelectedIndex];
        }
        private void comboBox醬料_SelectedIndexChanged(object sender, EventArgs e)
        {
            所選品項醬料 = list醬料[comboBox醬料.SelectedIndex];
        }
        private void comboBox額外配料_SelectedIndexChanged(object sender, EventArgs e)
        {
            所選品項額外配料 = list額外配料[comboBox額外配料.SelectedIndex];
        }
        private void timer跑燈2_Tick(object sender, EventArgs e)
        {
            if (label2.Left + label2.Width > 0)
            {
                label2.Left = label2.Left - 30;
            }
            else if (label2.Left < 1)
            {
                label2.Left = 800;
            }
        }
    }
}
