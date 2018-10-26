namespace AfterSalesCSharp
{
    partial class concerndetailFRM
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
            this.questionGRID = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.answerGRID = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.questionGRID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerGRID)).BeginInit();
            this.SuspendLayout();
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
            this.questionGRID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.questionGRID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.questionGRID.ColumnHeadersHeight = 30;
            this.questionGRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.questionGRID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.questionGRID.Location = new System.Drawing.Point(0, 63);
            this.questionGRID.MultiSelect = false;
            this.questionGRID.Name = "questionGRID";
            this.questionGRID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.questionGRID.ReadOnly = true;
            this.questionGRID.RowHeadersVisible = false;
            this.questionGRID.RowHeadersWidth = 40;
            this.questionGRID.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.questionGRID.RowTemplate.Height = 27;
            this.questionGRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.questionGRID.Size = new System.Drawing.Size(489, 434);
            this.questionGRID.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.questionGRID.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.questionGRID.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.questionGRID.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.questionGRID.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(68)))), ((int)(((byte)(55)))));
            this.questionGRID.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(68)))), ((int)(((byte)(55)))));
            this.questionGRID.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.questionGRID.StateCommon.HeaderColumn.Border.Width = 0;
            this.questionGRID.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.questionGRID.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionGRID.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.questionGRID.TabIndex = 473;
            this.questionGRID.SelectionChanged += new System.EventHandler(this.questionGRID_SelectionChanged);
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
            this.answerGRID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.answerGRID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.answerGRID.ColumnHeadersHeight = 30;
            this.answerGRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.answerGRID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answerGRID.Location = new System.Drawing.Point(495, 63);
            this.answerGRID.Name = "answerGRID";
            this.answerGRID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.answerGRID.ReadOnly = true;
            this.answerGRID.RowHeadersVisible = false;
            this.answerGRID.RowHeadersWidth = 40;
            this.answerGRID.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.answerGRID.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.answerGRID.RowTemplate.Height = 27;
            this.answerGRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.answerGRID.Size = new System.Drawing.Size(513, 434);
            this.answerGRID.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.answerGRID.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.answerGRID.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.answerGRID.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.answerGRID.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(68)))), ((int)(((byte)(55)))));
            this.answerGRID.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(68)))), ((int)(((byte)(55)))));
            this.answerGRID.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.answerGRID.StateCommon.HeaderColumn.Border.Width = 0;
            this.answerGRID.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.answerGRID.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerGRID.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.answerGRID.TabIndex = 474;
            // 
            // concerndetailFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 520);
            this.Controls.Add(this.answerGRID);
            this.Controls.Add(this.questionGRID);
            this.MaximizeBox = false;
            this.Name = "concerndetailFRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Load += new System.EventHandler(this.concerndetailFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionGRID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerGRID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal ComponentFactory.Krypton.Toolkit.KryptonDataGridView questionGRID;
        internal ComponentFactory.Krypton.Toolkit.KryptonDataGridView answerGRID;
    }
}