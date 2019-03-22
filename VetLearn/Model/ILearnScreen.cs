using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace VetLearn.Model
{
    public interface ILearnScreen : IScreen
    {
        event EventHandler AnswerBtnClicked;
        event EventHandler GotoMenuBtnClicked;
        event Action<object, RichTextBox, PictureBox> GotoNextBtnClicked;
        void SetQuestionDetails(string description, Image image);
    }
}
