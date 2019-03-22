using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetLearn.Model;

namespace VetLearn.Screens
{
    public partial class AddQuestionScreen : Form, IAddQuestionScreen
    {
        public event Action<Question> AddQuestionBtnClicked;
        public event EventHandler GotoMenuBtnClicked;
        private string newImagePath = null;

        public AddQuestionScreen()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            GotoMenuBtnClicked(sender, e);
        }

        private void AddQstnbtn_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 
                || string.IsNullOrEmpty(descriptionTextBox.Text) 
                || string.IsNullOrEmpty(answTextBox.Text)
                || newImagePath == null)
            {
                MessageBox.Show($"Информация о вопросе была введена не корректно");
                return;
            }

            Question newQuestion = new Question(comboBox1.Items[comboBox1.SelectedIndex].ToString(),
                descriptionTextBox.Text, answTextBox.Text, newImagePath);

            newImagePath = null;

            AddQuestionBtnClicked(newQuestion);
        }

        public void OpenHide(bool open)
        {
            if (open)
            {
                Show();
            }
            else
            {
                fileNamelbl.Text = "";
                Hide();
            }
        }

        private void LoadImgbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            //For any other formats
            of.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (of.ShowDialog() == DialogResult.OK)
            {
                //File.Copy(of.FileName, "../../../Pictures/" + fileName);
                newImagePath = of.FileName;
                string fileName = Path.GetFileName(of.FileName);
                fileNamelbl.Text = fileName;
            }
            else
            {
                MessageBox.Show($"Шото пошло не так, трай эгейн");
                return;
            }
        }

        private void NoPicturebtn_Click(object sender, EventArgs e)
        {
            newImagePath = "No picture";
        }

        public void AdjustCategoriesListToCombobox(string categoryName, bool add)
        {
            if (add)
            {
                comboBox1.Items.Add(categoryName);
            }
            else
            {
                comboBox1.Items.Remove(categoryName);
            }
        }

        private void AddQuestionScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
