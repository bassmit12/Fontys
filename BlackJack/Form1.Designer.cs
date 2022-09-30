namespace BlackJack
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView_dealer = new System.Windows.Forms.ListView();
            this.listView_player = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_hit = new System.Windows.Forms.Button();
            this.button_stand = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.value_dealer = new System.Windows.Forms.Label();
            this.value_player = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView_dealer
            // 
            this.listView_dealer.AccessibleName = "";
            this.listView_dealer.Location = new System.Drawing.Point(331, 79);
            this.listView_dealer.Name = "listView_dealer";
            this.listView_dealer.Size = new System.Drawing.Size(226, 143);
            this.listView_dealer.TabIndex = 0;
            this.listView_dealer.UseCompatibleStateImageBehavior = false;
            this.listView_dealer.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // listView_player
            // 
            this.listView_player.Location = new System.Drawing.Point(331, 248);
            this.listView_player.Name = "listView_player";
            this.listView_player.Size = new System.Drawing.Size(226, 143);
            this.listView_player.TabIndex = 1;
            this.listView_player.UseCompatibleStateImageBehavior = false;
            this.listView_player.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dealer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Player";
            // 
            // button_hit
            // 
            this.button_hit.Location = new System.Drawing.Point(107, 363);
            this.button_hit.Name = "button_hit";
            this.button_hit.Size = new System.Drawing.Size(94, 29);
            this.button_hit.TabIndex = 4;
            this.button_hit.Text = "Hit";
            this.button_hit.UseVisualStyleBackColor = true;
            this.button_hit.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_stand
            // 
            this.button_stand.Location = new System.Drawing.Point(219, 363);
            this.button_stand.Name = "button_stand";
            this.button_stand.Size = new System.Drawing.Size(94, 29);
            this.button_stand.TabIndex = 5;
            this.button_stand.Text = "Stand";
            this.button_stand.UseVisualStyleBackColor = true;
            this.button_stand.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(14, 216);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(94, 29);
            this.button_start.TabIndex = 6;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button3_Click);
            // 
            // value_dealer
            // 
            this.value_dealer.AutoSize = true;
            this.value_dealer.Location = new System.Drawing.Point(586, 139);
            this.value_dealer.Name = "value_dealer";
            this.value_dealer.Size = new System.Drawing.Size(45, 20);
            this.value_dealer.TabIndex = 7;
            this.value_dealer.Text = "Value";
            this.value_dealer.Click += new System.EventHandler(this.label3_Click);
            // 
            // value_player
            // 
            this.value_player.AutoSize = true;
            this.value_player.Location = new System.Drawing.Point(583, 313);
            this.value_player.Name = "value_player";
            this.value_player.Size = new System.Drawing.Size(45, 20);
            this.value_player.TabIndex = 8;
            this.value_player.Text = "Value";
            this.value_player.Click += new System.EventHandler(this.value_player_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 451);
            this.Controls.Add(this.value_player);
            this.Controls.Add(this.value_dealer);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_stand);
            this.Controls.Add(this.button_hit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView_player);
            this.Controls.Add(this.listView_dealer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listView_dealer;
        private ListView listView_player;
        private Label label1;
        private Label label2;
        private Button button_hit;
        private Button button_stand;
        private Button button_start;
        private Label value_dealer;
        private Label value_player;
    }
}