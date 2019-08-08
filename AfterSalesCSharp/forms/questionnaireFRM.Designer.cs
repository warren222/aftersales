namespace AfterSalesCSharp
{
    partial class questionnaireFRM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.refreshBTN = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.questionGRID = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.deleteBTN = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.updateBTN = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.addBTN = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.itemTXT = new MetroFramework.Controls.MetroTextBox();
            this.questionTXT = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.question = new MetroFramework.Controls.MetroTextBox();
            this.answerTXT = new MetroFramework.Controls.MetroTextBox();
            this.aitemTXT = new MetroFramework.Controls.MetroTextBox();
            this.metroTextButton2 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTextButton1 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTextButton4 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTextButton3 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.answerGRID = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.questionGRID)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.answerGRID)).BeginInit();
            this.SuspendLayout();
            // 
            // refreshBTN
            // 
            this.refreshBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBTN.Image = null;
            this.refreshBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.refreshBTN.Location = new System.Drawing.Point(663, 57);
            this.refreshBTN.Name = "refreshBTN";
            this.refreshBTN.Size = new System.Drawing.Size(98, 30);
            this.refreshBTN.Style = MetroFramework.MetroColorStyle.Red;
            this.refreshBTN.TabIndex = 19;
            this.refreshBTN.Text = "refresh";
            this.refreshBTN.UseSelectable = true;
            this.refreshBTN.UseVisualStyleBackColor = true;
            this.refreshBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // questionGRID
            // 
            this.questionGRID.AllowUserToAddRows = false;
            this.questionGRID.AllowUserToDeleteRows = false;
            this.questionGRID.AllowUserToOrderColumns = true;
            this.questionGRID.AllowUserToResizeColumns = false;
            this.questionGRID.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.questionGRID.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.questionGRID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questionGRID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.questionGRID.ColumnHeadersHeight = 30;
            this.questionGRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.questionGRID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.questionGRID.Location = new System.Drawing.Point(13, 118);
            this.questionGRID.MultiSelect = false;
            this.questionGRID.Name = "questionGRID";
            this.questionGRID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.questionGRID.ReadOnly = true;
            this.questionGRID.RowHeadersVisible = false;
            this.questionGRID.RowHeadersWidth = 40;
            this.questionGRID.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.questionGRID.RowTemplate.Height = 40;
            this.questionGRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.questionGRID.Size = new System.Drawing.Size(778, 307);
            this.questionGRID.StateCommon.Background.Color1 = System.Drawing.Color.WhiteSmoke;
            this.questionGRID.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.questionGRID.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.questionGRID.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.questionGRID.StateCommon.DataCell.Content.Padding = new System.Windows.Forms.Padding(-1, 10, -1, 10);
            this.questionGRID.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.questionGRID.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.questionGRID.StateCommon.HeaderColumn.Border.Width = 0;
            this.questionGRID.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.questionGRID.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionGRID.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.questionGRID.TabIndex = 466;
            this.questionGRID.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.questionGRID_CellDoubleClick);
            this.questionGRID.SelectionChanged += new System.EventHandler(this.questionGRID_SelectionChanged);
            // 
            // deleteBTN
            // 
            this.deleteBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBTN.Image = null;
            this.deleteBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteBTN.Location = new System.Drawing.Point(559, 57);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(98, 30);
            this.deleteBTN.Style = MetroFramework.MetroColorStyle.Red;
            this.deleteBTN.TabIndex = 467;
            this.deleteBTN.Text = "delete";
            this.deleteBTN.UseSelectable = true;
            this.deleteBTN.UseVisualStyleBackColor = true;
            this.deleteBTN.Click += new System.EventHandler(this.metroTextButton1_Click);
            // 
            // updateBTN
            // 
            this.updateBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBTN.Image = null;
            this.updateBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateBTN.Location = new System.Drawing.Point(455, 57);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(98, 30);
            this.updateBTN.Style = MetroFramework.MetroColorStyle.Red;
            this.updateBTN.TabIndex = 468;
            this.updateBTN.Text = "update";
            this.updateBTN.UseSelectable = true;
            this.updateBTN.UseVisualStyleBackColor = true;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click_1);
            // 
            // addBTN
            // 
            this.addBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBTN.Image = null;
            this.addBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addBTN.Location = new System.Drawing.Point(351, 57);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(98, 30);
            this.addBTN.Style = MetroFramework.MetroColorStyle.Red;
            this.addBTN.TabIndex = 469;
            this.addBTN.Text = "add";
            this.addBTN.UseSelectable = true;
            this.addBTN.UseVisualStyleBackColor = true;
            this.addBTN.Click += new System.EventHandler(this.metroTextButton3_Click);
            // 
            // itemTXT
            // 
            // 
            // 
            // 
            this.itemTXT.CustomButton.Image = null;
            this.itemTXT.CustomButton.Location = new System.Drawing.Point(44, 2);
            this.itemTXT.CustomButton.Name = "";
            this.itemTXT.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.itemTXT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.itemTXT.CustomButton.TabIndex = 1;
            this.itemTXT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.itemTXT.CustomButton.UseSelectable = true;
            this.itemTXT.CustomButton.Visible = false;
            this.itemTXT.DisplayIcon = true;
            this.itemTXT.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.itemTXT.Lines = new string[0];
            this.itemTXT.Location = new System.Drawing.Point(18, 15);
            this.itemTXT.MaxLength = 32767;
            this.itemTXT.Name = "itemTXT";
            this.itemTXT.PasswordChar = '\0';
            this.itemTXT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.itemTXT.SelectedText = "";
            this.itemTXT.SelectionLength = 0;
            this.itemTXT.SelectionStart = 0;
            this.itemTXT.ShowClearButton = true;
            this.itemTXT.Size = new System.Drawing.Size(74, 32);
            this.itemTXT.Style = MetroFramework.MetroColorStyle.Red;
            this.itemTXT.TabIndex = 470;
            this.itemTXT.UseCustomForeColor = true;
            this.itemTXT.UseSelectable = true;
            this.itemTXT.WaterMark = "Item No";
            this.itemTXT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.itemTXT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // questionTXT
            // 
            this.questionTXT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.questionTXT.CustomButton.Image = null;
            this.questionTXT.CustomButton.Location = new System.Drawing.Point(633, 2);
            this.questionTXT.CustomButton.Name = "";
            this.questionTXT.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.questionTXT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.questionTXT.CustomButton.TabIndex = 1;
            this.questionTXT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.questionTXT.CustomButton.UseSelectable = true;
            this.questionTXT.CustomButton.Visible = false;
            this.questionTXT.DisplayIcon = true;
            this.questionTXT.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.questionTXT.Lines = new string[0];
            this.questionTXT.Location = new System.Drawing.Point(98, 15);
            this.questionTXT.MaxLength = 32767;
            this.questionTXT.Name = "questionTXT";
            this.questionTXT.PasswordChar = '\0';
            this.questionTXT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.questionTXT.SelectedText = "";
            this.questionTXT.SelectionLength = 0;
            this.questionTXT.SelectionStart = 0;
            this.questionTXT.ShowClearButton = true;
            this.questionTXT.Size = new System.Drawing.Size(663, 32);
            this.questionTXT.Style = MetroFramework.MetroColorStyle.Red;
            this.questionTXT.TabIndex = 471;
            this.questionTXT.UseCustomForeColor = true;
            this.questionTXT.UseSelectable = true;
            this.questionTXT.WaterMark = "Question";
            this.questionTXT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.questionTXT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.ItemSize = new System.Drawing.Size(150, 34);
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(800, 470);
            this.metroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTabControl1.TabIndex = 472;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.panel2);
            this.metroTabPage1.Controls.Add(this.questionGRID);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(792, 428);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Question";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.itemTXT);
            this.panel2.Controls.Add(this.deleteBTN);
            this.panel2.Controls.Add(this.updateBTN);
            this.panel2.Controls.Add(this.refreshBTN);
            this.panel2.Controls.Add(this.questionTXT);
            this.panel2.Controls.Add(this.addBTN);
            this.panel2.Location = new System.Drawing.Point(13, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 99);
            this.panel2.TabIndex = 472;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.panel1);
            this.metroTabPage2.Controls.Add(this.answerGRID);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(792, 428);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Answer";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.question);
            this.panel1.Controls.Add(this.answerTXT);
            this.panel1.Controls.Add(this.aitemTXT);
            this.panel1.Controls.Add(this.metroTextButton2);
            this.panel1.Controls.Add(this.metroTextButton1);
            this.panel1.Controls.Add(this.metroTextButton4);
            this.panel1.Controls.Add(this.metroTextButton3);
            this.panel1.Location = new System.Drawing.Point(10, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 145);
            this.panel1.TabIndex = 480;
            // 
            // question
            // 
            this.question.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.question.CustomButton.Image = null;
            this.question.CustomButton.Location = new System.Drawing.Point(714, 2);
            this.question.CustomButton.Name = "";
            this.question.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.question.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.question.CustomButton.TabIndex = 1;
            this.question.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.question.CustomButton.UseSelectable = true;
            this.question.CustomButton.Visible = false;
            this.question.DisplayIcon = true;
            this.question.Enabled = false;
            this.question.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.question.Lines = new string[0];
            this.question.Location = new System.Drawing.Point(15, 14);
            this.question.MaxLength = 32767;
            this.question.Name = "question";
            this.question.PasswordChar = '\0';
            this.question.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.question.SelectedText = "";
            this.question.SelectionLength = 0;
            this.question.SelectionStart = 0;
            this.question.ShowClearButton = true;
            this.question.Size = new System.Drawing.Size(744, 32);
            this.question.Style = MetroFramework.MetroColorStyle.Red;
            this.question.TabIndex = 479;
            this.question.UseCustomForeColor = true;
            this.question.UseSelectable = true;
            this.question.WaterMark = "Question";
            this.question.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.question.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // answerTXT
            // 
            this.answerTXT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.answerTXT.CustomButton.Image = null;
            this.answerTXT.CustomButton.Location = new System.Drawing.Point(633, 2);
            this.answerTXT.CustomButton.Name = "";
            this.answerTXT.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.answerTXT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.answerTXT.CustomButton.TabIndex = 1;
            this.answerTXT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.answerTXT.CustomButton.UseSelectable = true;
            this.answerTXT.CustomButton.Visible = false;
            this.answerTXT.DisplayIcon = true;
            this.answerTXT.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.answerTXT.Lines = new string[0];
            this.answerTXT.Location = new System.Drawing.Point(96, 63);
            this.answerTXT.MaxLength = 32767;
            this.answerTXT.Name = "answerTXT";
            this.answerTXT.PasswordChar = '\0';
            this.answerTXT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.answerTXT.SelectedText = "";
            this.answerTXT.SelectionLength = 0;
            this.answerTXT.SelectionStart = 0;
            this.answerTXT.ShowClearButton = true;
            this.answerTXT.Size = new System.Drawing.Size(663, 32);
            this.answerTXT.Style = MetroFramework.MetroColorStyle.Red;
            this.answerTXT.TabIndex = 477;
            this.answerTXT.UseCustomForeColor = true;
            this.answerTXT.UseSelectable = true;
            this.answerTXT.WaterMark = "Question";
            this.answerTXT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.answerTXT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // aitemTXT
            // 
            // 
            // 
            // 
            this.aitemTXT.CustomButton.Image = null;
            this.aitemTXT.CustomButton.Location = new System.Drawing.Point(43, 2);
            this.aitemTXT.CustomButton.Name = "";
            this.aitemTXT.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.aitemTXT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.aitemTXT.CustomButton.TabIndex = 1;
            this.aitemTXT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.aitemTXT.CustomButton.UseSelectable = true;
            this.aitemTXT.CustomButton.Visible = false;
            this.aitemTXT.DisplayIcon = true;
            this.aitemTXT.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.aitemTXT.Lines = new string[0];
            this.aitemTXT.Location = new System.Drawing.Point(15, 63);
            this.aitemTXT.MaxLength = 32767;
            this.aitemTXT.Name = "aitemTXT";
            this.aitemTXT.PasswordChar = '\0';
            this.aitemTXT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.aitemTXT.SelectedText = "";
            this.aitemTXT.SelectionLength = 0;
            this.aitemTXT.SelectionStart = 0;
            this.aitemTXT.ShowClearButton = true;
            this.aitemTXT.Size = new System.Drawing.Size(73, 32);
            this.aitemTXT.Style = MetroFramework.MetroColorStyle.Red;
            this.aitemTXT.TabIndex = 476;
            this.aitemTXT.UseCustomForeColor = true;
            this.aitemTXT.UseSelectable = true;
            this.aitemTXT.WaterMark = "Item No";
            this.aitemTXT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.aitemTXT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextButton2
            // 
            this.metroTextButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTextButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTextButton2.Image = null;
            this.metroTextButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTextButton2.Location = new System.Drawing.Point(661, 104);
            this.metroTextButton2.Name = "metroTextButton2";
            this.metroTextButton2.Size = new System.Drawing.Size(98, 30);
            this.metroTextButton2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextButton2.TabIndex = 472;
            this.metroTextButton2.Text = "refresh";
            this.metroTextButton2.UseSelectable = true;
            this.metroTextButton2.UseVisualStyleBackColor = true;
            this.metroTextButton2.Click += new System.EventHandler(this.metroTextButton2_Click);
            // 
            // metroTextButton1
            // 
            this.metroTextButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTextButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTextButton1.Image = null;
            this.metroTextButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTextButton1.Location = new System.Drawing.Point(349, 104);
            this.metroTextButton1.Name = "metroTextButton1";
            this.metroTextButton1.Size = new System.Drawing.Size(98, 30);
            this.metroTextButton1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextButton1.TabIndex = 475;
            this.metroTextButton1.Text = "add";
            this.metroTextButton1.UseSelectable = true;
            this.metroTextButton1.UseVisualStyleBackColor = true;
            this.metroTextButton1.Click += new System.EventHandler(this.metroTextButton1_Click_1);
            // 
            // metroTextButton4
            // 
            this.metroTextButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTextButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTextButton4.Image = null;
            this.metroTextButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTextButton4.Location = new System.Drawing.Point(557, 104);
            this.metroTextButton4.Name = "metroTextButton4";
            this.metroTextButton4.Size = new System.Drawing.Size(98, 30);
            this.metroTextButton4.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextButton4.TabIndex = 473;
            this.metroTextButton4.Text = "delete";
            this.metroTextButton4.UseSelectable = true;
            this.metroTextButton4.UseVisualStyleBackColor = true;
            this.metroTextButton4.Click += new System.EventHandler(this.metroTextButton4_Click);
            // 
            // metroTextButton3
            // 
            this.metroTextButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTextButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTextButton3.Image = null;
            this.metroTextButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTextButton3.Location = new System.Drawing.Point(453, 104);
            this.metroTextButton3.Name = "metroTextButton3";
            this.metroTextButton3.Size = new System.Drawing.Size(98, 30);
            this.metroTextButton3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextButton3.TabIndex = 474;
            this.metroTextButton3.Text = "update";
            this.metroTextButton3.UseSelectable = true;
            this.metroTextButton3.UseVisualStyleBackColor = true;
            this.metroTextButton3.Click += new System.EventHandler(this.metroTextButton3_Click_1);
            // 
            // answerGRID
            // 
            this.answerGRID.AllowUserToAddRows = false;
            this.answerGRID.AllowUserToDeleteRows = false;
            this.answerGRID.AllowUserToOrderColumns = true;
            this.answerGRID.AllowUserToResizeColumns = false;
            this.answerGRID.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.answerGRID.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.answerGRID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.answerGRID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.answerGRID.ColumnHeadersHeight = 30;
            this.answerGRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.answerGRID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answerGRID.Location = new System.Drawing.Point(10, 163);
            this.answerGRID.MultiSelect = false;
            this.answerGRID.Name = "answerGRID";
            this.answerGRID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.answerGRID.ReadOnly = true;
            this.answerGRID.RowHeadersVisible = false;
            this.answerGRID.RowHeadersWidth = 40;
            this.answerGRID.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.answerGRID.RowTemplate.Height = 40;
            this.answerGRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.answerGRID.Size = new System.Drawing.Size(777, 262);
            this.answerGRID.StateCommon.Background.Color1 = System.Drawing.Color.WhiteSmoke;
            this.answerGRID.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.answerGRID.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.answerGRID.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.answerGRID.StateCommon.DataCell.Content.Padding = new System.Windows.Forms.Padding(-1, 10, -1, 10);
            this.answerGRID.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.answerGRID.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.answerGRID.StateCommon.HeaderColumn.Border.Width = 0;
            this.answerGRID.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.answerGRID.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerGRID.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.answerGRID.TabIndex = 478;
            this.answerGRID.SelectionChanged += new System.EventHandler(this.answerGRID_SelectionChanged);
            // 
            // questionnaireFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 550);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "questionnaireFRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.questionnaireFRM_FormClosing);
            this.Load += new System.EventHandler(this.questionnaireFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionGRID)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.answerGRID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal MetroFramework.Controls.MetroTextBox.MetroTextButton refreshBTN;
        internal ComponentFactory.Krypton.Toolkit.KryptonDataGridView questionGRID;
        internal MetroFramework.Controls.MetroTextBox.MetroTextButton deleteBTN;
        internal MetroFramework.Controls.MetroTextBox.MetroTextButton updateBTN;
        internal MetroFramework.Controls.MetroTextBox.MetroTextButton addBTN;
        internal MetroFramework.Controls.MetroTextBox itemTXT;
        internal MetroFramework.Controls.MetroTextBox questionTXT;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        internal ComponentFactory.Krypton.Toolkit.KryptonDataGridView answerGRID;
        internal MetroFramework.Controls.MetroTextBox answerTXT;
        internal MetroFramework.Controls.MetroTextBox aitemTXT;
        internal MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton1;
        internal MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton2;
        internal MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton3;
        internal MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton4;
        internal MetroFramework.Controls.MetroTextBox question;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}