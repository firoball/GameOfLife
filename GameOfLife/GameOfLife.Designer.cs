namespace GameOfLife
{
    partial class GameOfLife
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Progress = new System.Windows.Forms.Button();
            this.Playfield = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Playfield)).BeginInit();
            this.SuspendLayout();
            // 
            // Progress
            // 
            this.Progress.Location = new System.Drawing.Point(10, 270);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(75, 23);
            this.Progress.TabIndex = 0;
            this.Progress.Text = "&Progress";
            this.Progress.UseVisualStyleBackColor = true;
            this.Progress.Visible = false;
            this.Progress.Click += new System.EventHandler(this.Progress_Click);
            // 
            // Playfield
            // 
            this.Playfield.BackColor = System.Drawing.Color.White;
            this.Playfield.Location = new System.Drawing.Point(10, 10);
            this.Playfield.Name = "Playfield";
            this.Playfield.Size = new System.Drawing.Size(250, 250);
            this.Playfield.TabIndex = 1;
            this.Playfield.TabStop = false;
            this.Playfield.Paint += new System.Windows.Forms.PaintEventHandler(this.Playfield_Paint);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(185, 270);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "E&xit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(98, 270);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 3;
            this.Start.Text = "&Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // GameOfLife
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 301);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Playfield);
            this.Controls.Add(this.Progress);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GameOfLife";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game of Life";
            this.Load += new System.EventHandler(this.GameOfLife_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Playfield)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Progress;
        private System.Windows.Forms.PictureBox Playfield;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Timer Timer;
    }
}

