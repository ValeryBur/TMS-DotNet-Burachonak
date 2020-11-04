using System;
using System.Collections.Generic;
using System.Text;

namespace Homework4
{
    interface IZooManager
    {
        List<AnimalBase<int>> Animals {get; set; }
        void Show();
    }
}
