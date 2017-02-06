namespace Tester
{
    partial class Test3Form
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
            this.timeTimer = new System.Windows.Forms.Timer(this.components);
            this.testHeadline = new System.Windows.Forms.Label();
            this.headlineLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.exerciseTimer = new System.Windows.Forms.Timer(this.components);
            this.actionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timeTimer
            // 
            this.timeTimer.Tick += new System.EventHandler(this.timeTimer_Tick);
            // 
            // testHeadline
            // 
            this.testHeadline.AutoSize = true;
            this.testHeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testHeadline.Location = new System.Drawing.Point(13, 13);
            this.testHeadline.Name = "testHeadline";
            this.testHeadline.Size = new System.Drawing.Size(90, 31);
            this.testHeadline.TabIndex = 0;
            this.testHeadline.Text = "Test 3";
            // 
            // headlineLabel
            // 
            this.headlineLabel.AutoSize = true;
            this.headlineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headlineLabel.Location = new System.Drawing.Point(333, 13);
            this.headlineLabel.Name = "headlineLabel";
            this.headlineLabel.Size = new System.Drawing.Size(119, 31);
            this.headlineLabel.TabIndex = 1;
            this.headlineLabel.Text = "Przykład";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(19, 48);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(138, 25);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "00:00:00:000";
            // 
            // exerciseTimer
            // 
            this.exerciseTimer.Interval = 50;
            this.exerciseTimer.Tick += new System.EventHandler(this.exerciseTimer_Tick);
            // 
            // actionButton
            // 
            this.actionButton.Cursor = System.Windows.Forms.Cursors.Cross;
            this.actionButton.Location = new System.Drawing.Point(400, 200);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(70, 70);
            this.actionButton.TabIndex = 3;
            this.actionButton.Text = "KLIKNIJ!";
            this.actionButton.UseVisualStyleBackColor = true;
            this.actionButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // Test3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.actionButton);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.headlineLabel);
            this.Controls.Add(this.testHeadline);
            this.Name = "Test3Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Test3Form_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timeTimer;
        private System.Windows.Forms.Label testHeadline;
        private System.Windows.Forms.Label headlineLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer exerciseTimer;
        private System.Windows.Forms.Button actionButton;
    }
}