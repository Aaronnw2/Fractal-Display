namespace Fractal_Display
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtXMax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtXMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYMax = new System.Windows.Forms.TextBox();
            this.txtYMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReDraw = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtIterations = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(750, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // txtXMax
            // 
            this.txtXMax.Location = new System.Drawing.Point(12, 538);
            this.txtXMax.Name = "txtXMax";
            this.txtXMax.Size = new System.Drawing.Size(87, 20);
            this.txtXMax.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 522);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "X Max";
            // 
            // txtXMin
            // 
            this.txtXMin.Location = new System.Drawing.Point(105, 538);
            this.txtXMin.Name = "txtXMin";
            this.txtXMin.Size = new System.Drawing.Size(87, 20);
            this.txtXMin.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 522);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "X Min";
            // 
            // txtYMax
            // 
            this.txtYMax.Location = new System.Drawing.Point(233, 538);
            this.txtYMax.Name = "txtYMax";
            this.txtYMax.Size = new System.Drawing.Size(87, 20);
            this.txtYMax.TabIndex = 5;
            // 
            // txtYMin
            // 
            this.txtYMin.Location = new System.Drawing.Point(326, 538);
            this.txtYMin.Name = "txtYMin";
            this.txtYMin.Size = new System.Drawing.Size(87, 20);
            this.txtYMin.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 522);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Y Min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 522);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Y Max";
            // 
            // btnReDraw
            // 
            this.btnReDraw.Location = new System.Drawing.Point(545, 522);
            this.btnReDraw.Name = "btnReDraw";
            this.btnReDraw.Size = new System.Drawing.Size(82, 36);
            this.btnReDraw.TabIndex = 9;
            this.btnReDraw.Text = "Recalculate";
            this.btnReDraw.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(684, 522);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 36);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtIterations
            // 
            this.txtIterations.Location = new System.Drawing.Point(452, 538);
            this.txtIterations.Name = "txtIterations";
            this.txtIterations.Size = new System.Drawing.Size(87, 20);
            this.txtIterations.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(449, 522);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Iterations";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 570);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIterations);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReDraw);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtYMin);
            this.Controls.Add(this.txtYMax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtXMin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtXMax);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Fractal Display";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtXMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtXMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYMax;
        private System.Windows.Forms.TextBox txtYMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReDraw;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtIterations;
        private System.Windows.Forms.Label label5;

    }
}

