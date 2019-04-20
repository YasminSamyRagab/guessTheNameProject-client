namespace client
{
    partial class Spectate
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
            this.Player1lbl = new System.Windows.Forms.Label();
            this.Player2lbl = new System.Windows.Forms.Label();
            this.Stat1lbl = new System.Windows.Forms.Label();
            this.Stat2lbl = new System.Windows.Forms.Label();
            this.word_label = new System.Windows.Forms.Label();
            this.action = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Player1lbl
            // 
            this.Player1lbl.AutoSize = true;
            this.Player1lbl.Font = new System.Drawing.Font("Ravie", 9.75F);
            this.Player1lbl.Location = new System.Drawing.Point(12, 17);
            this.Player1lbl.Name = "Player1lbl";
            this.Player1lbl.Size = new System.Drawing.Size(33, 22);
            this.Player1lbl.TabIndex = 0;
            this.Player1lbl.Text = "P1";
            // 
            // Player2lbl
            // 
            this.Player2lbl.AutoSize = true;
            this.Player2lbl.Font = new System.Drawing.Font("Ravie", 9.75F);
            this.Player2lbl.Location = new System.Drawing.Point(833, 17);
            this.Player2lbl.Name = "Player2lbl";
            this.Player2lbl.Size = new System.Drawing.Size(38, 22);
            this.Player2lbl.TabIndex = 1;
            this.Player2lbl.Text = "P2";
            // 
            // Stat1lbl
            // 
            this.Stat1lbl.AutoSize = true;
            this.Stat1lbl.Font = new System.Drawing.Font("Ravie", 9.75F);
            this.Stat1lbl.Location = new System.Drawing.Point(12, 68);
            this.Stat1lbl.Name = "Stat1lbl";
            this.Stat1lbl.Size = new System.Drawing.Size(107, 22);
            this.Stat1lbl.TabIndex = 2;
            this.Stat1lbl.Text = "Playing..";
            // 
            // Stat2lbl
            // 
            this.Stat2lbl.AutoSize = true;
            this.Stat2lbl.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stat2lbl.Location = new System.Drawing.Point(820, 68);
            this.Stat2lbl.Name = "Stat2lbl";
            this.Stat2lbl.Size = new System.Drawing.Size(101, 22);
            this.Stat2lbl.TabIndex = 3;
            this.Stat2lbl.Text = "Waiting";
            // 
            // word_label
            // 
            this.word_label.AutoSize = true;
            this.word_label.Location = new System.Drawing.Point(414, 33);
            this.word_label.Name = "word_label";
            this.word_label.Size = new System.Drawing.Size(42, 17);
            this.word_label.TabIndex = 4;
            this.word_label.Text = "label1";
            // 
            // action
            // 
            this.action.AutoSize = true;
            this.action.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.action.Location = new System.Drawing.Point(63, 262);
            this.action.Name = "action";
            this.action.Size = new System.Drawing.Size(101, 23);
            this.action.TabIndex = 5;
            this.action.Text = "Transitions:";
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.Location = new System.Drawing.Point(63, 313);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(56, 23);
            this.log.TabIndex = 6;
            this.log.Text = "label2";
            // 
            // Spectate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.log);
            this.Controls.Add(this.action);
            this.Controls.Add(this.word_label);
            this.Controls.Add(this.Stat2lbl);
            this.Controls.Add(this.Stat1lbl);
            this.Controls.Add(this.Player2lbl);
            this.Controls.Add(this.Player1lbl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Spectate";
            this.Text = "Spectate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Spectate_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Player1lbl;
        private System.Windows.Forms.Label Player2lbl;
        private System.Windows.Forms.Label Stat1lbl;
        private System.Windows.Forms.Label Stat2lbl;
        private System.Windows.Forms.Label word_label;
        private System.Windows.Forms.Label action;
        private System.Windows.Forms.Label log;
    }
}