namespace DAT602_MIlestone_One
{
    partial class MainGameLobby
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
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnAdminconsole = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnNewgame1 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(453, 22);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(128, 35);
            this.button6.TabIndex = 29;
            this.button6.Text = "Delete Account";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Font = new System.Drawing.Font("Calibri", 14F);
            this.button5.Location = new System.Drawing.Point(410, 164);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(171, 43);
            this.button5.TabIndex = 28;
            this.button5.Text = "Join Game";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnAdminconsole
            // 
            this.btnAdminconsole.AutoSize = true;
            this.btnAdminconsole.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnAdminconsole.Location = new System.Drawing.Point(409, 214);
            this.btnAdminconsole.Name = "btnAdminconsole";
            this.btnAdminconsole.Size = new System.Drawing.Size(172, 43);
            this.btnAdminconsole.TabIndex = 27;
            this.btnAdminconsole.Text = "Admin Console";
            this.btnAdminconsole.UseVisualStyleBackColor = true;
            this.btnAdminconsole.Click += new System.EventHandler(this.btnAdminconsole_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(25, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 29);
            this.label2.TabIndex = 26;
            this.label2.Text = "Current Game";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(217, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "Online Player";
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Font = new System.Drawing.Font("Calibri", 14F);
            this.button3.Location = new System.Drawing.Point(410, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 43);
            this.button3.TabIndex = 24;
            this.button3.Text = "New 2v2 Game";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Calibri", 14F);
            this.button2.Location = new System.Drawing.Point(410, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 43);
            this.button2.TabIndex = 23;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnNewgame1
            // 
            this.btnNewgame1.AutoSize = true;
            this.btnNewgame1.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnNewgame1.Location = new System.Drawing.Point(410, 63);
            this.btnNewgame1.Name = "btnNewgame1";
            this.btnNewgame1.Size = new System.Drawing.Size(171, 43);
            this.btnNewgame1.TabIndex = 22;
            this.btnNewgame1.Text = "New 1v1 Game";
            this.btnNewgame1.UseVisualStyleBackColor = true;
            this.btnNewgame1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Calibri", 12F);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 24;
            this.listBox2.Items.AddRange(new object[] {
            "Bozhi\t2000",
            "Josef\t1200\t\t",
            "Super\t7000"});
            this.listBox2.Location = new System.Drawing.Point(221, 63);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(173, 244);
            this.listBox2.TabIndex = 21;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Calibri", 12F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Items.AddRange(new object[] {
            "Game 1v1(1)",
            "Game 1v1(2)",
            "Game 2v2(1)",
            "Game 3v3(1)"});
            this.listBox1.Location = new System.Drawing.Point(29, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(173, 244);
            this.listBox1.TabIndex = 20;
            // 
            // MainGameLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 325);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnAdminconsole);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnNewgame1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "MainGameLobby";
            this.Text = "MainGameLobby";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnAdminconsole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnNewgame1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
    }
}