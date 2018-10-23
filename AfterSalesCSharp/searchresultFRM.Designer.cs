namespace AfterSalesCSharp
{
    partial class searchresultFRM
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
            this.searchResultGridview = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // searchResultGridview
            // 
            this.searchResultGridview.AllowUserToAddRows = false;
            this.searchResultGridview.AllowUserToDeleteRows = false;
            this.searchResultGridview.AllowUserToOrderColumns = true;
            this.searchResultGridview.AllowUserToResizeColumns = false;
            this.searchResultGridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.searchResultGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.searchResultGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.searchResultGridview.ColumnHeadersHeight = 30;
            this.searchResultGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.searchResultGridview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchResultGridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchResultGridview.Location = new System.Drawing.Point(20, 60);
            this.searchResultGridview.Name = "searchResultGridview";
            this.searchResultGridview.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.searchResultGridview.ReadOnly = true;
            this.searchResultGridview.RowHeadersWidth = 40;
            this.searchResultGridview.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.searchResultGridview.RowTemplate.Height = 27;
            this.searchResultGridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchResultGridview.Size = new System.Drawing.Size(658, 426);
            this.searchResultGridview.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.searchResultGridview.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.searchResultGridview.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.searchResultGridview.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchResultGridview.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(68)))), ((int)(((byte)(55)))));
            this.searchResultGridview.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(68)))), ((int)(((byte)(55)))));
            this.searchResultGridview.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.searchResultGridview.StateCommon.HeaderColumn.Border.Width = 0;
            this.searchResultGridview.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.searchResultGridview.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchResultGridview.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.searchResultGridview.TabIndex = 472;
            this.searchResultGridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchResultGridview_CellClick);
            this.searchResultGridview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchResultGridview_CellDoubleClick);
            this.searchResultGridview.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.searchResultGridview_RowPostPaint);
            // 
            // searchresultFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 506);
            this.Controls.Add(this.searchResultGridview);
            this.Name = "searchresultFRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Search Result";
            this.Load += new System.EventHandler(this.searchresultFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchResultGridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal ComponentFactory.Krypton.Toolkit.KryptonDataGridView searchResultGridview;
    }
}