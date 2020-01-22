namespace Cyanair20012020
{
    partial class search_flights
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(search_flights));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cyanairAirportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cyanairDataSet = new Cyanair20012020.cyanairDataSet();
            this.travel_class_comboBox = new System.Windows.Forms.ComboBox();
            this.search_flights_btn = new System.Windows.Forms.Button();
            this.cancel_search_flights_btn = new System.Windows.Forms.Button();
            this.cyanairAirportsTableAdapter = new Cyanair20012020.cyanairDataSetTableAdapters.CyanairAirportsTableAdapter();
            this.tableAdapterManager = new Cyanair20012020.cyanairDataSetTableAdapters.TableAdapterManager();
            this.cyanairAirportsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cyanairAirportsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cyanairDataSet1 = new Cyanair20012020.cyanairDataSet();
            this.from_airport_comboBox = new System.Windows.Forms.ComboBox();
            this.to_airport_comboBox = new System.Windows.Forms.ComboBox();
            this.return_flight_checkbox = new System.Windows.Forms.CheckBox();
            this.passengers_no = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flight_date = new System.Windows.Forms.DateTimePicker();
            this.filtered_flights = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cyanairAirportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyanairDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyanairAirportsBindingNavigator)).BeginInit();
            this.cyanairAirportsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cyanairDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengers_no)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filtered_flights)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Passengers No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(512, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Travel class";
            // 
            // cyanairAirportsBindingSource
            // 
            this.cyanairAirportsBindingSource.DataMember = "CyanairAirports";
            this.cyanairAirportsBindingSource.DataSource = this.cyanairDataSet;
            // 
            // cyanairDataSet
            // 
            this.cyanairDataSet.DataSetName = "cyanairDataSet";
            this.cyanairDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // travel_class_comboBox
            // 
            this.travel_class_comboBox.FormattingEnabled = true;
            this.travel_class_comboBox.Items.AddRange(new object[] {
            "Economy",
            "Business",
            "First"});
            this.travel_class_comboBox.Location = new System.Drawing.Point(628, 33);
            this.travel_class_comboBox.Name = "travel_class_comboBox";
            this.travel_class_comboBox.Size = new System.Drawing.Size(121, 21);
            this.travel_class_comboBox.TabIndex = 9;
            // 
            // search_flights_btn
            // 
            this.search_flights_btn.Location = new System.Drawing.Point(611, 264);
            this.search_flights_btn.Name = "search_flights_btn";
            this.search_flights_btn.Size = new System.Drawing.Size(115, 23);
            this.search_flights_btn.TabIndex = 10;
            this.search_flights_btn.Text = "Search flights";
            this.search_flights_btn.UseVisualStyleBackColor = true;
            this.search_flights_btn.Click += new System.EventHandler(this.search_flights_btn_Click);
            // 
            // cancel_search_flights_btn
            // 
            this.cancel_search_flights_btn.Location = new System.Drawing.Point(53, 264);
            this.cancel_search_flights_btn.Name = "cancel_search_flights_btn";
            this.cancel_search_flights_btn.Size = new System.Drawing.Size(121, 23);
            this.cancel_search_flights_btn.TabIndex = 11;
            this.cancel_search_flights_btn.Text = "Go Back";
            this.cancel_search_flights_btn.UseVisualStyleBackColor = true;
            this.cancel_search_flights_btn.Click += new System.EventHandler(this.cancel_search_flights_btn_Click);
            // 
            // cyanairAirportsTableAdapter
            // 
            this.cyanairAirportsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CyanairAirportsTableAdapter = this.cyanairAirportsTableAdapter;
            this.tableAdapterManager.CyanairReservationTableAdapter = null;
            this.tableAdapterManager.CyanairScheduleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Cyanair20012020.cyanairDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cyanairAirportsBindingNavigator
            // 
            this.cyanairAirportsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cyanairAirportsBindingNavigator.BindingSource = this.cyanairAirportsBindingSource;
            this.cyanairAirportsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cyanairAirportsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cyanairAirportsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cyanairAirportsBindingNavigatorSaveItem});
            this.cyanairAirportsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cyanairAirportsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cyanairAirportsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cyanairAirportsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cyanairAirportsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cyanairAirportsBindingNavigator.Name = "cyanairAirportsBindingNavigator";
            this.cyanairAirportsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cyanairAirportsBindingNavigator.Size = new System.Drawing.Size(884, 25);
            this.cyanairAirportsBindingNavigator.TabIndex = 12;
            this.cyanairAirportsBindingNavigator.Text = "bindingNavigator1";
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
            // cyanairAirportsBindingNavigatorSaveItem
            // 
            this.cyanairAirportsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cyanairAirportsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cyanairAirportsBindingNavigatorSaveItem.Image")));
            this.cyanairAirportsBindingNavigatorSaveItem.Name = "cyanairAirportsBindingNavigatorSaveItem";
            this.cyanairAirportsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cyanairAirportsBindingNavigatorSaveItem.Text = "Save Data";
            this.cyanairAirportsBindingNavigatorSaveItem.Click += new System.EventHandler(this.cyanairAirportsBindingNavigatorSaveItem_Click);
            // 
            // cyanairDataSet1
            // 
            this.cyanairDataSet1.DataSetName = "cyanairDataSet";
            this.cyanairDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // from_airport_comboBox
            // 
            this.from_airport_comboBox.FormattingEnabled = true;
            this.from_airport_comboBox.Location = new System.Drawing.Point(66, 28);
            this.from_airport_comboBox.Name = "from_airport_comboBox";
            this.from_airport_comboBox.Size = new System.Drawing.Size(121, 21);
            this.from_airport_comboBox.TabIndex = 13;
            this.from_airport_comboBox.ValueMember = "Airport Codes";
            this.from_airport_comboBox.SelectedIndexChanged += new System.EventHandler(this.from_airport_comboBox_SelectedIndexChanged);
            // 
            // to_airport_comboBox
            // 
            this.to_airport_comboBox.FormattingEnabled = true;
            this.to_airport_comboBox.Location = new System.Drawing.Point(66, 91);
            this.to_airport_comboBox.Name = "to_airport_comboBox";
            this.to_airport_comboBox.Size = new System.Drawing.Size(121, 21);
            this.to_airport_comboBox.TabIndex = 14;
            // 
            // return_flight_checkbox
            // 
            this.return_flight_checkbox.AutoSize = true;
            this.return_flight_checkbox.Location = new System.Drawing.Point(628, 89);
            this.return_flight_checkbox.Name = "return_flight_checkbox";
            this.return_flight_checkbox.Size = new System.Drawing.Size(15, 14);
            this.return_flight_checkbox.TabIndex = 15;
            this.return_flight_checkbox.UseVisualStyleBackColor = true;
            // 
            // passengers_no
            // 
            this.passengers_no.Location = new System.Drawing.Point(364, 157);
            this.passengers_no.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.passengers_no.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.passengers_no.Name = "passengers_no";
            this.passengers_no.Size = new System.Drawing.Size(120, 20);
            this.passengers_no.TabIndex = 16;
            this.passengers_no.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(512, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Book return flight:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.flight_date);
            this.groupBox2.Controls.Add(this.from_airport_comboBox);
            this.groupBox2.Controls.Add(this.return_flight_checkbox);
            this.groupBox2.Controls.Add(this.to_airport_comboBox);
            this.groupBox2.Controls.Add(this.travel_class_comboBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(24, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(838, 145);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Outbound Flight";
            // 
            // flight_date
            // 
            this.flight_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.flight_date.Location = new System.Drawing.Point(340, 31);
            this.flight_date.Name = "flight_date";
            this.flight_date.Size = new System.Drawing.Size(120, 20);
            this.flight_date.TabIndex = 31;
            this.flight_date.Value = new System.DateTime(2020, 1, 22, 0, 0, 0, 0);
            // 
            // filtered_flights
            // 
            this.filtered_flights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filtered_flights.Location = new System.Drawing.Point(24, 354);
            this.filtered_flights.Name = "filtered_flights";
            this.filtered_flights.Size = new System.Drawing.Size(838, 150);
            this.filtered_flights.TabIndex = 31;
            // 
            // search_flights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 516);
            this.Controls.Add(this.filtered_flights);
            this.Controls.Add(this.passengers_no);
            this.Controls.Add(this.cyanairAirportsBindingNavigator);
            this.Controls.Add(this.cancel_search_flights_btn);
            this.Controls.Add(this.search_flights_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Name = "search_flights";
            this.Text = "search_flights";
            this.Load += new System.EventHandler(this.search_flights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cyanairAirportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyanairDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyanairAirportsBindingNavigator)).EndInit();
            this.cyanairAirportsBindingNavigator.ResumeLayout(false);
            this.cyanairAirportsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cyanairDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengers_no)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filtered_flights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox travel_class_comboBox;
        private System.Windows.Forms.Button search_flights_btn;
        private System.Windows.Forms.Button cancel_search_flights_btn;
        private cyanairDataSet cyanairDataSet;
        private System.Windows.Forms.BindingSource cyanairAirportsBindingSource;
        private cyanairDataSetTableAdapters.CyanairAirportsTableAdapter cyanairAirportsTableAdapter;
        private cyanairDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cyanairAirportsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cyanairAirportsBindingNavigatorSaveItem;
        private cyanairDataSet cyanairDataSet1;
        private System.Windows.Forms.ComboBox from_airport_comboBox;
        private System.Windows.Forms.ComboBox to_airport_comboBox;
        private System.Windows.Forms.CheckBox return_flight_checkbox;
        private System.Windows.Forms.NumericUpDown passengers_no;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker flight_date;
        private System.Windows.Forms.DataGridView filtered_flights;
    }
}