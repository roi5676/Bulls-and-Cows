using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A22_Ex05
{
    public partial class FormColorPick : Form
    {
        private BoardButton m_ButtonSelected;

        public FormColorPick()
        {
            InitializeComponent();
        }

        public BoardButton ButtonSelected
        {
            set { m_ButtonSelected = value; }
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (!m_ButtonSelected.BackColor.Name.Equals("Control")) 
            {
                foreach (Control control in Controls)
                {
                    Button b = control as Button;
                    if (b.BackColor.Equals(m_ButtonSelected.BackColor)) 
                    {
                        b.Enabled = true;
                    }
                }
            }

            m_ButtonSelected.BackColor = button.BackColor;
            button.Enabled = false;
            this.Close();
        }
    }
}