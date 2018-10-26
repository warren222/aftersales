namespace AfterSalesCSharp.forms
{
    partial class itemfinderFRM
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
            this.projectname = new System.Windows.Forms.ComboBox();
            this.joborder = new System.Windows.Forms.ComboBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.metroTextButton2 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.itemGRID = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.address = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.itemGRID)).BeginInit();
            this.SuspendLayout();
            // 
            // projectname
            // 
            this.projectname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.projectname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.projectname.DropDownHeight = 250;
            this.projectname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectname.FormattingEnabled = true;
            this.projectname.IntegralHeight = false;
            this.projectname.Location = new System.Drawing.Point(47, 90);
            this.projectname.Name = "projectname";
            this.projectname.Size = new System.Drawing.Size(608, 24);
            this.projectname.TabIndex = 0;
            this.projectname.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseDown);
            // 
            // joborder
            // 
            this.joborder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.joborder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.joborder.DropDownHeight = 250;
            this.joborder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joborder.FormattingEnabled = true;
            this.joborder.IntegralHeight = false;
            this.joborder.Location = new System.Drawing.Point(47, 150);
            this.joborder.Name = "joborder";
            this.joborder.Size = new System.Drawing.Size(425, 24);
            this.joborder.TabIndex = 1;
            this.joborder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.joborder_MouseDown);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(47, 122);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(108, 22);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 496;
            this.kryptonLabel3.Values.Text = "JOB ORDER NO:";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(46, 62);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(109, 22);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 497;
            this.kryptonLabel1.Values.Text = "PROJECT NAME:";
            // 
            // metroTextButton2
            // 
            this.metroTextButton2.BackColor = System.Drawing.Color.DarkGray;
            this.metroTextButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTextButton2.Image = null;
            this.metroTextButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTextButton2.Location = new System.Drawing.Point(478, 150);
            this.metroTextButton2.Name = "metroTextButton2";
            this.metroTextButton2.Size = new System.Drawing.Size(177, 28);
            this.metroTextButton2.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTextButton2.TabIndex = 498;
            this.metroTextButton2.Text = "FIND";
            this.metroTextButton2.UseCustomBackColor = true;
            this.metroTextButton2.UseSelectable = true;
            this.metroTextButton2.UseVisualStyleBackColor = false;
            this.metroTextButton2.Click += new System.EventHandler(this.metroTextButton2_Click);
            // 
            // itemGRID
            // 
            this.itemGRID.AllowUserToAddRows = false;
            this.itemGRID.AllowUserToDeleteRows = false;
            this.itemGRID.AllowUserToOrderColumns = true;
            this.itemGRID.AllowUserToResizeColumns = false;
            this.itemGRID.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.itemGRID.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.itemGRID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemGRID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.itemGRID.ColumnHeadersHeight = 30;
            this.itemGRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.itemGRID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemGRID.Location = new System.Drawing.Point(3, 218);
            this.itemGRID.MultiSelect = false;
            this.itemGRID.Name = "itemGRID";
            this.itemGRID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.itemGRID.ReadOnly = true;
            this.itemGRID.RowHeadersWidth = 40;
            this.itemGRID.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.itemGRID.RowTemplate.Height = 27;
            this.itemGRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemGRID.Size = new System.Drawing.Size(692, 273);
            this.itemGRID.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.itemGRID.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.itemGRID.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.itemGRID.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.itemGRID.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.itemGRID.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.itemGRID.StateCommon.HeaderColumn.Border.Width = 0;
            this.itemGRID.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.itemGRID.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemGRID.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.itemGRID.TabIndex = 499;
            this.itemGRID.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemGRID_CellClick);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(46, 180);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(56, 22);
            this.address.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.address.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.TabIndex = 500;
            this.address.Values.Text = "address";
            // 
            // itemfinderFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 513);
            this.Controls.Add(this.address);
            this.Controls.Add(this.itemGRID);
            this.Controls.Add(this.metroTextButton2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.joborder);
            this.Controls.Add(this.projectname);
            this.Name = "itemfinderFRM";
            this.Text = "Find Items";
            this.Load += new System.EventHandler(this.itemfinderFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemGRID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox projectname;
        private System.Windows.Forms.ComboBox joborder;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        internal MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton2;
        internal ComponentFactory.Krypton.Toolkit.KryptonDataGridView itemGRID;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel address;
    }
}