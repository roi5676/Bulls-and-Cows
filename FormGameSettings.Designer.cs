namespace A22_Ex05
{
    partial class FormGameSettings
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
            this.m_ButtonChancesNumber = new System.Windows.Forms.Button();
            this.m_ButtonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_ButtonChancesNumber
            // 
            this.m_ButtonChancesNumber.BackColor = System.Drawing.SystemColors.ControlLight;
            this.m_ButtonChancesNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m_ButtonChancesNumber.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_ButtonChancesNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.m_ButtonChancesNumber.Location = new System.Drawing.Point(22, 12);
            this.m_ButtonChancesNumber.Name = "m_ButtonChancesNumber";
            this.m_ButtonChancesNumber.Size = new System.Drawing.Size(234, 27);
            this.m_ButtonChancesNumber.TabIndex = 0;
            this.m_ButtonChancesNumber.Text = "Number of chances: ";
            this.m_ButtonChancesNumber.UseVisualStyleBackColor = true;
            this.m_ButtonChancesNumber.Click += new System.EventHandler(this.m_ButtonChancesNumber_Click);
            // 
            // m_ButtonStart
            // 
            this.m_ButtonStart.Location = new System.Drawing.Point(181, 88);
            this.m_ButtonStart.Name = "m_ButtonStart";
            this.m_ButtonStart.Size = new System.Drawing.Size(75, 23);
            this.m_ButtonStart.TabIndex = 1;
            this.m_ButtonStart.Text = "Start";
            this.m_ButtonStart.UseVisualStyleBackColor = true;
            this.m_ButtonStart.Click += new System.EventHandler(this.m_ButtonStart_Click);
            // 
            // FormGameSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 133);
            this.Controls.Add(this.m_ButtonStart);
            this.Controls.Add(this.m_ButtonChancesNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormGameSettings";
            this.Text = "Bool Pgia";
            this.Load += new System.EventHandler(this.FormGameSettings_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_ButtonChancesNumber;
        private System.Windows.Forms.Button m_ButtonStart;
    }
}