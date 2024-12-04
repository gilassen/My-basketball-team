namespace new_project1
{
    partial class Coach
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
            this.DeletePlayer = new System.Windows.Forms.Button();
            this.ChangeCoach = new System.Windows.Forms.Button();
            this.ListPlayerS = new System.Windows.Forms.DataGridView();
            this.ListPlayerC = new System.Windows.Forms.DataGridView();
            this.IdC = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ListPlayerS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListPlayerC)).BeginInit();
            this.SuspendLayout();
            // 
            // DeletePlayer
            // 
            this.DeletePlayer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.DeletePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.DeletePlayer.Location = new System.Drawing.Point(439, 381);
            this.DeletePlayer.Name = "DeletePlayer";
            this.DeletePlayer.Size = new System.Drawing.Size(182, 59);
            this.DeletePlayer.TabIndex = 0;
            this.DeletePlayer.Text = "DeletePlayer";
            this.DeletePlayer.UseVisualStyleBackColor = false;
            this.DeletePlayer.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChangeCoach
            // 
            this.ChangeCoach.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ChangeCoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ChangeCoach.Location = new System.Drawing.Point(122, 377);
            this.ChangeCoach.Name = "ChangeCoach";
            this.ChangeCoach.Size = new System.Drawing.Size(182, 61);
            this.ChangeCoach.TabIndex = 1;
            this.ChangeCoach.Text = "ChangeCoach";
            this.ChangeCoach.UseVisualStyleBackColor = false;
            this.ChangeCoach.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListPlayerS
            // 
            this.ListPlayerS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListPlayerS.Location = new System.Drawing.Point(43, 48);
            this.ListPlayerS.Name = "ListPlayerS";
            this.ListPlayerS.RowHeadersWidth = 62;
            this.ListPlayerS.RowTemplate.Height = 28;
            this.ListPlayerS.Size = new System.Drawing.Size(753, 131);
            this.ListPlayerS.TabIndex = 3;
            this.ListPlayerS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListPlayerS_CellContentClick);
            // 
            // ListPlayerC
            // 
            this.ListPlayerC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListPlayerC.Location = new System.Drawing.Point(43, 240);
            this.ListPlayerC.Name = "ListPlayerC";
            this.ListPlayerC.RowHeadersWidth = 62;
            this.ListPlayerC.RowTemplate.Height = 28;
            this.ListPlayerC.Size = new System.Drawing.Size(753, 131);
            this.ListPlayerC.TabIndex = 4;
            // 
            // IdC
            // 
            this.IdC.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.IdC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IdC.Location = new System.Drawing.Point(627, 419);
            this.IdC.Name = "IdC";
            this.IdC.Size = new System.Drawing.Size(154, 19);
            this.IdC.TabIndex = 5;
            this.IdC.TextChanged += new System.EventHandler(this.IdC_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox1.Location = new System.Drawing.Point(627, 379);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 30);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "enter id:";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox2.Location = new System.Drawing.Point(43, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(217, 39);
            this.textBox2.TabIndex = 17;
            this.textBox2.Text = "shooter players :";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox3.Location = new System.Drawing.Point(43, 195);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(217, 39);
            this.textBox3.TabIndex = 18;
            this.textBox3.Text = "center players :";
            // 
            // Coach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::new_project1.Properties.Resources.basketball;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(835, 443);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.IdC);
            this.Controls.Add(this.ListPlayerC);
            this.Controls.Add(this.ListPlayerS);
            this.Controls.Add(this.ChangeCoach);
            this.Controls.Add(this.DeletePlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Coach";
            this.Text = "Coach";
            this.Load += new System.EventHandler(this.Coach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListPlayerS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListPlayerC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeletePlayer;
        private System.Windows.Forms.Button ChangeCoach;
        private System.Windows.Forms.DataGridView ListPlayerS;
        private System.Windows.Forms.DataGridView ListPlayerC;
        private System.Windows.Forms.TextBox IdC;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}