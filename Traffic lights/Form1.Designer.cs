namespace Traffic_lights
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
            this.btn1G = new System.Windows.Forms.Button();
            this.btn1Y = new System.Windows.Forms.Button();
            this.btn1R = new System.Windows.Forms.Button();
            this.btn3G = new System.Windows.Forms.Button();
            this.btn3Y = new System.Windows.Forms.Button();
            this.btn3R = new System.Windows.Forms.Button();
            this.btn2G = new System.Windows.Forms.Button();
            this.btn2Y = new System.Windows.Forms.Button();
            this.btn2R = new System.Windows.Forms.Button();
            this.t1 = new System.Windows.Forms.Timer(this.components);
            this.t1Y = new System.Windows.Forms.Timer(this.components);
            this.t2 = new System.Windows.Forms.Timer(this.components);
            this.t2Y = new System.Windows.Forms.Timer(this.components);
            this.t3Y = new System.Windows.Forms.Timer(this.components);
            this.t3 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1G
            // 
            this.btn1G.BackColor = System.Drawing.Color.Silver;
            this.btn1G.Location = new System.Drawing.Point(150, 23);
            this.btn1G.Name = "btn1G";
            this.btn1G.Size = new System.Drawing.Size(51, 33);
            this.btn1G.TabIndex = 0;
            this.btn1G.UseVisualStyleBackColor = false;
            // 
            // btn1Y
            // 
            this.btn1Y.BackColor = System.Drawing.Color.Silver;
            this.btn1Y.Location = new System.Drawing.Point(150, 62);
            this.btn1Y.Name = "btn1Y";
            this.btn1Y.Size = new System.Drawing.Size(51, 33);
            this.btn1Y.TabIndex = 0;
            this.btn1Y.UseVisualStyleBackColor = false;
            // 
            // btn1R
            // 
            this.btn1R.BackColor = System.Drawing.Color.Silver;
            this.btn1R.Location = new System.Drawing.Point(150, 101);
            this.btn1R.Name = "btn1R";
            this.btn1R.Size = new System.Drawing.Size(51, 33);
            this.btn1R.TabIndex = 0;
            this.btn1R.UseVisualStyleBackColor = false;
            // 
            // btn3G
            // 
            this.btn3G.BackColor = System.Drawing.Color.Silver;
            this.btn3G.Location = new System.Drawing.Point(304, 308);
            this.btn3G.Name = "btn3G";
            this.btn3G.Size = new System.Drawing.Size(51, 33);
            this.btn3G.TabIndex = 0;
            this.btn3G.UseVisualStyleBackColor = false;
            // 
            // btn3Y
            // 
            this.btn3Y.BackColor = System.Drawing.Color.Silver;
            this.btn3Y.Location = new System.Drawing.Point(304, 347);
            this.btn3Y.Name = "btn3Y";
            this.btn3Y.Size = new System.Drawing.Size(51, 33);
            this.btn3Y.TabIndex = 0;
            this.btn3Y.UseVisualStyleBackColor = false;
            // 
            // btn3R
            // 
            this.btn3R.BackColor = System.Drawing.Color.Silver;
            this.btn3R.Location = new System.Drawing.Point(304, 386);
            this.btn3R.Name = "btn3R";
            this.btn3R.Size = new System.Drawing.Size(51, 33);
            this.btn3R.TabIndex = 0;
            this.btn3R.UseVisualStyleBackColor = false;
            // 
            // btn2G
            // 
            this.btn2G.BackColor = System.Drawing.Color.Silver;
            this.btn2G.Location = new System.Drawing.Point(625, 160);
            this.btn2G.Name = "btn2G";
            this.btn2G.Size = new System.Drawing.Size(51, 33);
            this.btn2G.TabIndex = 0;
            this.btn2G.UseVisualStyleBackColor = false;
            // 
            // btn2Y
            // 
            this.btn2Y.BackColor = System.Drawing.Color.Silver;
            this.btn2Y.Location = new System.Drawing.Point(625, 199);
            this.btn2Y.Name = "btn2Y";
            this.btn2Y.Size = new System.Drawing.Size(51, 33);
            this.btn2Y.TabIndex = 0;
            this.btn2Y.UseVisualStyleBackColor = false;
            // 
            // btn2R
            // 
            this.btn2R.BackColor = System.Drawing.Color.Silver;
            this.btn2R.Location = new System.Drawing.Point(625, 238);
            this.btn2R.Name = "btn2R";
            this.btn2R.Size = new System.Drawing.Size(51, 33);
            this.btn2R.TabIndex = 0;
            this.btn2R.UseVisualStyleBackColor = false;
            // 
            // t1
            // 
            this.t1.Interval = 1000;
            this.t1.Tick += new System.EventHandler(this.t1_Tick);
            // 
            // t1Y
            // 
            this.t1Y.Interval = 1000;
            this.t1Y.Tick += new System.EventHandler(this.t1Y_Tick);
            // 
            // t2
            // 
            this.t2.Interval = 1000;
            this.t2.Tick += new System.EventHandler(this.t2_Tick);
            // 
            // t2Y
            // 
            this.t2Y.Interval = 1000;
            this.t2Y.Tick += new System.EventHandler(this.t2Y_Tick);
            // 
            // t3Y
            // 
            this.t3Y.Interval = 1000;
            this.t3Y.Tick += new System.EventHandler(this.t3Y_Tick);
            // 
            // t3
            // 
            this.t3.Interval = 1000;
            this.t3.Tick += new System.EventHandler(this.t3_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(715, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(405, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 501);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn3R);
            this.Controls.Add(this.btn2R);
            this.Controls.Add(this.btn1R);
            this.Controls.Add(this.btn3Y);
            this.Controls.Add(this.btn2Y);
            this.Controls.Add(this.btn1Y);
            this.Controls.Add(this.btn3G);
            this.Controls.Add(this.btn2G);
            this.Controls.Add(this.btn1G);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1G;
        private System.Windows.Forms.Button btn1Y;
        private System.Windows.Forms.Button btn1R;
        private System.Windows.Forms.Button btn3G;
        private System.Windows.Forms.Button btn3Y;
        private System.Windows.Forms.Button btn3R;
        private System.Windows.Forms.Button btn2G;
        private System.Windows.Forms.Button btn2Y;
        private System.Windows.Forms.Button btn2R;
        private System.Windows.Forms.Timer t1;
        private System.Windows.Forms.Timer t1Y;
        private System.Windows.Forms.Timer t2;
        private System.Windows.Forms.Timer t2Y;
        private System.Windows.Forms.Timer t3Y;
        private System.Windows.Forms.Timer t3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

