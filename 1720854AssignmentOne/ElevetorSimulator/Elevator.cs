using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevetorSimulator
{
    class Elevator
    {
        int moveUp = 109;
        int moveDown = 486;
        

        public void MovesUp(PictureBox insideElevator)
        {
            if (insideElevator.Top >= moveUp)//To move the elevator upward
            {
                insideElevator.Top -= 1;
                
            }

        }

        public void Down(PictureBox insideElevators)
        {
            if (insideElevators.Top <= moveDown)//To move the elevator downward
            {
                insideElevators.Top += 1;
            }

        }
    }
}
