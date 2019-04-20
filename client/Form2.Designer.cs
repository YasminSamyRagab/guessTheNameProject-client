namespace client
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Player1lbl = new System.Windows.Forms.Label();
            this.Player2lbl = new System.Windows.Forms.Label();
            this.pl1 = new System.Windows.Forms.Label();
            this.pl2 = new System.Windows.Forms.Label();
            this.roomname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(322, 309);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 163);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // Player1lbl
            // 
            this.Player1lbl.AutoSize = true;
            this.Player1lbl.Font = new System.Drawing.Font("Ravie", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1lbl.Location = new System.Drawing.Point(31, 13);
            this.Player1lbl.Name = "Player1lbl";
            this.Player1lbl.Size = new System.Drawing.Size(31, 21);
            this.Player1lbl.TabIndex = 7;
            this.Player1lbl.Text = "P1";
            // 
            // Player2lbl
            // 
            this.Player2lbl.AutoSize = true;
            this.Player2lbl.Font = new System.Drawing.Font("Ravie", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2lbl.Location = new System.Drawing.Point(1071, 13);
            this.Player2lbl.Name = "Player2lbl";
            this.Player2lbl.Size = new System.Drawing.Size(35, 21);
            this.Player2lbl.TabIndex = 8;
            this.Player2lbl.Text = "P2";
            // 
            // pl1
            // 
            this.pl1.AutoSize = true;
            this.pl1.Font = new System.Drawing.Font("Ravie", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pl1.Location = new System.Drawing.Point(31, 54);
            this.pl1.Name = "pl1";
            this.pl1.Size = new System.Drawing.Size(96, 21);
            this.pl1.TabIndex = 9;
            this.pl1.Text = "Playing..";
            // 
            // pl2
            // 
            this.pl2.AutoSize = true;
            this.pl2.Font = new System.Drawing.Font("Ravie", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pl2.Location = new System.Drawing.Point(1060, 54);
            this.pl2.Name = "pl2";
            this.pl2.Size = new System.Drawing.Size(90, 21);
            this.pl2.TabIndex = 10;
            this.pl2.Text = "Waiting";
            // 
            // roomname
            // 
            this.roomname.AutoSize = true;
            this.roomname.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomname.Location = new System.Drawing.Point(506, 13);
            this.roomname.Name = "roomname";
            this.roomname.Size = new System.Drawing.Size(79, 18);
            this.roomname.TabIndex = 11;
            this.roomname.Text = "roomname";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1290, 522);
            this.Controls.Add(this.roomname);
            this.Controls.Add(this.pl2);
            this.Controls.Add(this.pl1);
            this.Controls.Add(this.Player2lbl);
            this.Controls.Add(this.Player1lbl);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Player1lbl;
        private System.Windows.Forms.Label Player2lbl;
        private System.Windows.Forms.Label pl1;
        private System.Windows.Forms.Label pl2;
        private System.Windows.Forms.Label roomname;
    }
}