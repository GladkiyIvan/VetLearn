using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetLearn.Model
{
    public interface IStartScreen : IScreen
    {
        event Action<object, string> CategoryIsChosen;
        event EventHandler GotoAddCategoryScreen;
        event EventHandler GotoAddQuestionScreen;
        event EventHandler GotoDeleteCategoryScreen;
        void AdjustCategoriesListToCombobox(string categoryName, bool add);
    }
}
