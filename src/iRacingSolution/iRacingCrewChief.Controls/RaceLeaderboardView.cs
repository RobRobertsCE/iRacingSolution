﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.ComponentModel.Design;
using iRacingCrewChief.Controls.ViewModels;

namespace iRacingCrewChief.Controls
{
    [ComplexBindingProperties("DataSource", "DataMember")]
    [DefaultBindingProperty("ViewModels")]
    [DefaultProperty("Items")]
    [HelpKeywordAttribute(typeof(UserControl))]
    [ToolboxItem("System.Windows.Forms.Design.AutoSizeToolboxItem,System.Design")]
    public partial class RaceLeaderboardView : UserControl
    {
        private ListChangedEventHandler listChangedHandler;
        private EventHandler positionChangedHandler;

       
        public IList<LeaderboardViewModel> ViewModels { get; set; }


        public IList<ColumnHeader> Columns { get; set; }
        //public int SelectedIndex { get { return listView1.SelectedIndex; } set{listView1.SelectedIndex = value}}
        public int SelectedIndex
        {
            get
            {
                if (listView1.SelectedIndices.Count > 0)
                    return listView1.SelectedIndices[0];
                else
                    return 0;
            }
            set { listView1.SelectedIndices.Add(value); ; }
        }
        public ListView.ListViewItemCollection Items { get { return listView1.Items; }  }
        public ListView.SelectedIndexCollection SelectedIndices
        {
            get { return listView1.SelectedIndices; }
        }

        private object dataSource;

        [TypeConverter("System.Windows.Forms.Design.DataSourceConverter, System.Design")]
        [Category("Data")]
        [DefaultValue(null)]
        public object DataSource
        {
            get
            {
                return this.dataSource;
            }
            set
            {
                if (this.dataSource != value)
                {
                    this.dataSource = value;
                    tryDataBinding();
                }
            }
        }

        private string dataMember;

        [Category("Data")]
        [Editor("System.Windows.Forms.Design.DataMemberListEditor,          System.Design", "System.Drawing.Design.UITypeEditor,          System.Drawing")]
        [DefaultValue("")]
        public string DataMember
        {
            get
            {
                return this.dataMember;
            }
            set
            {
                if (this.dataMember != value)
                {
                    this.dataMember = value;
                    tryDataBinding();
                }
            }
        }

        private CurrencyManager dataManager;
        private void tryDataBinding()
        {
            if (this.DataSource == null ||
                base.BindingContext == null)
                return;

            CurrencyManager cm;
            try
            {
                cm = (CurrencyManager)
                      base.BindingContext[this.DataSource, this.DataMember];
            }
            catch (System.ArgumentException)
            {
                // If no CurrencyManager was found
                return;
            }

            if (this.dataManager != cm)
            {
                // Unwire the old CurrencyManager
                if (this.dataManager != null)
                {
                    this.dataManager.ListChanged -= listChangedHandler;
                    this.dataManager.PositionChanged -= positionChangedHandler;
                }
                this.dataManager = cm;
                // Wire the new CurrencyManager
                if (this.dataManager != null)
                {
                    this.dataManager.ListChanged += listChangedHandler;
                    this.dataManager.PositionChanged += positionChangedHandler;
                }

                // Update metadata and data
                calculateColumns();
                updateAllData();
            }
        }

        private void calculateColumns()
        {
            this.Columns.Clear();
            if (dataManager == null)
                return;

            foreach (PropertyDescriptor prop in
                     dataManager.GetItemProperties())
            {
                ColumnHeader column = new ColumnHeader();
                column.Text = prop.Name;
                this.Columns.Add(column);
            }
        }

        private void updateAllData()
        {
            this.Items.Clear();
            for (int i = 0; i < dataManager.Count; i++)
            {
                addItem(i);
            }
        }

        private void addItem(int index)
        {
            ListViewItem item = getListViewItem(index);
            this.Items.Insert(index, item);
        }

        private ListViewItem getListViewItem(int index)
        {
            object row = dataManager.List[index];
            PropertyDescriptorCollection propColl =
                    dataManager.GetItemProperties();
            ArrayList items = new ArrayList();

            // Fill value for each column
            foreach (ColumnHeader column in this.Columns)
            {
                PropertyDescriptor prop = null;
                prop = propColl.Find(column.Text, false);
                if (prop != null)
                {
                    items.Add(prop.GetValue(row).ToString());
                }
            }
            return new ListViewItem((string[])items.ToArray(typeof(string)));
        }

        private void updateItem(int index)
        {
            if (index >= 0 &&
                index < this.Items.Count)
            {
                ListViewItem item = getListViewItem(index);
                this.Items[index] = item;
            }
        }

        private void deleteItem(int index)
        {
            if (index >= 0 &&
                index < this.Items.Count)
                this.Items.RemoveAt(index);
        }

        private void dataManager_PositionChanged(object sender, EventArgs e)
        {
            if (this.Items.Count > dataManager.Position)
            {
                this.Items[dataManager.Position].Selected = true;
                //this.EnsureVisible(dataManager.TirePosition);
            }
        }

        private void ListViewDataBinding_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.SelectedIndices.Count > 0 &&
                    dataManager.Position != this.SelectedIndices[0])
                    dataManager.Position = this.SelectedIndices[0];
            }
            catch
            {
                // Could appear, if you change the position
                // while someone edits a row with invalid data.
            }
        }
        //
        // overriden event from listview control, to write changes back to datasource.
        //
        //protected override void OnAfterLabelEdit(LabelEditEventArgs e)
        //{
        //    base.OnAfterLabelEdit(e);
        //    if (e.Label == null)
        //    {
        //        // If you press ESC while editing.
        //        e.CancelEdit = true;
        //        return;
        //    }

        //    if (dataManager.List.Count > e.Item)
        //    {
        //        object row = dataManager.List[e.Item];
        //        // In a ListView you are only able to edit the first Column.
        //        PropertyDescriptor col =
        //          dataManager.GetItemProperties().Find(this.Columns[0].Text, false);
        //        try
        //        {
        //            if (row != null &&
        //            col != null)
        //                col.SetValue(row, e.Label);
        //            dataManager.EndCurrentEdit();
        //        }
        //        catch (Exception ex)
        //        {
        //            // If you try to enter strings in number-columns,
        //            // too long strings or something
        //            // else wich is not allowed by the DataSource.
        //            MessageBox.Show("Edit failed:\r\n" + ex.Message,
        //                            "Edit failed", MessageBoxButtons.OK,
        //                            MessageBoxIcon.Error);
        //            dataManager.CancelCurrentEdit();
        //            e.CancelEdit = true;
        //        }
        //    }
        //}

        private void dataManager_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.Reset ||
            e.ListChangedType == ListChangedType.ItemMoved)
            {
                // Update all data
                updateAllData();
            }
            else if (e.ListChangedType == ListChangedType.ItemAdded)
            {
                // Add new Item
                addItem(e.NewIndex);
            }
            else if (e.ListChangedType == ListChangedType.ItemChanged)
            {
                // Change Item
                updateItem(e.NewIndex);
            }
            else if (e.ListChangedType == ListChangedType.ItemDeleted)
            {
                // Delete Item
                deleteItem(e.NewIndex);
            }
            else
            {
                // Update metadata and all data
                calculateColumns();
                updateAllData();
            }
        }

        protected override void OnBindingContextChanged(EventArgs e)
        {
            this.tryDataBinding();
            base.OnBindingContextChanged(e);
        }

        public RaceLeaderboardView()
        {
            InitializeComponent();

            listChangedHandler = new ListChangedEventHandler(dataManager_ListChanged);
            positionChangedHandler = new EventHandler(dataManager_PositionChanged);
        }
    }
}
