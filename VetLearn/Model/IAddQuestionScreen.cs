using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetLearn.Model
{
    public interface IAddQuestionScreen : IScreen
    {
        event Action<Question> AddQuestionBtnClicked;
        event EventHandler GotoMenuBtnClicked;
        void AdjustCategoriesListToCombobox(string categoryName, bool add);
    }
}
