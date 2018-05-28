namespace Autoukis
{
    partial class RobotsFrom
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
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Robot1 = new System.Windows.Forms.Button();
            this.btn_Robot2 = new System.Windows.Forms.Button();
            this.btn_Robot3 = new System.Windows.Forms.Button();
            this.btn_Robot4 = new System.Windows.Forms.Button();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(16, 16);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(68, 45);
            this.btn_Back.TabIndex = 0;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Robot1
            // 
            this.btn_Robot1.BackColor = System.Drawing.Color.Gray;
            this.btn_Robot1.Location = new System.Drawing.Point(51, 114);
            this.btn_Robot1.Name = "btn_Robot1";
            this.btn_Robot1.Size = new System.Drawing.Size(108, 84);
            this.btn_Robot1.TabIndex = 1;
            this.btn_Robot1.Text = "Robotas 1";
            this.btn_Robot1.UseVisualStyleBackColor = false;
            this.btn_Robot1.Click += new System.EventHandler(this.btn_Robot1_Click);
            // 
            // btn_Robot2
            // 
            this.btn_Robot2.BackColor = System.Drawing.Color.Gray;
            this.btn_Robot2.Location = new System.Drawing.Point(195, 114);
            this.btn_Robot2.Name = "btn_Robot2";
            this.btn_Robot2.Size = new System.Drawing.Size(108, 84);
            this.btn_Robot2.TabIndex = 2;
            this.btn_Robot2.Text = "Robotas 2";
            this.btn_Robot2.UseVisualStyleBackColor = false;
            this.btn_Robot2.Click += new System.EventHandler(this.btn_Robot2_Click);
            // 
            // btn_Robot3
            // 
            this.btn_Robot3.BackColor = System.Drawing.Color.Gray;
            this.btn_Robot3.Location = new System.Drawing.Point(51, 234);
            this.btn_Robot3.Name = "btn_Robot3";
            this.btn_Robot3.Size = new System.Drawing.Size(108, 84);
            this.btn_Robot3.TabIndex = 3;
            this.btn_Robot3.Text = "Robotas 3";
            this.btn_Robot3.UseVisualStyleBackColor = false;
            this.btn_Robot3.Click += new System.EventHandler(this.btn_Robot3_Click);
            // 
            // btn_Robot4
            // 
            this.btn_Robot4.BackColor = System.Drawing.Color.Gray;
            this.btn_Robot4.Location = new System.Drawing.Point(195, 234);
            this.btn_Robot4.Name = "btn_Robot4";
            this.btn_Robot4.Size = new System.Drawing.Size(103, 84);
            this.btn_Robot4.TabIndex = 4;
            this.btn_Robot4.Text = "Robotas 4";
            this.btn_Robot4.UseVisualStyleBackColor = false;
            this.btn_Robot4.Click += new System.EventHandler(this.btn_Robot4_Click);
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(114, 401);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(108, 33);
            this.btn_Ok.TabIndex = 5;
            this.btn_Ok.Text = "Patvirtinti";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // RobotsFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 482);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.btn_Robot4);
            this.Controls.Add(this.btn_Robot3);
            this.Controls.Add(this.btn_Robot2);
            this.Controls.Add(this.btn_Robot1);
            this.Controls.Add(this.btn_Back);
            this.Name = "RobotsFrom";
            this.Text = "RobotsFrom";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Robot1;
        private System.Windows.Forms.Button btn_Robot2;
        private System.Windows.Forms.Button btn_Robot3;
        private System.Windows.Forms.Button btn_Robot4;
        private System.Windows.Forms.Button btn_Ok;
    }
}