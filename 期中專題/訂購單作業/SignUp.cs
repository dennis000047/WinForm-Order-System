using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace 訂購單作業
{
    public partial class SignUp : Form
    {
        SqlConnectionStringBuilder scsb;
        string strMyLuwaconnectionString = "";
        public SignUp()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"."; //一個字串代表伺服器名稱
            scsb.InitialCatalog = "myluwa"; //database(資料庫)名稱
            scsb.IntegratedSecurity = true;//整合驗證
            strMyLuwaconnectionString = scsb.ToString();
        }

        private void txt註冊姓名_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt註冊手機_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt註冊密碼_TextChanged(object sender, EventArgs e)
        {
           
        }
        void AddMenberToSQL()
        {
            SqlConnection con = new SqlConnection(strMyLuwaconnectionString);
            con.Open();
            string strSQL = "insert luwamenber values(@NewName,@NewPhone,@NewPassword, 10)";//10會員
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@NewName", txt註冊姓名.Text);
            cmd.Parameters.AddWithValue("@NewPhone", txt註冊手機.Text);
            cmd.Parameters.AddWithValue("@NewPassword", txt註冊密碼.Text);

            //只執行不查詢 像ssms的update 顯示受影響有幾筆但不查詢
            int rows = cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show(String.Format("新增成功, {0} 個資料列受到影響", rows));
            txt註冊姓名.Clear();
            txt註冊手機.Clear();
            txt註冊密碼.Clear();
            this.Close();
            Login 登入 = new Login();
            登入.ShowDialog();
        }

        private void btn送出_Click(object sender, EventArgs e)
        {
            string strPhone = txt註冊手機.Text;
            bool Phone = Regex.IsMatch(strPhone, @"^09[0-9]{8}$");
           
            if (txt註冊手機.Text != "" && Phone == true)
            {
                List<string> 會員手機帳號 = new List<string>();
                SqlConnection con = new SqlConnection(strMyLuwaconnectionString);                
                string strSQL = "select* from luwamenber ";
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string 會員手機 = reader["手機"].ToString();
                    會員手機帳號.Add(會員手機);
                }
                reader.Close();
                con.Close();
                             
                for (int i = 0; i < 會員手機帳號.Count; i++)
                {
                    if (會員手機帳號[i] == txt註冊手機.Text)
                    {
                        MessageBox.Show("此手機已註冊過囉");
                        txt註冊手機.Clear();
                        txt註冊密碼.Clear();
                        
                        break;
                    }
                }                            
                    if (strPhone == txt註冊手機.Text && Phone == true)
                    {
                        if ((txt註冊姓名.Text != "") && (txt註冊手機.Text != "") && (txt註冊密碼.Text != ""))
                        {
                            AddMenberToSQL();                          
                        }                      
                    }               
            }
            else
            {
                MessageBox.Show("格式錯誤請重新輸入");
                txt註冊手機.Clear();
                txt註冊密碼.Clear();
            }
        }

        private void btn返回_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
