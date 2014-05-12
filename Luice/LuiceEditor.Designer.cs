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
            this.gameobjectTab = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.npcEntryTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.findCreatureBtn = new System.Windows.Forms.Button();
            this.creatureSearchDgv = new System.Windows.Forms.DataGridView();
            this.entry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subname = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tabControl1.Size = new System.Drawing.Size(772, 309);
            this.tabControl1.TabIndex = 0;
            // 
            // creatureTab
            // 
            this.creatureTab.Controls.Add(this.tabControl2);
            this.creatureTab.Location = new System.Drawing.Point(4, 22);
            this.creatureTab.Name = "creatureTab";
            this.creatureTab.Padding = new System.Windows.Forms.Padding(3);
            this.creatureTab.Size = new System.Drawing.Size(764, 283);
            this.creatureTab.TabIndex = 0;
            this.creatureTab.Text = "Creature";
            this.creatureTab.UseVisualStyleBackColor = true;
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
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(6, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(762, 284);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.creatureSearchDgv);
            this.tabPage1.Controls.Add(this.findCreatureBtn);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.npcEntryTxt);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(754, 258);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(754, 258);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // npcEntryTxt
            // 
            this.npcEntryTxt.Location = new System.Drawing.Point(6, 26);
            this.npcEntryTxt.Name = "npcEntryTxt";
            this.npcEntryTxt.Size = new System.Drawing.Size(100, 20);
            this.npcEntryTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "entry";
            // 
            // findCreatureBtn
            // 
            this.findCreatureBtn.Location = new System.Drawing.Point(112, 24);
            this.findCreatureBtn.Name = "findCreatureBtn";
            this.findCreatureBtn.Size = new System.Drawing.Size(75, 23);
            this.findCreatureBtn.TabIndex = 2;
            this.findCreatureBtn.Text = "find";
            this.findCreatureBtn.UseVisualStyleBackColor = true;
            this.findCreatureBtn.Click += new System.EventHandler(this.findCreatureBtn_Click);
            // 
            // creatureSearchDgv
            // 
            this.creatureSearchDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.creatureSearchDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.entry,
            this.name,
            this.subname});
            this.creatureSearchDgv.Location = new System.Drawing.Point(10, 53);
            this.creatureSearchDgv.Name = "creatureSearchDgv";
            this.creatureSearchDgv.Size = new System.Drawing.Size(739, 199);
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
            // LuiceEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(777, 324);
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
        private System.Windows.Forms.Button findCreatureBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox npcEntryTxt;
        private System.Windows.Forms.TabPage tabPage2;

    }
}