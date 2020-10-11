using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BluePope.Lib.Controls;
using BluePope.Lib.Models;
using BluePope.WinApp1.Models;

using Infragistics.Win;

namespace BluePope.WinApp1.Views
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            popeGrid1.AddColumn("EmpNo", "사번", 80, PopeGrid.EditTypeEnum.EditOnlyNewRow);
            popeGrid1.AddColumn("HangulName", "성명", 80, PopeGrid.EditTypeEnum.Edit);
            popeGrid1.AddColumn("FullName", "사번성명", 80, PopeGrid.EditTypeEnum.ReadOnly);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            popeGrid1.DataSource = EmployModel.GetList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            popeGrid1.AddRow();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            popeGrid1.DeleteRow();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach(var row in popeGrid1.GetModifiedRows<EmployModel>())
            {
                if (row.RowState == ModelBase.RowStateEnum.New)
                {
                    //insert
                }
            }
        }
    }
}
