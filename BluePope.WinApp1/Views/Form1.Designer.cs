namespace BluePope.WinApp1.Views
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            this.ultraPanel1 = new Infragistics.Win.Misc.UltraPanel();
            this.btnSave = new Infragistics.Win.Misc.UltraButton();
            this.btnDelete = new Infragistics.Win.Misc.UltraButton();
            this.btnAdd = new Infragistics.Win.Misc.UltraButton();
            this.btnSearch = new Infragistics.Win.Misc.UltraButton();
            this.popeGrid1 = new BluePope.Lib.Controls.PopeGrid();
            this.ultraPanel1.ClientArea.SuspendLayout();
            this.ultraPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popeGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraPanel1
            // 
            // 
            // ultraPanel1.ClientArea
            // 
            this.ultraPanel1.ClientArea.Controls.Add(this.btnSave);
            this.ultraPanel1.ClientArea.Controls.Add(this.btnDelete);
            this.ultraPanel1.ClientArea.Controls.Add(this.btnAdd);
            this.ultraPanel1.ClientArea.Controls.Add(this.btnSearch);
            this.ultraPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ultraPanel1.Location = new System.Drawing.Point(0, 0);
            this.ultraPanel1.Name = "ultraPanel1";
            this.ultraPanel1.Size = new System.Drawing.Size(800, 94);
            this.ultraPanel1.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(533, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(164, 51);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "저장";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(363, 21);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(164, 51);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "삭제";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(193, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(164, 51);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "추가";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(23, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(164, 51);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "조회";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // popeGrid1
            // 
            appearance1.BackColor = System.Drawing.SystemColors.Window;
            appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.popeGrid1.DisplayLayout.Appearance = appearance1;
            this.popeGrid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.popeGrid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance2.BorderColor = System.Drawing.SystemColors.Window;
            this.popeGrid1.DisplayLayout.GroupByBox.Appearance = appearance2;
            appearance3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.popeGrid1.DisplayLayout.GroupByBox.BandLabelAppearance = appearance3;
            this.popeGrid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance4.BackColor2 = System.Drawing.SystemColors.Control;
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.popeGrid1.DisplayLayout.GroupByBox.PromptAppearance = appearance4;
            this.popeGrid1.DisplayLayout.MaxColScrollRegions = 1;
            this.popeGrid1.DisplayLayout.MaxRowScrollRegions = 1;
            appearance5.BackColor = System.Drawing.SystemColors.Window;
            appearance5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.popeGrid1.DisplayLayout.Override.ActiveCellAppearance = appearance5;
            appearance6.BackColor = System.Drawing.SystemColors.Highlight;
            appearance6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.popeGrid1.DisplayLayout.Override.ActiveRowAppearance = appearance6;
            this.popeGrid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.popeGrid1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance7.BackColor = System.Drawing.SystemColors.Window;
            this.popeGrid1.DisplayLayout.Override.CardAreaAppearance = appearance7;
            appearance8.BorderColor = System.Drawing.Color.Silver;
            appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.popeGrid1.DisplayLayout.Override.CellAppearance = appearance8;
            this.popeGrid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.popeGrid1.DisplayLayout.Override.CellPadding = 0;
            appearance9.BackColor = System.Drawing.SystemColors.Control;
            appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance9.BorderColor = System.Drawing.SystemColors.Window;
            this.popeGrid1.DisplayLayout.Override.GroupByRowAppearance = appearance9;
            appearance10.TextHAlignAsString = "Left";
            this.popeGrid1.DisplayLayout.Override.HeaderAppearance = appearance10;
            this.popeGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.popeGrid1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance11.BackColor = System.Drawing.SystemColors.Window;
            appearance11.BorderColor = System.Drawing.Color.Silver;
            this.popeGrid1.DisplayLayout.Override.RowAppearance = appearance11;
            this.popeGrid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.popeGrid1.DisplayLayout.Override.TemplateAddRowAppearance = appearance12;
            this.popeGrid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.popeGrid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.popeGrid1.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            this.popeGrid1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.popeGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.popeGrid1.Location = new System.Drawing.Point(0, 94);
            this.popeGrid1.Name = "popeGrid1";
            this.popeGrid1.Size = new System.Drawing.Size(800, 356);
            this.popeGrid1.TabIndex = 6;
            this.popeGrid1.Text = "popeGrid1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.popeGrid1);
            this.Controls.Add(this.ultraPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ultraPanel1.ClientArea.ResumeLayout(false);
            this.ultraPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popeGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraPanel ultraPanel1;
        private Infragistics.Win.Misc.UltraButton btnSave;
        private Infragistics.Win.Misc.UltraButton btnDelete;
        private Infragistics.Win.Misc.UltraButton btnAdd;
        private Infragistics.Win.Misc.UltraButton btnSearch;
        private Lib.Controls.PopeGrid popeGrid1;
    }
}