using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A22_Ex05
{
    public class BoardButton : Button
    {
        private int m_BtnRow;
        private int m_BtnCol;
        private bool m_BtnClicked = false;

        public bool Clicked
        {
            get
            {
                return m_BtnClicked;
            }

            set
            {
                m_BtnClicked = value;
            }
        }

        public int Row
        {
            get
            {
                return m_BtnRow;
            }

            set
            {
                m_BtnRow = value;
            }
        }

        public int Col
        {
            get
            {
                return m_BtnCol;
            }

            set
            {
                m_BtnCol = value;
            }
        }
    }
}
