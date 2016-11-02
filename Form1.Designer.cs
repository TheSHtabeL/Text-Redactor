namespace TextRedactor
{
    partial class WrITe
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WrITe));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuDocument = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDocumentNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDocumentOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDocumentSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDocumentSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDocumentClose = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAlignment = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAlignmentLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAlignmentCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAlignmentRight = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTextWindow = new System.Windows.Forms.RichTextBox();
            this.MenuLabelSize = new System.Windows.Forms.Label();
            this.MenuSizeText = new System.Windows.Forms.NumericUpDown();
            this.MenuLabelFont = new System.Windows.Forms.Label();
            this.BottomSymbolsCount = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.MenuFont = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSizeText)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuDocument,
            this.MenuAlignment});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // MenuDocument
            // 
            this.MenuDocument.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuDocumentNew,
            this.MenuDocumentOpen,
            this.MenuDocumentSave,
            this.MenuDocumentSaveAs,
            this.MenuDocumentClose});
            this.MenuDocument.Name = "MenuDocument";
            resources.ApplyResources(this.MenuDocument, "MenuDocument");
            this.MenuDocument.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // MenuDocumentNew
            // 
            this.MenuDocumentNew.Name = "MenuDocumentNew";
            resources.ApplyResources(this.MenuDocumentNew, "MenuDocumentNew");
            this.MenuDocumentNew.Click += new System.EventHandler(this.MenuDocumentNew_Click);
            // 
            // MenuDocumentOpen
            // 
            this.MenuDocumentOpen.Name = "MenuDocumentOpen";
            resources.ApplyResources(this.MenuDocumentOpen, "MenuDocumentOpen");
            this.MenuDocumentOpen.Click += new System.EventHandler(this.menuOpenDocument);
            // 
            // MenuDocumentSave
            // 
            this.MenuDocumentSave.Name = "MenuDocumentSave";
            resources.ApplyResources(this.MenuDocumentSave, "MenuDocumentSave");
            this.MenuDocumentSave.Click += new System.EventHandler(this.MenuDocumentSave_Click);
            // 
            // MenuDocumentSaveAs
            // 
            this.MenuDocumentSaveAs.Name = "MenuDocumentSaveAs";
            resources.ApplyResources(this.MenuDocumentSaveAs, "MenuDocumentSaveAs");
            this.MenuDocumentSaveAs.Click += new System.EventHandler(this.MenuDocumentSaveAs_Click);
            // 
            // MenuDocumentClose
            // 
            this.MenuDocumentClose.Name = "MenuDocumentClose";
            resources.ApplyResources(this.MenuDocumentClose, "MenuDocumentClose");
            this.MenuDocumentClose.Click += new System.EventHandler(this.MenuDocumentClose_Click);
            // 
            // MenuAlignment
            // 
            this.MenuAlignment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAlignmentLeft,
            this.MenuAlignmentCenter,
            this.MenuAlignmentRight});
            this.MenuAlignment.Name = "MenuAlignment";
            resources.ApplyResources(this.MenuAlignment, "MenuAlignment");
            // 
            // MenuAlignmentLeft
            // 
            this.MenuAlignmentLeft.Name = "MenuAlignmentLeft";
            resources.ApplyResources(this.MenuAlignmentLeft, "MenuAlignmentLeft");
            this.MenuAlignmentLeft.Click += new System.EventHandler(this.MenuAlignmentLeft_Click);
            // 
            // MenuAlignmentCenter
            // 
            this.MenuAlignmentCenter.Name = "MenuAlignmentCenter";
            resources.ApplyResources(this.MenuAlignmentCenter, "MenuAlignmentCenter");
            this.MenuAlignmentCenter.Click += new System.EventHandler(this.MenuAlignmentCenter_Click);
            // 
            // MenuAlignmentRight
            // 
            this.MenuAlignmentRight.Name = "MenuAlignmentRight";
            resources.ApplyResources(this.MenuAlignmentRight, "MenuAlignmentRight");
            this.MenuAlignmentRight.Click += new System.EventHandler(this.MenuAlignmentRight_Click);
            // 
            // MainTextWindow
            // 
            this.MainTextWindow.AcceptsTab = true;
            resources.ApplyResources(this.MainTextWindow, "MainTextWindow");
            this.MainTextWindow.Name = "MainTextWindow";
            this.MainTextWindow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainTextWindow_MouseClick);
            this.MainTextWindow.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // MenuLabelSize
            // 
            resources.ApplyResources(this.MenuLabelSize, "MenuLabelSize");
            this.MenuLabelSize.Name = "MenuLabelSize";
            this.MenuLabelSize.Click += new System.EventHandler(this.label1_Click);
            // 
            // MenuSizeText
            // 
            this.MenuSizeText.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            resources.ApplyResources(this.MenuSizeText, "MenuSizeText");
            this.MenuSizeText.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.MenuSizeText.Name = "MenuSizeText";
            this.MenuSizeText.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.MenuSizeText.ValueChanged += new System.EventHandler(this.MenuSizeText_ValueChanged);
            // 
            // MenuLabelFont
            // 
            resources.ApplyResources(this.MenuLabelFont, "MenuLabelFont");
            this.MenuLabelFont.Name = "MenuLabelFont";
            this.MenuLabelFont.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // BottomSymbolsCount
            // 
            resources.ApplyResources(this.BottomSymbolsCount, "BottomSymbolsCount");
            this.BottomSymbolsCount.Name = "BottomSymbolsCount";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // MenuFont
            // 
            resources.ApplyResources(this.MenuFont, "MenuFont");
            this.MenuFont.Name = "MenuFont";
            this.MenuFont.UseCompatibleStateImageBehavior = false;
            this.MenuFont.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // WrITe
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BottomSymbolsCount);
            this.Controls.Add(this.MenuLabelFont);
            this.Controls.Add(this.MenuFont);
            this.Controls.Add(this.MenuSizeText);
            this.Controls.Add(this.MenuLabelSize);
            this.Controls.Add(this.MainTextWindow);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WrITe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WrITe_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSizeText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuDocument;
        private System.Windows.Forms.ToolStripMenuItem MenuDocumentNew;
        private System.Windows.Forms.ToolStripMenuItem MenuDocumentOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuDocumentSave;
        private System.Windows.Forms.ToolStripMenuItem MenuDocumentClose;
        private System.Windows.Forms.RichTextBox MainTextWindow;
        private System.Windows.Forms.Label MenuLabelSize;
        private System.Windows.Forms.NumericUpDown MenuSizeText;
        private System.Windows.Forms.Label MenuLabelFont;
        private System.Windows.Forms.ToolStripMenuItem MenuAlignment;
        private System.Windows.Forms.ToolStripMenuItem MenuAlignmentLeft;
        private System.Windows.Forms.ToolStripMenuItem MenuAlignmentCenter;
        private System.Windows.Forms.ToolStripMenuItem MenuAlignmentRight;
        private System.Windows.Forms.Label BottomSymbolsCount;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private CurrentDocument currentDocument = new CurrentDocument();
        private System.Windows.Forms.ToolStripMenuItem MenuDocumentSaveAs;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ListView MenuFont;
    }
}

