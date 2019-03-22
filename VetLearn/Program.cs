using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetLearn.Screens;

namespace VetLearn
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                // View
                StartScreen startScreen = new StartScreen();
                LearnScreen learnScreen = new LearnScreen();
                AnswerScreen answerScreen = new AnswerScreen();
                AddQuestionScreen addQuestionScreen = new AddQuestionScreen();

                // Presenter
                Presenter.Presenter presenter = new Presenter.Presenter(startScreen, learnScreen, answerScreen, addQuestionScreen);

                Application.Run(startScreen);
            }
            catch (Exception ex)
            {
                //Write ex.Message to a file
                using (StreamWriter outfile = new StreamWriter(@".\error.txt"))
                {
                    outfile.Write(ex.Message.ToString());
                }
            }
        }
    }
}
