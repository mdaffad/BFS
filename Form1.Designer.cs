namespace src
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.Clock = new System.Windows.Forms.Label();
            this.ContactButton = new FontAwesome.Sharp.IconButton();
            this.GraphButton = new FontAwesome.Sharp.IconButton();
            this.HomeButton = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.HMIF = new System.Windows.Forms.PictureBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Date = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HMIF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(1)))), ((int)(((byte)(31)))));
            this.panelMenu.Controls.Add(this.Date);
            this.panelMenu.Controls.Add(this.Clock);
            this.panelMenu.Controls.Add(this.ContactButton);
            this.panelMenu.Controls.Add(this.GraphButton);
            this.panelMenu.Controls.Add(this.HomeButton);
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 579);
            this.panelMenu.TabIndex = 7;
            // 
            // Clock
            // 
            this.Clock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Clock.AutoSize = true;
            this.Clock.ForeColor = System.Drawing.Color.SeaShell;
            this.Clock.Location = new System.Drawing.Point(52, 509);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(86, 23);
            this.Clock.TabIndex = 4;
            this.Clock.Text = "00:00:00";
            // 
            // ContactButton
            // 
            this.ContactButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContactButton.FlatAppearance.BorderSize = 0;
            this.ContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContactButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ContactButton.ForeColor = System.Drawing.Color.SeaShell;
            this.ContactButton.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.ContactButton.IconColor = System.Drawing.Color.SeaShell;
            this.ContactButton.IconSize = 32;
            this.ContactButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ContactButton.Location = new System.Drawing.Point(0, 230);
            this.ContactButton.Name = "ContactButton";
            this.ContactButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ContactButton.Rotation = 0D;
            this.ContactButton.Size = new System.Drawing.Size(200, 60);
            this.ContactButton.TabIndex = 3;
            this.ContactButton.Text = "Contact Us";
            this.ContactButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ContactButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ContactButton.UseVisualStyleBackColor = true;
            this.ContactButton.Click += new System.EventHandler(this.ContactButton_Click);
            // 
            // GraphButton
            // 
            this.GraphButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.GraphButton.FlatAppearance.BorderSize = 0;
            this.GraphButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GraphButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.GraphButton.ForeColor = System.Drawing.Color.SeaShell;
            this.GraphButton.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.GraphButton.IconColor = System.Drawing.Color.SeaShell;
            this.GraphButton.IconSize = 32;
            this.GraphButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GraphButton.Location = new System.Drawing.Point(0, 170);
            this.GraphButton.Name = "GraphButton";
            this.GraphButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.GraphButton.Rotation = 0D;
            this.GraphButton.Size = new System.Drawing.Size(200, 60);
            this.GraphButton.TabIndex = 2;
            this.GraphButton.Text = "Graph";
            this.GraphButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GraphButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GraphButton.UseVisualStyleBackColor = true;
            this.GraphButton.Click += new System.EventHandler(this.GraphButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.HomeButton.ForeColor = System.Drawing.Color.SeaShell;
            this.HomeButton.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.HomeButton.IconColor = System.Drawing.Color.SeaShell;
            this.HomeButton.IconSize = 32;
            this.HomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.Location = new System.Drawing.Point(0, 110);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.HomeButton.Rotation = 0D;
            this.HomeButton.Size = new System.Drawing.Size(200, 60);
            this.HomeButton.TabIndex = 1;
            this.HomeButton.Text = "Home";
            this.HomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.HMIF);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 110);
            this.panel3.TabIndex = 0;
            // 
            // HMIF
            // 
            this.HMIF.Image = ((System.Drawing.Image)(resources.GetObject("HMIF.Image")));
            this.HMIF.Location = new System.Drawing.Point(41, 27);
            this.HMIF.Name = "HMIF";
            this.HMIF.Size = new System.Drawing.Size(113, 50);
            this.HMIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HMIF.TabIndex = 0;
            this.HMIF.TabStop = false;
            this.HMIF.Click += new System.EventHandler(this.HMIF_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(10)))), ((int)(((byte)(41)))));
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panel5.Location = new System.Drawing.Point(200, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1117, 579);
            this.panel5.TabIndex = 11;
            // 
            // Date
            // 
            this.Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.Date.ForeColor = System.Drawing.Color.SeaShell;
            this.Date.Location = new System.Drawing.Point(27, 539);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(56, 17);
            this.Date.TabIndex = 5;
            this.Date.Text = "00:00:00";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 539);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 40);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(463, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "copyright all right reserved";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1317, 579);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.Name = "Form1";
            this.Text = "Corona Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HMIF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton ContactButton;
        private FontAwesome.Sharp.IconButton GraphButton;
        private FontAwesome.Sharp.IconButton HomeButton;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.PictureBox HMIF;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label Clock;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

