namespace TimingExperiment
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
            this.pyVmBox = new System.Windows.Forms.TextBox();
            this.pyAppBox = new System.Windows.Forms.TextBox();
            this.jarVmBox = new System.Windows.Forms.TextBox();
            this.jarAppBox = new System.Windows.Forms.TextBox();
            this.btnPing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Python VM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Python App:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Java VM:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Java App:";
            // 
            // pyVmBox
            // 
            this.pyVmBox.Location = new System.Drawing.Point(129, 40);
            this.pyVmBox.Name = "pyVmBox";
            this.pyVmBox.Size = new System.Drawing.Size(100, 20);
            this.pyVmBox.TabIndex = 4;
            // 
            // pyAppBox
            // 
            this.pyAppBox.Location = new System.Drawing.Point(129, 65);
            this.pyAppBox.Name = "pyAppBox";
            this.pyAppBox.Size = new System.Drawing.Size(100, 20);
            this.pyAppBox.TabIndex = 5;
            // 
            // jarVmBox
            // 
            this.jarVmBox.Location = new System.Drawing.Point(129, 89);
            this.jarVmBox.Name = "jarVmBox";
            this.jarVmBox.Size = new System.Drawing.Size(100, 20);
            this.jarVmBox.TabIndex = 6;
            // 
            // jarAppBox
            // 
            this.jarAppBox.Location = new System.Drawing.Point(129, 115);
            this.jarAppBox.Name = "jarAppBox";
            this.jarAppBox.Size = new System.Drawing.Size(100, 20);
            this.jarAppBox.TabIndex = 7;
            // 
            // btnPing
            // 
            this.btnPing.Location = new System.Drawing.Point(84, 163);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(75, 23);
            this.btnPing.TabIndex = 8;
            this.btnPing.Text = "Ping";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 198);
            this.Controls.Add(this.btnPing);
            this.Controls.Add(this.jarAppBox);
            this.Controls.Add(this.jarVmBox);
            this.Controls.Add(this.pyAppBox);
            this.Controls.Add(this.pyVmBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pyVmBox;
        private System.Windows.Forms.TextBox pyAppBox;
        private System.Windows.Forms.TextBox jarVmBox;
        private System.Windows.Forms.TextBox jarAppBox;
        private System.Windows.Forms.Button btnPing;
    }
}

