namespace ProgramDoLiczeniaRMS
{
    partial class MainForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.readFiles_Button = new System.Windows.Forms.Button();
            this.textBox_resoult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_maxVal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_doublerms = new System.Windows.Forms.TextBox();
            this.button_outcome = new System.Windows.Forms.Button();
            this.textBox_N = new System.Windows.Forms.TextBox();
            this.label_N = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Policz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // readFiles_Button
            // 
            this.readFiles_Button.Location = new System.Drawing.Point(188, 43);
            this.readFiles_Button.Name = "readFiles_Button";
            this.readFiles_Button.Size = new System.Drawing.Size(38, 20);
            this.readFiles_Button.TabIndex = 2;
            this.readFiles_Button.Text = "...";
            this.readFiles_Button.UseVisualStyleBackColor = true;
            this.readFiles_Button.Click += new System.EventHandler(this.readFiles_Button_Click);
            // 
            // textBox_resoult
            // 
            this.textBox_resoult.Location = new System.Drawing.Point(64, 19);
            this.textBox_resoult.Name = "textBox_resoult";
            this.textBox_resoult.Size = new System.Drawing.Size(191, 20);
            this.textBox_resoult.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Zaczytaj plik tekstowy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "max value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "RMS";
            // 
            // textbox_maxVal
            // 
            this.textbox_maxVal.Location = new System.Drawing.Point(62, 19);
            this.textbox_maxVal.Name = "textbox_maxVal";
            this.textbox_maxVal.Size = new System.Drawing.Size(191, 20);
            this.textbox_maxVal.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "RMS x2";
            // 
            // textBox_doublerms
            // 
            this.textBox_doublerms.Location = new System.Drawing.Point(62, 45);
            this.textBox_doublerms.Name = "textBox_doublerms";
            this.textBox_doublerms.Size = new System.Drawing.Size(191, 20);
            this.textBox_doublerms.TabIndex = 9;
            // 
            // button_outcome
            // 
            this.button_outcome.Location = new System.Drawing.Point(10, 73);
            this.button_outcome.Name = "button_outcome";
            this.button_outcome.Size = new System.Drawing.Size(253, 52);
            this.button_outcome.TabIndex = 10;
            this.button_outcome.UseVisualStyleBackColor = true;
            // 
            // textBox_N
            // 
            this.textBox_N.Location = new System.Drawing.Point(41, 76);
            this.textBox_N.Name = "textBox_N";
            this.textBox_N.Size = new System.Drawing.Size(33, 20);
            this.textBox_N.TabIndex = 11;
            // 
            // label_N
            // 
            this.label_N.AutoSize = true;
            this.label_N.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_N.Location = new System.Drawing.Point(15, 76);
            this.label_N.Name = "label_N";
            this.label_N.Size = new System.Drawing.Size(20, 20);
            this.label_N.TabIndex = 12;
            this.label_N.Text = "N";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "© Michał Podralski";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textbox_maxVal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_doublerms);
            this.groupBox1.Controls.Add(this.button_outcome);
            this.groupBox1.Location = new System.Drawing.Point(15, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 142);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Analiza dokładności";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_resoult);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(15, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 61);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wynik";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.readFiles_Button);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label_N);
            this.groupBox3.Controls.Add(this.textBox_N);
            this.groupBox3.Location = new System.Drawing.Point(15, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(281, 107);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wprowadź dane";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Wprowadź wartość N (opcjonalne)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 391);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "RMS Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button readFiles_Button;
        private System.Windows.Forms.TextBox textBox_resoult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox_maxVal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_doublerms;
        private System.Windows.Forms.Button button_outcome;
        private System.Windows.Forms.TextBox textBox_N;
        private System.Windows.Forms.Label label_N;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
    }
}

