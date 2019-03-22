using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetLearn.Model
{
    interface IQuestion
    {
        string CategoryId { get; set; }
        string Description { get; set; }
        string Answer { get; set; }
        string ImagePath { get; set; }
        Image Image { get; set; }
    }
}
