namespace Test_Scores
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userScoreTxt = new System.Windows.Forms.TextBox();
            this.scoreTotalTxt = new System.Windows.Forms.TextBox();
            this.scoreCountTxt = new System.Windows.Forms.TextBox();
            this.averageTxt = new System.Windows.Forms.TextBox();
            this.addNumBtn = new System.Windows.Forms.Button();
            this.displayScoresBtn = new System.Windows.Forms.Button();
            this.clearScoresBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Score total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Score count:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Average";
            // 
            // userScoreTxt
            // 
            this.userScoreTxt.Location = new System.Drawing.Point(134, 12);
            this.userScoreTxt.Name = "userScoreTxt";
            this.userScoreTxt.Size = new System.Drawing.Size(100, 22);
            this.userScoreTxt.TabIndex = 4;
            // 
            // scoreTotalTxt
            // 
            this.scoreTotalTxt.Enabled = false;
            this.scoreTotalTxt.Location = new System.Drawing.Point(134, 40);
            this.scoreTotalTxt.Name = "scoreTotalTxt";
            this.scoreTotalTxt.Size = new System.Drawing.Size(100, 22);
            this.scoreTotalTxt.TabIndex = 5;
            // 
            // scoreCountTxt
            // 
            this.scoreCountTxt.Enabled = false;
            this.scoreCountTxt.Location = new System.Drawing.Point(134, 68);
            this.scoreCountTxt.Name = "scoreCountTxt";
            this.scoreCountTxt.Size = new System.Drawing.Size(100, 22);
            this.scoreCountTxt.TabIndex = 6;
            // 
            // averageTxt
            // 
            this.averageTxt.Enabled = false;
            this.averageTxt.Location = new System.Drawing.Point(134, 96);
            this.averageTxt.Name = "averageTxt";
            this.averageTxt.Size = new System.Drawing.Size(100, 22);
            this.averageTxt.TabIndex = 7;
            // 
            // addNumBtn
            // 
            this.addNumBtn.Location = new System.Drawing.Point(252, 11);
            this.addNumBtn.Name = "addNumBtn";
            this.addNumBtn.Size = new System.Drawing.Size(98, 23);
            this.addNumBtn.TabIndex = 8;
            this.addNumBtn.Text = "Add";
            this.addNumBtn.UseVisualStyleBackColor = true;
            this.addNumBtn.Click += new System.EventHandler(this.AddNumBtn_Click);
            // 
            // displayScoresBtn
            // 
            this.displayScoresBtn.Location = new System.Drawing.Point(43, 137);
            this.displayScoresBtn.Name = "displayScoresBtn";
            this.displayScoresBtn.Size = new System.Drawing.Size(114, 30);
            this.displayScoresBtn.TabIndex = 9;
            this.displayScoresBtn.Text = "Display Scores";
            this.displayScoresBtn.UseVisualStyleBackColor = true;
            this.displayScoresBtn.Click += new System.EventHandler(this.DisplayScoresBtn_Click);
            // 
            // clearScoresBtn
            // 
            this.clearScoresBtn.Location = new System.Drawing.Point(163, 137);
            this.clearScoresBtn.Name = "clearScoresBtn";
            this.clearScoresBtn.Size = new System.Drawing.Size(102, 30);
            this.clearScoresBtn.TabIndex = 10;
            this.clearScoresBtn.Text = "Clear Scores";
            this.clearScoresBtn.UseVisualStyleBackColor = true;
            this.clearScoresBtn.Click += new System.EventHandler(this.ClearScoresBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.exitBtn.Location = new System.Drawing.Point(163, 173);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(102, 31);
            this.exitBtn.TabIndex = 11;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(394, 228);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearScoresBtn);
            this.Controls.Add(this.displayScoresBtn);
            this.Controls.Add(this.addNumBtn);
            this.Controls.Add(this.averageTxt);
            this.Controls.Add(this.scoreCountTxt);
            this.Controls.Add(this.scoreTotalTxt);
            this.Controls.Add(this.userScoreTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Score Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userScoreTxt;
        private System.Windows.Forms.TextBox scoreTotalTxt;
        private System.Windows.Forms.TextBox scoreCountTxt;
        private System.Windows.Forms.TextBox averageTxt;
        private System.Windows.Forms.Button addNumBtn;
        private System.Windows.Forms.Button displayScoresBtn;
        private System.Windows.Forms.Button clearScoresBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

