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
    public partial class FormGameSettings : Form
    {
        private const int k_MinCounter = 4;
        private const int k_MaxCounter = 10;
        private const string k_ChanceCounterText = "Number of chances: ";
        private int m_ChanceCounter = 4;

        public FormGameSettings()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            FormClosing += FormGameSettings_FormClosing;
            m_ButtonChancesNumber.Text = k_ChanceCounterText + m_ChanceCounter.ToString();
        }

        private void FormGameSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                string message = "Are you sure you want to exit the game?";
                string title = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.OK)
                {
                    Application.Exit();
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        public static void StartGame()
        {
            FormGameSettings game = new FormGameSettings();
            game.ShowDialog();
        }

        private void FormGameSettings_Load(object sender, EventArgs e)
        {
        }

        private void m_ButtonStart_Click(object sender, EventArgs e)
        {
            new FormGameBoard(m_ChanceCounter).ShowDialog();
        }

        private void m_ButtonChancesNumber_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            m_ChanceCounter++;
            if (m_ChanceCounter > k_MaxCounter)
            {
                m_ChanceCounter = k_MinCounter;
            }

            button.Text = k_ChanceCounterText + m_ChanceCounter.ToString();
        }
    }
}
