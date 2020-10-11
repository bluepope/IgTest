using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using BluePope.Lib.Models;

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;

namespace BluePope.Lib.Controls
{
    public class PopeGrid : UltraGrid
    {
        public enum EditTypeEnum
        {
            Edit,
            ReadOnly,
            EditOnlyNewRow
        }

        public PopeGrid()
        {
            this.BeforeEnterEditMode += PopeGrid_BeforeEnterEditMode;
            this.CellChange += PopeGrid_CellChange;
        }

        protected override void OnEndInit()
        {
            base.OnEndInit();

            this.DisplayLayout.NewColumnLoadStyle = Infragistics.Win.UltraWinGrid.NewColumnLoadStyle.Hide;
            this.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            this.DisplayLayout.Override.RowSelectors = DefaultableBoolean.True;
        }
        private void PopeGrid_CellChange(object sender, CellEventArgs e)
        {
            var cellObject = (e.Cell.Row.ListObject as ModelBase);
            if (cellObject.RowState == ModelBase.RowStateEnum.None)
            {
                cellObject.RowState = ModelBase.RowStateEnum.Modified;
            }
        }

        private void PopeGrid_BeforeEnterEditMode(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.ActiveCell.Column.Tag as string == "PK")
            {
                if ((this.ActiveRow.ListObject as ModelBase).RowState !=  ModelBase.RowStateEnum.New)
                {
                    e.Cancel = true;
                }
            }
        }

        public UltraGridRow AddRow()
        {
            var row = this.DisplayLayout.Bands[0].AddNew();
            (row.ListObject as ModelBase).RowState = ModelBase.RowStateEnum.New;

            return row;
        }

        public void AddColumn(string key, string caption, int width, EditTypeEnum editType)
        {
            var col = this.DisplayLayout.Bands[0].Columns.Add(key, caption);
            col.Width = width;

            if (editType == EditTypeEnum.Edit)
            {
                col.CellActivation = Activation.AllowEdit;
            }
            else if (editType == EditTypeEnum.ReadOnly)
            {
                col.CellActivation = Activation.NoEdit;
            }
            else if (editType == EditTypeEnum.EditOnlyNewRow)
            {
                col.CellActivation = Activation.AllowEdit;
                col.Tag = "PK";
            }
        }

        public void DeleteRow()
        {
            var deleteIndexList = new List<int>();
            int? activeIndex = this.ActiveRow?.Index;

            if (this.Selected.Rows.Count == 0)
            {
                if (this.ActiveRow != null)
                {
                    deleteIndexList.Add(this.ActiveRow.Index);
                }
            }
            else
            {
                foreach (var row in this.Selected.Rows)
                {
                    deleteIndexList.Add(row.Index);
                }
            }

            foreach (int idx in deleteIndexList.OrderByDescending(p => p))
            {
                var row = (this.Rows[idx].ListObject as ModelBase);
                if (row.RowState == ModelBase.RowStateEnum.New)
                {
                    this.Rows[idx].Delete(false);
                }
                else
                {
                    row.RowState = ModelBase.RowStateEnum.Deleted;
                    this.Rows[idx].Hidden = true;
                }

            }

            int focusRowIndex = activeIndex.GetValueOrDefault(0) - 1;

            if (this.Rows.Count == 0)
            {
                return;
            }
            else if (this.Rows.Count - 1 < focusRowIndex)
            {
                focusRowIndex = this.Rows.Count - 1;
            }
            else if (focusRowIndex < 0)
            {
                focusRowIndex = 0;
            }

            this.ActiveRow = this.Rows[focusRowIndex];
        }

        public List<T> GetModifiedRows<T>()
        {
            return ((BindingList<T>)this.DataSource).Where(p => (p as ModelBase).RowState != ModelBase.RowStateEnum.None).ToList();
        }

    }
}
