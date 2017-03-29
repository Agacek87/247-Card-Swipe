# 247-Card-Swipe
247 Card Swipe system
namespace LabAidPunch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.FlatAppearance.BorderSize = 0;

            if (textBoxID.Text != "" && textBoxPassword.Text != "")
            { 
                button1.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text != "" && textBoxPassword.Text != "")
            {
                labelSuccess.ForeColor = System.Drawing.Color.DarkGreen;
                labelSuccess.Text = ("Successful Punch!");

                textBoxID.Text = String.Empty;
                textBoxPassword.Text = String.Empty;
                errorLabel.Text = String.Empty;
            }
               else if(textBoxID.Text == "" && textBoxPassword.Text == "")
            {
                labelSuccess.ForeColor = System.Drawing.Color.Red;
                labelSuccess.Text = ("Bad Punch!");

                errorLabel.ForeColor = System.Drawing.Color.Red;
                errorLabel.Text= ("Please Enter Something");

                textBoxID.Text = String.Empty;
                textBoxPassword.Text = String.Empty;

            }
            else if (comboLabs.SelectedIndex == 0)
            {
                labelSuccess.ForeColor = System.Drawing.Color.Red;
                labelSuccess.Text = ("Bad Punch!");

                errorLabel.ForeColor = System.Drawing.Color.Red;
                errorLabel.Text = ("Please Enter Something");

                textBoxID.Text = String.Empty;
                textBoxPassword.Text = String.Empty;
                comboLabs.Text = String.Empty;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Admin_Click(object sender, EventArgs e)
        {
            AdminForm adminController = new AdminForm();
            adminController.Show();
        }
    }
}
