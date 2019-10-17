namespace ElevetorSimulator
{
    partial class ElevatorController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElevatorController));
            this.OpenUp = new System.Windows.Forms.Timer(this.components);
            this.CloseUp = new System.Windows.Forms.Timer(this.components);
            this.OpenDown = new System.Windows.Forms.Timer(this.components);
            this.CloseDown = new System.Windows.Forms.Timer(this.components);
            this.MoveUp = new System.Windows.Forms.Timer(this.components);
            this.MoveDown = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Delay = new System.Windows.Forms.Timer(this.components);
            this.firstF = new System.Windows.Forms.Label();
            this.groundF = new System.Windows.Forms.Label();
            this.open = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.groundFloor = new System.Windows.Forms.Button();
            this.firstFloor = new System.Windows.Forms.Button();
            this.requestD = new System.Windows.Forms.Button();
            this.requestU = new System.Windows.Forms.Button();
            this.rightDoorD = new System.Windows.Forms.PictureBox();
            this.leftDoorD = new System.Windows.Forms.PictureBox();
            this.rightDoorU = new System.Windows.Forms.PictureBox();
            this.leftDoorU = new System.Windows.Forms.PictureBox();
            this.insideElevator = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.show = new System.Windows.Forms.PictureBox();
            this.showPanel = new System.Windows.Forms.PictureBox();
            this.UpInfo = new System.Windows.Forms.PictureBox();
            this.DownInfo = new System.Windows.Forms.PictureBox();
            this.Clear = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightDoorD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftDoorD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightDoorU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftDoorU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insideElevator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenUp
            // 
            this.OpenUp.Interval = 5;
            this.OpenUp.Tick += new System.EventHandler(this.OpenUp_Tick);
            // 
            // CloseUp
            // 
            this.CloseUp.Interval = 5;
            this.CloseUp.Tick += new System.EventHandler(this.CloseUp_Tick);
            // 
            // OpenDown
            // 
            this.OpenDown.Interval = 5;
            this.OpenDown.Tick += new System.EventHandler(this.OpenDown_Tick);
            // 
            // CloseDown
            // 
            this.CloseDown.Interval = 5;
            this.CloseDown.Tick += new System.EventHandler(this.CloseDown_Tick);
            // 
            // MoveUp
            // 
            this.MoveUp.Interval = 5;
            this.MoveUp.Tick += new System.EventHandler(this.MoveUp_Tick);
            // 
            // MoveDown
            // 
            this.MoveDown.Interval = 5;
            this.MoveDown.Tick += new System.EventHandler(this.MoveDown_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(650, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(512, 587);
            this.dataGridView1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(845, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Detail Data Log";
            // 
            // Delay
            // 
            this.Delay.Interval = 5;
            this.Delay.Tick += new System.EventHandler(this.Delay_Tick);
            // 
            // firstF
            // 
            this.firstF.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.firstF.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstF.Location = new System.Drawing.Point(155, 72);
            this.firstF.Name = "firstF";
            this.firstF.Size = new System.Drawing.Size(39, 15);
            this.firstF.TabIndex = 0;
            this.firstF.Text = "Close";
            // 
            // groundF
            // 
            this.groundF.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groundF.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groundF.Location = new System.Drawing.Point(154, 448);
            this.groundF.Name = "groundF";
            this.groundF.Size = new System.Drawing.Size(39, 15);
            this.groundF.TabIndex = 15;
            this.groundF.Text = "Close";
            // 
            // open
            // 
            this.open.Image = ((System.Drawing.Image)(resources.GetObject("open.Image")));
            this.open.Location = new System.Drawing.Point(448, 473);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(54, 45);
            this.open.TabIndex = 9;
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // close
            // 
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(510, 473);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(54, 45);
            this.close.TabIndex = 8;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // groundFloor
            // 
            this.groundFloor.Image = ((System.Drawing.Image)(resources.GetObject("groundFloor.Image")));
            this.groundFloor.Location = new System.Drawing.Point(481, 332);
            this.groundFloor.Name = "groundFloor";
            this.groundFloor.Size = new System.Drawing.Size(57, 54);
            this.groundFloor.TabIndex = 7;
            this.groundFloor.UseVisualStyleBackColor = true;
            this.groundFloor.Click += new System.EventHandler(this.groundFloor_Click);
            // 
            // firstFloor
            // 
            this.firstFloor.Image = ((System.Drawing.Image)(resources.GetObject("firstFloor.Image")));
            this.firstFloor.Location = new System.Drawing.Point(481, 407);
            this.firstFloor.Name = "firstFloor";
            this.firstFloor.Size = new System.Drawing.Size(57, 51);
            this.firstFloor.TabIndex = 6;
            this.firstFloor.UseVisualStyleBackColor = true;
            this.firstFloor.Click += new System.EventHandler(this.firstFloor_Click);
            // 
            // requestD
            // 
            this.requestD.BackColor = System.Drawing.Color.White;
            this.requestD.Image = global::ElevetorSimulator.Properties.Resources.down;
            this.requestD.Location = new System.Drawing.Point(252, 577);
            this.requestD.Name = "requestD";
            this.requestD.Size = new System.Drawing.Size(44, 43);
            this.requestD.TabIndex = 5;
            this.requestD.UseVisualStyleBackColor = false;
            this.requestD.Click += new System.EventHandler(this.responseD_Click);
            // 
            // requestU
            // 
            this.requestU.BackColor = System.Drawing.Color.White;
            this.requestU.Image = global::ElevetorSimulator.Properties.Resources.up;
            this.requestU.Location = new System.Drawing.Point(252, 187);
            this.requestU.Name = "requestU";
            this.requestU.Size = new System.Drawing.Size(44, 45);
            this.requestU.TabIndex = 4;
            this.requestU.UseVisualStyleBackColor = false;
            this.requestU.Click += new System.EventHandler(this.requestU_Click);
            // 
            // rightDoorD
            // 
            this.rightDoorD.Image = ((System.Drawing.Image)(resources.GetObject("rightDoorD.Image")));
            this.rightDoorD.Location = new System.Drawing.Point(174, 485);
            this.rightDoorD.Name = "rightDoorD";
            this.rightDoorD.Size = new System.Drawing.Size(63, 198);
            this.rightDoorD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightDoorD.TabIndex = 3;
            this.rightDoorD.TabStop = false;
            // 
            // leftDoorD
            // 
            this.leftDoorD.Image = ((System.Drawing.Image)(resources.GetObject("leftDoorD.Image")));
            this.leftDoorD.Location = new System.Drawing.Point(111, 485);
            this.leftDoorD.Name = "leftDoorD";
            this.leftDoorD.Size = new System.Drawing.Size(63, 198);
            this.leftDoorD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftDoorD.TabIndex = 3;
            this.leftDoorD.TabStop = false;
            // 
            // rightDoorU
            // 
            this.rightDoorU.Image = ((System.Drawing.Image)(resources.GetObject("rightDoorU.Image")));
            this.rightDoorU.Location = new System.Drawing.Point(174, 108);
            this.rightDoorU.Name = "rightDoorU";
            this.rightDoorU.Size = new System.Drawing.Size(63, 198);
            this.rightDoorU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightDoorU.TabIndex = 3;
            this.rightDoorU.TabStop = false;
            // 
            // leftDoorU
            // 
            this.leftDoorU.Image = ((System.Drawing.Image)(resources.GetObject("leftDoorU.Image")));
            this.leftDoorU.Location = new System.Drawing.Point(111, 108);
            this.leftDoorU.Name = "leftDoorU";
            this.leftDoorU.Size = new System.Drawing.Size(63, 198);
            this.leftDoorU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftDoorU.TabIndex = 3;
            this.leftDoorU.TabStop = false;
            // 
            // insideElevator
            // 
            this.insideElevator.Image = ((System.Drawing.Image)(resources.GetObject("insideElevator.Image")));
            this.insideElevator.Location = new System.Drawing.Point(111, 109);
            this.insideElevator.Name = "insideElevator";
            this.insideElevator.Size = new System.Drawing.Size(126, 198);
            this.insideElevator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.insideElevator.TabIndex = 2;
            this.insideElevator.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(40, 422);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(267, 324);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 324);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // show
            // 
            this.show.Image = ((System.Drawing.Image)(resources.GetObject("show.Image")));
            this.show.Location = new System.Drawing.Point(392, 121);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(232, 524);
            this.show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.show.TabIndex = 10;
            this.show.TabStop = false;
            // 
            // showPanel
            // 
            this.showPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.showPanel.Image = global::ElevetorSimulator.Properties.Resources.FirstFloor;
            this.showPanel.Location = new System.Drawing.Point(447, 187);
            this.showPanel.Name = "showPanel";
            this.showPanel.Size = new System.Drawing.Size(117, 118);
            this.showPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showPanel.TabIndex = 16;
            this.showPanel.TabStop = false;
            // 
            // UpInfo
            // 
            this.UpInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpInfo.Image = global::ElevetorSimulator.Properties.Resources.FirstFloor;
            this.UpInfo.Location = new System.Drawing.Point(201, 72);
            this.UpInfo.Name = "UpInfo";
            this.UpInfo.Size = new System.Drawing.Size(18, 15);
            this.UpInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UpInfo.TabIndex = 17;
            this.UpInfo.TabStop = false;
            // 
            // DownInfo
            // 
            this.DownInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DownInfo.Image = global::ElevetorSimulator.Properties.Resources.FirstFloor;
            this.DownInfo.Location = new System.Drawing.Point(201, 448);
            this.DownInfo.Name = "DownInfo";
            this.DownInfo.Size = new System.Drawing.Size(18, 15);
            this.DownInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DownInfo.TabIndex = 18;
            this.DownInfo.TabStop = false;
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.Color.Black;
            this.Clear.Location = new System.Drawing.Point(669, 652);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(86, 31);
            this.Clear.TabIndex = 19;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Black;
            this.Exit.Location = new System.Drawing.Point(809, 652);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(82, 31);
            this.Exit.TabIndex = 20;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 695);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.DownInfo);
            this.Controls.Add(this.UpInfo);
            this.Controls.Add(this.showPanel);
            this.Controls.Add(this.groundF);
            this.Controls.Add(this.firstF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.open);
            this.Controls.Add(this.close);
            this.Controls.Add(this.groundFloor);
            this.Controls.Add(this.firstFloor);
            this.Controls.Add(this.requestD);
            this.Controls.Add(this.requestU);
            this.Controls.Add(this.rightDoorD);
            this.Controls.Add(this.leftDoorD);
            this.Controls.Add(this.rightDoorU);
            this.Controls.Add(this.leftDoorU);
            this.Controls.Add(this.insideElevator);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.show);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Elevator Simulator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightDoorD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftDoorD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightDoorU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftDoorU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insideElevator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox insideElevator;
        private System.Windows.Forms.PictureBox leftDoorU;
        private System.Windows.Forms.PictureBox rightDoorU;
        private System.Windows.Forms.PictureBox leftDoorD;
        private System.Windows.Forms.PictureBox rightDoorD;
        private System.Windows.Forms.Button requestU;
        private System.Windows.Forms.Button requestD;
        private System.Windows.Forms.Timer OpenUp;
        private System.Windows.Forms.Timer CloseUp;
        private System.Windows.Forms.Timer OpenDown;
        private System.Windows.Forms.Timer CloseDown;
        private System.Windows.Forms.Timer MoveUp;
        private System.Windows.Forms.Timer MoveDown;
        private System.Windows.Forms.Button firstFloor;
        private System.Windows.Forms.Button groundFloor;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.PictureBox show;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Delay;
        private System.Windows.Forms.Label firstF;
        private System.Windows.Forms.Label groundF;
        private System.Windows.Forms.PictureBox showPanel;
        private System.Windows.Forms.PictureBox UpInfo;
        private System.Windows.Forms.PictureBox DownInfo;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Exit;
    }
}

