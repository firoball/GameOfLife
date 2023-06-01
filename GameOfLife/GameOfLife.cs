using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class GameOfLife : Form
    {
        private Lifecycle m_cycle;
        public GameOfLife()
        {
            InitializeComponent();
        }

        private void GameOfLife_Load(object sender, EventArgs e)
        {
            m_cycle = new Lifecycle();
            Refresh();
        }

        private void Progress_Click(object sender, EventArgs e)
        {
            m_cycle.Evolve();
            Refresh();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            m_cycle = new Lifecycle();
            Timer.Start();
            Refresh();
        }

        private void Playfield_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Generation generation = m_cycle.Current;
            Brush brush = new SolidBrush(Color.Green);
            Rectangle rect = e.ClipRectangle;
            int factorX = rect.Width / generation.SizeX;
            int factorY = rect.Height / generation.SizeY;

            for (int x = 0; x < generation.SizeX; x++)
            {
                for (int y = 0; y < generation.SizeY; y++)
                {
                    if (generation[x,y])
                    {
                        Rectangle cell = new Rectangle(x * factorX, y * factorY, factorX, factorY);
                        graphics.FillRectangle(brush, cell);
                    }
                }
            }

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            m_cycle.Evolve();
            Refresh();
        }

    }
}
