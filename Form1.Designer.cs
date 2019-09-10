namespace PracP5
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
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.buttonGo = new System.Windows.Forms.Button();
            this.pictureBoxTable = new System.Windows.Forms.PictureBox();
            this.labelCollisions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTable)).BeginInit();
            this.SuspendLayout();
            // 
            // timerTime
            // 
            this.timerTime.Interval = 50;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // buttonGo
            // 
            this.buttonGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonGo.Location = new System.Drawing.Point(11, 180);
            this.buttonGo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(56, 24);
            this.buttonGo.TabIndex = 0;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // pictureBoxTable
            // 
            this.pictureBoxTable.BackColor = System.Drawing.Color.Green;
            this.pictureBoxTable.Location = new System.Drawing.Point(33, 41);
            this.pictureBoxTable.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxTable.Name = "pictureBoxTable";
            this.pictureBoxTable.Size = new System.Drawing.Size(233, 117);
            this.pictureBoxTable.TabIndex = 1;
            this.pictureBoxTable.TabStop = false;
            // 
            // labelCollisions
            // 
            this.labelCollisions.AutoSize = true;
            this.labelCollisions.Location = new System.Drawing.Point(93, 325);
            this.labelCollisions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCollisions.Name = "labelCollisions";
            this.labelCollisions.Size = new System.Drawing.Size(0, 13);
            this.labelCollisions.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(303, 215);
            this.Controls.Add(this.labelCollisions);
            this.Controls.Add(this.pictureBoxTable);
            this.Controls.Add(this.buttonGo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "Form1";
            this.Text = "Practical P5 Exercise 1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.PictureBox pictureBoxTable;
        private System.Windows.Forms.Label labelCollisions;
    }
}

