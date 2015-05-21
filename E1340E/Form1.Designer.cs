namespace E1340E
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.buttonShape = new System.Windows.Forms.Button();
            this.textBoxFrequency = new System.Windows.Forms.TextBox();
            this.buttonQueryConfig = new System.Windows.Forms.Button();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.buttonCtrlC = new System.Windows.Forms.Button();
            this.radioButtonRamp = new System.Windows.Forms.RadioButton();
            this.radioButtonUserA = new System.Windows.Forms.RadioButton();
            this.radioButtonUserB = new System.Windows.Forms.RadioButton();
            this.radioButtonUserC = new System.Windows.Forms.RadioButton();
            this.radioButtonUserD = new System.Windows.Forms.RadioButton();
            this.textBoxAmplitude = new System.Windows.Forms.TextBox();
            this.textBoxOffset = new System.Windows.Forms.TextBox();
            this.checkBoxEnabled = new System.Windows.Forms.CheckBox();
            this.radioButtonDC = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Talk";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 507);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(780, 20);
            this.textBox1.TabIndex = 1;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(841, 28);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(4, 253);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(931, 251);
            this.textBox2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(832, 510);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Send";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonDC);
            this.groupBox1.Controls.Add(this.radioButtonUserD);
            this.groupBox1.Controls.Add(this.radioButtonUserC);
            this.groupBox1.Controls.Add(this.radioButtonUserB);
            this.groupBox1.Controls.Add(this.radioButtonUserA);
            this.groupBox1.Controls.Add(this.radioButtonRamp);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(4, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 238);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Waveform shape";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 88);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(59, 17);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.Text = "Square";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 65);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "Triangle";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 42);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(46, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Sine";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // buttonShape
            // 
            this.buttonShape.Location = new System.Drawing.Point(461, 61);
            this.buttonShape.Name = "buttonShape";
            this.buttonShape.Size = new System.Drawing.Size(88, 42);
            this.buttonShape.TabIndex = 9;
            this.buttonShape.Text = "Update waveform";
            this.buttonShape.UseVisualStyleBackColor = true;
            this.buttonShape.Click += new System.EventHandler(this.buttonShape_Click);
            // 
            // textBoxFrequency
            // 
            this.textBoxFrequency.Location = new System.Drawing.Point(336, 48);
            this.textBoxFrequency.Name = "textBoxFrequency";
            this.textBoxFrequency.Size = new System.Drawing.Size(100, 20);
            this.textBoxFrequency.TabIndex = 10;
            this.textBoxFrequency.Text = "10k";
            // 
            // buttonQueryConfig
            // 
            this.buttonQueryConfig.Location = new System.Drawing.Point(841, 160);
            this.buttonQueryConfig.Name = "buttonQueryConfig";
            this.buttonQueryConfig.Size = new System.Drawing.Size(75, 23);
            this.buttonQueryConfig.TabIndex = 15;
            this.buttonQueryConfig.Text = "Query config";
            this.buttonQueryConfig.UseVisualStyleBackColor = true;
            this.buttonQueryConfig.Click += new System.EventHandler(this.buttonQueryConfig_Click);
            // 
            // buttonUpload
            // 
            this.buttonUpload.Location = new System.Drawing.Point(841, 114);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(75, 23);
            this.buttonUpload.TabIndex = 16;
            this.buttonUpload.Text = "Upload";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // buttonCtrlC
            // 
            this.buttonCtrlC.Location = new System.Drawing.Point(841, 71);
            this.buttonCtrlC.Name = "buttonCtrlC";
            this.buttonCtrlC.Size = new System.Drawing.Size(75, 23);
            this.buttonCtrlC.TabIndex = 17;
            this.buttonCtrlC.Text = "Ctrl+C";
            this.buttonCtrlC.UseVisualStyleBackColor = true;
            this.buttonCtrlC.Click += new System.EventHandler(this.buttonCtrlC_Click);
            // 
            // radioButtonRamp
            // 
            this.radioButtonRamp.AutoSize = true;
            this.radioButtonRamp.Location = new System.Drawing.Point(7, 111);
            this.radioButtonRamp.Name = "radioButtonRamp";
            this.radioButtonRamp.Size = new System.Drawing.Size(53, 17);
            this.radioButtonRamp.TabIndex = 9;
            this.radioButtonRamp.Text = "Ramp";
            this.radioButtonRamp.UseVisualStyleBackColor = true;
            // 
            // radioButtonUserA
            // 
            this.radioButtonUserA.AutoSize = true;
            this.radioButtonUserA.Location = new System.Drawing.Point(7, 134);
            this.radioButtonUserA.Name = "radioButtonUserA";
            this.radioButtonUserA.Size = new System.Drawing.Size(102, 17);
            this.radioButtonUserA.TabIndex = 10;
            this.radioButtonUserA.Text = "User A (Sin(x)/x)";
            this.radioButtonUserA.UseVisualStyleBackColor = true;
            // 
            // radioButtonUserB
            // 
            this.radioButtonUserB.AutoSize = true;
            this.radioButtonUserB.Location = new System.Drawing.Point(7, 157);
            this.radioButtonUserB.Name = "radioButtonUserB";
            this.radioButtonUserB.Size = new System.Drawing.Size(168, 17);
            this.radioButtonUserB.TabIndex = 11;
            this.radioButtonUserB.Text = "UserB (3rd, 4th, 5th Harmonic)";
            this.radioButtonUserB.UseVisualStyleBackColor = true;
            // 
            // radioButtonUserC
            // 
            this.radioButtonUserC.AutoSize = true;
            this.radioButtonUserC.Location = new System.Drawing.Point(8, 180);
            this.radioButtonUserC.Name = "radioButtonUserC";
            this.radioButtonUserC.Size = new System.Drawing.Size(167, 17);
            this.radioButtonUserC.TabIndex = 12;
            this.radioButtonUserC.Text = "UserC (four terms of a Square)";
            this.radioButtonUserC.UseVisualStyleBackColor = true;
            // 
            // radioButtonUserD
            // 
            this.radioButtonUserD.AutoSize = true;
            this.radioButtonUserD.Location = new System.Drawing.Point(8, 203);
            this.radioButtonUserD.Name = "radioButtonUserD";
            this.radioButtonUserD.Size = new System.Drawing.Size(112, 17);
            this.radioButtonUserD.TabIndex = 13;
            this.radioButtonUserD.Text = "UserD (rising Sine)";
            this.radioButtonUserD.UseVisualStyleBackColor = true;
            // 
            // textBoxAmplitude
            // 
            this.textBoxAmplitude.Location = new System.Drawing.Point(336, 71);
            this.textBoxAmplitude.Name = "textBoxAmplitude";
            this.textBoxAmplitude.Size = new System.Drawing.Size(100, 20);
            this.textBoxAmplitude.TabIndex = 18;
            this.textBoxAmplitude.Text = "1";
            // 
            // textBoxOffset
            // 
            this.textBoxOffset.Location = new System.Drawing.Point(336, 94);
            this.textBoxOffset.Name = "textBoxOffset";
            this.textBoxOffset.Size = new System.Drawing.Size(100, 20);
            this.textBoxOffset.TabIndex = 19;
            this.textBoxOffset.Text = "0";
            // 
            // checkBoxEnabled
            // 
            this.checkBoxEnabled.AutoSize = true;
            this.checkBoxEnabled.Location = new System.Drawing.Point(229, 28);
            this.checkBoxEnabled.Name = "checkBoxEnabled";
            this.checkBoxEnabled.Size = new System.Drawing.Size(96, 17);
            this.checkBoxEnabled.TabIndex = 12;
            this.checkBoxEnabled.Text = "Ouput enabled";
            this.checkBoxEnabled.UseVisualStyleBackColor = true;
            this.checkBoxEnabled.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // radioButtonDC
            // 
            this.radioButtonDC.AutoSize = true;
            this.radioButtonDC.Location = new System.Drawing.Point(7, 19);
            this.radioButtonDC.Name = "radioButtonDC";
            this.radioButtonDC.Size = new System.Drawing.Size(40, 17);
            this.radioButtonDC.TabIndex = 14;
            this.radioButtonDC.Text = "DC";
            this.radioButtonDC.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Frequency [Hz]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Amplitude [V]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Offset [V]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 540);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxOffset);
            this.Controls.Add(this.textBoxAmplitude);
            this.Controls.Add(this.buttonCtrlC);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.buttonQueryConfig);
            this.Controls.Add(this.checkBoxEnabled);
            this.Controls.Add(this.textBoxFrequency);
            this.Controls.Add(this.buttonShape);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "E1340 Arbitrary waveform generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button buttonShape;
        private System.Windows.Forms.TextBox textBoxFrequency;
        private System.Windows.Forms.Button buttonQueryConfig;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.Button buttonCtrlC;
        private System.Windows.Forms.RadioButton radioButtonUserD;
        private System.Windows.Forms.RadioButton radioButtonUserC;
        private System.Windows.Forms.RadioButton radioButtonUserB;
        private System.Windows.Forms.RadioButton radioButtonUserA;
        private System.Windows.Forms.RadioButton radioButtonRamp;
        private System.Windows.Forms.RadioButton radioButtonDC;
        private System.Windows.Forms.TextBox textBoxAmplitude;
        private System.Windows.Forms.TextBox textBoxOffset;
        private System.Windows.Forms.CheckBox checkBoxEnabled;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

