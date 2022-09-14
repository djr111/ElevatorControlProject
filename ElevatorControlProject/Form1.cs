using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ElevatorControlProject
{
    public partial class Form1 : Form
    {
        // used variables

        int y_up = 50;
        int y_down = 380;
        int x_left = 10;
        int x_right = 340;
        int x_left_cl = 68;
        int x_right_cl = 109;

        bool go_up = false;
        bool go_down = false;

        bool arrived_ground = false;
        bool arrived_first = false;

        // Database variable
        public DataSet ds = new DataSet();
        private bool filled;
        public Form1()
        {
            InitializeComponent();
        }

        //   timers for lift
        private void timer_going_down_Tick(object sender, EventArgs e)
        {
            if (Elevator_image.Top <= y_down)
            {
                Elevator_image.Top += 1;
            }
            else
            {
                timer_going_down.Enabled = false;
                liftgroundfloorbutton.BackColor = Color.White;
                groundfloorbutton.BackColor = Color.White;
                stopbutton.BackColor = Color.White;
                doors_open_ground();
                arrived_ground = true;
                close_doors_button.Enabled = true;
                open_doors_button.Enabled = true;
                groundfloorbutton.Enabled = true;
                firstfloorbutton.Enabled = true;

                panel_display.Image = global::ElevatorControlProject.Properties.Resources.letterG;
                ground_display.Image = global::ElevatorControlProject.Properties.Resources.letterG;
                first_display.Image = global::ElevatorControlProject.Properties.Resources.letterG;
            }
        }

        private void timer_going_up_Tick(object sender, EventArgs e)
        {

            if (Elevator_image.Top >= y_up)
            {
                Elevator_image.Top -= 1;
            }
            else
            {
                timer_going_up.Enabled = false;
                firstfloorbutton.BackColor = Color.White;
                liftfirstfloorbutton.BackColor = Color.White;
                stopbutton.BackColor = Color.White;
                doors_open_first();
                arrived_first = true;
                close_doors_button.Enabled = true;
                open_doors_button.Enabled = true;
                groundfloorbutton.Enabled = true;
                firstfloorbutton.Enabled = true;

                panel_display.Image = global::ElevatorControlProject.Properties.Resources.number1;
                ground_display.Image = global::ElevatorControlProject.Properties.Resources.number1;
                first_display.Image = global::ElevatorControlProject.Properties.Resources.number1;
            }

        }

        // timers for doors

        private void timer_doors_open_gr_Tick(object sender, EventArgs e)
        {

            if (groundleftdoor.Left >= x_left && groundrightdoor.Left <= x_right)
            {
                groundleftdoor.Left -= 1;
                groundrightdoor.Left += 1;
            }
            else
            {
                timer_doors_open_gr.Enabled = false;
            }
        }
        private void timer_doors_close_gr_Tick(object sender, EventArgs e)
        {

            if (groundleftdoor.Left <= x_left_cl && groundrightdoor.Left >= x_right_cl)
            {
                groundleftdoor.Left += 1;
                groundrightdoor.Left -= 1;
            }
            else
            {
                timer_doors_close_gr.Enabled = false;

                if (go_up == true)
                {
                    timer_going_up.Enabled = true;
                    go_up = false;

                    panel_display.Image = global::ElevatorControlProject.Properties.Resources.arrowUP;
                    ground_display.Image = global::ElevatorControlProject.Properties.Resources.arrowUP;
                    first_display.Image = global::ElevatorControlProject.Properties.Resources.arrowUP;
                }
            }
        }
        private void timer_doors_open_first_Tick(object sender, EventArgs e)
        {
            if (firstleftdoor.Left >= x_left && firstrightdoor.Left <= x_right)
            {
                firstleftdoor.Left -= 1;
                firstrightdoor.Left += 1;
            }
            else
            {
                timer_doors_open_gr.Enabled = false;
            }
        }
        private void timer_doors_close_first_Tick(object sender, EventArgs e)
        {
            if (firstleftdoor.Left <= x_left_cl && firstrightdoor.Left >= x_right_cl)
            {
                firstleftdoor.Left += 1;
                firstrightdoor.Left -= 1;
            }
            else
            {
                timer_doors_close_first.Enabled = false;
                if (go_down == true)
                {
                    timer_going_down.Enabled = true;
                    go_down = false;

                    panel_display.Image = global::ElevatorControlProject.Properties.Resources.arrowDOWN;
                    ground_display.Image = global::ElevatorControlProject.Properties.Resources.arrowDOWN;
                    first_display.Image = global::ElevatorControlProject.Properties.Resources.arrowDOWN;
                }
            }
        }
        private void doors_close_ground()
        {
            insertdata("Closing doors - ground floor");
            timer_doors_close_gr.Enabled = true;
            timer_doors_open_gr.Enabled = false;
            
        }
        private void doors_open_ground()
        {
            insertdata("Opening doors - ground floor");
            timer_doors_close_gr.Enabled = false;
            timer_doors_open_gr.Enabled = true;
            
        }
        private void doors_close_first()
        {
            insertdata("Closing doors - first floor");
            timer_doors_close_first.Enabled = true;
            timer_doors_open_first.Enabled = false;
            
        }
        private void doors_open_first()
        {
            insertdata("Opening doors - first floor");
            timer_doors_close_first.Enabled = false;
            timer_doors_open_first.Enabled = true;
            
        }
        private void going_up()
        {
            go_up = true;
            doors_close_ground();
            arrived_ground = false;
            insertdata("Lift moving Up");

            close_doors_button.Enabled = false;
            open_doors_button.Enabled = false;
            groundfloorbutton.Enabled = false;
            firstfloorbutton.Enabled = false;

        }
        private void going_down()
        {
            go_down = true;
            doors_close_first();
            arrived_first = false;
            insertdata("Lift moving Down");

            close_doors_button.Enabled = false;
            open_doors_button.Enabled = false;
            groundfloorbutton.Enabled = false;
            firstfloorbutton.Enabled = false;
        }
        // control panel buttons
        private void firstfloorbutton_Click(object sender, EventArgs e)
        {
            firstfloorbutton.BackColor = Color.Blue;
            liftfirstfloorbutton.BackColor = Color.Blue;
            going_up();
        }
        private void groundfloorbutton_Click(object sender, EventArgs e)
        {
            groundfloorbutton.BackColor = Color.Blue;
            liftgroundfloorbutton.BackColor = Color.Blue;
            going_down();
        }
        private void open_doors_button_Click(object sender, EventArgs e)
        {
            if (arrived_ground == true)
            {
                doors_open_ground();
            }
            else if (arrived_first == true)
            {
                doors_open_first();
            }
        }
        private void close_doors_button_Click(object sender, EventArgs e)
        {
            if (arrived_ground == true)
            {
                doors_close_ground();
            }
            else if (arrived_first == true)
            {
                doors_close_first();
            }
        }
        private void stopbutton_Click(object sender, EventArgs e)
        {
            stopbutton.BackColor = Color.Red;
            insertdata("Lift stopped by emergency!");
            timer_going_down.Enabled = false;
            timer_going_up.Enabled = false;
            timer_doors_open_first.Enabled = true;
            timer_doors_open_gr.Enabled = true;
            panel_display.Image = global::ElevatorControlProject.Properties.Resources.alarm;
            ground_display.Image = global::ElevatorControlProject.Properties.Resources.alarm;
            first_display.Image = global::ElevatorControlProject.Properties.Resources.alarm;
        }
        //  floor elevator buttons
        private void liftgroundfloorbutton_Click(object sender, EventArgs e)
        {
            liftgroundfloorbutton.BackColor = Color.Blue;
            groundfloorbutton.BackColor = Color.Blue;
            going_down();
        }
        private void liftfirstfloorbutton_Click(object sender, EventArgs e)
        {
            liftfirstfloorbutton.BackColor = Color.Blue;
            firstfloorbutton.BackColor = Color.Blue;
            going_up();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        //*
        // Database coding part
        //*
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            {
                try
                {

                    string dbconnection = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ElevatorDB.accdb";
                    string dbcommand = "Select * from ElevatorDB;";
                    OleDbConnection conn = new OleDbConnection(dbconnection);
                    OleDbCommand comm = new OleDbCommand(dbcommand, conn);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(dbcommand, conn);

                    conn.Open();
                    while (filled == false)
                    {
                        adapter.Fill(ds);
                        filled = true;
                    }
                    conn.Close();
                }
                catch
                {
                    MessageBox.Show("Can not connect to DatabBase ! ");
                }
                event_box.Invoke((MethodInvoker)(() => event_box.Items.Clear()));
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    event_box.Invoke((MethodInvoker)(() => event_box.Items.Add(row["Date"] + "\t\t" + row["Time"] + "\t\t\t" + row["Action"])));
                }
            }
        }

        private void insertdata(string action)
        {
            string dbconnection = "Provider = Microsoft.ACE.OLEDB.12.0;"+@" Data Source = ElevatorDB.accdb;";
            string dbcommand = "insert into [ElevatorDB] ([Date],[Time],[Action]) values (@date, @time, @action)";
            string date = DateTime.Now.ToShortDateString();
            string time = DateTime.Now.ToLongTimeString();

            event_box.Items.Add(date + "\t\t" + time + "\t\t" + action);

            OleDbConnection conn_db = new OleDbConnection(dbconnection);
            OleDbCommand comm_insert = new OleDbCommand(dbcommand, conn_db);
            OleDbDataAdapter adapter_insert = new OleDbDataAdapter(comm_insert);
            comm_insert.Parameters.AddWithValue("@date", date);
            comm_insert.Parameters.AddWithValue("@time", time);
            comm_insert.Parameters.AddWithValue("@action", action);

            conn_db.Open();
            comm_insert.ExecuteNonQuery();
            conn_db.Close();

        }
        private void clearlogButton_Click(object sender, EventArgs e)
        {
            event_box.Items.Clear();
        }
        
        
        private void displaylogButton_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }
    }
}

