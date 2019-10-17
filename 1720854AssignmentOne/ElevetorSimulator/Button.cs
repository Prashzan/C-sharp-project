using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevetorSimulator
{
    class Button
    {
        int floorNumber;
        public Button(int floorNum)
        {
            floorNumber = floorNum;
        }

        public int floorNumbers()
        {
            return floorNumber;
        }
       
    }
}
