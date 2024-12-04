namespace new_project1
{
    partial class CreateCoach
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
            this.ADD = new System.Windows.Forms.Button();
            this.seniorityh = new System.Windows.Forms.TextBox();
            this.nameh = new System.Windows.Forms.TextBox();
            this.idh = new System.Windows.Forms.TextBox();
            this.cittizenshiph = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.text = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Coach1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Coach1)).BeginInit();
            this.SuspendLayout();
            // 
            // ADD
            // 
            this.ADD.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ADD.Location = new System.Drawing.Point(316, 380);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(115, 58);
            this.ADD.TabIndex = 14;
            this.ADD.Text = "UPDATE";
            this.ADD.UseVisualStyleBackColor = false;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // seniorityh
            // 
            this.seniorityh.Location = new System.Drawing.Point(647, 329);
            this.seniorityh.Name = "seniorityh";
            this.seniorityh.Size = new System.Drawing.Size(141, 26);
            this.seniorityh.TabIndex = 11;
            // 
            // nameh
            // 
            this.nameh.Location = new System.Drawing.Point(173, 323);
            this.nameh.Name = "nameh";
            this.nameh.Size = new System.Drawing.Size(141, 26);
            this.nameh.TabIndex = 10;
            this.nameh.TextChanged += new System.EventHandler(this.nameh_TextChanged);
            // 
            // idh
            // 
            this.idh.Location = new System.Drawing.Point(173, 265);
            this.idh.Name = "idh";
            this.idh.Size = new System.Drawing.Size(141, 26);
            this.idh.TabIndex = 9;
            this.idh.TextChanged += new System.EventHandler(this.idh_TextChanged);
            // 
            // cittizenshiph
            // 
            this.cittizenshiph.Location = new System.Drawing.Point(647, 269);
            this.cittizenshiph.Name = "cittizenshiph";
            this.cittizenshiph.Size = new System.Drawing.Size(141, 26);
            this.cittizenshiph.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox1.Location = new System.Drawing.Point(176, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(436, 48);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "enter details of new Coach";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // text
            // 
            this.text.BackColor = System.Drawing.Color.Yellow;
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.text.Location = new System.Drawing.Point(10, 258);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(97, 35);
            this.text.TabIndex = 17;
            this.text.Text = "enter id:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Yellow;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox2.Location = new System.Drawing.Point(10, 316);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(138, 35);
            this.textBox2.TabIndex = 18;
            this.textBox2.Text = "enter name:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Yellow;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox3.Location = new System.Drawing.Point(417, 260);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(195, 35);
            this.textBox3.TabIndex = 19;
            this.textBox3.Text = "enter cittizenship:";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Yellow;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox4.Location = new System.Drawing.Point(417, 320);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(195, 35);
            this.textBox4.TabIndex = 20;
            this.textBox4.Text = "enter seniority:";
            // 
            // Coach1
            // 
            this.Coach1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Coach1.Location = new System.Drawing.Point(12, 101);
            this.Coach1.Name = "Coach1";
            this.Coach1.RowHeadersWidth = 62;
            this.Coach1.RowTemplate.Height = 28;
            this.Coach1.Size = new System.Drawing.Size(776, 93);
            this.Coach1.TabIndex = 22;
            this.Coach1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // CreateCoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::new_project1.Properties.Resources.כדורסל_מכבי_תל_אביב1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Coach1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.text);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cittizenshiph);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.seniorityh);
            this.Controls.Add(this.nameh);
            this.Controls.Add(this.idh);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateCoach";
            this.Text = "CreateCoach";
            this.Load += new System.EventHandler(this.CreateCoach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Coach1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.TextBox seniorityh;
        private System.Windows.Forms.TextBox nameh;
        private System.Windows.Forms.TextBox idh;
        private System.Windows.Forms.TextBox cittizenshiph;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView Coach1;
    }
}