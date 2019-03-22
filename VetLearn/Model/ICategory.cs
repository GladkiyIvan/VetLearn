using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetLearn.Model
{
    interface ICategory
    {
        string Id { get; set; }
        List<Question> Questions { get; set; }
    }
}
