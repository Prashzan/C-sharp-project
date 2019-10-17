using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevetorSimulator
{
    class Door
    {
        int openLeftDoor = 61;
        int openRightDoor = 224;
        int closeLeftDoor = 111;
        int closeRightDoor = 174;
        public void CloseDoor(PictureBox leftDoor, PictureBox rightDoor,int floorNum)
        {//Close the door according to the floor number
            if (floorNum == 1 && leftDoor.Left <= closeLeftDoor && rightDoor.Left >= closeRightDoor)
            {
                leftDoor.Left += 1;
                rightDoor.Left -= 1;

            }
            else if (floorNum == 0 && leftDoor.Left <= closeLeftDoor && rightDoor.Left >= closeRightDoor)
            {
                leftDoor.Left += 1;
                rightDoor.Left -= 1;
            } 
        }

        public void OpenDoor(PictureBox leftDoor, PictureBox rightDoor, int floorNum)
        {//Open the door according to the floor number
            if (floorNum == 1 && leftDoor.Left >= openLeftDoor && rightDoor.Left <= openRightDoor)
            {
                leftDoor.Left -= 1;
                rightDoor.Left += 1;
            }
            else if (floorNum == 0 && leftDoor.Left >= openLeftDoor && rightDoor.Left <= openRightDoor)
            {
                leftDoor.Left -= 1;
                rightDoor.Left += 1;
            }
        }
    }
}
