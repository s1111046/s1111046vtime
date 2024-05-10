using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s1111046vtime
{   
    
    public partial class Form1 : Form
    {

        private int count = 101;//設定初始剩下秒數為100秒
        private Timer timer;//建計算器
        public Form1()
        {
            InitializeComponent();
            InitializeTimer();//初始化計時器


        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval =1000;//設計計時器隔為1秒
            timer.Tick += label1_Click;//設定計時器觸發事件

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
            
        }


        private void label1_Click(object sender, EventArgs e)
        {
            if(count > 0)
            {
                count--;//每一秒減少剩餘秒數
                label1.Text = $"{count}";//更新label顯示的文字

            }
            else
            {
                timer.Stop();//停止計時器
                MessageBox.Show("時間到了！");//彈出窗口
            }

        }







        

    }
}
