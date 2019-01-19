using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHNN
{
    public partial class Form1 : Form
    {
        MHNN mohinh = new MHNN();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ dữ liệu");
                return;
            }
            mohinh.a        = Convert.ToInt16(textBox1.Text);
            mohinh.b        = Convert.ToInt16(textBox2.Text);
            mohinh.c        = Convert.ToInt16(textBox3.Text);
            mohinh.d        = Convert.ToInt16(textBox4.Text);
            string[] matran = new string[mohinh.d + 1];
            matran = mohinh.matran();
            listBox1.Items.Add("Ma trận sinh G");
            for (int i = 0; i < matran.Length; i++)
            {
                listBox1.Items.Add(matran[i]);
            }
            listBox1.Items.Add(""); listBox1.Items.Add(""); 
            float[] pio = mohinh.buildPi();
            float soxe = 0;

            for(int i=0; i< pio.Length; i++)
            {
                soxe += i * pio[i];
                listBox1.Items.Add("pi("+i+") = "+pio[i]);
            }
            float ln = 0;
            float r = mohinh.a / mohinh.b;
            float Lq = (soxe - r);
            float Wq = Lq / mohinh.a;
            float W = Wq + 1 / mohinh.b;
            listBox1.Items.Add("");
            if (textBox5.Text != "") {
                ln = soxe * 24 * (Convert.ToInt16(textBox5.Text));
                listBox1.Items.Add("Lợi nhuận = " + ln);
            }
            listBox1.Items.Add("Số khách trung bình toàn bộ hệ thống là " + soxe);
            //listBox1.Items.Add("Số khách trung bình trong hàng chờ là " + Lq.ToString());
            //listBox1.Items.Add("Thời gian chờ trung bình trong hàng chờ "  + Wq.ToString());
            //listBox1.Items.Add("Thời gian chờ trung bình trong toàn bộ hệ thống "  + W.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
