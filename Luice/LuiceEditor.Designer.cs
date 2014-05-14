namespace Luice
{
    partial class LuiceEditor
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.creatureTab = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.creatureSearchDgv = new System.Windows.Forms.DataGridView();
            this.entry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.npcflag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minlevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxlevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_loc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subname_loc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.findCreatureBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.npcEntryTxt = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gameobjectTab = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.creatureTab.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creatureSearchDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.creatureTab);
            this.tabControl1.Controls.Add(this.gameobjectTab);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1036, 476);
            this.tabControl1.TabIndex = 0;
            // 
            // creatureTab
            // 
            this.creatureTab.Controls.Add(this.tabControl2);
            this.creatureTab.Location = new System.Drawing.Point(4, 22);
            this.creatureTab.Name = "creatureTab";
            this.creatureTab.Padding = new System.Windows.Forms.Padding(3);
            this.creatureTab.Size = new System.Drawing.Size(1028, 450);
            this.creatureTab.TabIndex = 0;
            this.creatureTab.Text = "Creature";
            this.creatureTab.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(6, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1015, 442);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.creatureSearchDgv);
            this.tabPage1.Controls.Add(this.findCreatureBtn);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.npcEntryTxt);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1007, 416);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // creatureSearchDgv
            // 
            this.creatureSearchDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.creatureSearchDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.entry,
            this.name,
            this.subname,
            this.npcflag,
            this.minlevel,
            this.maxlevel,
            this.count,
            this.name_loc,
            this.subname_loc});
            this.creatureSearchDgv.Location = new System.Drawing.Point(35, 69);
            this.creatureSearchDgv.Name = "creatureSearchDgv";
            this.creatureSearchDgv.Size = new System.Drawing.Size(943, 329);
            this.creatureSearchDgv.TabIndex = 3;
            // 
            // entry
            // 
            this.entry.HeaderText = "entry";
            this.entry.Name = "entry";
            // 
            // name
            // 
            this.name.HeaderText = "name";
            this.name.Name = "name";
            // 
            // subname
            // 
            this.subname.HeaderText = "subname";
            this.subname.Name = "subname";
            // 
            // npcflag
            // 
            this.npcflag.HeaderText = "npcflag";
            this.npcflag.Name = "npcflag";
            // 
            // minlevel
            // 
            this.minlevel.HeaderText = "minlevel";
            this.minlevel.Name = "minlevel";
            // 
            // maxlevel
            // 
            this.maxlevel.HeaderText = "maxlevel";
            this.maxlevel.Name = "maxlevel";
            // 
            // count
            // 
            this.count.HeaderText = "count";
            this.count.Name = "count";
            // 
            // name_loc
            // 
            this.name_loc.HeaderText = "name_loc";
            this.name_loc.Name = "name_loc";
            // 
            // subname_loc
            // 
            this.subname_loc.HeaderText = "subname_loc";
            this.subname_loc.Name = "subname_loc";
            // 
            // findCreatureBtn
            // 
            this.findCreatureBtn.Location = new System.Drawing.Point(929, 21);
            this.findCreatureBtn.Name = "findCreatureBtn";
            this.findCreatureBtn.Size = new System.Drawing.Size(75, 23);
            this.findCreatureBtn.TabIndex = 2;
            this.findCreatureBtn.Text = "find";
            this.findCreatureBtn.UseVisualStyleBackColor = true;
            this.findCreatureBtn.Click += new System.EventHandler(this.findCreatureBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entry";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // npcEntryTxt
            // 
            this.npcEntryTxt.Location = new System.Drawing.Point(10, 24);
            this.npcEntryTxt.Name = "npcEntryTxt";
            this.npcEntryTxt.Size = new System.Drawing.Size(100, 20);
            this.npcEntryTxt.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(956, 365);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gameobjectTab
            // 
            this.gameobjectTab.Location = new System.Drawing.Point(4, 22);
            this.gameobjectTab.Name = "gameobjectTab";
            this.gameobjectTab.Padding = new System.Windows.Forms.Padding(3);
            this.gameobjectTab.Size = new System.Drawing.Size(764, 283);
            this.gameobjectTab.TabIndex = 1;
            this.gameobjectTab.Text = "GameObject";
            this.gameobjectTab.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(328, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(217, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sub Name";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(703, 24);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(820, 24);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(700, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "KillCredit1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(817, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "KillCredit2";
            // 
            // LuiceEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1039, 482);
            this.Controls.Add(this.tabControl1);
            this.Name = "LuiceEditor";
            this.Text = "LuiceEditor";
            this.tabControl1.ResumeLayout(false);
            this.creatureTab.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creatureSearchDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage creatureTab;
        private System.Windows.Forms.TabPage gameobjectTab;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView creatureSearchDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn entry;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn subname;
        private System.Windows.Forms.DataGridViewTextBoxColumn npcflag;
        private System.Windows.Forms.DataGridViewTextBoxColumn minlevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxlevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_loc;
        private System.Windows.Forms.DataGridViewTextBoxColumn subname_loc;
        private System.Windows.Forms.Button findCreatureBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox npcEntryTxt;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;

    }
}