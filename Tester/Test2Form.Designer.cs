namespace Tester
{
    partial class Test2Form
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
            this.headlineLabel = new System.Windows.Forms.Label();
            this.testHeadline = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.timeTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // headlineLabel
            // 
            this.headlineLabel.AutoSize = true;
            this.headlineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headlineLabel.Location = new System.Drawing.Point(323, 9);
            this.headlineLabel.Name = "headlineLabel";
            this.headlineLabel.Size = new System.Drawing.Size(119, 31);
            this.headlineLabel.TabIndex = 0;
            this.headlineLabel.Text = "Przykład";
            // 
            // testHeadline
            // 
            this.testHeadline.AutoSize = true;
            this.testHeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testHeadline.Location = new System.Drawing.Point(13, 13);
            this.testHeadline.Name = "testHeadline";
            this.testHeadline.Size = new System.Drawing.Size(90, 31);
            this.testHeadline.TabIndex = 1;
            this.testHeadline.Text = "Test 2";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(13, 48);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(138, 25);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "00:00:00:000";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Tester.Properties.Resources._29;
            this.pictureBox.Location = new System.Drawing.Point(145, 43);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(468, 468);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(270, 518);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(100, 20);
            this.answerTextBox.TabIndex = 4;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(376, 517);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 22);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // timeTimer
            // 
            this.timeTimer.Tick += new System.EventHandler(this.timeTimer_Tick);
            // 
            // Test2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.testHeadline);
            this.Controls.Add(this.headlineLabel);
            this.Name = "Test2Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Test2Form_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headlineLabel;
        private System.Windows.Forms.Label testHeadline;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Timer timeTimer;
    }
}