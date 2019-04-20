namespace client
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.diff = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RoomName_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.categ = new System.Windows.Forms.ListBox();
            this.new_room_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.join_btn = new System.Windows.Forms.Button();
            this.show_btn = new System.Windows.Forms.Button();
            this.rooms_list = new System.Windows.Forms.ListBox();
            this.btn_watch = new System.Windows.Forms.Button();
            this.welcome_label = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.diff);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.RoomName_txt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.categ);
            this.groupBox2.Controls.Add(this.new_room_btn);
            this.groupBox2.Location = new System.Drawing.Point(409, 50);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(352, 373);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // diff
            // 
            this.diff.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diff.FormattingEnabled = true;
            this.diff.ItemHeight = 21;
            this.diff.Location = new System.Drawing.Point(39, 177);
            this.diff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.diff.Name = "diff";
            this.diff.Size = new System.Drawing.Size(119, 67);
            this.diff.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(196, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "Category";
            // 
            // RoomName_txt
            // 
            this.RoomName_txt.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomName_txt.Location = new System.Drawing.Point(97, 64);
            this.RoomName_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RoomName_txt.Name = "RoomName_txt";
            this.RoomName_txt.Size = new System.Drawing.Size(150, 28);
            this.RoomName_txt.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Difficulty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "RoomName";
            // 
            // categ
            // 
            this.categ.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categ.FormattingEnabled = true;
            this.categ.ItemHeight = 21;
            this.categ.Location = new System.Drawing.Point(200, 177);
            this.categ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categ.Name = "categ";
            this.categ.Size = new System.Drawing.Size(119, 67);
            this.categ.TabIndex = 14;
            // 
            // new_room_btn
            // 
            this.new_room_btn.Location = new System.Drawing.Point(107, 287);
            this.new_room_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.new_room_btn.Name = "new_room_btn";
            this.new_room_btn.Size = new System.Drawing.Size(150, 52);
            this.new_room_btn.TabIndex = 0;
            this.new_room_btn.Text = "New room";
            this.new_room_btn.UseVisualStyleBackColor = true;
            this.new_room_btn.Click += new System.EventHandler(this.new_room_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.join_btn);
            this.groupBox1.Controls.Add(this.show_btn);
            this.groupBox1.Controls.Add(this.rooms_list);
            this.groupBox1.Controls.Add(this.btn_watch);
            this.groupBox1.Location = new System.Drawing.Point(40, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(334, 373);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // join_btn
            // 
            this.join_btn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.join_btn.Location = new System.Drawing.Point(22, 289);
            this.join_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.join_btn.Name = "join_btn";
            this.join_btn.Size = new System.Drawing.Size(107, 49);
            this.join_btn.TabIndex = 11;
            this.join_btn.Text = "Join";
            this.join_btn.UseVisualStyleBackColor = true;
            this.join_btn.Click += new System.EventHandler(this.join_btn_Click);
            // 
            // show_btn
            // 
            this.show_btn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_btn.Location = new System.Drawing.Point(65, 177);
            this.show_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(153, 52);
            this.show_btn.TabIndex = 1;
            this.show_btn.Text = "Show Rooms";
            this.show_btn.UseVisualStyleBackColor = true;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // rooms_list
            // 
            this.rooms_list.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms_list.FormattingEnabled = true;
            this.rooms_list.ItemHeight = 21;
            this.rooms_list.Location = new System.Drawing.Point(33, 28);
            this.rooms_list.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rooms_list.Name = "rooms_list";
            this.rooms_list.Size = new System.Drawing.Size(235, 109);
            this.rooms_list.TabIndex = 10;
            this.rooms_list.SelectedIndexChanged += new System.EventHandler(this.rooms_list_SelectedIndexChanged);
            // 
            // btn_watch
            // 
            this.btn_watch.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_watch.Location = new System.Drawing.Point(157, 287);
            this.btn_watch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_watch.Name = "btn_watch";
            this.btn_watch.Size = new System.Drawing.Size(111, 52);
            this.btn_watch.TabIndex = 9;
            this.btn_watch.Text = "Watch";
            this.btn_watch.UseVisualStyleBackColor = true;
            this.btn_watch.Click += new System.EventHandler(this.btn_watch_Click);
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_label.ForeColor = System.Drawing.Color.Black;
            this.welcome_label.Location = new System.Drawing.Point(307, 9);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(143, 24);
            this.welcome_label.TabIndex = 19;
            this.welcome_label.Text = "welcome_label";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.welcome_label);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox diff;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RoomName_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox categ;
        private System.Windows.Forms.Button new_room_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button join_btn;
        private System.Windows.Forms.Button show_btn;
        private System.Windows.Forms.ListBox rooms_list;
        private System.Windows.Forms.Button btn_watch;
        private System.Windows.Forms.Label welcome_label;
    }
}

