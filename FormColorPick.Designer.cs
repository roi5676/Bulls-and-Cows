namespace A22_Ex05
{
    partial class FormColorPick
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
            this.m_PurpleButten = new System.Windows.Forms.Button();
            this.m_RedButten = new System.Windows.Forms.Button();
            this.m_LimeButten = new System.Windows.Forms.Button();
            this.m_AquaButten = new System.Windows.Forms.Button();
            this.m_BlueButten = new System.Windows.Forms.Button();
            this.m_YellowButten = new System.Windows.Forms.Button();
            this.m_BrownButten = new System.Windows.Forms.Button();
            this.m_WhiteButten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_PurpleButten
            // 
            this.m_PurpleButten.BackColor = System.Drawing.Color.Purple;
            this.m_PurpleButten.Location = new System.Drawing.Point(12, 12);
            this.m_PurpleButten.Name = "m_PurpleButten";
            this.m_PurpleButten.Size = new System.Drawing.Size(60, 60);
            this.m_PurpleButten.TabIndex = 0;
            this.m_PurpleButten.UseVisualStyleBackColor = false;
            this.m_PurpleButten.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // m_RedButten
            // 
            this.m_RedButten.BackColor = System.Drawing.Color.Red;
            this.m_RedButten.Location = new System.Drawing.Point(100, 12);
            this.m_RedButten.Name = "m_RedButten";
            this.m_RedButten.Size = new System.Drawing.Size(60, 60);
            this.m_RedButten.TabIndex = 1;
            this.m_RedButten.UseVisualStyleBackColor = false;
            this.m_RedButten.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // m_LimeButten
            // 
            this.m_LimeButten.BackColor = System.Drawing.Color.Lime;
            this.m_LimeButten.Location = new System.Drawing.Point(190, 12);
            this.m_LimeButten.Name = "m_LimeButten";
            this.m_LimeButten.Size = new System.Drawing.Size(60, 60);
            this.m_LimeButten.TabIndex = 2;
            this.m_LimeButten.UseVisualStyleBackColor = false;
            this.m_LimeButten.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // m_AquaButten
            // 
            this.m_AquaButten.BackColor = System.Drawing.Color.Aqua;
            this.m_AquaButten.Location = new System.Drawing.Point(278, 12);
            this.m_AquaButten.Name = "m_AquaButten";
            this.m_AquaButten.Size = new System.Drawing.Size(60, 60);
            this.m_AquaButten.TabIndex = 3;
            this.m_AquaButten.UseVisualStyleBackColor = false;
            this.m_AquaButten.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // m_BlueButten
            // 
            this.m_BlueButten.BackColor = System.Drawing.Color.Blue;
            this.m_BlueButten.Location = new System.Drawing.Point(12, 92);
            this.m_BlueButten.Name = "m_BlueButten";
            this.m_BlueButten.Size = new System.Drawing.Size(60, 60);
            this.m_BlueButten.TabIndex = 4;
            this.m_BlueButten.UseVisualStyleBackColor = false;
            this.m_BlueButten.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // m_YellowButten
            // 
            this.m_YellowButten.BackColor = System.Drawing.Color.Yellow;
            this.m_YellowButten.Location = new System.Drawing.Point(100, 92);
            this.m_YellowButten.Name = "m_YellowButten";
            this.m_YellowButten.Size = new System.Drawing.Size(60, 60);
            this.m_YellowButten.TabIndex = 5;
            this.m_YellowButten.UseVisualStyleBackColor = false;
            this.m_YellowButten.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // m_BrownButten
            // 
            this.m_BrownButten.BackColor = System.Drawing.Color.Brown;
            this.m_BrownButten.Location = new System.Drawing.Point(190, 92);
            this.m_BrownButten.Name = "m_BrownButten";
            this.m_BrownButten.Size = new System.Drawing.Size(60, 60);
            this.m_BrownButten.TabIndex = 6;
            this.m_BrownButten.UseVisualStyleBackColor = false;
            this.m_BrownButten.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // m_WhiteButten
            // 
            this.m_WhiteButten.BackColor = System.Drawing.Color.White;
            this.m_WhiteButten.Location = new System.Drawing.Point(278, 92);
            this.m_WhiteButten.Name = "m_WhiteButten";
            this.m_WhiteButten.Size = new System.Drawing.Size(60, 60);
            this.m_WhiteButten.TabIndex = 7;
            this.m_WhiteButten.UseVisualStyleBackColor = false;
            this.m_WhiteButten.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // FormColorPick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 173);
            this.Controls.Add(this.m_WhiteButten);
            this.Controls.Add(this.m_BrownButten);
            this.Controls.Add(this.m_YellowButten);
            this.Controls.Add(this.m_BlueButten);
            this.Controls.Add(this.m_AquaButten);
            this.Controls.Add(this.m_LimeButten);
            this.Controls.Add(this.m_RedButten);
            this.Controls.Add(this.m_PurpleButten);
            this.Name = "FormColorPick";
            this.Text = "FormColorPick";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_PurpleButten;
        private System.Windows.Forms.Button m_RedButten;
        private System.Windows.Forms.Button m_LimeButten;
        private System.Windows.Forms.Button m_AquaButten;
        private System.Windows.Forms.Button m_BlueButten;
        private System.Windows.Forms.Button m_YellowButten;
        private System.Windows.Forms.Button m_BrownButten;
        private System.Windows.Forms.Button m_WhiteButten;
    }
}