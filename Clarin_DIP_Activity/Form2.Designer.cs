﻿namespace Clarin_DIP_Activity
{
    partial class Form2
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loadIMG1 = new System.Windows.Forms.Button();
            this.loadIMG2 = new System.Windows.Forms.Button();
            this.backPanel_btn = new System.Windows.Forms.Button();
            this.subtractIMG_btn = new System.Windows.Forms.Button();
            this.saveResultIMG_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(36, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(326, 114);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 250);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(615, 114);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(250, 250);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(377, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(637, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Subtracted Image Result";
            // 
            // loadIMG1
            // 
            this.loadIMG1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadIMG1.Location = new System.Drawing.Point(90, 380);
            this.loadIMG1.Name = "loadIMG1";
            this.loadIMG1.Size = new System.Drawing.Size(144, 38);
            this.loadIMG1.TabIndex = 6;
            this.loadIMG1.Text = "Load Image 1";
            this.loadIMG1.UseVisualStyleBackColor = true;
            this.loadIMG1.Click += new System.EventHandler(this.loadIMG1_Click);
            // 
            // loadIMG2
            // 
            this.loadIMG2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadIMG2.Location = new System.Drawing.Point(381, 380);
            this.loadIMG2.Name = "loadIMG2";
            this.loadIMG2.Size = new System.Drawing.Size(144, 38);
            this.loadIMG2.TabIndex = 7;
            this.loadIMG2.Text = "Load Image 2";
            this.loadIMG2.UseVisualStyleBackColor = true;
            this.loadIMG2.Click += new System.EventHandler(this.loadIMG2_Click);
            // 
            // backPanel_btn
            // 
            this.backPanel_btn.BackColor = System.Drawing.Color.Black;
            this.backPanel_btn.ForeColor = System.Drawing.Color.White;
            this.backPanel_btn.Location = new System.Drawing.Point(37, 24);
            this.backPanel_btn.Name = "backPanel_btn";
            this.backPanel_btn.Size = new System.Drawing.Size(75, 23);
            this.backPanel_btn.TabIndex = 9;
            this.backPanel_btn.Text = "Back";
            this.backPanel_btn.UseVisualStyleBackColor = false;
            this.backPanel_btn.Click += new System.EventHandler(this.backPanel_btn_Click);
            // 
            // subtractIMG_btn
            // 
            this.subtractIMG_btn.Location = new System.Drawing.Point(790, 24);
            this.subtractIMG_btn.Name = "subtractIMG_btn";
            this.subtractIMG_btn.Size = new System.Drawing.Size(75, 23);
            this.subtractIMG_btn.TabIndex = 10;
            this.subtractIMG_btn.Text = "Subtract";
            this.subtractIMG_btn.UseVisualStyleBackColor = true;
            this.subtractIMG_btn.Click += new System.EventHandler(this.subtractIMG_btn_Click);
            // 
            // saveResultIMG_btn
            // 
            this.saveResultIMG_btn.Location = new System.Drawing.Point(128, 24);
            this.saveResultIMG_btn.Name = "saveResultIMG_btn";
            this.saveResultIMG_btn.Size = new System.Drawing.Size(75, 23);
            this.saveResultIMG_btn.TabIndex = 11;
            this.saveResultIMG_btn.Text = "Save Result";
            this.saveResultIMG_btn.UseVisualStyleBackColor = true;
            this.saveResultIMG_btn.Click += new System.EventHandler(this.saveResultIMG_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "( image must be a green screen )";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "( image must be a background )";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(903, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saveResultIMG_btn);
            this.Controls.Add(this.subtractIMG_btn);
            this.Controls.Add(this.backPanel_btn);
            this.Controls.Add(this.loadIMG2);
            this.Controls.Add(this.loadIMG1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loadIMG1;
        private System.Windows.Forms.Button loadIMG2;
        private System.Windows.Forms.Button backPanel_btn;
        private System.Windows.Forms.Button subtractIMG_btn;
        private System.Windows.Forms.Button saveResultIMG_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}