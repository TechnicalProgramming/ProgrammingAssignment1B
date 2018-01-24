namespace Programming_Assignment2StudentPredicate
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.badMarksButton = new System.Windows.Forms.Button();
            this.goodMarksButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.predicateNeededLabel = new System.Windows.Forms.Label();
            this.predicateResultsLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.projectTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.additionalTextBox = new System.Windows.Forms.TextBox();
            this.term2TextBox = new System.Windows.Forms.TextBox();
            this.term1TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.practicalsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Predicate";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.clearButton);
            this.groupBox6.Controls.Add(this.calculateButton);
            this.groupBox6.Controls.Add(this.badMarksButton);
            this.groupBox6.Controls.Add(this.goodMarksButton);
            this.groupBox6.Location = new System.Drawing.Point(483, 143);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(226, 122);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Simulate Marks";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(145, 93);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(9, 93);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // badMarksButton
            // 
            this.badMarksButton.Location = new System.Drawing.Point(145, 29);
            this.badMarksButton.Name = "badMarksButton";
            this.badMarksButton.Size = new System.Drawing.Size(75, 23);
            this.badMarksButton.TabIndex = 1;
            this.badMarksButton.Text = "Bad Marks";
            this.badMarksButton.UseVisualStyleBackColor = true;
            // 
            // goodMarksButton
            // 
            this.goodMarksButton.Location = new System.Drawing.Point(9, 29);
            this.goodMarksButton.Name = "goodMarksButton";
            this.goodMarksButton.Size = new System.Drawing.Size(75, 23);
            this.goodMarksButton.TabIndex = 0;
            this.goodMarksButton.Text = "Good Marks";
            this.goodMarksButton.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.predicateNeededLabel);
            this.groupBox5.Controls.Add(this.predicateResultsLabel);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox5.Location = new System.Drawing.Point(19, 143);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(458, 122);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Results";
            // 
            // predicateNeededLabel
            // 
            this.predicateNeededLabel.AutoSize = true;
            this.predicateNeededLabel.Location = new System.Drawing.Point(6, 58);
            this.predicateNeededLabel.Name = "predicateNeededLabel";
            this.predicateNeededLabel.Size = new System.Drawing.Size(171, 13);
            this.predicateNeededLabel.TabIndex = 4;
            this.predicateNeededLabel.Text = "You need 00.0 in the exam to pass";
            // 
            // predicateResultsLabel
            // 
            this.predicateResultsLabel.AutoSize = true;
            this.predicateResultsLabel.Location = new System.Drawing.Point(6, 34);
            this.predicateResultsLabel.Name = "predicateResultsLabel";
            this.predicateResultsLabel.Size = new System.Drawing.Size(113, 13);
            this.predicateResultsLabel.TabIndex = 3;
            this.predicateResultsLabel.Text = "Your predicate is: 00.0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.projectTextBox);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox4.Location = new System.Drawing.Point(483, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(226, 106);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Projects";
            // 
            // projectTextBox
            // 
            this.projectTextBox.Location = new System.Drawing.Point(82, 23);
            this.projectTextBox.Name = "projectTextBox";
            this.projectTextBox.Size = new System.Drawing.Size(100, 20);
            this.projectTextBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Project Total:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.additionalTextBox);
            this.groupBox3.Controls.Add(this.term2TextBox);
            this.groupBox3.Controls.Add(this.term1TextBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox3.Location = new System.Drawing.Point(251, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 106);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tests";
            // 
            // additionalTextBox
            // 
            this.additionalTextBox.Location = new System.Drawing.Point(71, 71);
            this.additionalTextBox.Name = "additionalTextBox";
            this.additionalTextBox.Size = new System.Drawing.Size(100, 20);
            this.additionalTextBox.TabIndex = 7;
            // 
            // term2TextBox
            // 
            this.term2TextBox.Location = new System.Drawing.Point(71, 47);
            this.term2TextBox.Name = "term2TextBox";
            this.term2TextBox.Size = new System.Drawing.Size(100, 20);
            this.term2TextBox.TabIndex = 6;
            // 
            // term1TextBox
            // 
            this.term1TextBox.Location = new System.Drawing.Point(71, 23);
            this.term1TextBox.Name = "term1TextBox";
            this.term1TextBox.Size = new System.Drawing.Size(100, 20);
            this.term1TextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Additional:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Term 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Term 1:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.practicalsTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(19, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 106);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Practicals";
            // 
            // practicalsTextBox
            // 
            this.practicalsTextBox.Location = new System.Drawing.Point(84, 23);
            this.practicalsTextBox.Name = "practicalsTextBox";
            this.practicalsTextBox.Size = new System.Drawing.Size(100, 20);
            this.practicalsTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pratical Total:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 318);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Predicate";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button badMarksButton;
        private System.Windows.Forms.Button goodMarksButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label predicateNeededLabel;
        private System.Windows.Forms.Label predicateResultsLabel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox projectTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox additionalTextBox;
        private System.Windows.Forms.TextBox term2TextBox;
        private System.Windows.Forms.TextBox term1TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox practicalsTextBox;
        private System.Windows.Forms.Label label1;
    }
}

