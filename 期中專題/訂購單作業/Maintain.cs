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
    public partial class Maintain : Form
    {
        SqlConnectionStringBuilder scsb;
        string strMyLuwaConnectionString = "";
        List<int> SearchIDs = new List<int>(); //進階搜尋的結果
        

        public Maintain()
        {
            InitializeComponent();
            CenterToScreen();
            dataGridView會員資料.AllowUserToAddRows = false;

        }

        private void Maintain_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "myluwa"; //database(資料庫)名稱
            scsb.IntegratedSecurity = true;//整合驗證
            strMyLuwaConnectionString = scsb.ToString();

            cbox搜尋欄位.Items.Add("姓名");
            cbox搜尋欄位.Items.Add("手機");
            cbox搜尋欄位.Items.Add("密碼");
            cbox搜尋欄位.Items.Add("權限");
            cbox搜尋欄位.SelectedIndex = 0;

            產生全部會員資料列表();
        }

        private void btn資料筆數_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strMyLuwaConnectionString);           
            string strSQL = "select *  from  luwamenber ; ";
            con.Open();
            SqlCommand cmd = new SqlCommand(strSQL, con);            
            SqlDataReader reader = cmd.ExecuteReader();

            string strMsg = "";
            int i = 0;

            while (reader.Read())
            {
                string id = reader["id"].ToString();
                string 姓名 = reader["姓名"].ToString();
                string 手機 = reader["手機"].ToString();
                
                strMsg += string.Format("id:{0}, 姓名:{1},手機:{2}\n", id, 姓名, 手機);
                i += 1;
            }
            strMsg += "筆數:" + i.ToString();

            reader.Close();
            con.Close();
            MessageBox.Show(strMsg);
        }
        private void btn資料搜尋_Click(object sender, EventArgs e)
        {
            if (txt姓名.Text != "")
            {
                SqlConnection con = new SqlConnection(strMyLuwaConnectionString);
                con.Open();
                string strSQL = "select * from luwamenber where 姓名 like @SearchName;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchName", "%" + txt姓名.Text + "%");
                //參數名稱 ,參數內容
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblID.Text = reader["id"].ToString();
                    txt姓名.Text = reader["姓名"].ToString();
                    txt手機.Text = reader["手機"].ToString();
                    txt密碼.Text = reader["密碼"].ToString();
                    txt權限.Text = reader["權限"].ToString();
                }
                else
                {
                    MessageBox.Show("查無此人");
                    清空欄位();
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入姓名");
            }
        }
        private void btn修改資料_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblID.Text, out intID);

            if ((intID > 0) && (txt姓名.Text != "") && (txt手機.Text != ""))
            {
                SqlConnection con = new SqlConnection(strMyLuwaConnectionString);
                con.Open();
                string strSQL = "update  luwamenber  set  姓名=@Name ,手機=@Phone,密碼=@Password,權限=@Permission  where  id=@SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Name", txt姓名.Text);
                cmd.Parameters.AddWithValue("@Phone", txt手機.Text);
                cmd.Parameters.AddWithValue("@Password", txt密碼.Text);
                cmd.Parameters.AddWithValue("@Permission", txt權限.Text);
                cmd.Parameters.AddWithValue("@SearchID", intID);
                Console.WriteLine(intID+"654654541");
                //只執行不查詢 像ssms的update 顯示受影響有幾筆但不查詢
                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine(intID);
                con.Close();

                MessageBox.Show(String.Format("異動成功, {0} 個資料列受到影響", rows));
            }
        }
        void 新增MenberToSQL()
        {
            SqlConnection con = new SqlConnection(strMyLuwaConnectionString);
            con.Open();
            string strSQL = "insert luwamenber values(@Name,@Phone,@Password,@Permission)";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@Name", txt姓名.Text);
            cmd.Parameters.AddWithValue("@Phone", txt手機.Text);
            cmd.Parameters.AddWithValue("@Password", txt密碼.Text);
            cmd.Parameters.AddWithValue("@Permission", txt權限.Text);
            int rows = cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show(String.Format("新增成功, {0} 個資料列受到影響", rows));
        }

        private void btn新增資料_Click(object sender, EventArgs e)
        {
            string strPhone = txt手機.Text;
            bool Phone = Regex.IsMatch(strPhone, @"^09[0-9]{8}$");
            

            if (txt手機.Text != "" && Phone == true)
            {
                List<string> 會員手機帳號 = new List<string>();
                SqlConnection con = new SqlConnection(strMyLuwaConnectionString);

                string strSQL = "select* from luwamenber where 手機 = @Phone ";
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Phone",txt手機.Text);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string 會員手機 = reader["手機"].ToString();
                    //會員手機帳號.Add(會員手機);
                    MessageBox.Show("此手機已註冊過囉");                   
                }
                else
                {
                    if (strPhone == txt手機.Text && Phone == true)
                    {
                        if ((txt姓名.Text != "") && (txt手機.Text != "") && (txt密碼.Text != ""))
                        {
                            新增MenberToSQL();
                        }
                    }
                }
                reader.Close();
                con.Close();                
            }
            else
            {
                MessageBox.Show("格式錯誤請重新輸入");              
            }       
        }
        void 清空欄位()
        {
            lblID.Text = "";
            txt姓名.Clear();
            txt手機.Clear();
            txt密碼.Clear();
            txt權限.Clear();
        }
        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            清空欄位();
        }

        private void btn搜尋_Click(object sender, EventArgs e)
        {
            listBox搜尋結果.Items.Clear();
            SearchIDs.Clear();
            string str欄位名稱 = cbox搜尋欄位.SelectedItem.ToString();       

            if (txt搜尋關鍵字.Text != "")
            {
                SqlConnection con = new SqlConnection(strMyLuwaConnectionString);
                con.Open();
                string strSQL = " select * from luwamenber where " + str欄位名稱 + " like @SearchKeyword ";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchKeyword", "%" + txt搜尋關鍵字.Text + "%");             
                SqlDataReader reader = cmd.ExecuteReader();

                int i = 0;
                while (reader.Read())
                {
                    listBox搜尋結果.Items.Add(string.Format("ID:{0} 姓名:{1}手機:{2}", reader["id"], reader["姓名"], reader["手機"]));
                    SearchIDs.Add((int)reader["id"]); //真正搜尋結果
                    i += 1;
                }
                if (i == 0)
                {
                    MessageBox.Show("查無此人");
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入關鍵字");
            }
        }
        private void listBox搜尋結果_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox搜尋結果.SelectedIndex >= 0)
            {
                int intSelectID = SearchIDs[listBox搜尋結果.SelectedIndex];

                SqlConnection con = new SqlConnection(strMyLuwaConnectionString);
                con.Open();
                string strSQL = "select * from luwamenber where id like @SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", intSelectID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblID.Text = reader["id"].ToString();
                    txt姓名.Text = reader["姓名"].ToString();
                    txt手機.Text = reader["手機"].ToString();
                    txt密碼.Text = reader["密碼"].ToString();
                    txt權限.Text = reader["權限"].ToString();
                }
                else
                {
                    MessageBox.Show("查無此人");
                    清空欄位();
                }
                reader.Close();
                con.Close();
            }
        }
        void 產生全部會員資料列表()
        {
            SqlConnection con = new SqlConnection(strMyLuwaConnectionString);
            con.Open();
            //string strSQL = "select * from persons";
            string strSQL = "select id as 會員編號, 姓名 ,手機, 密碼, 權限 from luwamenber";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView會員資料.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }
        private void dataGridView會員資料_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string strSelectedID = dataGridView會員資料.Rows[e.RowIndex].Cells[0].Value.ToString();
                //取得row物件(上下)然後在取得cell(左右行內)物件在取得欄位的值
                int intSelID = 0;
                bool isID = Int32.TryParse(strSelectedID, out intSelID);//out 可以為null ref不行

                if (isID)
                {
                    SqlConnection con = new SqlConnection(strMyLuwaConnectionString);
                    con.Open();
                    string strSQL = "select * from luwamenber where id like @SearchID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", intSelID);
                    //參數名稱 ,參數內容
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        lblID.Text = reader["id"].ToString();
                        txt姓名.Text = reader["姓名"].ToString();
                        txt手機.Text = reader["手機"].ToString();
                        txt密碼.Text = reader["密碼"].ToString();
                        txt權限.Text = reader["權限"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("查無此人");
                        清空欄位();
                    }
                    reader.Close();
                    con.Close();
                }
            }
        }
    }
}
