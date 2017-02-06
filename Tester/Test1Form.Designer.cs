namespace Tester
{
    partial class Test1Form
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
            this.playSoundButtonTest = new System.Windows.Forms.Button();
            this.answerComboBox = new System.Windows.Forms.ComboBox();
            this.okButton = new System.Windows.Forms.Button();
            this.testHeadline = new System.Windows.Forms.Label();
            this.timeTimer = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headlineLabel
            // 
            this.headlineLabel.AutoSize = true;
            this.headlineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headlineLabel.Location = new System.Drawing.Point(324, 9);
            this.headlineLabel.Name = "headlineLabel";
            this.headlineLabel.Size = new System.Drawing.Size(119, 31);
            this.headlineLabel.TabIndex = 0;
            this.headlineLabel.Text = "Przykład";
            // 
            // playSoundButtonTest
            // 
            this.playSoundButtonTest.Location = new System.Drawing.Point(330, 152);
            this.playSoundButtonTest.Name = "playSoundButtonTest";
            this.playSoundButtonTest.Size = new System.Drawing.Size(100, 100);
            this.playSoundButtonTest.TabIndex = 1;
            this.playSoundButtonTest.Text = "Graj dźwięk";
            this.playSoundButtonTest.UseVisualStyleBackColor = true;
            this.playSoundButtonTest.Click += new System.EventHandler(this.playSoundButtonTest_Click);
            // 
            // answerComboBox
            // 
            this.answerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.answerComboBox.FormattingEnabled = true;
            this.answerComboBox.Items.AddRange(new object[] {
            "krowa",
            "lew",
            "wilk",
            "świerszcz",
            "koza",
            "koń"});
            this.answerComboBox.Location = new System.Drawing.Point(330, 258);
            this.answerComboBox.Name = "answerComboBox";
            this.answerComboBox.Size = new System.Drawing.Size(100, 21);
            this.answerComboBox.TabIndex = 2;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(330, 285);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // testHeadline
            // 
            this.testHeadline.AutoSize = true;
            this.testHeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testHeadline.Location = new System.Drawing.Point(13, 9);
            this.testHeadline.Name = "testHeadline";
            this.testHeadline.Size = new System.Drawing.Size(90, 31);
            this.testHeadline.TabIndex = 4;
            this.testHeadline.Text = "Test 1";
            // 
            // timeTimer
            // 
            this.timeTimer.Tick += new System.EventHandler(this.timeTimer_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(19, 44);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(138, 25);
            this.timeLabel.TabIndex = 5;
            this.timeLabel.Text = "00:00:00:000";
            // 
            // Test1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.testHeadline);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.answerComboBox);
            this.Controls.Add(this.playSoundButtonTest);
            this.Controls.Add(this.headlineLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Test1Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Test1Form_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headlineLabel;
        private System.Windows.Forms.Button playSoundButtonTest;
        private System.Windows.Forms.ComboBox answerComboBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label testHeadline;
        private System.Windows.Forms.Timer timeTimer;
        private System.Windows.Forms.Label timeLabel;
    }
}