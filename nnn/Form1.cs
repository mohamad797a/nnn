using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nnn
{
    public partial class Form1 : Form
    {
        Random Random = new Random();

        int number = 0;
        int guesses = 0;


        public Form1()
        {
            InitializeComponent();

            loadQuestions();
        }

        private void CheckNumber(object sender, EventArgs e)
        {
        int i = Convert.ToInt32(txtEnterNumber.Text);

            guesses += 1;
            lblGuessed.Text = "Du gissade" +   guesses   + "gånger"; 

            if (i == number)
            {
                MessageBox.Show(" Bra du gissade rätt, frösök en gång till");
                loadQuestions();
                txtEnterNumber.Text = "";
                guesses = 0;
            }
            else if (i < number) 
            {
                MessageBox.Show("Gå högre"); 
            }
            else
            {
                MessageBox.Show("Gå mindre");
            }






        }


        private void loadQuestions()
        {
            number = Random.Next(0, 100);

            lblQuestion.Text=" Gissa rätt nummer från 0-100"; 

        }
    }
}
