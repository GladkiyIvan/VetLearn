using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using VetLearn.Model;
using VetLearn.Extensions;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace VetLearn.Presenter
{
    public class Presenter
    {
        private readonly IStartScreen _startScreen;
        private readonly ILearnScreen _learnScreen;
        private readonly IAnswerScreen _answerScreen;
        private readonly IAddQuestionScreen _addQuestionScreen;
        private const string dataPath = "Data/categories.json";
        private const string defaultPicturePath = "Pictures/Default.jpg";
        private const string picturePath = "Pictures/";

        private readonly List<Category> _categories;
        private Category _currentCategory;
        private int questionsCounter = 0;

        public Presenter(IStartScreen startscreen, ILearnScreen learnScreen, 
            IAnswerScreen answerScreen, IAddQuestionScreen addQuestionScreen)
        {
            // Configuration
            _startScreen = startscreen;
            _learnScreen = learnScreen;
            _answerScreen = answerScreen;
            _addQuestionScreen = addQuestionScreen;

            _startScreen.CategoryIsChosen += ChooseCategory;
            _startScreen.GotoAddCategoryScreen += AddCategoryDialog;
            _startScreen.GotoDeleteCategoryScreen += DeleteCategoryDialog;
            _startScreen.GotoAddQuestionScreen += GotoAddQuestionFromMenuScreen;
            _learnScreen.AnswerBtnClicked += OpenAnswerScreen;
            _learnScreen.GotoMenuBtnClicked += GotoMenuFromLearnScreen;
            _learnScreen.GotoNextBtnClicked += GotoNextQuestion;
            _answerScreen.GotoLearnScreenBtnClicked += CloseAnswerScreen;
            _addQuestionScreen.GotoMenuBtnClicked += GotoMenuFromAddQuestionScreen;
            _addQuestionScreen.AddQuestionBtnClicked += AddQuestion;

            // Load resources
            _currentCategory = new Category();
            // 
            // Encoding.GetEncoding(1251)
            if (!File.Exists(dataPath))
            {
                var sw = File.CreateText(dataPath);
                sw.Close();
                _categories = new List<Category> ();
            }
            else
            {
                _categories = JsonConvert.DeserializeObject<List<Category>>(File.ReadAllText(dataPath, Encoding.UTF8));
            }

            // Get images from byte arrays
            if (_categories.Any())
            {
                foreach (var category in _categories)
                {
                    _startScreen.AdjustCategoriesListToCombobox(category.Id, true);
                    _addQuestionScreen.AdjustCategoriesListToCombobox(category.Id, true);

                    if (category.Questions.Any())
                    {
                        foreach (var question in category.Questions)
                        {
                            if (string.IsNullOrEmpty(question.ImagePath))
                            {
                                question.Image = Image.FromStream(new MemoryStream(File.ReadAllBytes(defaultPicturePath)));
                                continue;
                            }

                            using (var ms = new MemoryStream(File.ReadAllBytes(question.ImagePath)))
                            {
                                question.Image = Image.FromStream(ms);
                            }
                        }
                    }
                }
            }
        }

        void ChooseCategory(object sender, string chosenCategory)
        {
            _currentCategory = _categories.FirstOrDefault(c => c.Id == chosenCategory);

            if (_currentCategory == null)
            {
                MessageBox.Show($"Категории {chosenCategory} не существует");
                return;
            }
            if (!_currentCategory.Questions.Any())
            {
                MessageBox.Show($"В данной категории еще нет вопросов");
                return;
            }

            _startScreen.OpenHide(false);
            _learnScreen.OpenHide(true);

            questionsCounter = 0;
            _currentCategory.Questions.Shuffle();
            var question = _currentCategory.Questions[questionsCounter];
            _learnScreen.SetQuestionDetails(question.Description, question.Image);
        }

        void OpenAnswerScreen(object sender, EventArgs e)
        {
            _answerScreen.OpenHide(true);
            _answerScreen.SetAnswer(_currentCategory.Questions[questionsCounter].Answer);
        }

        void CloseAnswerScreen(object sender, EventArgs e)
        {
            _answerScreen.OpenHide(false);
        }

        void GotoMenuFromLearnScreen(object sender, EventArgs e)
        {
            _startScreen.OpenHide(true);
            _learnScreen.OpenHide(false);
            questionsCounter = 0;
        }

        void GotoMenuFromAddQuestionScreen(object sender, EventArgs e)
        {
            _addQuestionScreen.OpenHide(false);
            _startScreen.OpenHide(true);
        }

        void GotoAddQuestionFromMenuScreen(object sender, EventArgs e)
        {
            _startScreen.OpenHide(false);
            _addQuestionScreen.OpenHide(true);
        }

        void GotoNextQuestion(object sender, RichTextBox textBox, PictureBox pictureBox)
        {
            questionsCounter += 1;

            if (questionsCounter >= _currentCategory.Questions.Count())
            {
                _currentCategory.Questions.Shuffle();
                questionsCounter = 0;
            }

            var question = _currentCategory.Questions[questionsCounter];
            textBox.Text = question.Description;
            pictureBox.Image = question.Image;
            _answerScreen.OpenHide(false);
        }

        private void AddCategoryDialog(object sender, EventArgs e)
        {
            Form prompt = new Form()
            {
                Width = 250,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Добавление категории",
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 25, Top = 20, Text = "Введи название категории" };
            TextBox textBox = new TextBox() { Left = 25, Top = 50, Width = 200 };
            Button confirmation = new Button() { Text = "Ок", Left = 175, Width = 50, Top = 80, DialogResult = DialogResult.OK };
            confirmation.Click += (s, ev) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            if (prompt.ShowDialog() == DialogResult.OK)
            {
                _categories.Add(new Category(textBox.Text));
                File.WriteAllText(dataPath, JsonConvert.SerializeObject(_categories));
                _startScreen.AdjustCategoriesListToCombobox(textBox.Text, true);
                _addQuestionScreen.AdjustCategoriesListToCombobox(textBox.Text, true);

                MessageBox.Show($"Категория была успешно добавленна");
            }
            else
            {
                MessageBox.Show($"Шото пошло не так, трай эгейн");
                return;
            }
        }

        private void DeleteCategoryDialog(object sender, EventArgs e)
        {
            if (!_categories.Any())
            {
                MessageBox.Show($"Еще нет ни одной категории");
                return;
            }

            Form prompt = new Form()
            {
                Width = 250,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Удаление категории",
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 25, Top = 20, Text = "Список категорий" };
            ComboBox comboBox = new ComboBox() { Left = 25, Top = 50, Width = 200 };
            comboBox.Items.AddRange(_categories.Select(c => c.Id).ToArray());
            Button confirmation = new Button() { Text = "Ок", Left = 175, Width = 50, Top = 80, DialogResult = DialogResult.OK };
            confirmation.Click += (s, ev) => { prompt.Close(); };
            prompt.Controls.Add(comboBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            if (prompt.ShowDialog() == DialogResult.OK)
            {
                if (comboBox.SelectedIndex == -1)
                {
                    MessageBox.Show($"Сначала нужно выбрать категорию");
                    return;
                }

                string deletedCategory = comboBox.Items[comboBox.SelectedIndex].ToString();
                _categories.Remove(_categories.FirstOrDefault(c => c.Id == deletedCategory));
                File.WriteAllText(dataPath, JsonConvert.SerializeObject(_categories));
                _startScreen.AdjustCategoriesListToCombobox(deletedCategory, false);
                _addQuestionScreen.AdjustCategoriesListToCombobox(deletedCategory, false);

                MessageBox.Show($"Категория была успешно удалена");
            }
            else
            {
                MessageBox.Show($"Шото пошло не так, трай эгейн");
                return;
            }
        }

        private void AddQuestion(Question newQuestion)
        {
            if (newQuestion.ImagePath == "No picture")
            {
                newQuestion.ImagePath = defaultPicturePath;
            }
            else
            {
                string fileName = Path.GetFileName(newQuestion.ImagePath);

                if (File.Exists(picturePath + fileName))
                {
                    fileName = "new_" + fileName;
                }

                File.Copy(newQuestion.ImagePath, picturePath + fileName);
                newQuestion.ImagePath = picturePath + fileName;
            }

            newQuestion.Image = Image.FromStream(new MemoryStream(File.ReadAllBytes(newQuestion.ImagePath)));
            _categories.Find(c => c.Id == newQuestion.CategoryId).Questions.Add(newQuestion);

            File.WriteAllText(dataPath, JsonConvert.SerializeObject(_categories));

            MessageBox.Show($"Вопрос был успешно добавлен в категорию {newQuestion.CategoryId}");
            _addQuestionScreen.OpenHide(false);
            _startScreen.OpenHide(true);
        }
    }
}
