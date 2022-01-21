using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace A22_Ex05
{
    public class Board
    {
        private readonly BoardButton[,] r_Pins;
        private readonly BoardButton[,] r_Results;
        private readonly BoardButton[] r_Arrows;
        
        public Board(int i_MatrixLength)
        {
            r_Pins = new BoardButton[i_MatrixLength, 4];
            r_Results = new BoardButton[i_MatrixLength, 4];
            r_Arrows = new BoardButton[i_MatrixLength];
        }

        public void SetPins(BoardButton i_BoardBtn)
        {
            r_Pins[i_BoardBtn.Row, i_BoardBtn.Col] = i_BoardBtn;
        }

        public void SetResult(BoardButton i_BoardBtn)
        {
            r_Results[i_BoardBtn.Row, i_BoardBtn.Col] = i_BoardBtn;
        }

        public BoardButton GetResult(int i_Row, int i_Col)
        {
            return r_Results[i_Row, i_Col];
        }

        public BoardButton GetPin(int i_Row, int i_Col)
        {
            return r_Pins[i_Row, i_Col];
        }

        public void SetArrow(BoardButton i_ArrowBtn)
        {
            r_Arrows[i_ArrowBtn.Row] = i_ArrowBtn;
        }

        public BoardButton GetArrow(int i_Row)
        {
            return r_Arrows[i_Row];
        }
    }
}
