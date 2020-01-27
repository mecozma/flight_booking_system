namespace Cyanair20012020
{
    partial class admin_actions
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label flight_NoLabel;
            System.Windows.Forms.Label departingLabel;
            System.Windows.Forms.Label arrivingLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label timeLabel;
            System.Windows.Forms.Label economyLabel;
            System.Windows.Forms.Label businessLabel;
            System.Windows.Forms.Label firstLabel;
            System.Windows.Forms.Label durationLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_actions));
            this.cyanairDataSet = new Cyanair20012020.cyanairDataSet();
            this.cyanairScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cyanairScheduleTableAdapter = new Cyanair20012020.cyanairDataSetTableAdapters.CyanairScheduleTableAdapter();
            this.tableAdapterManager = new Cyanair20012020.cyanairDataSetTableAdapters.TableAdapterManager();
            this.cyanairScheduleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cyanairScheduleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cyanairScheduleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flight_NoTextBox = new System.Windows.Forms.TextBox();
            this.departingTextBox = new System.Windows.Forms.TextBox();
            this.arrivingTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.economyTextBox = new System.Windows.Forms.TextBox();
            this.businessTextBox = new System.Windows.Forms.TextBox();
            this.firstTextBox = new System.Windows.Forms.TextBox();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.btn_update_flight = new System.Windows.Forms.Button();
            this.btn_add_flight = new System.Windows.Forms.Button();
            this.btn_delete_flight = new System.Windows.Forms.Button();
            this.btn_search_flight = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.admin_actions_time = new System.Windows.Forms.TextBox();
            flight_NoLabel = new System.Windows.Forms.Label();
            departingLabel = new System.Windows.Forms.Label();
            arrivingLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            timeLabel = new System.Windows.Forms.Label();
            economyLabel = new System.Windows.Forms.Label();
            businessLabel = new System.Windows.Forms.Label();
            firstLabel = new System.Windows.Forms.Label();
            durationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cyanairDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyanairScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyanairScheduleBindingNavigator)).BeginInit();
            this.cyanairScheduleBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cyanairScheduleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // flight_NoLabel
            // 
            flight_NoLabel.AutoSize = true;
            flight_NoLabel.Location = new System.Drawing.Point(149, 40);
            flight_NoLabel.Name = "flight_NoLabel";
            flight_NoLabel.Size = new System.Drawing.Size(52, 13);
            flight_NoLabel.TabIndex = 2;
            flight_NoLabel.Text = "Flight No:";
            // 
            // departingLabel
            // 
            departingLabel.AutoSize = true;
            departingLabel.Location = new System.Drawing.Point(149, 66);
            departingLabel.Name = "departingLabel";
            departingLabel.Size = new System.Drawing.Size(56, 13);
            departingLabel.TabIndex = 4;
            departingLabel.Text = "Departing:";
            // 
            // arrivingLabel
            // 
            arrivingLabel.AutoSize = true;
            arrivingLabel.Location = new System.Drawing.Point(149, 92);
            arrivingLabel.Name = "arrivingLabel";
            arrivingLabel.Size = new System.Drawing.Size(45, 13);
            arrivingLabel.TabIndex = 6;
            arrivingLabel.Text = "Arriving:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(149, 119);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 8;
            dateLabel.Text = "Date:";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new System.Drawing.Point(149, 145);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new System.Drawing.Size(33, 13);
            timeLabel.TabIndex = 10;
            timeLabel.Text = "Time:";
            // 
            // economyLabel
            // 
            economyLabel.AutoSize = true;
            economyLabel.Location = new System.Drawing.Point(149, 170);
            economyLabel.Name = "economyLabel";
            economyLabel.Size = new System.Drawing.Size(54, 13);
            economyLabel.TabIndex = 12;
            economyLabel.Text = "Economy:";
            // 
            // businessLabel
            // 
            businessLabel.AutoSize = true;
            businessLabel.Location = new System.Drawing.Point(149, 196);
            businessLabel.Name = "businessLabel";
            businessLabel.Size = new System.Drawing.Size(52, 13);
            businessLabel.TabIndex = 14;
            businessLabel.Text = "Business:";
            // 
            // firstLabel
            // 
            firstLabel.AutoSize = true;
            firstLabel.Location = new System.Drawing.Point(149, 222);
            firstLabel.Name = "firstLabel";
            firstLabel.Size = new System.Drawing.Size(29, 13);
            firstLabel.TabIndex = 16;
            firstLabel.Text = "First:";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Location = new System.Drawing.Point(149, 248);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new System.Drawing.Size(50, 13);
            durationLabel.TabIndex = 18;
            durationLabel.Text = "Duration:";
            // 
            // cyanairDataSet
            // 
            this.cyanairDataSet.DataSetName = "cyanairDataSet";
            this.cyanairDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cyanairScheduleBindingSource
            // 
            this.cyanairScheduleBindingSource.DataMember = "CyanairSchedule";
            this.cyanairScheduleBindingSource.DataSource = this.cyanairDataSet;
            // 
            // cyanairScheduleTableAdapter
            // 
            this.cyanairScheduleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CyanairAirportsTableAdapter = null;
            this.tableAdapterManager.CyanairReservationTableAdapter = null;
            this.tableAdapterManager.CyanairScheduleTableAdapter = this.cyanairScheduleTableAdapter;
            this.tableAdapterManager.UpdateOrder = Cyanair20012020.cyanairDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cyanairScheduleBindingNavigator
            // 
            this.cyanairScheduleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cyanairScheduleBindingNavigator.BindingSource = this.cyanairScheduleBindingSource;
            this.cyanairScheduleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cyanairScheduleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cyanairScheduleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cyanairScheduleBindingNavigatorSaveItem});
            this.cyanairScheduleBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cyanairScheduleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cyanairScheduleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cyanairScheduleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cyanairScheduleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cyanairScheduleBindingNavigator.Name = "cyanairScheduleBindingNavigator";
            this.cyanairScheduleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cyanairScheduleBindingNavigator.Size = new System.Drawing.Size(965, 25);
            this.cyanairScheduleBindingNavigator.TabIndex = 0;
            this.cyanairScheduleBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cyanairScheduleBindingNavigatorSaveItem
            // 
            this.cyanairScheduleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cyanairScheduleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cyanairScheduleBindingNavigatorSaveItem.Image")));
            this.cyanairScheduleBindingNavigatorSaveItem.Name = "cyanairScheduleBindingNavigatorSaveItem";
            this.cyanairScheduleBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cyanairScheduleBindingNavigatorSaveItem.Text = "Save Data";
            this.cyanairScheduleBindingNavigatorSaveItem.Click += new System.EventHandler(this.cyanairScheduleBindingNavigatorSaveItem_Click);
            // 
            // cyanairScheduleDataGridView
            // 
            this.cyanairScheduleDataGridView.AutoGenerateColumns = false;
            this.cyanairScheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cyanairScheduleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.cyanairScheduleDataGridView.DataSource = this.cyanairScheduleBindingSource;
            this.cyanairScheduleDataGridView.Location = new System.Drawing.Point(0, 285);
            this.cyanairScheduleDataGridView.Name = "cyanairScheduleDataGridView";
            this.cyanairScheduleDataGridView.Size = new System.Drawing.Size(945, 220);
            this.cyanairScheduleDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Flight No";
            this.dataGridViewTextBoxColumn1.HeaderText = "Flight No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Departing";
            this.dataGridViewTextBoxColumn2.HeaderText = "Departing";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Arriving";
            this.dataGridViewTextBoxColumn3.HeaderText = "Arriving";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Time";
            this.dataGridViewTextBoxColumn5.HeaderText = "Time";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Economy";
            this.dataGridViewTextBoxColumn6.HeaderText = "Economy";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Business";
            this.dataGridViewTextBoxColumn7.HeaderText = "Business";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "First";
            this.dataGridViewTextBoxColumn8.HeaderText = "First";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Duration";
            this.dataGridViewTextBoxColumn9.HeaderText = "Duration";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // flight_NoTextBox
            // 
            this.flight_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cyanairScheduleBindingSource, "Flight No", true));
            this.flight_NoTextBox.Location = new System.Drawing.Point(211, 37);
            this.flight_NoTextBox.Name = "flight_NoTextBox";
            this.flight_NoTextBox.Size = new System.Drawing.Size(200, 20);
            this.flight_NoTextBox.TabIndex = 3;
            // 
            // departingTextBox
            // 
            this.departingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cyanairScheduleBindingSource, "Departing", true));
            this.departingTextBox.Location = new System.Drawing.Point(211, 63);
            this.departingTextBox.Name = "departingTextBox";
            this.departingTextBox.Size = new System.Drawing.Size(200, 20);
            this.departingTextBox.TabIndex = 5;
            // 
            // arrivingTextBox
            // 
            this.arrivingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cyanairScheduleBindingSource, "Arriving", true));
            this.arrivingTextBox.Location = new System.Drawing.Point(211, 89);
            this.arrivingTextBox.Name = "arrivingTextBox";
            this.arrivingTextBox.Size = new System.Drawing.Size(200, 20);
            this.arrivingTextBox.TabIndex = 7;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cyanairScheduleBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(211, 115);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 9;
            // 
            // economyTextBox
            // 
            this.economyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cyanairScheduleBindingSource, "Economy", true));
            this.economyTextBox.Location = new System.Drawing.Point(211, 167);
            this.economyTextBox.Name = "economyTextBox";
            this.economyTextBox.Size = new System.Drawing.Size(200, 20);
            this.economyTextBox.TabIndex = 13;
            // 
            // businessTextBox
            // 
            this.businessTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cyanairScheduleBindingSource, "Business", true));
            this.businessTextBox.Location = new System.Drawing.Point(211, 193);
            this.businessTextBox.Name = "businessTextBox";
            this.businessTextBox.Size = new System.Drawing.Size(200, 20);
            this.businessTextBox.TabIndex = 15;
            // 
            // firstTextBox
            // 
            this.firstTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cyanairScheduleBindingSource, "First", true));
            this.firstTextBox.Location = new System.Drawing.Point(211, 219);
            this.firstTextBox.Name = "firstTextBox";
            this.firstTextBox.Size = new System.Drawing.Size(200, 20);
            this.firstTextBox.TabIndex = 17;
            // 
            // durationTextBox
            // 
            this.durationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cyanairScheduleBindingSource, "Duration", true));
            this.durationTextBox.Location = new System.Drawing.Point(211, 245);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(200, 20);
            this.durationTextBox.TabIndex = 19;
            // 
            // btn_update_flight
            // 
            this.btn_update_flight.Location = new System.Drawing.Point(499, 40);
            this.btn_update_flight.Name = "btn_update_flight";
            this.btn_update_flight.Size = new System.Drawing.Size(75, 23);
            this.btn_update_flight.TabIndex = 20;
            this.btn_update_flight.Text = "Update flight";
            this.btn_update_flight.UseVisualStyleBackColor = true;
            this.btn_update_flight.Click += new System.EventHandler(this.btn_update_flight_Click);
            // 
            // btn_add_flight
            // 
            this.btn_add_flight.Location = new System.Drawing.Point(499, 81);
            this.btn_add_flight.Name = "btn_add_flight";
            this.btn_add_flight.Size = new System.Drawing.Size(75, 23);
            this.btn_add_flight.TabIndex = 21;
            this.btn_add_flight.Text = "Add flight";
            this.btn_add_flight.UseVisualStyleBackColor = true;
            this.btn_add_flight.Click += new System.EventHandler(this.btn_add_flight_Click);
            // 
            // btn_delete_flight
            // 
            this.btn_delete_flight.Location = new System.Drawing.Point(499, 119);
            this.btn_delete_flight.Name = "btn_delete_flight";
            this.btn_delete_flight.Size = new System.Drawing.Size(75, 23);
            this.btn_delete_flight.TabIndex = 22;
            this.btn_delete_flight.Text = "Delete flight";
            this.btn_delete_flight.UseVisualStyleBackColor = true;
            this.btn_delete_flight.Click += new System.EventHandler(this.btn_delete_flight_Click);
            // 
            // btn_search_flight
            // 
            this.btn_search_flight.Location = new System.Drawing.Point(499, 149);
            this.btn_search_flight.Name = "btn_search_flight";
            this.btn_search_flight.Size = new System.Drawing.Size(75, 23);
            this.btn_search_flight.TabIndex = 23;
            this.btn_search_flight.Text = "Search flight";
            this.btn_search_flight.UseVisualStyleBackColor = true;
            this.btn_search_flight.Click += new System.EventHandler(this.btn_search_flight_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(499, 185);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 24;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(499, 222);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 25;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // admin_actions_time
            // 
            this.admin_actions_time.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cyanairScheduleBindingSource, "Time", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "G"));
            this.admin_actions_time.Location = new System.Drawing.Point(211, 142);
            this.admin_actions_time.Name = "admin_actions_time";
            this.admin_actions_time.Size = new System.Drawing.Size(200, 20);
            this.admin_actions_time.TabIndex = 26;
            // 
            // admin_actions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 525);
            this.Controls.Add(this.admin_actions_time);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_search_flight);
            this.Controls.Add(this.btn_delete_flight);
            this.Controls.Add(this.btn_add_flight);
            this.Controls.Add(this.btn_update_flight);
            this.Controls.Add(flight_NoLabel);
            this.Controls.Add(this.flight_NoTextBox);
            this.Controls.Add(departingLabel);
            this.Controls.Add(this.departingTextBox);
            this.Controls.Add(arrivingLabel);
            this.Controls.Add(this.arrivingTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(timeLabel);
            this.Controls.Add(economyLabel);
            this.Controls.Add(this.economyTextBox);
            this.Controls.Add(businessLabel);
            this.Controls.Add(this.businessTextBox);
            this.Controls.Add(firstLabel);
            this.Controls.Add(this.firstTextBox);
            this.Controls.Add(durationLabel);
            this.Controls.Add(this.durationTextBox);
            this.Controls.Add(this.cyanairScheduleDataGridView);
            this.Controls.Add(this.cyanairScheduleBindingNavigator);
            this.Name = "admin_actions";
            this.Text = "admin_actions";
            this.Load += new System.EventHandler(this.admin_actions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cyanairDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyanairScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyanairScheduleBindingNavigator)).EndInit();
            this.cyanairScheduleBindingNavigator.ResumeLayout(false);
            this.cyanairScheduleBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cyanairScheduleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cyanairDataSet cyanairDataSet;
        private System.Windows.Forms.BindingSource cyanairScheduleBindingSource;
        private cyanairDataSetTableAdapters.CyanairScheduleTableAdapter cyanairScheduleTableAdapter;
        private cyanairDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cyanairScheduleBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cyanairScheduleBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView cyanairScheduleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox flight_NoTextBox;
        private System.Windows.Forms.TextBox departingTextBox;
        private System.Windows.Forms.TextBox arrivingTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox economyTextBox;
        private System.Windows.Forms.TextBox businessTextBox;
        private System.Windows.Forms.TextBox firstTextBox;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.Button btn_update_flight;
        private System.Windows.Forms.Button btn_add_flight;
        private System.Windows.Forms.Button btn_delete_flight;
        private System.Windows.Forms.Button btn_search_flight;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.TextBox admin_actions_time;
    }
}