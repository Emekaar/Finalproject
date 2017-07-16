
namespace Rodis_
{
	partial class NoteReader
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.reverseTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.capatalizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toLowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.makeAcronymToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solveExpressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backGroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foreFroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(823, 499);
            this.textBox1.TabIndex = 0;
            this.textBox1.CursorChanged += new System.EventHandler(this.textBox1_CursorChanged);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.toolStripSeparator1,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator3,
            this.selectAllToolStripMenuItem,
            this.toolStripSeparator2,
            this.reverseTextToolStripMenuItem,
            this.toolStripSeparator4,
            this.capatalizeToolStripMenuItem,
            this.toLowerToolStripMenuItem,
            this.toolStripSeparator5,
            this.makeAcronymToolStripMenuItem,
            this.solveExpressionToolStripMenuItem,
            this.toolStripSeparator6,
            this.fontToolStripMenuItem,
            this.backGroundToolStripMenuItem,
            this.foreFroundToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 326);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(157, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
            // 
            // reverseTextToolStripMenuItem
            // 
            this.reverseTextToolStripMenuItem.Name = "reverseTextToolStripMenuItem";
            this.reverseTextToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.reverseTextToolStripMenuItem.Text = "Reverse Text";
            this.reverseTextToolStripMenuItem.Click += new System.EventHandler(this.reverseTextToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(157, 6);
            // 
            // capatalizeToolStripMenuItem
            // 
            this.capatalizeToolStripMenuItem.Name = "capatalizeToolStripMenuItem";
            this.capatalizeToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.capatalizeToolStripMenuItem.Text = "To Upper";
            this.capatalizeToolStripMenuItem.Click += new System.EventHandler(this.capatalizeToolStripMenuItem_Click);
            // 
            // toLowerToolStripMenuItem
            // 
            this.toLowerToolStripMenuItem.Name = "toLowerToolStripMenuItem";
            this.toLowerToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.toLowerToolStripMenuItem.Text = "To Lower";
            this.toLowerToolStripMenuItem.Click += new System.EventHandler(this.toLowerToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(157, 6);
            // 
            // makeAcronymToolStripMenuItem
            // 
            this.makeAcronymToolStripMenuItem.Name = "makeAcronymToolStripMenuItem";
            this.makeAcronymToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.makeAcronymToolStripMenuItem.Text = "Make Acronym";
            this.makeAcronymToolStripMenuItem.Click += new System.EventHandler(this.makeAcronymToolStripMenuItem_Click);
            // 
            // solveExpressionToolStripMenuItem
            // 
            this.solveExpressionToolStripMenuItem.Name = "solveExpressionToolStripMenuItem";
            this.solveExpressionToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.solveExpressionToolStripMenuItem.Text = "Solve Expression";
            this.solveExpressionToolStripMenuItem.Click += new System.EventHandler(this.solveExpressionToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(157, 6);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // backGroundToolStripMenuItem
            // 
            this.backGroundToolStripMenuItem.Name = "backGroundToolStripMenuItem";
            this.backGroundToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.backGroundToolStripMenuItem.Text = "BackGround ";
            this.backGroundToolStripMenuItem.Click += new System.EventHandler(this.backGroundToolStripMenuItem_Click);
            // 
            // foreFroundToolStripMenuItem
            // 
            this.foreFroundToolStripMenuItem.Name = "foreFroundToolStripMenuItem";
            this.foreFroundToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.foreFroundToolStripMenuItem.Text = "ForeFround";
            this.foreFroundToolStripMenuItem.Click += new System.EventHandler(this.foreFroundToolStripMenuItem_Click);
            // 
            // NoteReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Name = "NoteReader";
            this.Size = new System.Drawing.Size(823, 499);
            this.Load += new System.EventHandler(this.NoteReaderLoad);
            this.Leave += new System.EventHandler(this.NoteReaderLeave);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem reverseTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capatalizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeAcronymToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toLowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solveExpressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backGroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foreFroundToolStripMenuItem;
        public System.Windows.Forms.TextBox textBox1;
	}
}
