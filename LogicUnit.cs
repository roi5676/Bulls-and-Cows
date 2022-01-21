using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace A22_Ex05
{
    public class LogicUnit
    {
        private const int k_NumberOfColsBoard = 4;
        private int m_RowButtonClicked = 0;
        private Random m_rand = new Random();
        private Board m_GameBoard;
        private List<int> m_RandomSequence;
        private int m_CurrentStep = 1;
        private bool m_IsWin = false;
        private int m_NumberOfGuesses;
        private Dictionary<Color, eColorType> m_ColorConvert = new Dictionary<Color, eColorType>();

        public LogicUnit()
        {
            m_ColorConvert.Add(Color.Blue, eColorType.Blue);
            m_ColorConvert.Add(Color.Brown, eColorType.Brown);
            m_ColorConvert.Add(Color.Aqua, eColorType.Aqua);
            m_ColorConvert.Add(Color.Lime, eColorType.Lime);
            m_ColorConvert.Add(Color.Purple, eColorType.Purple);
            m_ColorConvert.Add(Color.Red, eColorType.Red);
            m_ColorConvert.Add(Color.White, eColorType.White);
            m_ColorConvert.Add(Color.Yellow, eColorType.Yellow);
        }

        public bool IsWin
        {
            get { return m_IsWin; }
        }

        public int RowButtonClicked
        {
            get { return m_RowButtonClicked;  }
            set { m_RowButtonClicked = value; }
        }

        public Board Board
        {
            get { return m_GameBoard; }
        }

        public int CurrentStep
        {
            get { return m_CurrentStep; }
        }

        public void InitGameBoard(int i_BoardSize)
        {
            m_NumberOfGuesses = i_BoardSize;
            m_GameBoard = new Board(i_BoardSize + 1);
        }

        public void NextStep()
        {
            m_CurrentStep++;
        }

        public void EnableLine()
        {
            for (int i = 0; i < k_NumberOfColsBoard; i++)
            {
                m_GameBoard.GetPin(m_CurrentStep, i).Enabled = true;
            }
        }

        public void DisableLine()
        {
            for (int i = 0; i < k_NumberOfColsBoard; i++)
            {
                m_GameBoard.GetPin(m_CurrentStep, i).Enabled = false;
            }

            m_GameBoard.GetArrow(m_CurrentStep).Enabled = false;
        }

        public void EnableArrow()
        {
            m_GameBoard.GetArrow(m_CurrentStep).Enabled = true;
        }
        
        public void GenerateRandomSequence()
        {
            List<int> possible = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7 };
            m_RandomSequence = new List<int>();

            for (int i = 0; i < k_NumberOfColsBoard; ++i)
            {
                int index = m_rand.Next(0, possible.Count);
                m_RandomSequence.Add(possible[index]);
                possible.RemoveAt(index);
            }
        }

        public bool CheckAllLineClicked()
        {
            int count = 0;

            for (int i = 0; i < k_NumberOfColsBoard; i++)
            {
                if (m_GameBoard.GetPin(m_CurrentStep, i).Clicked)
                {
                    count++;
                }
            }

            return count == 4;
        }

        public int DrawMatchedGuesses()
        {
            int countV = 0;
            int countX = 0;
            List<int> playerGuess = convertPlayerGuess(); 

            for (int i = 0; i < k_NumberOfColsBoard; ++i)
            {
                if (m_RandomSequence.Contains(playerGuess[i]))
                {
                    if (m_RandomSequence.IndexOf(playerGuess[i]) == i)
                    {
                        countV++;
                    }
                    else
                    {
                        countX++;
                    }
                }
            }

            checkWin(countV);
            drawResults(countV, countX);
            return countV;
        }

        public void DrawRandomSequence()
        {
            for (int i = 0; i < k_NumberOfColsBoard; i++)
            {
                m_GameBoard.GetPin(0, i).BackColor = Color.FromName(((eColorType)m_RandomSequence[i]).ToString());
            }
        }

        private void checkWin(int i_CountV)
        {
            if (i_CountV == 4)
            {
                m_IsWin = true;
            }
        }

        public bool IsEndGame()
        {
            return m_CurrentStep > m_NumberOfGuesses || m_IsWin == true;
        }

        private void drawResults(int i_CountV, int i_CountX)
        {
            int i = 0;
            for (; i < i_CountV; i++)
            {
                m_GameBoard.GetResult(m_CurrentStep, i).BackColor = Color.Black;
            }

            for (; i < i_CountX + i_CountV; i++)
            {
                m_GameBoard.GetResult(m_CurrentStep, i).BackColor = Color.Yellow;
            }
        }

        private List<int> convertPlayerGuess()
        {
            List<int> playerGuess = new List<int>();
            int indexGuess;

            for (int i = 0; i < k_NumberOfColsBoard; i++)
            {
                indexGuess = (int)m_ColorConvert[m_GameBoard.GetPin(m_CurrentStep, i).BackColor];
                playerGuess.Add(indexGuess);
            }

            return playerGuess;
        }
    }
}