using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace 訂購單作業
{
    internal class globalVar
    {
        public static string 訂購人資訊 = "";
        public static List<ArrayList> list訂購品資訊列表 = new List<ArrayList>();
        public static string 訂單總價 = "";
        public static int id=2022;//訪客預設
        public static string name = "";
        public static string phone = "";
        public static int w = 0;// 登入登出按鈕visible
        public static int t = 1; //會員權限  100系統管理員 10會員 1訪客


    }
}
