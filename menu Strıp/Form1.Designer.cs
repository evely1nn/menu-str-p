namespace menu_Strıp
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.öğrenciEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kALINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pTToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciEkleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(457, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // öğrenciEkleToolStripMenuItem
            // 
            this.öğrenciEkleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem});
            this.öğrenciEkleToolStripMenuItem.Name = "öğrenciEkleToolStripMenuItem";
            this.öğrenciEkleToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.öğrenciEkleToolStripMenuItem.Text = "Öğrenci İşlemleri";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ekleToolStripMenuItem.Text = "ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Location = new System.Drawing.Point(152, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(214, 99);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kALINToolStripMenuItem,
            this.pTToolStripMenuItem,
            this.pTToolStripMenuItem1,
            this.pTToolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 92);
            // 
            // kALINToolStripMenuItem
            // 
            this.kALINToolStripMenuItem.Name = "kALINToolStripMenuItem";
            this.kALINToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kALINToolStripMenuItem.Text = "KALIN";
            this.kALINToolStripMenuItem.Click += new System.EventHandler(this.kALINToolStripMenuItem_Click);
            // 
            // pTToolStripMenuItem
            // 
            this.pTToolStripMenuItem.Name = "pTToolStripMenuItem";
            this.pTToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pTToolStripMenuItem.Text = "12 PT";
            this.pTToolStripMenuItem.Click += new System.EventHandler(this.pTToolStripMenuItem_Click);
            // 
            // pTToolStripMenuItem1
            // 
            this.pTToolStripMenuItem1.Name = "pTToolStripMenuItem1";
            this.pTToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.pTToolStripMenuItem1.Text = "15 PT";
            this.pTToolStripMenuItem1.Click += new System.EventHandler(this.pTToolStripMenuItem1_Click);
            // 
            // pTToolStripMenuItem2
            // 
            this.pTToolStripMenuItem2.Name = "pTToolStripMenuItem2";
            this.pTToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.pTToolStripMenuItem2.Text = "20 PT";
            this.pTToolStripMenuItem2.Click += new System.EventHandler(this.pTToolStripMenuItem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 223);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kALINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pTToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pTToolStripMenuItem2;
    }
}

