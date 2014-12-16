using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba8oop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string simvols = txtText.Text;
            txtCount1.Text = simvols.Count().ToString();
            UserInfo UI = new UserInfo();
            UI.MyDic();
            //string text = UI.Show(simvols);
            string text = "";
            for (int i = 0; i < simvols.Count(); i++ )
            {
                if (UI.dic.ContainsKey(simvols.ElementAt(i).ToString()))
                {
                    text += UI.dic[simvols.ElementAt(i).ToString()]; 
                }
                else { MessageBox.Show("Содержится неправильный элемент"); return; }
            }
                txtCount2.Text = text.Count().ToString() ;
                textBox1.Text = text;

        }
    }
}
