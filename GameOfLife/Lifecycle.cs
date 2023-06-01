using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Lifecycle
    {
        private Generation m_current;

        public Lifecycle()
        {
            m_current = new Generation();
            m_current.Populate();
        }

        public Generation Current { get => m_current; }

        public void Evolve()
        {
            Generation next = new Generation(m_current);

            for (int x = 0; x < m_current.SizeX; x++)
            {
                for (int y = 0; y < m_current.SizeY; y++)
                {
                    next[x, y] = ApplyRules(x, y);
                }
            }

            m_current = next;
        }

        private bool ApplyRules(int x, int y)
        {
            bool next;
            int neighbours = m_current.Neighbours(x, y);

            if (m_current[x, y])
            {
                if (neighbours < 2 || neighbours > 3)
                    next = false;
                else
                    next = true;
            }
            else
            {
                if (neighbours == 3)
                    next = true;
                else
                    next = false;
            }

            return next;
        }

    }

}
