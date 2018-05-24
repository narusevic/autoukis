namespace Autoukis
{
    partial class LandingForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Feeding = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_Notifications = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 72);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_Feeding
            // 
            this.btn_Feeding.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Feeding.Location = new System.Drawing.Point(39, 185);
            this.btn_Feeding.Name = "btn_Feeding";
            this.btn_Feeding.Size = new System.Drawing.Size(286, 72);
            this.btn_Feeding.TabIndex = 1;
            this.btn_Feeding.Text = "Maitinimas";
            this.btn_Feeding.UseVisualStyleBackColor = true;
            this.btn_Feeding.Click += new System.EventHandler(this.btn_Feeding_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(39, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(286, 72);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_Notifications
            // 
            this.btn_Notifications.Location = new System.Drawing.Point(39, 432);
            this.btn_Notifications.Name = "btn_Notifications";
            this.btn_Notifications.Size = new System.Drawing.Size(286, 72);
            this.btn_Notifications.TabIndex = 3;
            this.btn_Notifications.Text = "Pranešimai";
            this.btn_Notifications.UseVisualStyleBackColor = true;
            this.btn_Notifications.Click += new System.EventHandler(this.btn_Notifications_Click);
            // 
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 554);
            this.Controls.Add(this.btn_Notifications);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_Feeding);
            this.Controls.Add(this.button1);
            this.Name = "LandingForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Feeding;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_Notifications;
    }
}

