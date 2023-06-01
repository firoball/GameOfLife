using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Generation
    {
        private bool[,] m_cells;

        public Generation(int sizeX, int sizeY)
        {
            m_cells = new bool[sizeX, sizeY];
            for (int x = 0; x < SizeX; x++)
            {
                for (int y = 0; y < SizeY; y++)
                {
                    m_cells[x,y] = false;
                }
            }
        }

        public Generation(Generation old) : this(old.SizeX, old.SizeY) { }

        public Generation() : this(50, 50) { }

        public int SizeX
        {
            get
            {
                return m_cells.GetLength(0);
            }
        }

        public int SizeY
        {
            get
            {
                return m_cells.GetLength(1);
            }
        }

        public bool this [int x, int y]
        {
            set
            {
                m_cells[x, y] = value;
            }
            get
            {
                return m_cells[x, y];
            }
        }

        public void Populate()
        {
            Random rnd = new Random();
            for (int x = 0; x < SizeX; x++)
            {
                for (int y = 0; y < SizeY; y++)
                {
                    m_cells[x, y] = rnd.NextDouble() >= 0.5;
                }
            }

        }

        public int Neighbours(int x, int y)
        {
            int lastY = SizeY - 1;
            int lastX = SizeX - 1;

            int upperY = y == 0 ? lastY : y - 1;
            int lowerY = y == lastY ? 0 : y + 1;
            int leftX = x == 0 ? lastX : x - 1;
            int rightX = x == lastX ? 0 : x + 1;

            int neighbours = 0;
            if (m_cells[leftX, upperY]) neighbours++;
            if (m_cells[x, upperY]) neighbours++;
            if (m_cells[rightX, upperY]) neighbours++;
            if (m_cells[leftX, y]) neighbours++;
            if (m_cells[rightX, y]) neighbours++;
            if (m_cells[leftX, lowerY]) neighbours++;
            if (m_cells[x, lowerY]) neighbours++;
            if (m_cells[rightX, lowerY]) neighbours++;

            return neighbours;
        }

    }
}
