namespace AND_Gate_Backpropagation
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
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.input3 = new System.Windows.Forms.TextBox();
            this.input4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.TextBox();
            this.testBtn = new System.Windows.Forms.Button();
            this.TrainBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(149, 156);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(100, 22);
            this.input1.TabIndex = 0;
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(149, 195);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(100, 22);
            this.input2.TabIndex = 1;
            // 
            // input3
            // 
            this.input3.Location = new System.Drawing.Point(149, 235);
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(100, 22);
            this.input3.TabIndex = 2;
            // 
            // input4
            // 
            this.input4.Location = new System.Drawing.Point(149, 275);
            this.input4.Name = "input4";
            this.input4.Size = new System.Drawing.Size(100, 22);
            this.input4.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(446, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "OUTPUT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "INPUTS";
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(389, 203);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(236, 32);
            this.output.TabIndex = 6;
            // 
            // testBtn
            // 
            this.testBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testBtn.Location = new System.Drawing.Point(549, 356);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(115, 58);
            this.testBtn.TabIndex = 7;
            this.testBtn.Text = "Test";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // TrainBtn
            // 
            this.TrainBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrainBtn.Location = new System.Drawing.Point(262, 356);
            this.TrainBtn.Name = "TrainBtn";
            this.TrainBtn.Size = new System.Drawing.Size(281, 58);
            this.TrainBtn.TabIndex = 8;
            this.TrainBtn.Text = "Train The Neural Net";
            this.TrainBtn.UseVisualStyleBackColor = true;
            this.TrainBtn.Click += new System.EventHandler(this.TrainBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.Location = new System.Drawing.Point(91, 356);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(165, 58);
            this.createBtn.TabIndex = 9;
            this.createBtn.Text = "Create BPNN";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(245, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 36);
            this.label3.TabIndex = 10;
            this.label3.Text = "AND GATE OPERATION";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.TrainBtn);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input4);
            this.Controls.Add(this.input3);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.TextBox input3;
        private System.Windows.Forms.TextBox input4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.Button TrainBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Label label3;
    }
}

