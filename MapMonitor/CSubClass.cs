using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;
using MapMonitor.Properties;

namespace Com.SubClass
{
    internal enum DtType
    {
        LongDate = 0,   //yyyy-MM-dd
        LongTime = 1,   //yyyy-MM-dd HH:mm
    }

    public class ExComboBox
    {
        public int Index { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public string Tag { get; set; }

        public ExComboBox(int pIndex, string pKey, string pValue)
        {
            this.Index = pIndex;
            this.Key = pKey;
            this.Value = pValue;
        }

        public ExComboBox(int pIndex, string pKey, string pValue, string pTag)
        {
            this.Index = pIndex;
            this.Key = pKey;
            this.Value = pValue;
            this.Tag = pTag;
        }
        public override string ToString()
        {
            return this.Value;
        }
    }

    public class ExColumn
    {
        public string Key { get; set; }
        public string Txt { get; set; }
        public Bitmap Img { get; set; }

        public ExColumn(string pKey, string pTxt, Bitmap pImg)
        {
            this.Key = pKey;
            this.Txt = pTxt;
            this.Img = pImg;
        }
    }

    internal class CSubClass
    {
        internal static void SetXtraTxtMask(object frm)
        {
            foreach (Control ctl in (frm as Control).Controls)
            {
                if (ctl.Controls.Count != 0)
                {
                    SetXtraTxtMask(ctl);
                }

                if (ctl is DevExpress.XtraEditors.TextEdit)
                {
                    (ctl as DevExpress.XtraEditors.TextEdit).Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
                    //(ctl as DevExpress.XtraEditors.TextEdit).Properties.Mask.EditMask = @"[\u4e00-\u9fa5]|\w+";
                    (ctl as DevExpress.XtraEditors.TextEdit).Properties.Mask.EditMask = @"[^']+";   //过滤单引号
                }
            }
        }

        internal static void SetXtraDtpStyle(DevExpress.XtraEditors.DateEdit dtp, DtType dtType)
        {
            switch (dtType)
            {
                case DtType.LongDate:
                    //设置Mask.EditMask和DisplayFormat,EditFormat属性，设置为一致：'yyyy-MM-dd';  //按照想要的显示格式设置此字符串。
                    dtp.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                    dtp.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
                    dtp.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                    dtp.Properties.EditFormat.FormatString = "yyyy-MM-dd";
                    dtp.Properties.Mask.EditMask = "yyyy-MM-dd";
                    break;

                case DtType.LongTime:
                    //设置Mask.EditMask和DisplayFormat,EditFormat属性，设置为一致：'yyyy-MM-dd HH:mm';  //按照想要的显示格式设置此字符串。
                    dtp.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                    dtp.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm";
                    dtp.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                    dtp.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm";
                    dtp.Properties.Mask.EditMask = "yyyy-MM-dd HH:mm";
                    //2. 如果要显示时间需要设置VistaDisplayMode=true, VistaEditTime=true。意思为显示时间，在时间控件中会出现时钟图标，并可以编辑时间。
                    dtp.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
                    dtp.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.True;
                    //3. 设置时间部分的格式，时间部分指的是打开日期空间后，在时钟图标下的显示的日期格式
                    dtp.Properties.VistaTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                    dtp.Properties.VistaTimeProperties.DisplayFormat.FormatString = "HH:mm";
                    dtp.Properties.VistaTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                    dtp.Properties.VistaTimeProperties.EditFormat.FormatString = "HH:mm";
                    dtp.Properties.VistaTimeProperties.Mask.EditMask = "HH:mm";
                    break;
            }
        }

        internal static void SetXtraTmrStyle(DevExpress.XtraEditors.TimeEdit tmr)
        {
            //设置Mask.EditMask和DisplayFormat,EditFormat属性，设置为一致：'HH:mm';  //按照想要的显示格式设置此字符串。
            tmr.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            tmr.Properties.DisplayFormat.FormatString = "HH:mm";
            tmr.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            tmr.Properties.EditFormat.FormatString = "HH:mm";
            tmr.Properties.Mask.EditMask = "HH:mm";
        }

        internal static void FindInCbo(DevExpress.XtraEditors.ComboBoxEdit cbo, string str)
        {
            for (int i = 0; i < cbo.Properties.Items.Count; i++)
            {
                if (((ExComboBox)cbo.Properties.Items[i]).Key == str)
                {
                    cbo.SelectedIndex = i;
                    break;
                }
            }
        }

        internal static void SetNodeFocus(DevExpress.XtraTreeList.TreeList treeList, DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs e)
        {
            if (e.Node == treeList.FocusedNode)
            {

                e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds);

                Rectangle r = new Rectangle(e.EditViewInfo.ContentRect.Left,
                                           e.EditViewInfo.ContentRect.Top,
                                            Convert.ToInt32(e.Graphics.MeasureString(e.CellText, treeList.Font).Width + 1),
                                            Convert.ToInt32(e.Graphics.MeasureString(e.CellText, treeList.Font).Height));

                e.Graphics.FillRectangle(SystemBrushes.Highlight, r);

                e.Graphics.DrawString(e.CellText, treeList.Font, SystemBrushes.HighlightText, r);

                e.Handled = true;
            }
        }

        internal static void SetXtraGridStyle(DevExpress.XtraGrid.Views.Grid.GridView grid)
        {
            grid.Appearance.EvenRow.BackColor = System.Drawing.Color.Honeydew;
            grid.Appearance.EvenRow.Options.UseBackColor = true;
            grid.Appearance.GroupFooter.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            grid.Appearance.GroupFooter.Options.UseFont = true;
            grid.Appearance.GroupPanel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            grid.Appearance.GroupPanel.Options.UseFont = true;
            grid.Appearance.GroupRow.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            grid.Appearance.GroupRow.Options.UseFont = true;
            grid.Appearance.HeaderPanel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            grid.Appearance.HeaderPanel.Options.UseFont = true;
            grid.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            grid.Appearance.OddRow.Options.UseBackColor = true;
            grid.Appearance.Preview.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            grid.Appearance.Preview.Options.UseFont = true;
            grid.Appearance.Row.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            grid.Appearance.Row.Options.UseFont = true;
            grid.Appearance.TopNewRow.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            grid.Appearance.TopNewRow.Options.UseFont = true;
            grid.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            grid.IndicatorWidth = 40;
            grid.OptionsBehavior.Editable = false;
            grid.OptionsCustomization.AllowFilter = false;
            grid.OptionsCustomization.AllowQuickHideColumns = false;
            grid.OptionsSelection.EnableAppearanceFocusedCell = false;
            //grid.OptionsView.EnableAppearanceEvenRow = true;
            //grid.OptionsView.EnableAppearanceOddRow = true;
            grid.OptionsView.ShowGroupPanel = false;
        }

        internal static void SetXtraGridStyle(DevExpress.XtraGrid.Views.BandedGrid.BandedGridView grid)
        {
            grid.Appearance.EvenRow.BackColor = System.Drawing.Color.Honeydew;
            grid.Appearance.EvenRow.Options.UseBackColor = true;
            grid.Appearance.GroupFooter.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            grid.Appearance.GroupFooter.Options.UseFont = true;
            grid.Appearance.GroupPanel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            grid.Appearance.GroupPanel.Options.UseFont = true;
            grid.Appearance.GroupRow.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            grid.Appearance.GroupRow.Options.UseFont = true;
            grid.Appearance.HeaderPanel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            grid.Appearance.HeaderPanel.Options.UseFont = true;
            grid.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            grid.Appearance.OddRow.Options.UseBackColor = true;
            grid.Appearance.Preview.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            grid.Appearance.Preview.Options.UseFont = true;
            grid.Appearance.Row.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            grid.Appearance.Row.Options.UseFont = true;
            grid.Appearance.TopNewRow.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            grid.Appearance.TopNewRow.Options.UseFont = true;
            grid.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            grid.IndicatorWidth = 40;
            grid.OptionsBehavior.Editable = false;
            grid.OptionsCustomization.AllowFilter = false;
            grid.OptionsCustomization.AllowQuickHideColumns = false;
            grid.OptionsSelection.EnableAppearanceFocusedCell = false;
            //grid.OptionsView.EnableAppearanceEvenRow = true;
            //grid.OptionsView.EnableAppearanceOddRow = true;
            grid.OptionsView.ShowGroupPanel = false;

            grid.Appearance.BandPanel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            grid.Appearance.BandPanel.Options.UseFont = true;
        }

        internal static RepositoryItemButtonEdit CreateDefOprColumn()
        {
            return CreateOprColumn(new ExColumn[] { 
                new ExColumn("edit","编辑", Resources.ico_edit),
                new ExColumn("delete","删除", Resources.ico_delete),
                new ExColumn("disable","禁用", Resources.ico_stop)
            });
        }

        internal static RepositoryItemButtonEdit CreateDefOprColumn(bool includeDisable)
        {
            if (includeDisable)
            {
                return CreateDefOprColumn();
            }
            else
            {
                return CreateOprColumn(new ExColumn[] { 
                    new ExColumn("edit","编辑", Resources.ico_edit),
                    new ExColumn("delete","删除", Resources.ico_delete)
                });
            }
        }

        internal static RepositoryItemButtonEdit CreateOprColumn(ExColumn[] pColumn)
        {
            RepositoryItemButtonEdit riButtonEdit = new RepositoryItemButtonEdit();
            riButtonEdit.TextEditStyle = TextEditStyles.HideTextEditor;
            riButtonEdit.Buttons.Clear();

            for (int i = 0; i < pColumn.Length; i++)
            {
                EditorButton btnEdit = new EditorButton();
                btnEdit.Kind = ButtonPredefines.Glyph;
                btnEdit.Appearance.Font = new System.Drawing.Font("微软雅黑", 9);
                btnEdit.Caption = pColumn[i].Txt;
                btnEdit.Tag = pColumn[i].Key;
                btnEdit.Image = pColumn[i].Img;
                btnEdit.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
                btnEdit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
                riButtonEdit.Buttons.Add(btnEdit);
            }

            return riButtonEdit;
        }

        internal static void ClearRows(DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            bool _mutilSelected = gridView.OptionsSelection.MultiSelect;//获取当前是否可以多选
            if (!_mutilSelected)
                gridView.OptionsSelection.MultiSelect = true;
            gridView.SelectAll();
            gridView.DeleteSelectedRows();
            gridView.OptionsSelection.MultiSelect = _mutilSelected;//还原之前是否可以多选状态
        }

        internal static void SetEmptyForeground(DevExpress.XtraGrid.Views.Grid.GridView dgv, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            if (dgv.RowCount == 0)
            {
                string str = "没有查询到你所想要的数据!";
                Font f = new Font("微软雅黑", 10, FontStyle.Bold);
                Rectangle r = new Rectangle(e.Bounds.Left + 5, e.Bounds.Top + 5, e.Bounds.Width - 5, e.Bounds.Height - 5);
                e.Graphics.DrawString(str, f, Brushes.SteelBlue, r);
            }
        }

        internal static void ExpToExcel(DevExpress.XtraGrid.GridControl grid)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "导出Excel";
            saveFileDialog.Filter = "Excel文件(*.xls)|*.xls";
            DialogResult dialogResult = saveFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                DevExpress.XtraPrinting.XlsExportOptions options = new DevExpress.XtraPrinting.XlsExportOptions();
                grid.ExportToXls(saveFileDialog.FileName);
                DevExpress.XtraEditors.XtraMessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 设置表格基本属性
        /// </summary>
        /// <param name="dgv"></param>
        internal static void SetDgvStyle(DataGridView dgv)
        {
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersHeight = 30;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(239, 239, 239);
            //dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);
            //dgv.ColumnHeadersDefaultCellStyle.Font = new Font("微软雅黑", 9, System.Drawing.FontStyle.Bold);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(249, 249, 249);
            dgv.RowsDefaultCellStyle.BackColor = Color.FromArgb(253, 252, 248);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(198, 217, 253);
            dgv.GridColor = Color.FromArgb(221, 221, 221);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.RowTemplate.Height = 30;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Font = new Font("微软雅黑", 9);
        }

        internal static void SetExProp(DataGridView dgv)
        {
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                dgv.Columns[i].MinimumWidth = dgv.Columns[i].Width;
                dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// 自动根据表格高度填充空白行
        /// </summary>
        /// <param name="dgv"></param>
        internal static void FillDgvRows(DataGridView dgv)
        {
            if (dgv.Columns.Count == 0)
            {
                return;
            }

            int realRows = 0;
            int visRows = 0;

            realRows = GetRealRows(dgv);
            visRows = (int)(Decimal.Ceiling(dgv.ClientSize.Height / dgv.RowTemplate.Height)) - 1;

            if (realRows < visRows)
            {
                //删除多余的行
                if (visRows < dgv.Rows.Count)
                {
                    for (int j = dgv.Rows.Count; j > visRows; j--)
                    {
                        dgv.Rows.RemoveAt(j - 1);
                    }
                }
                else
                {
                    for (int j = dgv.Rows.Count; j <= visRows; j++)
                    {
                        dgv.Rows.Add();
                    }
                }
            }
            else
            {
                //删除多余的行
                if (realRows < dgv.Rows.Count)
                {
                    for (int j = dgv.Rows.Count; j > realRows; j--)
                    {
                        dgv.Rows.RemoveAt(j - 1);
                    }
                }
            }
        }

        /// <summary>
        /// 获取表格有效数据行
        /// </summary>
        /// <param name="dgv"></param>
        /// <returns></returns>
        internal static int GetRealRows(DataGridView dgv)
        {
            int j = 0;

            for (int i = 1; i <= dgv.Rows.Count; i++)
            {
                if (dgv.Rows[i - 1].Cells[0].Value != null)
                {
                    j++;
                }
                else
                {
                    break;
                }
            }

            return j;
        }

        internal static int AddRows(DataGridView dgv)
        {
            int realRows = 0;

            realRows = GetRealRows(dgv);

            if (realRows == dgv.Rows.Count)
            {
                dgv.Rows.Add();
            }

            return realRows;
        }
    }
}
