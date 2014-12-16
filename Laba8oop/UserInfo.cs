using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba8oop
{
    

    class UserInfo
    {
        public Dictionary<string, string> dic = new Dictionary<string, string>();
        public string this[string key]
        {
            get { return dic[key]; }
            set { dic[key] = value; }
        }
        public void MyDic()
        {
            dic.Add("ф", "f");
            dic.Add("а", "a");
            dic.Add("б", "b");
            dic.Add("в", "v");
            dic.Add("г", "g");
            dic.Add("д", "d");
            dic.Add("е", "e");
            dic.Add("ё", "io");
            dic.Add("ж", "j");
            dic.Add("з", "z");
            dic.Add("и", "i");
            dic.Add("й", "i");
            dic.Add("к", "k");
            dic.Add("л", "l");
            dic.Add("м", "m");
            dic.Add("н", "n");
            dic.Add("о", "o");
            dic.Add("п", "p");
            dic.Add("р", "r");
            dic.Add("с", "s");
            dic.Add("т", "t");
            dic.Add("у", "u");
            dic.Add("х", "h");
            dic.Add("ц", "ts");
            dic.Add("ч", "ch");
            dic.Add("щ", "ch'");
            dic.Add("ы", "y");
            dic.Add("ь", "'");
            dic.Add("ъ", "i");
            dic.Add("э", "e");
            dic.Add("ю", "iu");
            dic.Add("я", "ia");
            dic.Add(" ", " ");
            dic.Add(",", ",");
            dic.Add(".", ".");
        }
        //public string Show(string s)
        //{
        //    string text = "";
        //    for (int i = 0; i < s.Length;i++)
        //    {
        //        string ss = Convert.ToString(s[i]);
        //        if (dic.ContainsKey(ss))
        //            text += dic[ss];
        //        else
        //        {
        //            if (ss.Equals(" "))
        //                text += ss;
        //        }
        //    }

        //    return text;
        //}
    }
}
