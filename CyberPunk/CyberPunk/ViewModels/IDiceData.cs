using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberPunk.ViewModels
{
    interface IDiceData
    {
        int Dice10 { get; set; }

        int Dice20 { get; set; }

        int GetResult(int feature, int skill);
    }
}
