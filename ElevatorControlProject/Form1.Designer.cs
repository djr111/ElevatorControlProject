namespace ElevatorControlProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.event_box = new System.Windows.Forms.ListBox();
            this.displaylogButton = new System.Windows.Forms.Button();
            this.eventLabel = new System.Windows.Forms.Label();
            this.clearlogButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.controlpanellabel = new System.Windows.Forms.Label();
            this.firstfloorbutton = new System.Windows.Forms.Button();
            this.groundfloorbutton = new System.Windows.Forms.Button();
            this.open_doors_button = new System.Windows.Forms.Button();
            this.close_doors_button = new System.Windows.Forms.Button();
            this.stopbutton = new System.Windows.Forms.Button();
            this.timer_going_up = new System.Windows.Forms.Timer(this.components);
            this.timer_going_down = new System.Windows.Forms.Timer(this.components);
            this.timelabel = new System.Windows.Forms.Label();
            this.datelabel = new System.Windows.Forms.Label();
            this.actionlabel = new System.Windows.Forms.Label();
            this.liftgroundfloorbutton = new System.Windows.Forms.Button();
            this.liftfirstfloorbutton = new System.Windows.Forms.Button();
            this.timer_doors_open_gr = new System.Windows.Forms.Timer(this.components);
            this.timer_doors_close_gr = new System.Windows.Forms.Timer(this.components);
            this.timer_doors_open_first = new System.Windows.Forms.Timer(this.components);
            this.timer_doors_close_first = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.ground_display = new System.Windows.Forms.PictureBox();
            this.first_display = new System.Windows.Forms.PictureBox();
            this.panel_display = new System.Windows.Forms.PictureBox();
            this.groundrightdoor = new System.Windows.Forms.PictureBox();
            this.groundleftdoor = new System.Windows.Forms.PictureBox();
            this.firstrightdoor = new System.Windows.Forms.PictureBox();
            this.firstleftdoor = new System.Windows.Forms.PictureBox();
            this.Elevator_image = new System.Windows.Forms.PictureBox();
            this.liftimagefirstfloor = new System.Windows.Forms.PictureBox();
            this.liftimagegroundfloor = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground_display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundrightdoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundleftdoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstrightdoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstleftdoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Elevator_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftimagefirstfloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftimagegroundfloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // event_box
            // 
            this.event_box.ForeColor = System.Drawing.Color.Black;
            this.event_box.FormattingEnabled = true;
            this.event_box.Location = new System.Drawing.Point(998, 103);
            this.event_box.Name = "event_box";
            this.event_box.Size = new System.Drawing.Size(421, 550);
            this.event_box.TabIndex = 0;
            // 
            // displaylogButton
            // 
            this.displaylogButton.Location = new System.Drawing.Point(1435, 51);
            this.displaylogButton.Name = "displaylogButton";
            this.displaylogButton.Size = new System.Drawing.Size(85, 33);
            this.displaylogButton.TabIndex = 1;
            this.displaylogButton.Text = "Display Log";
            this.displaylogButton.UseVisualStyleBackColor = true;
            this.displaylogButton.Click += new System.EventHandler(this.displaylogButton_Click);
            // 
            // eventLabel
            // 
            this.eventLabel.AutoSize = true;
            this.eventLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eventLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eventLabel.Location = new System.Drawing.Point(1163, 28);
            this.eventLabel.Name = "eventLabel";
            this.eventLabel.Size = new System.Drawing.Size(110, 26);
            this.eventLabel.TabIndex = 2;
            this.eventLabel.Text = "Control Log";
            // 
            // clearlogButton
            // 
            this.clearlogButton.Location = new System.Drawing.Point(1435, 120);
            this.clearlogButton.Name = "clearlogButton";
            this.clearlogButton.Size = new System.Drawing.Size(85, 33);
            this.clearlogButton.TabIndex = 3;
            this.clearlogButton.Text = "Clear Log";
            this.clearlogButton.UseVisualStyleBackColor = true;
            this.clearlogButton.Click += new System.EventHandler(this.clearlogButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1435, 604);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(85, 33);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // controlpanellabel
            // 
            this.controlpanellabel.AutoSize = true;
            this.controlpanellabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.controlpanellabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.controlpanellabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlpanellabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.controlpanellabel.Location = new System.Drawing.Point(575, 168);
            this.controlpanellabel.Name = "controlpanellabel";
            this.controlpanellabel.Size = new System.Drawing.Size(206, 28);
            this.controlpanellabel.TabIndex = 5;
            this.controlpanellabel.Text = "Elevator Control Panel";
            // 
            // firstfloorbutton
            // 
            this.firstfloorbutton.BackColor = System.Drawing.Color.White;
            this.firstfloorbutton.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstfloorbutton.Location = new System.Drawing.Point(647, 325);
            this.firstfloorbutton.Name = "firstfloorbutton";
            this.firstfloorbutton.Size = new System.Drawing.Size(68, 53);
            this.firstfloorbutton.TabIndex = 6;
            this.firstfloorbutton.Text = "1";
            this.firstfloorbutton.UseVisualStyleBackColor = false;
            this.firstfloorbutton.Click += new System.EventHandler(this.firstfloorbutton_Click);
            // 
            // groundfloorbutton
            // 
            this.groundfloorbutton.BackColor = System.Drawing.Color.White;
            this.groundfloorbutton.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groundfloorbutton.Location = new System.Drawing.Point(647, 402);
            this.groundfloorbutton.Name = "groundfloorbutton";
            this.groundfloorbutton.Size = new System.Drawing.Size(68, 53);
            this.groundfloorbutton.TabIndex = 7;
            this.groundfloorbutton.Text = "G";
            this.groundfloorbutton.UseVisualStyleBackColor = false;
            this.groundfloorbutton.Click += new System.EventHandler(this.groundfloorbutton_Click);
            // 
            // open_doors_button
            // 
            this.open_doors_button.BackColor = System.Drawing.Color.White;
            this.open_doors_button.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.open_doors_button.Location = new System.Drawing.Point(627, 461);
            this.open_doors_button.Name = "open_doors_button";
            this.open_doors_button.Size = new System.Drawing.Size(49, 34);
            this.open_doors_button.TabIndex = 8;
            this.open_doors_button.Text = "< >";
            this.open_doors_button.UseVisualStyleBackColor = false;
            this.open_doors_button.Click += new System.EventHandler(this.open_doors_button_Click);
            // 
            // close_doors_button
            // 
            this.close_doors_button.BackColor = System.Drawing.Color.White;
            this.close_doors_button.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_doors_button.Location = new System.Drawing.Point(682, 461);
            this.close_doors_button.Name = "close_doors_button";
            this.close_doors_button.Size = new System.Drawing.Size(49, 34);
            this.close_doors_button.TabIndex = 9;
            this.close_doors_button.Text = "> <";
            this.close_doors_button.UseVisualStyleBackColor = false;
            this.close_doors_button.Click += new System.EventHandler(this.close_doors_button_Click);
            // 
            // stopbutton
            // 
            this.stopbutton.BackColor = System.Drawing.Color.White;
            this.stopbutton.Location = new System.Drawing.Point(647, 508);
            this.stopbutton.Name = "stopbutton";
            this.stopbutton.Size = new System.Drawing.Size(68, 47);
            this.stopbutton.TabIndex = 10;
            this.stopbutton.Text = "STOP";
            this.stopbutton.UseVisualStyleBackColor = false;
            this.stopbutton.Click += new System.EventHandler(this.stopbutton_Click);
            // 
            // timer_going_up
            // 
            this.timer_going_up.Interval = 15;
            this.timer_going_up.Tick += new System.EventHandler(this.timer_going_up_Tick);
            // 
            // timer_going_down
            // 
            this.timer_going_down.Interval = 15;
            this.timer_going_down.Tick += new System.EventHandler(this.timer_going_down_Tick);
            // 
            // timelabel
            // 
            this.timelabel.AutoSize = true;
            this.timelabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timelabel.Location = new System.Drawing.Point(1137, 71);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(52, 22);
            this.timelabel.TabIndex = 12;
            this.timelabel.Text = "Time";
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datelabel.Location = new System.Drawing.Point(1005, 71);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(49, 22);
            this.datelabel.TabIndex = 13;
            this.datelabel.Text = "Date";
            // 
            // actionlabel
            // 
            this.actionlabel.AutoSize = true;
            this.actionlabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.actionlabel.Location = new System.Drawing.Point(1282, 71);
            this.actionlabel.Name = "actionlabel";
            this.actionlabel.Size = new System.Drawing.Size(63, 22);
            this.actionlabel.TabIndex = 14;
            this.actionlabel.Text = "Action";
            // 
            // liftgroundfloorbutton
            // 
            this.liftgroundfloorbutton.BackColor = System.Drawing.Color.White;
            this.liftgroundfloorbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.liftgroundfloorbutton.Location = new System.Drawing.Point(245, 180);
            this.liftgroundfloorbutton.Name = "liftgroundfloorbutton";
            this.liftgroundfloorbutton.Size = new System.Drawing.Size(35, 33);
            this.liftgroundfloorbutton.TabIndex = 17;
            this.liftgroundfloorbutton.Text = "1";
            this.liftgroundfloorbutton.UseVisualStyleBackColor = false;
            this.liftgroundfloorbutton.Click += new System.EventHandler(this.liftgroundfloorbutton_Click);
            // 
            // liftfirstfloorbutton
            // 
            this.liftfirstfloorbutton.BackColor = System.Drawing.Color.White;
            this.liftfirstfloorbutton.Location = new System.Drawing.Point(245, 515);
            this.liftfirstfloorbutton.Name = "liftfirstfloorbutton";
            this.liftfirstfloorbutton.Size = new System.Drawing.Size(35, 33);
            this.liftfirstfloorbutton.TabIndex = 18;
            this.liftfirstfloorbutton.Text = "G";
            this.liftfirstfloorbutton.UseVisualStyleBackColor = false;
            this.liftfirstfloorbutton.Click += new System.EventHandler(this.liftfirstfloorbutton_Click);
            // 
            // timer_doors_open_gr
            // 
            this.timer_doors_open_gr.Interval = 15;
            this.timer_doors_open_gr.Tick += new System.EventHandler(this.timer_doors_open_gr_Tick);
            // 
            // timer_doors_close_gr
            // 
            this.timer_doors_close_gr.Interval = 15;
            this.timer_doors_close_gr.Tick += new System.EventHandler(this.timer_doors_close_gr_Tick);
            // 
            // timer_doors_open_first
            // 
            this.timer_doors_open_first.Interval = 15;
            this.timer_doors_open_first.Tick += new System.EventHandler(this.timer_doors_open_first_Tick);
            // 
            // timer_doors_close_first
            // 
            this.timer_doors_close_first.Interval = 15;
            this.timer_doors_close_first.Tick += new System.EventHandler(this.timer_doors_close_first_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // ground_display
            // 
            this.ground_display.BackColor = System.Drawing.Color.Black;
            this.ground_display.Location = new System.Drawing.Point(136, 356);
            this.ground_display.Name = "ground_display";
            this.ground_display.Size = new System.Drawing.Size(22, 22);
            this.ground_display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground_display.TabIndex = 27;
            this.ground_display.TabStop = false;
            // 
            // first_display
            // 
            this.first_display.BackColor = System.Drawing.Color.Black;
            this.first_display.Location = new System.Drawing.Point(137, 20);
            this.first_display.Name = "first_display";
            this.first_display.Size = new System.Drawing.Size(21, 22);
            this.first_display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.first_display.TabIndex = 25;
            this.first_display.TabStop = false;
            // 
            // panel_display
            // 
            this.panel_display.BackColor = System.Drawing.Color.Black;
            this.panel_display.Location = new System.Drawing.Point(627, 222);
            this.panel_display.Name = "panel_display";
            this.panel_display.Size = new System.Drawing.Size(104, 85);
            this.panel_display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.panel_display.TabIndex = 24;
            this.panel_display.TabStop = false;
            // 
            // groundrightdoor
            // 
            this.groundrightdoor.Image = ((System.Drawing.Image)(resources.GetObject("groundrightdoor.Image")));
            this.groundrightdoor.Location = new System.Drawing.Point(146, 379);
            this.groundrightdoor.Name = "groundrightdoor";
            this.groundrightdoor.Size = new System.Drawing.Size(79, 274);
            this.groundrightdoor.TabIndex = 22;
            this.groundrightdoor.TabStop = false;
            // 
            // groundleftdoor
            // 
            this.groundleftdoor.Image = ((System.Drawing.Image)(resources.GetObject("groundleftdoor.Image")));
            this.groundleftdoor.Location = new System.Drawing.Point(70, 381);
            this.groundleftdoor.Name = "groundleftdoor";
            this.groundleftdoor.Size = new System.Drawing.Size(79, 274);
            this.groundleftdoor.TabIndex = 21;
            this.groundleftdoor.TabStop = false;
            // 
            // firstrightdoor
            // 
            this.firstrightdoor.Image = ((System.Drawing.Image)(resources.GetObject("firstrightdoor.Image")));
            this.firstrightdoor.Location = new System.Drawing.Point(146, 48);
            this.firstrightdoor.Name = "firstrightdoor";
            this.firstrightdoor.Size = new System.Drawing.Size(79, 274);
            this.firstrightdoor.TabIndex = 20;
            this.firstrightdoor.TabStop = false;
            // 
            // firstleftdoor
            // 
            this.firstleftdoor.Image = ((System.Drawing.Image)(resources.GetObject("firstleftdoor.Image")));
            this.firstleftdoor.Location = new System.Drawing.Point(70, 48);
            this.firstleftdoor.Name = "firstleftdoor";
            this.firstleftdoor.Size = new System.Drawing.Size(79, 274);
            this.firstleftdoor.TabIndex = 19;
            this.firstleftdoor.TabStop = false;
            // 
            // Elevator_image
            // 
            this.Elevator_image.BackColor = System.Drawing.Color.Transparent;
            this.Elevator_image.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Elevator_image.ErrorImage")));
            this.Elevator_image.Image = ((System.Drawing.Image)(resources.GetObject("Elevator_image.Image")));
            this.Elevator_image.Location = new System.Drawing.Point(57, 48);
            this.Elevator_image.Name = "Elevator_image";
            this.Elevator_image.Size = new System.Drawing.Size(168, 273);
            this.Elevator_image.TabIndex = 19;
            this.Elevator_image.TabStop = false;
            // 
            // liftimagefirstfloor
            // 
            this.liftimagefirstfloor.BackColor = System.Drawing.Color.Transparent;
            this.liftimagefirstfloor.Image = ((System.Drawing.Image)(resources.GetObject("liftimagefirstfloor.Image")));
            this.liftimagefirstfloor.Location = new System.Drawing.Point(0, 9);
            this.liftimagefirstfloor.Name = "liftimagefirstfloor";
            this.liftimagefirstfloor.Size = new System.Drawing.Size(303, 347);
            this.liftimagefirstfloor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.liftimagefirstfloor.TabIndex = 11;
            this.liftimagefirstfloor.TabStop = false;
            // 
            // liftimagegroundfloor
            // 
            this.liftimagegroundfloor.BackColor = System.Drawing.Color.Transparent;
            this.liftimagegroundfloor.Image = ((System.Drawing.Image)(resources.GetObject("liftimagegroundfloor.Image")));
            this.liftimagegroundfloor.Location = new System.Drawing.Point(0, 345);
            this.liftimagegroundfloor.Name = "liftimagegroundfloor";
            this.liftimagegroundfloor.Size = new System.Drawing.Size(303, 347);
            this.liftimagegroundfloor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.liftimagegroundfloor.TabIndex = 16;
            this.liftimagegroundfloor.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(594, 208);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(171, 393);
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1542, 692);
            this.Controls.Add(this.ground_display);
            this.Controls.Add(this.first_display);
            this.Controls.Add(this.panel_display);
            this.Controls.Add(this.groundrightdoor);
            this.Controls.Add(this.groundleftdoor);
            this.Controls.Add(this.firstrightdoor);
            this.Controls.Add(this.firstleftdoor);
            this.Controls.Add(this.liftfirstfloorbutton);
            this.Controls.Add(this.liftgroundfloorbutton);
            this.Controls.Add(this.actionlabel);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.stopbutton);
            this.Controls.Add(this.close_doors_button);
            this.Controls.Add(this.open_doors_button);
            this.Controls.Add(this.groundfloorbutton);
            this.Controls.Add(this.firstfloorbutton);
            this.Controls.Add(this.controlpanellabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearlogButton);
            this.Controls.Add(this.eventLabel);
            this.Controls.Add(this.displaylogButton);
            this.Controls.Add(this.event_box);
            this.Controls.Add(this.Elevator_image);
            this.Controls.Add(this.liftimagefirstfloor);
            this.Controls.Add(this.liftimagegroundfloor);
            this.Controls.Add(this.pictureBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground_display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundrightdoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundleftdoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstrightdoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstleftdoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Elevator_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftimagefirstfloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftimagegroundfloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.ListBox event_box;
        private System.Windows.Forms.Label eventLabel;
        private System.Windows.Forms.Button displaylogButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearlogButton;
        private System.Windows.Forms.Button open_doors_button;
        private System.Windows.Forms.Button groundfloorbutton;
        private System.Windows.Forms.Button firstfloorbutton;
        private System.Windows.Forms.Label controlpanellabel;
        private System.Windows.Forms.Button stopbutton;
        private System.Windows.Forms.Button close_doors_button;
        private System.Windows.Forms.PictureBox Elevator_image;
        private System.Windows.Forms.Timer timer_going_up;
        private System.Windows.Forms.Timer timer_going_down;
        private System.Windows.Forms.PictureBox liftimagefirstfloor;
        private System.Windows.Forms.Label actionlabel;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.PictureBox liftimagegroundfloor;
        private System.Windows.Forms.Button liftfirstfloorbutton;
        private System.Windows.Forms.Button liftgroundfloorbutton;
        private System.Windows.Forms.PictureBox groundrightdoor;
        private System.Windows.Forms.PictureBox groundleftdoor;
        private System.Windows.Forms.PictureBox firstrightdoor;
        private System.Windows.Forms.PictureBox firstleftdoor;
        private System.Windows.Forms.Timer timer_doors_open_gr;
        private System.Windows.Forms.Timer timer_doors_close_gr;
        private System.Windows.Forms.Timer timer_doors_open_first;
        private System.Windows.Forms.PictureBox panel_display;
        private System.Windows.Forms.Timer timer_doors_close_first;
        private System.Windows.Forms.PictureBox first_display;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox ground_display;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

