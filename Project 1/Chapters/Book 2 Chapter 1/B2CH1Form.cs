using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class B2CH1Form : Form
    {
        public B2CH1Form()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            { UniversalCode.SetCursorEventsOnControls(control, Cursors.Hand); }
        }

        class Elevator
        {
            private int floorNumber;
            private int numberOfPassengers;
            public int FloorNumber { get { return floorNumber; } set { floorNumber = value; } }
            public int NumberOfPassengers { get { return numberOfPassengers; } set { numberOfPassengers = value; } }
            public object DirectionMoving { get; internal set; }
        }

        Elevator elevator = new Elevator();

        Random floor1Amount;
        Random floor2Amount;
        Random floor3Amount;
        Random floor4Amount;
        Random floor5Amount;
        Random floor6Amount;
        Random floor7Amount;
        Random floor8Amount;

        int floor1People;
        int floor2People;
        int floor3People;
        int floor4People;
        int floor5People;
        int floor6People;
        int floor7People;
        int floor8People;

        private void GetWaitingPeople()
        {
            // Get amount of people on each floor, and display in Labels
            floor1People = floor1Amount.Next(1, 5);
            floor2People = floor2Amount.Next(1, 5);
            floor3People = floor3Amount.Next(1, 5);
            floor4People = floor4Amount.Next(1, 5);
            floor5People = floor5Amount.Next(1, 5);
            floor6People = floor6Amount.Next(1, 5);
            floor7People = floor7Amount.Next(1, 5);
            floor8People = floor8Amount.Next(1, 5);

            floor1.Text = floor1People.ToString();
            floor2.Text = floor2People.ToString();
            floor3.Text = floor3People.ToString();
            floor4.Text = floor4People.ToString();
            floor5.Text = floor5People.ToString();
            floor6.Text = floor6People.ToString();
            floor7.Text = floor7People.ToString();
            floor8.Text = floor8People.ToString();
        }

        private void ElevatorMover()
        {
            // Used to move the elevator between floors, and update the floor number Label
            if (elevator.FloorNumber == 1) { floorNumberLBL.Text = "1"; elevatorPNL.Location = new Point(60, 286); }
            else if (elevator.FloorNumber == 2) { floorNumberLBL.Text = "2"; elevatorPNL.Location = new Point(60, 250); }
            else if (elevator.FloorNumber == 3) { floorNumberLBL.Text = "3"; elevatorPNL.Location = new Point(60, 214); }
            else if (elevator.FloorNumber == 4) { floorNumberLBL.Text = "4"; elevatorPNL.Location = new Point(60, 178); }
            else if (elevator.FloorNumber == 5) { floorNumberLBL.Text = "5"; elevatorPNL.Location = new Point(60, 143); }
            else if (elevator.FloorNumber == 6) { floorNumberLBL.Text = "6"; elevatorPNL.Location = new Point(60, 106); }
            else if (elevator.FloorNumber == 7) { floorNumberLBL.Text = "7"; elevatorPNL.Location = new Point(60, 70); }
            else if (elevator.FloorNumber == 8) { floorNumberLBL.Text = "8"; elevatorPNL.Location = new Point(60, 34); }
        }

        private void PeopleMover()
        {
            // Add the number of people on the floor to the elevator amount, and set the amount on the floor to 0
            if (elevator.FloorNumber == 1) { elevator.NumberOfPassengers += floor1People; floor1People = 0; floor1.Text = "0"; }
            else if (elevator.FloorNumber == 2) { elevator.NumberOfPassengers += floor2People; floor2People = 0; floor2.Text = "0"; }
            else if (elevator.FloorNumber == 3) { elevator.NumberOfPassengers += floor3People; floor3People = 0; floor3.Text = "0"; }
            else if (elevator.FloorNumber == 4) { elevator.NumberOfPassengers += floor4People; floor4People = 0; floor4.Text = "0"; }
            else if (elevator.FloorNumber == 5) { elevator.NumberOfPassengers += floor5People; floor5People = 0; floor5.Text = "0"; }
            else if (elevator.FloorNumber == 6) { elevator.NumberOfPassengers += floor6People; floor6People = 0; floor6.Text = "0"; }
            else if (elevator.FloorNumber == 7) { elevator.NumberOfPassengers += floor7People; floor7People = 0; floor7.Text = "0"; }
            else if (elevator.FloorNumber == 8) { elevator.NumberOfPassengers += floor8People; floor8People = 0; floor8.Text = "0"; }
        }

        private void CleanStart()
        {
            elevator.NumberOfPassengers = 0;
            elevatorCapacityLBL.Text = "0";
            elevator.FloorNumber = 1;
        }

        private void elevatorTimer_Tick(object sender, EventArgs e)
        {
            /* Elevator moves up a floor each tick until it gets to the top floor,
               where it pauses for a few seconds, then starts going down, until it hits
               the bottom floor, pauses for a few seconds, and resets. Rinse and repeat */
            if (elevator.FloorNumber == 8) { TimerStop(); elevator.DirectionMoving = "down"; }

            if (elevator.DirectionMoving == "up")
            {
                PeopleMover();
                elevator.FloorNumber++;
                ElevatorMover();
                elevatorCapacityLBL.Text = elevator.NumberOfPassengers.ToString();
            }
            else if (elevator.DirectionMoving == "down")
            {
                PeopleMover();
                elevator.FloorNumber--;
                ElevatorMover();
                elevatorCapacityLBL.Text = elevator.NumberOfPassengers.ToString();

                if (elevator.FloorNumber == 1)
                {
                    floorNumberLBL.Refresh();
                    TimerPause();
                    elevatorTimer.Stop();
                    B2CH1Form_Load(sender, e);
                }
            }
            if (elevator.FloorNumber == 1) { elevator.DirectionMoving = "up"; }
        }

        private void TimerStop()
        {
            floor8.Refresh();
            elevatorTimer.Stop();
            TimerPause();
            elevatorTimer.Start();
        }

        private void TimerPause()
        {
            for (int i = 0; i < 500000000; i++) { }
        }

        private void B2CH1Form_Load(object sender, EventArgs e)
        {
            /* Set elevator to be at bottom floor going up, get random
               amount of people for each floor, and start elevator */
            CleanStart();

            elevator.FloorNumber = 1;
            elevator.DirectionMoving = "up";

            int seed = (int)DateTime.Now.Ticks;
            floor1Amount = new Random(seed);
            floor2Amount = new Random(seed + 1);
            floor3Amount = new Random(seed + 2);
            floor4Amount = new Random(seed + 3);
            floor5Amount = new Random(seed + 4);
            floor6Amount = new Random(seed + 5);
            floor7Amount = new Random(seed + 6);
            floor8Amount = new Random(seed + 7);

            GetWaitingPeople();

            elevatorTimer.Start();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { this.Close(); }

        private void classVariablesToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B2CH1_Class&Variables.png"); }

        private void methodsToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B2CH1_Methods.png"); }

        private void methods2ToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B2CH1_Methods2.png"); }

        private void timerTickTimerMethodsToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B2CH1_TimerTick&Methods.png"); }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B2CH1_Load.png"); }
    }
}
