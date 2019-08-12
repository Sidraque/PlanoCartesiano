namespace CalculaCoordenadasForm {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAX = new System.Windows.Forms.TextBox();
            this.textBoxAY = new System.Windows.Forms.TextBox();
            this.textBoxAZ = new System.Windows.Forms.TextBox();
            this.textBoxBX = new System.Windows.Forms.TextBox();
            this.textBoxBY = new System.Windows.Forms.TextBox();
            this.textBoxBZ = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "AX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "AY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "AZ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(212, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "BX";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(212, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "BY";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gainsboro;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(212, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "BZ";
            // 
            // textBoxAX
            // 
            this.textBoxAX.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxAX.Location = new System.Drawing.Point(92, 82);
            this.textBoxAX.Name = "textBoxAX";
            this.textBoxAX.Size = new System.Drawing.Size(100, 20);
            this.textBoxAX.TabIndex = 6;
            this.textBoxAX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAX_KeyPress);
            // 
            // textBoxAY
            // 
            this.textBoxAY.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxAY.Location = new System.Drawing.Point(92, 137);
            this.textBoxAY.Name = "textBoxAY";
            this.textBoxAY.Size = new System.Drawing.Size(100, 20);
            this.textBoxAY.TabIndex = 7;
            this.textBoxAY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAY_KeyPress);
            // 
            // textBoxAZ
            // 
            this.textBoxAZ.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxAZ.Location = new System.Drawing.Point(92, 191);
            this.textBoxAZ.Name = "textBoxAZ";
            this.textBoxAZ.Size = new System.Drawing.Size(100, 20);
            this.textBoxAZ.TabIndex = 8;
            this.textBoxAZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAZ_KeyPress);
            // 
            // textBoxBX
            // 
            this.textBoxBX.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxBX.Location = new System.Drawing.Point(259, 82);
            this.textBoxBX.Name = "textBoxBX";
            this.textBoxBX.Size = new System.Drawing.Size(100, 20);
            this.textBoxBX.TabIndex = 9;
            this.textBoxBX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxBX_KeyPress);
            // 
            // textBoxBY
            // 
            this.textBoxBY.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxBY.Location = new System.Drawing.Point(259, 137);
            this.textBoxBY.Name = "textBoxBY";
            this.textBoxBY.Size = new System.Drawing.Size(100, 20);
            this.textBoxBY.TabIndex = 10;
            this.textBoxBY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxBY_KeyPress);
            // 
            // textBoxBZ
            // 
            this.textBoxBZ.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxBZ.Location = new System.Drawing.Point(259, 191);
            this.textBoxBZ.Name = "textBoxBZ";
            this.textBoxBZ.Size = new System.Drawing.Size(100, 20);
            this.textBoxBZ.TabIndex = 11;
            this.textBoxBZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxBZ_KeyPress);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(82, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 54);
            this.button1.TabIndex = 13;
            this.button1.Text = "CALCULAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(216, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 54);
            this.button2.TabIndex = 14;
            this.button2.Text = "LIMPAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(394, 355);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxBZ);
            this.Controls.Add(this.textBoxBY);
            this.Controls.Add(this.textBoxBX);
            this.Controls.Add(this.textBoxAZ);
            this.Controls.Add(this.textBoxAY);
            this.Controls.Add(this.textBoxAX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calcular Distância";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAX;
        private System.Windows.Forms.TextBox textBoxAY;
        private System.Windows.Forms.TextBox textBoxAZ;
        private System.Windows.Forms.TextBox textBoxBX;
        private System.Windows.Forms.TextBox textBoxBY;
        private System.Windows.Forms.TextBox textBoxBZ;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

