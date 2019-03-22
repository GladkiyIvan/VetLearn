using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VetLearn.Model;
using VetLearn.Extensions;

namespace VetLearn
{
    public partial class StartScreen : Form, IStartScreen
    {
        public event Action<object, string> CategoryIsChosen;
        public event EventHandler GotoAddCategoryScreen;
        public event EventHandler GotoAddQuestionScreen;
        public event EventHandler GotoDeleteCategoryScreen;

        public StartScreen()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show($"Сначала нужно выбрать категорию");
                return;
            }

            CategoryIsChosen(sender, comboBox1.Items[comboBox1.SelectedIndex].ToString());
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            GotoAddCategoryScreen(this, EventArgs.Empty);
        }
        private void AddQstnbtn_Click(object sender, EventArgs e)
        {
            GotoAddQuestionScreen(this, EventArgs.Empty);
        }
        private void Delbtn_Click(object sender, EventArgs e)
        {
            GotoDeleteCategoryScreen(this, EventArgs.Empty);
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
    }
}
