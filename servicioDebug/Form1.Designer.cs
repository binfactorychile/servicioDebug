namespace servicioDebug
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.checkVega = new System.Windows.Forms.CheckBox();
            this.checkActivarCasaMatriz = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Envia producto a hosting";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(46, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "vegas recibe prod desde host.";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(61, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Envia ventas al hosting";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(326, 112);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "matriz recibe venta desde host.";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkVega
            // 
            this.checkVega.AutoSize = true;
            this.checkVega.Location = new System.Drawing.Point(108, 41);
            this.checkVega.Name = "checkVega";
            this.checkVega.Size = new System.Drawing.Size(87, 17);
            this.checkVega.TabIndex = 4;
            this.checkVega.Text = "Activar Vega";
            this.checkVega.UseVisualStyleBackColor = true;
            this.checkVega.CheckedChanged += new System.EventHandler(this.checkVega_CheckedChanged);
            // 
            // checkActivarCasaMatriz
            // 
            this.checkActivarCasaMatriz.AutoSize = true;
            this.checkActivarCasaMatriz.Location = new System.Drawing.Point(361, 41);
            this.checkActivarCasaMatriz.Name = "checkActivarCasaMatriz";
            this.checkActivarCasaMatriz.Size = new System.Drawing.Size(78, 17);
            this.checkActivarCasaMatriz.TabIndex = 5;
            this.checkActivarCasaMatriz.Text = "Activar CM";
            this.checkActivarCasaMatriz.UseVisualStyleBackColor = true;
            this.checkActivarCasaMatriz.CheckedChanged += new System.EventHandler(this.checkActivarCasaMatriz_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 8000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 273);
            this.Controls.Add(this.checkActivarCasaMatriz);
            this.Controls.Add(this.checkVega);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1 VEGA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkVega;
        private System.Windows.Forms.CheckBox checkActivarCasaMatriz;
        private System.Windows.Forms.Timer timer1;
    }
}

