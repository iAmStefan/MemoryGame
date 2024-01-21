namespace MemoryGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.close = new System.Windows.Forms.Label();
            this.startGame = new System.Windows.Forms.Button();
            this.ceas = new System.Windows.Forms.Timer(this.components);
            this.timp = new System.Windows.Forms.Label();
            this.wait = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(848, -1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(23, 23);
            this.close.TabIndex = 0;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // startGame
            // 
            this.startGame.Location = new System.Drawing.Point(361, 143);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(88, 35);
            this.startGame.TabIndex = 1;
            this.startGame.Text = "Incepe jocul";
            this.startGame.UseVisualStyleBackColor = true;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // ceas
            // 
            this.ceas.Interval = 1000;
            this.ceas.Tick += new System.EventHandler(this.ceas_Tick);
            // 
            // timp
            // 
            this.timp.AutoSize = true;
            this.timp.Location = new System.Drawing.Point(16, 15);
            this.timp.Name = "timp";
            this.timp.Size = new System.Drawing.Size(0, 13);
            this.timp.TabIndex = 2;
            // 
            // wait
            // 
            this.wait.Interval = 800;
            this.wait.Tick += new System.EventHandler(this.wait_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 400);
            this.Controls.Add(this.timp);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.Timer ceas;
        private System.Windows.Forms.Label timp;
        private System.Windows.Forms.Timer wait;
    }
}

