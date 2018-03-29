using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaStarter
{
    public partial class ChooseSeat : Form
    {
        public List<Button> seatList = new List<Button>();
        public int LeftPos = 1;
        public int TopPos = 1;
        public int Count = 1;
        public int columCount = 6;
        void btn_click(object obj, EventArgs e)
        {
            var buton = obj as Button;
            buton.BackColor = Color.Red;
            buton.Enabled = false;
            seatList.Add(buton);
            textBox1.Text = "";
            foreach (Button item in seatList)
            {
                textBox1.Text += item.Text + ",";
            }
        }

            public ChooseSeat()
        {
            InitializeComponent();


            for (int i = 1; i <= columCount; i++)
            {
                
                for (int x = columCount; x > i; x--)
                {
                    LeftPos += 30;
                }

                for (int y = 0; y <= i; y++)
                {
                    Button btn = new Button();
                    btn.Width = 50;
                    btn.Click += new EventHandler(btn_click);
                    btn.Height = 30;
                    btn.Left = LeftPos;
                    btn.Text = Count.ToString();
                    btn.Top = TopPos;
                    Count++;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.BackColor = Color.Azure;
                    Controls.Add(btn);
                    LeftPos += 60;
                }

                TopPos += 50;
                LeftPos = 0;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
