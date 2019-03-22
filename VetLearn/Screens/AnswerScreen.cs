using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetLearn.Model;

namespace VetLearn
{
    public partial class AnswerScreen : Form, IAnswerScreen
    {
        public event EventHandler GotoLearnScreenBtnClicked;

        public AnswerScreen()
        {
            InitializeComponent();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            GotoLearnScreenBtnClicked(this, e);
        }

        public void SetAnswer(string answer)
        {
            answerTextBox.Text = answer;
        }

        public void OpenHide(bool open)
        {
            if (open)
            {
                Show();
            }
            else
            {
                Hide();
            }
        }

        private void AnswerScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
