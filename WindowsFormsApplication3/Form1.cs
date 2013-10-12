using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmdCheck_Click(object sender, EventArgs e)
        {
            string str = "รายการที่เลือก :" + Environment.NewLine;
            if (optMale.Checked == true)
            {
                str = str + "เพศ : ชาย" + Environment.NewLine;
            }
            else
            {
                str = str + "เพศ : หญิง" + Environment.NewLine;
            }
            str = str + "อายุ:" + Environment.NewLine;
            if (opt1.Checked == true)
            {
                str = str + "น้อยกว่า 20 ปี" + Environment.NewLine;
            }
            if (opt2.Checked == true)
            {
                str = str + " 20-40 ปี" + Environment.NewLine;
            }
            if (opt3.Checked == true)
            {
                str = str + "มากกว่า 40 ปี" + Environment.NewLine;
            }
            str = str + "1.อายุรถของคุณ:" + Environment.NewLine;
            if (apt1.Checked == true)
            {
                str = str + "ต่ำกว่า 5 ปี" + Environment.NewLine;
            }
            if (apt2.Checked == true)
            {
                str = str + " 5-10 ปี" + Environment.NewLine;
            }
            if (apt3.Checked == true)
            {
                str = str + " มากกว่า 10 ปี" + Environment.NewLine;

            }
            str = str + "2.คุณตรวจสภาพรถบ่อยแค่ไหน? :" + Environment.NewLine;
            if (bpt1.Checked == true)
            {
                str = str + "พอสมควร" + Environment.NewLine;
            }
            if (bpt2.Checked == true)
            {
                str = str + "ไม่เคยเลยหรือน้อย" + Environment.NewLine;

            }
            str = str + "3.คุณตรวจสภาพรถก่อนออกเดินทางหรือไม่ :" + Environment.NewLine;
            if (cpt1.Checked == true)
            {
                str = str + "ทุกครั้ง" + Environment.NewLine;
            }
            if (cpt2.Checked == true)
            {
                str = str + "บางครั้ง" + Environment.NewLine;
            }
            if (cpt3.Checked == true)
            {
                str = str + "ไม่เคยเลย" + Environment.NewLine;

            }
            str = str + "4.วิธีตรวจสภาพรถของคุณ :" + Environment.NewLine;
            if (dpt1.Checked == true)
            {
                str = str + "เข้าศูนย์" + Environment.NewLine;
            }
            if (dpt2.Checked == true)
            {
                str = str + "ด้วยตัวเอง" + Environment.NewLine;
            }
            if (dpt3.Checked == true)
            {
                str = str + "เข้าอู่" + Environment.NewLine;


            }
            str = str + "5.คุณใส่ใจกับการตรวจสภาพรถของคุณมากแค่ไหน :" + Environment.NewLine;
            if (fpt1.Checked == true)
            {
                str = str + "มากทีสุด" + Environment.NewLine;
            }
            if (fpt2.Checked == true)
            {
                str = str + "พอสมควร" + Environment.NewLine;
            }
            if (fpt3.Checked == true)
            {
                str = str + "ไม่เคย" + Environment.NewLine;


            }
            MessageBox.Show(str, "ผลการตรวจสอบ");
        }

        private void optMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

