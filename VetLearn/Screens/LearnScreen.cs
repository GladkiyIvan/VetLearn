using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using VetLearn.Model;

namespace VetLearn
{
    public partial class LearnScreen : Form, ILearnScreen
    {
        public event EventHandler AnswerBtnClicked;
        public event EventHandler GotoMenuBtnClicked;
        public event Action<object,RichTextBox,PictureBox> GotoNextBtnClicked;

        public LearnScreen()
        {
            InitializeComponent();
        }

        public void SetQuestionDetails(string description, Image image)
        {
            descriptionTextBox.Text = description;
            pictureBox1.Image = image;
        }

        private void AnswerBtn_Click(object sender, EventArgs e)
        {
            AnswerBtnClicked(sender, e);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            GotoMenuBtnClicked(sender, e);
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            GotoNextBtnClicked(sender, descriptionTextBox, pictureBox1);
            //OpenFileDialog fileDialog = new OpenFileDialog();

            //if (fileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    Bitmap btm = new Bitmap(fileDialog.FileName);
            //    pictureBox1.Image = btm;
            //}
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

        private void LearnScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
