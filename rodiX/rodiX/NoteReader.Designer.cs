namespace rodiX
{
    partial class NoteReader
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteReader));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reverseTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capatalizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toLowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeAcronymToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solveExpressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backGroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foreFroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeReadOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endOfLinrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.ruler1 = new FastColoredTextBoxNS.Ruler();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.reverseTextToolStripMenuItem,
            this.capatalizeToolStripMenuItem,
            this.toLowerToolStripMenuItem,
            this.makeAcronymToolStripMenuItem,
            this.solveExpressionToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.backGroundToolStripMenuItem,
            this.foreFroundToolStripMenuItem,
            this.findToolStripMenuItem,
            this.replaceToolStripMenuItem,
            this.gotoToolStripMenuItem,
            this.makeReadOnlyToolStripMenuItem,
            this.enableDocumentToolStripMenuItem,
            this.endOfLinrToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 422);
            this.contextMenuStrip1.Paint += new System.Windows.Forms.PaintEventHandler(this.contextMenuStrip1_Paint);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // reverseTextToolStripMenuItem
            // 
            this.reverseTextToolStripMenuItem.Name = "reverseTextToolStripMenuItem";
            this.reverseTextToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.reverseTextToolStripMenuItem.Text = "Reverse Text";
            this.reverseTextToolStripMenuItem.Click += new System.EventHandler(this.reverseTextToolStripMenuItem_Click);
            // 
            // capatalizeToolStripMenuItem
            // 
            this.capatalizeToolStripMenuItem.Name = "capatalizeToolStripMenuItem";
            this.capatalizeToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.capatalizeToolStripMenuItem.Text = "To Upper";
            this.capatalizeToolStripMenuItem.Click += new System.EventHandler(this.capatalizeToolStripMenuItem_Click);
            // 
            // toLowerToolStripMenuItem
            // 
            this.toLowerToolStripMenuItem.Name = "toLowerToolStripMenuItem";
            this.toLowerToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.toLowerToolStripMenuItem.Text = "To Lower";
            this.toLowerToolStripMenuItem.Click += new System.EventHandler(this.toLowerToolStripMenuItem_Click);
            // 
            // makeAcronymToolStripMenuItem
            // 
            this.makeAcronymToolStripMenuItem.Name = "makeAcronymToolStripMenuItem";
            this.makeAcronymToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.makeAcronymToolStripMenuItem.Text = "Make Acronym";
            this.makeAcronymToolStripMenuItem.Click += new System.EventHandler(this.makeAcronymToolStripMenuItem_Click);
            // 
            // solveExpressionToolStripMenuItem
            // 
            this.solveExpressionToolStripMenuItem.Name = "solveExpressionToolStripMenuItem";
            this.solveExpressionToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.solveExpressionToolStripMenuItem.Text = "Solve Expression";
            this.solveExpressionToolStripMenuItem.Click += new System.EventHandler(this.solveExpressionToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // backGroundToolStripMenuItem
            // 
            this.backGroundToolStripMenuItem.Name = "backGroundToolStripMenuItem";
            this.backGroundToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.backGroundToolStripMenuItem.Text = "Background";
            this.backGroundToolStripMenuItem.Click += new System.EventHandler(this.backGroundToolStripMenuItem_Click);
            // 
            // foreFroundToolStripMenuItem
            // 
            this.foreFroundToolStripMenuItem.Name = "foreFroundToolStripMenuItem";
            this.foreFroundToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.foreFroundToolStripMenuItem.Text = "Foreground";
            this.foreFroundToolStripMenuItem.Click += new System.EventHandler(this.foreFroundToolStripMenuItem_Click);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.findToolStripMenuItem.Text = "Find";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.replaceToolStripMenuItem.Text = "Replace";
            this.replaceToolStripMenuItem.Click += new System.EventHandler(this.replaceToolStripMenuItem_Click);
            // 
            // gotoToolStripMenuItem
            // 
            this.gotoToolStripMenuItem.Name = "gotoToolStripMenuItem";
            this.gotoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.gotoToolStripMenuItem.Text = "Goto";
            this.gotoToolStripMenuItem.Click += new System.EventHandler(this.gotoToolStripMenuItem_Click);
            // 
            // makeReadOnlyToolStripMenuItem
            // 
            this.makeReadOnlyToolStripMenuItem.Name = "makeReadOnlyToolStripMenuItem";
            this.makeReadOnlyToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.makeReadOnlyToolStripMenuItem.Text = "Make ReadOnly";
            this.makeReadOnlyToolStripMenuItem.Click += new System.EventHandler(this.makeReadOnlyToolStripMenuItem_Click);
            // 
            // enableDocumentToolStripMenuItem
            // 
            this.enableDocumentToolStripMenuItem.Name = "enableDocumentToolStripMenuItem";
            this.enableDocumentToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.enableDocumentToolStripMenuItem.Text = "Enable Document";
            this.enableDocumentToolStripMenuItem.Click += new System.EventHandler(this.enableDocumentToolStripMenuItem_Click);
            // 
            // endOfLinrToolStripMenuItem
            // 
            this.endOfLinrToolStripMenuItem.Name = "endOfLinrToolStripMenuItem";
            this.endOfLinrToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.endOfLinrToolStripMenuItem.Text = "End of line";
            this.endOfLinrToolStripMenuItem.Click += new System.EventHandler(this.endOfLinrToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.AutoCompleteBrackets = true;
            this.textBox1.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.textBox1.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.textBox1.BackBrush = null;
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BookmarkColor = System.Drawing.Color.Crimson;
            this.textBox1.CaretColor = System.Drawing.Color.Crimson;
            this.textBox1.CharHeight = 14;
            this.textBox1.CharWidth = 8;
            this.textBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.textBox1.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.textBox1.IndentBackColor = System.Drawing.Color.Transparent;
            this.textBox1.IsReplaceMode = false;
            this.textBox1.LeftBracket = '\'';
            this.textBox1.LeftBracket2 = '\"';
            this.textBox1.LineNumberColor = System.Drawing.Color.Crimson;
            this.textBox1.Location = new System.Drawing.Point(0, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.textBox1.RightBracket = '\'';
            this.textBox1.RightBracket2 = '\"';
            this.textBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.textBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("textBox1.ServiceColors")));
            this.textBox1.ServiceLinesColor = System.Drawing.Color.Transparent;
            this.textBox1.Size = new System.Drawing.Size(1314, 587);
            this.textBox1.TabIndex = 1;
            this.textBox1.Zoom = 100;
            this.textBox1.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.textBox1_TextChanged);
            this.textBox1.Pasting += new System.EventHandler<FastColoredTextBoxNS.TextChangingEventArgs>(this.textBox1_Pasting);
            this.textBox1.Load += new System.EventHandler(this.textBox1_Load);
            this.textBox1.BackColorChanged += new System.EventHandler(this.textBox1_BackColorChanged);
            this.textBox1.ForeColorChanged += new System.EventHandler(this.textBox1_ForeColorChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave_1);
            // 
            // ruler1
            // 
            this.ruler1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ruler1.BackColor = System.Drawing.Color.Transparent;
            this.ruler1.BackColor2 = System.Drawing.Color.Transparent;
            this.ruler1.CaretTickColor = System.Drawing.Color.Crimson;
            this.ruler1.ForeColor = System.Drawing.Color.Crimson;
            this.ruler1.Location = new System.Drawing.Point(0, 3);
            this.ruler1.MaximumSize = new System.Drawing.Size(1073741824, 24);
            this.ruler1.MinimumSize = new System.Drawing.Size(0, 24);
            this.ruler1.Name = "ruler1";
            this.ruler1.Size = new System.Drawing.Size(1314, 24);
            this.ruler1.TabIndex = 2;
            this.ruler1.Target = this.textBox1;
            this.ruler1.TickColor = System.Drawing.Color.Crimson;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 623);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1314, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // NoteReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ruler1);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Name = "NoteReader";
            this.Size = new System.Drawing.Size(1314, 645);
            this.Load += new System.EventHandler(this.NoteReader_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reverseTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capatalizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toLowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeAcronymToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solveExpressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backGroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foreFroundToolStripMenuItem;
        private FastColoredTextBoxNS.FastColoredTextBox textBox1;
        private FastColoredTextBoxNS.Ruler ruler1;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeReadOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableDocumentToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem endOfLinrToolStripMenuItem;
    }
}
