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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            moviesBox.Items.Add("1.Slash of the Titans");
            moviesBox.Items.Add("2.Bang Bang");
            moviesBox.Items.Add("3.DeadPool");
            moviesBox.Items.Add("4.John Wick 2");
            moviesBox.DropDownStyle = ComboBoxStyle.DropDownList;

            

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;

            Films flms1 = new Films("Slash of the Titans", "Wes Craven", "Robert Englund", 5.8, "2003/5/13");
            Films flms2 = new Films("Bang Bang", "Siddharth Anand", "Hrithik Roshan and Katrina Kaif", 5.5, "2014/6/28");
            Films flms3 = new Films("DeadPool", "Rhett Reese", "Ryan and Morena", 8.0, "2016/3/16");
            Films flms4 = new Films("John Wick 2", " Derek Kolstad,", "Keanu Reeves", 7.5, "2017/9/3");

            foreach (Films item in flms1.filmDetails)
            {


                comboBox1.Items.Add("1.Name: " + item.Name);
                comboBox1.Items.Add("2.Writers: " + item.Writers);
                comboBox1.Items.Add("3.Stars: " + item.Stars);
                comboBox1.Items.Add("4.IMDB Point: " + item.ImdbPoint);
                comboBox1.Items.Add("5. Vision Date: " + item.VisionDate);



            }


            foreach (Films item in flms2.filmDetails)
            {


                comboBox2.Items.Add("1.Name: " + item.Name);
                comboBox2.Items.Add("2.Writers: " + item.Writers);
                comboBox2.Items.Add("3.Stars: " + item.Stars);
                comboBox2.Items.Add("4.IMDB Point: " + item.ImdbPoint);
                comboBox2.Items.Add("5. Vision Date: " + item.VisionDate);




            }


            foreach (Films item in flms3.filmDetails)
            {


                comboBox3.Items.Add("1.Name: " + item.Name);
                comboBox3.Items.Add("2.Writers: " + item.Writers);
                comboBox3.Items.Add("3.Stars: " + item.Stars);
                comboBox3.Items.Add("4.IMDB Point: " + item.ImdbPoint);
                comboBox3.Items.Add("5. Vision Date: " + item.VisionDate);




            }

            foreach (Films item in flms4.filmDetails)
            {


                comboBox4.Items.Add("1.Name: " + item.Name);
                comboBox4.Items.Add("2.Writers: " + item.Writers);
                comboBox4.Items.Add("3.Stars: " + item.Stars);
                comboBox4.Items.Add("4.IMDB Point: " + item.ImdbPoint);
                comboBox4.Items.Add("5. Vision Date: " + item.VisionDate);




            }


        }

        private void Entry_Click(object sender, EventArgs e)
        {
            if (moviesBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select Movie Before Choose Seat");
            }
            else
            {
                this.Hide();
                ChooseSeat cs = new ChooseSeat();
                cs.Show();
            }
        }
    }

    class Films
    {
        public List<Films> filmDetails = new List<Films>();
        public List<Films> Movies = new List<Films>();

        public string Name;
        public string Writers;
        public string Stars;
        public double ImdbPoint;
        public string VisionDate;

        public Films(string _name, string _writers, string _stars, double _imdbpoint, string _visiondate)
        {
            this.Name = _name;
            this.Writers = _writers;
            this.Stars = _stars;
            this.ImdbPoint = _imdbpoint;
            this.VisionDate = _visiondate;
            filmDetails.Add(this);
        }

    }
}

