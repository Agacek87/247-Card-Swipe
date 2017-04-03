using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabAidPunch
{
    public partial class FormPunch : Form
    {

        public FormPunch()
        {
            InitializeComponent();
            buttonIn.FlatAppearance.BorderSize = 0;
            panelLogin.Visible = false;
            panelSuccess.Visible = false;
            panelHome.Visible = true;
            panelAdmin.Visible = false;
            panelATimeSheet.Visible = false;

           


        }

        private void button1_Click(object sender, EventArgs e)
        {

            string studentIDz = "";

            studentIDz = textBoxIDZ.Text;

            while (studentIDz != "")
            {


                int studentID;
                //bool goodPunch = false;

                //validation to check the user actually input something
                if (textBoxPassword.Text == "" && textBoxID.Text == "")
                {
                    labelSuccess.Text = ("Please enter something");
                    labelSuccess.ForeColor = System.Drawing.Color.Red;
                }
                else if (textBoxID.Text == "")
                {
                    labelSuccess.Text = ("Enter a Student #!");
                    labelSuccess.ForeColor = System.Drawing.Color.Red;
                    textBoxPassword.Text = String.Empty;
                }
                else if (textBoxPassword.Text == "")
                {
                    labelSuccess.Text = ("Enter a Password!");
                    labelSuccess.ForeColor = System.Drawing.Color.Red;
                    textBoxID.Text = String.Empty;
                }
                //check that only an integer can be input into the textbox
                else if (!int.TryParse(textBoxID.Text, out studentID))
                {
                    labelSuccess.Text = ("Only enter numbers!");
                    labelSuccess.ForeColor = System.Drawing.Color.Red;
                    textBoxPassword.Text = String.Empty;
                    textBoxID.Text = String.Empty;
                }

                //check that combobox has a selected index
                else if (comboLabs.SelectedIndex < 0)
                {
                    labelSuccess.Text = ("Select a lab");
                    labelSuccess.ForeColor = System.Drawing.Color.Red;
                }
                else
                {//if everything passes, notify good punch
                    panelSuccess.Visible = true;
                    labelSuccess.Text = String.Empty;
                    labelSuccess.ForeColor = System.Drawing.Color.MidnightBlue;
                    textBoxPassword.Text = String.Empty;
                    textBoxID.Text = String.Empty;
                    comboLabs.Text = String.Empty;
                    panelLogin.Visible = false;
                    //goodPunch = true;
                }

                if (textBoxIDZ.Text != "")
                {
                    labelhomeP.Text = (studentIDz + "Had a good punch!");
                    break;
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Admin_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = false;
            panelSuccess.Visible = false;


        }



        private void comboLabs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int studentID;

            //validation to check the user actually input something
            if (textBoxPassword.Text == "" && textBoxID.Text == "")
            {
                labelSuccess.Text = ("Please enter something");
                labelSuccess.ForeColor = System.Drawing.Color.Red;
            }
            else if (textBoxID.Text == "")
            {
                labelSuccess.Text = ("Enter a Student #!");
                labelSuccess.ForeColor = System.Drawing.Color.Red;
                textBoxPassword.Text = String.Empty;
            }
            else if (textBoxPassword.Text == "")
            {
                labelSuccess.Text = ("Enter a Password!");
                labelSuccess.ForeColor = System.Drawing.Color.Red;
                textBoxID.Text = String.Empty;
            }
            //check that only an integer can be input into the textbox
            else if (!int.TryParse(textBoxID.Text, out studentID))
            {
                labelSuccess.Text = ("Only enter numbers!");
                labelSuccess.ForeColor = System.Drawing.Color.Red;
                textBoxPassword.Text = String.Empty;
                textBoxID.Text = String.Empty;
            }
            else if (studentID < 6)
            {
                labelSuccess.Text = ("Please enter 6 digits");
            }

            //check that combobox has a selected index
            else if (comboLabs.SelectedIndex < 0)
            {
                labelSuccess.Text = ("Select a lab");
                labelSuccess.ForeColor = System.Drawing.Color.Red;
            }
            else
            {//if everything passes, notify good punch
                labelSuccess.Text = ("Punched out!");
                labelSuccess.ForeColor = System.Drawing.Color.MidnightBlue;
                textBoxPassword.Text = String.Empty;
                textBoxID.Text = String.Empty;
                comboLabs.Text = String.Empty;
                panelLogin.Visible = false;
                panelSuccess.Visible = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = false;
            panelSuccess.Visible = false;
            panelHome.Visible = true;
            panelAdmin.Visible = false;
            panelATimeSheet.Visible = false;

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            panelHome.Visible = false;
            panelLogin.Visible = false;
            panelSuccess.Visible = false;
            panelAdmin.Visible = true;
            panelATimeSheet.Visible = false;
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            panelHome.Visible = true;
            panelLogin.Visible = false;
            panelSuccess.Visible = false;
            panelAdmin.Visible = false;
            panelATimeSheet.Visible = false;

        }

        private void buttonStudent_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = true;
            panelHome.Visible = false;
            panelSuccess.Visible = false;
            panelAdmin.Visible = false;
            panelATimeSheet.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelAdminSuccess_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //validation to check the user actually input something
            if (textBoxALogin.Text == "" && textBoxAPass.Text == "")
            {
                labelAdminSuccess.Text = ("Please enter something");
                labelAdminSuccess.ForeColor = System.Drawing.Color.Red;
            }
            else if (textBoxALogin.Text == "")
            {
                labelAdminSuccess.Text = ("Enter a Username");
                labelAdminSuccess.ForeColor = System.Drawing.Color.Red;
                textBoxALogin.Text = String.Empty;
            }
            else if (textBoxAPass.Text == "")
            {
                labelAdminSuccess.Text = ("Enter a Password!");
                labelAdminSuccess.ForeColor = System.Drawing.Color.Red;
                textBoxAPass.Text = String.Empty;
            }
            else
            {//if everything passes, notify good punch
                labelAdminSuccess.Text = String.Empty;
                textBoxAPass.Text = String.Empty;
                textBoxALogin.Text = String.Empty;
                panelLogin.Visible = false;
                panelSuccess.Visible = false;
                panelAdmin.Visible = false;
                panelHome.Visible = false;
                panelATimeSheet.Visible = true;
            }

        }

        private void labelhomeP_Click(object sender, EventArgs e)
        {

        }

        private void textBoxIDZ_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
