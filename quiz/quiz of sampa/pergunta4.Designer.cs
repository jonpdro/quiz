namespace quiz_of_sampa
{
    partial class pergunta4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pergunta4));
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.Button2.Location = new System.Drawing.Point(474, 207);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(178, 68);
            this.Button2.TabIndex = 24;
            this.Button2.Text = "c) Verdadeiro";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.Button1.Location = new System.Drawing.Point(122, 207);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(178, 68);
            this.Button1.TabIndex = 23;
            this.Button1.Text = "a) Falso";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.DarkRed;
            this.Label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(104, 43);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(539, 32);
            this.Label1.TabIndex = 22;
            this.Label1.Text = "A torre Eiffel tem o mesmo nome de seu criador?";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Button4
            // 
            this.Button4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.Button4.Location = new System.Drawing.Point(474, 358);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(178, 68);
            this.Button4.TabIndex = 26;
            this.Button4.Text = "d) N.D.A";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(122, 358);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 68);
            this.button3.TabIndex = 25;
            this.button3.Text = "b) Talvez";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pergunta4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(787, 545);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label1);
            this.Name = "pergunta4";
            this.Text = "pergunta4";
            this.Load += new System.EventHandler(this.pergunta4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.Button button3;
    }
}