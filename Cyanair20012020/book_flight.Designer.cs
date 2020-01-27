namespace Cyanair20012020
{
    partial class book_flight
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
            System.Windows.Forms.Label seat_ClassLabel;
            System.Windows.Forms.Label passenger_Full_NameLabel;
            System.Windows.Forms.Label passport_NoLabel;
            System.Windows.Forms.Label booking_referenceLabel;
            System.Windows.Forms.Label emailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(book_flight));
            this.cyanairDataSet = new Cyanair20012020.cyanairDataSet();
            this.cyanairReservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cyanairReservationTableAdapter = new Cyanair20012020.cyanairDataSetTableAdapters.CyanairReservationTableAdapter();
            this.tableAdapterManager = new Cyanair20012020.cyanairDataSetTableAdapters.TableAdapterManager();
            this.cyanairReservationBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cyanairReservationBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cyanairReservationDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flight_NoTextBox = new System.Windows.Forms.TextBox();
            this.departingTextBox = new System.Windows.Forms.TextBox();
            this.arrivingTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.seat_ClassTextBox = new System.Windows.Forms.TextBox();
            this.passenger_Full_NameTextBox = new System.Windows.Forms.TextBox();
            this.passport_NoTextBox = new System.Windows.Forms.TextBox();
            this.booking_referenceTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.economy_radioButton = new System.Windows.Forms.RadioButton();
            this.business_radioButton = new System.Windows.Forms.RadioButton();
            this.first_class_radioButton = new System.Windows.Forms.RadioButton();
            this.generate_ticket_button = new System.Windows.Forms.Button();
            this.close_form = new System.Windows.Forms.Button();
            flight_NoLabel = new System.Windows.Forms.Label();
            departingLabel = new System.Windows.Forms.Label();
            arrivingLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            timeLabel = new System.Windows.Forms.Label();
            seat_ClassLabel = new System.Windows.Forms.Label();
            passenger_Full_NameLabel = new System.Windows.Forms.Label();
            passport_NoLabel = new System.Windows.Forms.Label();
            booking_referenceLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cyanairDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyanairReservationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyanairReservationBindingNavigator)).BeginInit();
            this.cyanairReservationBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cyanairReservationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // flight_NoLabel
            // 
            flight_NoLabel.AutoSize = true;
            flight_NoLabel.Location = new System.Drawing.Point(161, 125);
            flight_NoLabel.Name = "flight_NoLabel";
            flight_NoLabel.Size = new System.Drawing.Size(52, 13);
            flight_NoLabel.TabIndex = 2;
            flight_NoLabel.Text = "Flight No:";
            // 
            // departingLabel
            // 
            departingLabel.AutoSize = true;
            departingLabel.Location = new System.Drawing.Point(161, 151);
            departingLabel.Name = "departingLabel";
            departingLabel.Size = new System.Drawing.Size(56, 13);
            departingLabel.TabIndex = 4;
            departingLabel.Text = "Departing:";
            // 
            // arrivingLabel
            // 
            arrivingLabel.AutoSize = true;
            arrivingLabel.Location = new System.Drawing.Point(161, 177);
            arrivingLabel.Name = "arrivingLabel";
            arrivingLabel.Size = new System.Drawing.Size(45, 13);
            arrivingLabel.TabIndex = 6;
            arrivingLabel.Text = "Arriving:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(161, 203);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 8;
            dateLabel.Text = "Date:";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new System.Drawing.Point(161, 229);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new System.Drawing.Size(33, 13);
            timeLabel.TabIndex = 10;
            timeLabel.Text = "Time:";
            // 
            // seat_ClassLabel
            // 
            seat_ClassLabel.AutoSize = true;
            seat_ClassLabel.Location = new System.Drawing.Point(161, 255);
            seat_ClassLabel.Name = "seat_ClassLabel";
            seat_ClassLabel.Size = new System.Drawing.Size(60, 13);
            seat_ClassLabel.TabIndex = 12;
            seat_ClassLabel.Text = "Seat Class:";
            // 
            // passenger_Full_NameLabel
            // 
            passenger_Full_NameLabel.AutoSize = true;
            passenger_Full_NameLabel.Location = new System.Drawing.Point(161, 372);
            passenger_Full_NameLabel.Name = "passenger_Full_NameLabel";
            passenger_Full_NameLabel.Size = new System.Drawing.Size(110, 13);
            passenger_Full_NameLabel.TabIndex = 14;
            passenger_Full_NameLabel.Text = "Passenger Full Name:";
            // 
            // passport_NoLabel
            // 
            passport_NoLabel.AutoSize = true;
            passport_NoLabel.Location = new System.Drawing.Point(161, 398);
            passport_NoLabel.Name = "passport_NoLabel";
            passport_NoLabel.Size = new System.Drawing.Size(68, 13);
            passport_NoLabel.TabIndex = 16;
            passport_NoLabel.Text = "Passport No:";
            // 
            // booking_referenceLabel
            // 
            booking_referenceLabel.AutoSize = true;
            booking_referenceLabel.Location = new System.Drawing.Point(161, 424);
            booking_referenceLabel.Name = "booking_referenceLabel";
            booking_referenceLabel.Size = new System.Drawing.Size(97, 13);
            booking_referenceLabel.TabIndex = 18;
            booking_referenceLabel.Text = "Booking reference:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(161, 450);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 20;
            emailLabel.Text = "Email:";
            // 
            // cyanairDataSet
            // 
            this.cyanairDataSet.DataSetName = "cyanairDataSet";
            this.cyanairDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cyanairReservationBindingSource
            // 
            this.cyanairReservationBindingSource.DataMember = "CyanairReservation";
            this.cyanairReservationBindingSource.DataSource = this.cyanairDataSet;
            // 
            // cyanairReservationTableAdapter
            // 
            this.cyanairReservationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CyanairAirportsTableAdapter = null;
            this.tableAdapterManager.CyanairReservationTableAdapter = this.cyanairReservationTableAdapter;
            this.tableAdapterManager.CyanairScheduleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Cyanair20012020.cyanairDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cyanairReservationBindingNavigator
            // 
            this.cyanairReservationBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cyanairReservationBindingNavigator.BindingSource = this.cyanairReservationBindingSource;
            this.cyanairReservationBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cyanairReservationBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cyanairReservationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cyanairReservationBindingNavigatorSaveItem});
            this.cyanairReservationBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cyanairReservationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cyanairReservationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cyanairReservationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cyanairReservationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cyanairReservationBindingNavigator.Name = "cyanairReservationBindingNavigator";
            this.cyanairReservationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cyanairReservationBindingNavigator.Size = new System.Drawing.Size(1070, 25);
            this.cyanairReservationBindingNavigator.TabIndex = 0;
            this.cyanairReservationBindingNavigator.Text = "bindingNavigator1";
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
            // cyanairReservationBindingNavigatorSaveItem
            // 
            this.cyanairReservationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cyanairReservationBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cyanairReservationBindingNavigatorSaveItem.Image")));
            this.cyanairReservationBindingNavigatorSaveItem.Name = "cyanairReservationBindingNavigatorSaveItem";
            this.cyanairReservationBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cyanairReservationBindingNavigatorSaveItem.Text = "Save Data";
            this.cyanairReservationBindingNavigatorSaveItem.Click += new System.EventHandler(this.cyanairReservationBindingNavigatorSaveItem_Click);
            // 
            // cyanairReservationDataGridView
            // 
            this.cyanairReservationDataGridView.AutoGenerateColumns = false;
            this.cyanairReservationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cyanairReservationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.cyanairReservationDataGridView.DataSource = this.cyanairReservationBindingSource;
            this.cyanairReservationDataGridView.Location = new System.Drawing.Point(12, 507);
            this.cyanairReservationDataGridView.Name = "cyanairReservationDataGridView";
            this.cyanairReservationDataGridView.Size = new System.Drawing.Size(1042, 220);
            this.cyanairReservationDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Seat Class";
            this.dataGridViewTextBoxColumn6.HeaderText = "Seat Class";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Passenger Full Name";
            this.dataGridViewTextBoxColumn7.HeaderText = "Passenger Full Name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Passport No";
            this.dataGridViewTextBoxColumn8.HeaderText = "Passport No";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Booking reference";
            this.dataGridViewTextBoxColumn9.HeaderText = "Booking reference";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn10.HeaderText = "Email";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // flight_NoTextBox
            // 
            this.flight_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cyanairReservationBindingSource, "Flight No", true));
            this.flight_NoTextBox.Location = new System.Drawing.Point(277, 122);
            this.flight_NoTextBox.Name = "flight_NoTextBox";
            this.flight_NoTextBox.ReadOnly = true;
            this.flight_NoTextBox.Size = new System.Drawing.Size(100, 20);
            this.flight_NoTextBox.TabIndex = 3;
            // 
            // departingTextBox
            // 
            this.departingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cyanairReservationBindingSource, "Departing", true));
            this.departingTextBox.Location = new System.Drawing.Point(277, 148);
            this.departingTextBox.Name = "departingTextBox";
            this.departingTextBox.ReadOnly = true;
            this.departingTextBox.Size = new System.Drawing.Size(100, 20);
            this.departingTextBox.TabIndex = 5;
            // 
            // arrivingTextBox
            // 
            this.arrivingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cyanairReservationBindingSource, "Arriving", true));
            this.arrivingTextBox.Location = new System.Drawing.Point(277, 174);
            this.arrivingTextBox.Name = "arrivingTextBox";
            this.arrivingTextBox.ReadOnly = true;
            this.arrivingTextBox.Size = new System.Drawing.Size(100, 20);
            this.arrivingTextBox.TabIndex = 7;
            // 
            // dateTextBox
            // 
            this.dateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cyanairReservationBindingSource, "Date", true));
            this.dateTextBox.Location = new System.Drawing.Point(277, 200);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.ReadOnly = true;
            this.dateTextBox.Size = new System.Drawing.Size(100, 20);
            this.dateTextBox.TabIndex = 9;
            // 
            // timeTextBox
            // 
            this.timeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cyanairReservationBindingSource, "Time", true));
            this.timeTextBox.Location = new System.Drawing.Point(277, 226);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.ReadOnly = true;
            this.timeTextBox.Size = new System.Drawing.Size(100, 20);
            this.timeTextBox.TabIndex = 11;
            // 
            // seat_ClassTextBox
            // 
            this.seat_ClassTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cyanairReservationBindingSource, "Seat Class", true));
            this.seat_ClassTextBox.Enabled = false;
            this.seat_ClassTextBox.Location = new System.Drawing.Point(277, 255);
            this.seat_ClassTextBox.Name = "seat_ClassTextBox";
            this.seat_ClassTextBox.Size = new System.Drawing.Size(100, 20);
            this.seat_ClassTextBox.TabIndex = 13;
            // 
            // passenger_Full_NameTextBox
            // 
            this.passenger_Full_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cyanairReservationBindingSource, "Passenger Full Name", true));
            this.passenger_Full_NameTextBox.Location = new System.Drawing.Point(277, 369);
            this.passenger_Full_NameTextBox.Name = "passenger_Full_NameTextBox";
            this.passenger_Full_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.passenger_Full_NameTextBox.TabIndex = 15;
            // 
            // passport_NoTextBox
            // 
            this.passport_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cyanairReservationBindingSource, "Passport No", true));
            this.passport_NoTextBox.Location = new System.Drawing.Point(277, 395);
            this.passport_NoTextBox.Name = "passport_NoTextBox";
            this.passport_NoTextBox.Size = new System.Drawing.Size(100, 20);
            this.passport_NoTextBox.TabIndex = 17;
            // 
            // booking_referenceTextBox
            // 
            this.booking_referenceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cyanairReservationBindingSource, "Booking reference", true));
            this.booking_referenceTextBox.Location = new System.Drawing.Point(277, 421);
            this.booking_referenceTextBox.Name = "booking_referenceTextBox";
            this.booking_referenceTextBox.ReadOnly = true;
            this.booking_referenceTextBox.Size = new System.Drawing.Size(100, 20);
            this.booking_referenceTextBox.TabIndex = 19;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cyanairReservationBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(277, 447);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 21;
            // 
            // economy_radioButton
            // 
            this.economy_radioButton.AutoSize = true;
            this.economy_radioButton.Checked = true;
            this.economy_radioButton.Location = new System.Drawing.Point(279, 295);
            this.economy_radioButton.Name = "economy_radioButton";
            this.economy_radioButton.Size = new System.Drawing.Size(69, 17);
            this.economy_radioButton.TabIndex = 22;
            this.economy_radioButton.TabStop = true;
            this.economy_radioButton.Text = "Economy";
            this.economy_radioButton.UseVisualStyleBackColor = true;
            this.economy_radioButton.CheckedChanged += new System.EventHandler(this.economy_radioButton_CheckedChanged);
            // 
            // business_radioButton
            // 
            this.business_radioButton.AutoSize = true;
            this.business_radioButton.Location = new System.Drawing.Point(279, 318);
            this.business_radioButton.Name = "business_radioButton";
            this.business_radioButton.Size = new System.Drawing.Size(67, 17);
            this.business_radioButton.TabIndex = 23;
            this.business_radioButton.Text = "Business";
            this.business_radioButton.UseVisualStyleBackColor = true;
            this.business_radioButton.CheckedChanged += new System.EventHandler(this.business_radioButton_CheckedChanged);
            // 
            // first_class_radioButton
            // 
            this.first_class_radioButton.AutoSize = true;
            this.first_class_radioButton.Location = new System.Drawing.Point(279, 341);
            this.first_class_radioButton.Name = "first_class_radioButton";
            this.first_class_radioButton.Size = new System.Drawing.Size(44, 17);
            this.first_class_radioButton.TabIndex = 24;
            this.first_class_radioButton.Text = "First";
            this.first_class_radioButton.UseVisualStyleBackColor = true;
            this.first_class_radioButton.CheckedChanged += new System.EventHandler(this.first_class_radioButton_CheckedChanged);
            // 
            // generate_ticket_button
            // 
            this.generate_ticket_button.Location = new System.Drawing.Point(531, 352);
            this.generate_ticket_button.Name = "generate_ticket_button";
            this.generate_ticket_button.Size = new System.Drawing.Size(110, 23);
            this.generate_ticket_button.TabIndex = 25;
            this.generate_ticket_button.Text = "Generate ticket";
            this.generate_ticket_button.UseVisualStyleBackColor = true;
            this.generate_ticket_button.Click += new System.EventHandler(this.generate_ticket_button_Click);
            // 
            // close_form
            // 
            this.close_form.Location = new System.Drawing.Point(546, 424);
            this.close_form.Name = "close_form";
            this.close_form.Size = new System.Drawing.Size(75, 23);
            this.close_form.TabIndex = 26;
            this.close_form.Text = "Close";
            this.close_form.UseVisualStyleBackColor = true;
            this.close_form.Click += new System.EventHandler(this.close_form_Click);
            // 
            // book_flight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 739);
            this.Controls.Add(this.close_form);
            this.Controls.Add(this.generate_ticket_button);
            this.Controls.Add(this.first_class_radioButton);
            this.Controls.Add(this.business_radioButton);
            this.Controls.Add(this.economy_radioButton);
            this.Controls.Add(flight_NoLabel);
            this.Controls.Add(this.flight_NoTextBox);
            this.Controls.Add(departingLabel);
            this.Controls.Add(this.departingTextBox);
            this.Controls.Add(arrivingLabel);
            this.Controls.Add(this.arrivingTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(timeLabel);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(seat_ClassLabel);
            this.Controls.Add(this.seat_ClassTextBox);
            this.Controls.Add(passenger_Full_NameLabel);
            this.Controls.Add(this.passenger_Full_NameTextBox);
            this.Controls.Add(passport_NoLabel);
            this.Controls.Add(this.passport_NoTextBox);
            this.Controls.Add(booking_referenceLabel);
            this.Controls.Add(this.booking_referenceTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.cyanairReservationDataGridView);
            this.Controls.Add(this.cyanairReservationBindingNavigator);
            this.Name = "book_flight";
            this.Text = "book_flight";
            this.Load += new System.EventHandler(this.book_flight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cyanairDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyanairReservationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyanairReservationBindingNavigator)).EndInit();
            this.cyanairReservationBindingNavigator.ResumeLayout(false);
            this.cyanairReservationBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cyanairReservationDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cyanairDataSet cyanairDataSet;
        private System.Windows.Forms.BindingSource cyanairReservationBindingSource;
        private cyanairDataSetTableAdapters.CyanairReservationTableAdapter cyanairReservationTableAdapter;
        private cyanairDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cyanairReservationBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cyanairReservationBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView cyanairReservationDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TextBox flight_NoTextBox;
        private System.Windows.Forms.TextBox departingTextBox;
        private System.Windows.Forms.TextBox arrivingTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.TextBox seat_ClassTextBox;
        private System.Windows.Forms.TextBox passenger_Full_NameTextBox;
        private System.Windows.Forms.TextBox passport_NoTextBox;
        private System.Windows.Forms.TextBox booking_referenceTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.RadioButton economy_radioButton;
        private System.Windows.Forms.RadioButton business_radioButton;
        private System.Windows.Forms.RadioButton first_class_radioButton;
        private System.Windows.Forms.Button generate_ticket_button;
        private System.Windows.Forms.Button close_form;
    }
}