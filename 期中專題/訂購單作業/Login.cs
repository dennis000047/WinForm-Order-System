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
using System.Text.RegularExpressions;

namespace 訂購單作業
{
    public partial class Login : Form
    {
        SqlConnectionStringBuilder scsb;
        string strMyLuwaconnectionString = "";
        string i ;
        
        public Login()
        {
            InitializeComponent();
            CenterToScreen();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "myluwa"; //database(資料庫)名稱
            scsb.IntegratedSecurity = true;//整合驗證
            strMyLuwaconnectionString = scsb.ToString();
        }
        void 清空欄位()
        {           
            txt帳號.Clear();
            txt密碼.Clear();            
        }

        private void txt帳號_TextChanged(object sender, EventArgs e)
        {

        }
        private void txt密碼_TextChanged(object sender, EventArgs e)
        {

        }
        void 會員編號()
        {
            SqlConnection con = new SqlConnection(strMyLuwaconnectionString);           
            string strSQL = "select *  from  luwamenber where 手機 = @Phone ; ";
            con.Open();
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@Phone",i);       
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                globalVar.id = ((int)reader["id"]);
                //Console.WriteLine(globalVar.id + "888888888888888888888888");
            }
        }

        private void btn登入_Click(object sender, EventArgs e)
        {
            i = txt帳號.Text;
            SqlConnection con = new SqlConnection(strMyLuwaconnectionString);
            con.Open();
            string strSQL = "select *  from  luwamenber ;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            List<int> 會員ID = new List<int>();
            List<string> 會員姓名 = new List<string>();
            List<string> 會員手機 = new List<string>();
            List<string> 會員密碼 = new List<string>();
            List<int> 職稱ID = new List<int>();    
            
            while (reader.Read())
            {
                //int id = ((int)reader["id"]);
                string 姓名 = reader["姓名"].ToString();
                string 手機 = reader["手機"].ToString();
                string 密碼 = reader["密碼"].ToString();
                int 權限 = ((int)reader["權限"]);
                
                globalVar.name = 姓名;
                globalVar.phone = 手機;
              
                會員姓名.Add(姓名);
                會員手機.Add(手機);
                會員密碼.Add(密碼);
                職稱ID.Add(權限);              
            }
            reader.Close();
            con.Close();
           
            int k = 0;
            for (int i = 0; i < 會員手機.Count; i++)
            {
                if (會員手機[i] == txt帳號.Text && 會員密碼[i] == txt密碼.Text && 職稱ID[i] == 100)
                {                   
                    MessageBox.Show("歡迎登入" + 會員姓名[i] + "系統管理員");
                    
                    globalVar.t = 100;
                    
                    k = 1;
                    清空欄位();
                    Formimage 商品圖片 = new Formimage();
                    商品圖片.Show();
                    //Maintain 管理員維護 = new Maintain();
                    //管理員維護.Show();
                    globalVar.w++;
                    會員編號();
                    
                    break;
                }
                else if(會員手機[i] == txt帳號.Text && 會員密碼[i] == txt密碼.Text && 職稱ID[i] == 10 )
                {
                    MessageBox.Show("歡迎登入" + 會員姓名[i] + "會員");
                    globalVar.t = 10;
                    Close();                    
                    k = 1;
                    清空欄位();
                    會員編號();         
                    globalVar.w++;
                    break;
                }
                else
                {
                    k = 0;                                    
                }                
            }
            if (k == 0)
            {
                MessageBox.Show("輸入錯誤請檢察");
                清空欄位();
            }
        }
        private void btn註冊會員_Click(object sender, EventArgs e)
        {           
            SignUp 註冊會員 = new SignUp();
            註冊會員.ShowDialog();
            Close();
        }
    }
}
