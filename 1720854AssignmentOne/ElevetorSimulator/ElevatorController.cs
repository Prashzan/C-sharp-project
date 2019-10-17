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
    public partial class ElevatorController : Form
    {
        
        public bool moveDown = false;
        public bool  moveUp= false;

        Button b = new Button(1);
        Elevator el = new Elevator();
        Door d = new Door();
        Query dc = new Query();
        

        public bool atGround = false;
        public bool atFirst = true;
        public int count = 0;
        //int countt=0;
        
        public ElevatorController()
        {
            InitializeComponent();
            groundFloor.Enabled = false;
            firstFloor.Enabled = false;
            open.Enabled = false;
            close.Enabled = false;
            
        }

        private void responseD_Click(object sender, EventArgs e)
        {
            requestU.BackColor = Color.White;// to change the color of button
            requestD.BackColor = Color.Red;
            if (atFirst == true)
            {
                moveDown = true;
            }
            else if(atGround==true)
            {
                OpenDown.Enabled = true;
            }
            CloseUp.Enabled = true;
            atFirst = false;
        }

        private void requestU_Click(object sender, EventArgs e)
        {
            groundFloor.Enabled = true;
            firstFloor.Enabled = true;
            open.Enabled = true;
            close.Enabled = true;
            //MessageBox.Show(countt.ToString());
            requestD.BackColor = Color.White;
            requestU.BackColor = Color.Red;
            if (atGround == true)
            {
                moveUp = true;
            }
            else if(atFirst==true)
            {
                OpenUp.Enabled = true;
            }
            
            CloseDown.Enabled = true;
            atGround = false;

            
        }

        

        private void firstFloor_Click(object sender, EventArgs e)
        {
            moveUp = true;
            atGround = false;
            CloseDown.Enabled = true;
            OpenDown.Enabled = false;
        }

        private void groundFloor_Click(object sender, EventArgs e)
        {
            atFirst = false;
            moveDown = true;
            CloseUp.Enabled = true;
            OpenUp.Enabled = false;

            
        }

        private void close_Click(object sender, EventArgs e)
        {
            

            if (atGround == true)
            {

                CloseDown.Enabled = true;
                OpenDown.Enabled = false;
            }
            else if (atFirst == true)
            {

                CloseUp.Enabled = true;
                OpenUp.Enabled = false;
            }
        }

        private void open_Click(object sender, EventArgs e)
        {
            
            if (atGround == true)
            {

                OpenDown.Enabled = true;
                CloseDown.Enabled = false;
            }
            else if (atFirst == true)
            {

                CloseUp.Enabled = false;
                OpenUp.Enabled = true;
            }
        }

        private void OpenUp_Tick(object sender, EventArgs e)
        {
            
            if (leftDoorU.Left >= 61 && rightDoorU.Left <= 224)
            {

                d.OpenDoor(leftDoorU, rightDoorU,1);//sends the parameter to the Door class
            }
            else
            {
                firstF.Text="Open";
                Delay.Enabled = true;//to hold the door to be opened for 3 second
                dc.insertdata("First Floor: Door Open");//inserting data
                LoadData();
                OpenUp.Enabled = false;//disabling timer to open the first floor door
                requestD.Enabled = true;//enabling the ground floor request button
            }
        }

        private void CloseUp_Tick(object sender, EventArgs e)
        {
            
            if (leftDoorU.Left <=111 && rightDoorU.Left >= 174)
            {
                d.CloseDoor(leftDoorU, rightDoorU,1);//send parameter to Door class

            }
            else
            {
                requestU.BackColor = Color.White;// change color of button
                firstF.Text = "Close";
                Delay.Enabled = false;//disabling the delay timer
                count = 0;
                dc.insertdata("First Floor: Door Close");
                LoadData();
                CloseUp.Enabled = false;
                
                if (moveDown == true)
                {
                    dc.insertdata("Lift: Moving down");
                    OpenDown.Enabled = false;

                    groundFloor.Enabled = false;
                    firstFloor.Enabled = false;
                    //requestD.Enabled = false;

                    close.Enabled = false;
                    open.Enabled = false;
                    
                    showPanel.Image = global::ElevetorSimulator.Properties.Resources.DownArrow;
                    UpInfo.Image = global::ElevetorSimulator.Properties.Resources.DownArrow;
                    DownInfo.Image = global::ElevetorSimulator.Properties.Resources.DownArrow;
                    MoveDown.Enabled = true;
                    moveDown= false;
                }

            }
        }

        private void OpenDown_Tick(object sender, EventArgs e)
        {
            count = 0;
            if (leftDoorD.Left >= 61 && rightDoorD.Left <= 224)
            {
                d.OpenDoor(leftDoorD, rightDoorD,0);


            }
            else
            {
                groundF.Text = "Open";
                Delay.Enabled = true;
                dc.insertdata("Ground Floor: Door Open");
                LoadData();

                OpenDown.Enabled = false;
                requestU.Enabled= true;


            }
        }

        private void CloseDown_Tick(object sender, EventArgs e)
        {
            


            if (leftDoorD.Left <=111 && rightDoorD.Left >= 174)
            {
                d.CloseDoor(leftDoorD, rightDoorD,0);
            }

            else
            {
                requestD.BackColor = Color.White;
                count = 0;
                groundF.Text = "Close";
                Delay.Enabled = false;
                CloseDown.Enabled = false;
                dc.insertdata("Ground Floor: Door Close");
                LoadData();
                

                if (moveUp == true)
                {
                    dc.insertdata("Lift: Moving Up");//inserting data into the database
                    //disabling all the boolean value 
                    OpenUp.Enabled = false;

                    firstFloor.Enabled = false;
                    groundFloor.Enabled = false;
    
                    close.Enabled = false;
                    open.Enabled = false;
                    showPanel.Image = global::ElevetorSimulator.Properties.Resources.UpArrow;
                    UpInfo.Image = global::ElevetorSimulator.Properties.Resources.UpArrow;
                    DownInfo.Image = global::ElevetorSimulator.Properties.Resources.UpArrow;
                    MoveUp.Enabled = true;
                    moveUp = false;
                }


            }
        }

        private void MoveUp_Tick(object sender, EventArgs e)
        {
            if (insideElevator.Top >= 109)
            {
                el.MovesUp(insideElevator);//send parameter to elevator class
            }
            else
            {
                MoveUp.Enabled = false;
                LoadData();
                b = new Button(1);//send floor number to button class
                showPanel.Image = global::ElevetorSimulator.Properties.Resources.FirstFloor;//write floor number in panel
                UpInfo.Image = global::ElevetorSimulator.Properties.Resources.FirstFloor;
                DownInfo.Image = global::ElevetorSimulator.Properties.Resources.FirstFloor;
                requestD.Enabled = true;
                groundFloor.Enabled = true;
                close.Enabled = true;
                open.Enabled = true;
                OpenUp.Enabled = true;
                CloseUp.Enabled = false;
                atFirst = true;
            }
        }

        private void MoveDown_Tick(object sender, EventArgs e)
        {
            
            if (insideElevator.Top <= 486)
            {
                el.Down(insideElevator);
            }
            else
            {
                //countt = 0;
                
                LoadData();
                b = new Button(0);
                showPanel.Image = global::ElevetorSimulator.Properties.Resources.GroundFloor;
                UpInfo.Image = global::ElevetorSimulator.Properties.Resources.GroundFloor;
                DownInfo.Image = global::ElevetorSimulator.Properties.Resources.GroundFloor;
                MoveDown.Enabled = false;
                requestU.Enabled = true;
                firstFloor.Enabled = true;
                close.Enabled = true;
                open.Enabled = true;
                OpenDown.Enabled = true;

                CloseDown.Enabled = false;
                atGround= true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DatabaseConnection.DbConnection();
            
        }
        public void LoadData()
        {
            try
            {
                Query dc = new Query();
                DataTable dt = dc.ViewLog();
                dataGridView1.DataSource = dt;
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cannot show the detail log");
            }

        }

        private void Delay_Tick(object sender, EventArgs e)
        {
            
            count++;
            //MessageBox.Show(count.ToString());

            if (count >= 150 && atFirst == true)
            {
                CloseUp.Enabled = true;
                
            }
            else if (count >= 150 && atGround == true)
            {
                CloseDown.Enabled = true;

            }
            

            



        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Query q = new Query();
            q.clear();
            LoadData();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
