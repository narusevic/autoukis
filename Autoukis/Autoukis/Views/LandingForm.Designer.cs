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
            this.btn_ViewMap = new System.Windows.Forms.Button();
            this.btn_Feeding = new System.Windows.Forms.Button();
            this.btn_Robots = new System.Windows.Forms.Button();
            this.btn_Notifications = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ViewMap
            // 
            this.btn_ViewMap.Location = new System.Drawing.Point(39, 69);
            this.btn_ViewMap.Name = "btn_ViewMap";
            this.btn_ViewMap.Size = new System.Drawing.Size(286, 72);
            this.btn_ViewMap.TabIndex = 0;
            this.btn_ViewMap.Text = "Peržiūrėti ūkį iš viršaus";
            this.btn_ViewMap.UseVisualStyleBackColor = true;
            this.btn_ViewMap.Click += new System.EventHandler(this.btn_ViewMap_Click);
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
            // btn_Robots
            // 
            this.btn_Robots.Location = new System.Drawing.Point(39, 308);
            this.btn_Robots.Name = "btn_Robots";
            this.btn_Robots.Size = new System.Drawing.Size(286, 72);
            this.btn_Robots.TabIndex = 2;
            this.btn_Robots.Text = "Robotai";
            this.btn_Robots.UseVisualStyleBackColor = true;
            this.btn_Robots.Click += new System.EventHandler(this.btn_Robots_Click);
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
            this.Controls.Add(this.btn_Robots);
            this.Controls.Add(this.btn_Feeding);
            this.Controls.Add(this.btn_ViewMap);
            this.Name = "LandingForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ViewMap;
        private System.Windows.Forms.Button btn_Feeding;
        private System.Windows.Forms.Button btn_Robots;
        private System.Windows.Forms.Button btn_Notifications;
    }
}

