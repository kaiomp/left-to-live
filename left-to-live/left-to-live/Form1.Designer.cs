namespace left_to_live
{
    partial class App
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
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.bornLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.weeksLived = new System.Windows.Forms.Label();
            this.leftToLive = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // birthDate
            // 
            this.birthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDate.Location = new System.Drawing.Point(51, 48);
            this.birthDate.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(139, 26);
            this.birthDate.TabIndex = 0;
            this.birthDate.Value = new System.DateTime(2023, 6, 13, 23, 8, 4, 0);
            this.birthDate.ValueChanged += new System.EventHandler(this.birthDate_ValueChanged);
            // 
            // bornLabel
            // 
            this.bornLabel.AutoSize = true;
            this.bornLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bornLabel.Location = new System.Drawing.Point(47, 25);
            this.bornLabel.Name = "bornLabel";
            this.bornLabel.Size = new System.Drawing.Size(47, 20);
            this.bornLabel.TabIndex = 1;
            this.bornLabel.Text = "Birth";
            this.bornLabel.Click += new System.EventHandler(this.bornLabel_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 86400000;
            // 
            // weeksLived
            // 
            this.weeksLived.AutoSize = true;
            this.weeksLived.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeksLived.Location = new System.Drawing.Point(443, 317);
            this.weeksLived.Name = "weeksLived";
            this.weeksLived.Size = new System.Drawing.Size(0, 31);
            this.weeksLived.TabIndex = 2;
            this.weeksLived.Click += new System.EventHandler(this.weeksLived_Click_1);
            // 
            // leftToLive
            // 
            this.leftToLive.AutoSize = true;
            this.leftToLive.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftToLive.Location = new System.Drawing.Point(94, 317);
            this.leftToLive.Name = "leftToLive";
            this.leftToLive.Size = new System.Drawing.Size(0, 31);
            this.leftToLive.TabIndex = 3;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.leftToLive);
            this.Controls.Add(this.weeksLived);
            this.Controls.Add(this.bornLabel);
            this.Controls.Add(this.birthDate);
            this.Name = "App";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.App_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker birthDate;
        private System.Windows.Forms.Label bornLabel;
        private System.Windows.Forms.Timer timer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label weeksLived;
        private System.Windows.Forms.Label leftToLive;
    }
}
