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
    public partial class FormGameBoard : Form
    {
        private LogicUnit m_LogicUnit;
        private FormColorPick m_CurrentFormColor;

        public FormGameBoard(int io_BoardSize)
        {
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowOnly;
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += FormGameBoard_FormClosing;
            InitializeComponent();
            InitializeComponent(io_BoardSize);
        }

        private void InitializeComponent(int io_BoardSize)
        {
            m_LogicUnit = new LogicUnit();
            m_LogicUnit.InitGameBoard(io_BoardSize);
            initializeBlackLine();
            initializePins(io_BoardSize);
            initializeResults(io_BoardSize);
            startGame();
        }

        private void startGame()
        {
            m_LogicUnit.EnableLine();
            m_LogicUnit.GenerateRandomSequence();
            m_CurrentFormColor = new FormColorPick();
            m_CurrentFormColor.StartPosition = FormStartPosition.CenterScreen;
        }

        private void initializeBlackLine()
        {
            for (int i = 0; i < 4; i++)
            {
                BoardButton boardBtn = new BoardButton();
                boardBtn.Width = 50;
                boardBtn.Height = 50;
                boardBtn.Location = new Point((50 * i) + (10 * (i + 1)), 10);
                boardBtn.Text = string.Empty;
                boardBtn.Row = 0;
                boardBtn.Col = i;
                boardBtn.Click += boardBtn_Clicked;
                boardBtn.TabStop = false;
                boardBtn.BackColor = Color.Black;
                boardBtn.Enabled = false;
                this.Controls.Add(boardBtn);
                m_LogicUnit.Board.SetPins(boardBtn);
            }
        }

        private void initializePins(int i_BoardSize)
        {
            for (int i = 1; i <= i_BoardSize; i++)
            {
                int j = 0;
                for (; j < 4; j++)
                {
                    BoardButton boardBtn = new BoardButton();
                    boardBtn.Width = 50;
                    boardBtn.Height = 50;
                    boardBtn.Location = new Point((50 * j) + (10 * (j + 1)), 15 + (50 * i) + (10 * (i + 1)));
                    boardBtn.Text = string.Empty;
                    boardBtn.Row = i;
                    boardBtn.Col = j;
                    boardBtn.Click += boardBtn_Clicked;
                    boardBtn.TabStop = false;
                    boardBtn.Enabled = false;
                    m_LogicUnit.Board.SetPins(boardBtn);
                    this.Controls.Add(boardBtn);
                }

                BoardButton arrowBtn = new BoardButton();
                arrowBtn.Width = 55;
                arrowBtn.Height = 20;
                arrowBtn.Location = new Point((50 * j) + (10 * (j + 1)), 30 + (50 * i) + (10 * (i + 1)));
                arrowBtn.Text = "-->>";
                arrowBtn.Row = i;
                arrowBtn.Col = j;
                arrowBtn.TabStop = false;
                arrowBtn.Enabled = false;
                arrowBtn.Click += arrowBtn_Clicked;
                m_LogicUnit.Board.SetArrow(arrowBtn);
                this.Controls.Add(arrowBtn);
            }
        }

        private void initializeResults(int i_BoardSize)
        {
            for (int i = 1; i <= i_BoardSize; i++)
            {
                BoardButton boardBtn = new BoardButton();
                boardBtn.Width = 20;
                boardBtn.Height = 20;
                boardBtn.Location = new Point(320, 15 + (50 * i) + (10 * (i + 1)));
                boardBtn.Text = string.Empty;
                boardBtn.Row = i;
                boardBtn.Col = 0;
                boardBtn.TabStop = false;
                boardBtn.Enabled = false;
                m_LogicUnit.Board.SetResult(boardBtn);
                this.Controls.Add(boardBtn);

                boardBtn = new BoardButton();
                boardBtn.Width = 20;
                boardBtn.Height = 20;
                boardBtn.Location = new Point(350, 15 + (50 * i) + (10 * (i + 1)));
                boardBtn.Text = string.Empty;
                boardBtn.Row = i;
                boardBtn.Col = 1;
                boardBtn.TabStop = false;
                boardBtn.Enabled = false;
                m_LogicUnit.Board.SetResult(boardBtn);
                this.Controls.Add(boardBtn);

                boardBtn = new BoardButton();
                boardBtn.Width = 20;
                boardBtn.Height = 20;
                boardBtn.Location = new Point(320, 45 + (50 * i) + (10 * (i + 1)));
                boardBtn.Text = string.Empty;
                boardBtn.Row = i;
                boardBtn.Col = 2;
                boardBtn.TabStop = false;
                boardBtn.Enabled = false;
                m_LogicUnit.Board.SetResult(boardBtn);
                this.Controls.Add(boardBtn);

                boardBtn = new BoardButton();
                boardBtn.Width = 20;
                boardBtn.Height = 20;
                boardBtn.Location = new Point(350, 45 + (50 * i) + (10 * (i + 1)));
                boardBtn.Text = string.Empty;
                boardBtn.Row = i;
                boardBtn.Col = 3;
                boardBtn.TabStop = false;
                boardBtn.Enabled = false;
                m_LogicUnit.Board.SetResult(boardBtn);
                this.Controls.Add(boardBtn);
            }
        }

        private void arrowBtn_Clicked(object sender, EventArgs e)
        {
            m_LogicUnit.DisableLine();
            m_LogicUnit.DrawMatchedGuesses();
            m_LogicUnit.NextStep();

            if (m_LogicUnit.IsEndGame()) 
            {
                m_LogicUnit.DrawRandomSequence();
                endGameMessage();
            }

            m_CurrentFormColor = new FormColorPick();
            m_CurrentFormColor.StartPosition = FormStartPosition.CenterScreen;
            m_LogicUnit.EnableLine();
        }

        private void endGameMessage()
        {
            string statusGame = m_LogicUnit.IsWin ? "win" : "lose";
            string message = string.Format("You {0} ! ,Do you want to start a new game?", statusGame);
            string title = "EndGame Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void boardBtn_Clicked(object sender, EventArgs e)
        {
            BoardButton button = sender as BoardButton;
            m_CurrentFormColor.ButtonSelected = button;
            m_CurrentFormColor.ShowDialog();

            if (!button.BackColor.Name.Equals("Control"))
            {
                button.Clicked = true;
            }

            if (m_LogicUnit.CheckAllLineClicked())
            {
                m_LogicUnit.EnableArrow();
            }
        }

        private void FormGameBoard_Load(object sender, EventArgs e)
        {
        }

        private void FormGameBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                string message = "Are you sure you want to exit the game?";
                string title = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.OK)
                {
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
