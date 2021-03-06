﻿namespace Cyanair20012020
{
    partial class admin_search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_search));
            this.admin_search_label = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.cyanairDataSet = new Cyanair20012020.cyanairDataSet();
            this.cyanairScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cyanairScheduleTableAdapter = new Cyanair20012020.cyanairDataSetTableAdapters.CyanairScheduleTableAdapter();
            this.tableAdapterManager = new Cyanair20012020.cyanairDataSetTableAdapters.TableAdapterManager();
            this.cyanairReservationTableAdapter = new Cyanair20012020.cyanairDataSetTableAdapters.CyanairReservationTableAdapter();
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
            this.cyanairReservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reference_no_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cyanairDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyanairScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyanairScheduleBindingNavigator)).BeginInit();
            this.cyanairScheduleBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cyanairReservationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // admin_search_label
            // 
            this.admin_search_label.AutoSize = true;
            this.admin_search_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_search_label.Location = new System.Drawing.Point(330, 89);
            this.admin_search_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.admin_search_label.Name = "admin_search_label";
            this.admin_search_label.Size = new System.Drawing.Size(343, 40);
            this.admin_search_label.TabIndex = 0;
            this.admin_search_label.Text = "Reservations lookup";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_search.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_search.FlatAppearance.BorderSize = 2;
            this.btn_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(801, 206);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(154, 60);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.toolTip1.SetToolTip(this.btn_search, "Search flights that match the reference number provided");
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_close.FlatAppearance.BorderSize = 2;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(801, 322);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(154, 60);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Close";
            this.toolTip1.SetToolTip(this.btn_close, "Close this form and return to admin section.");
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
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
            this.tableAdapterManager.CyanairReservationTableAdapter = this.cyanairReservationTableAdapter;
            this.tableAdapterManager.CyanairScheduleTableAdapter = this.cyanairScheduleTableAdapter;
            this.tableAdapterManager.UpdateOrder = Cyanair20012020.cyanairDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cyanairReservationTableAdapter
            // 
            this.cyanairReservationTableAdapter.ClearBeforeFill = true;
            // 
            // cyanairScheduleBindingNavigator
            // 
            this.cyanairScheduleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cyanairScheduleBindingNavigator.BindingSource = this.cyanairScheduleBindingSource;
            this.cyanairScheduleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cyanairScheduleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cyanairScheduleBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
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
            this.cyanairScheduleBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.cyanairScheduleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cyanairScheduleBindingNavigator.Size = new System.Drawing.Size(1448, 31);
            this.cyanairScheduleBindingNavigator.TabIndex = 5;
            this.cyanairScheduleBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // cyanairScheduleBindingNavigatorSaveItem
            // 
            this.cyanairScheduleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cyanairScheduleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cyanairScheduleBindingNavigatorSaveItem.Image")));
            this.cyanairScheduleBindingNavigatorSaveItem.Name = "cyanairScheduleBindingNavigatorSaveItem";
            this.cyanairScheduleBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.cyanairScheduleBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // cyanairReservationBindingSource
            // 
            this.cyanairReservationBindingSource.DataMember = "CyanairReservation";
            this.cyanairReservationBindingSource.DataSource = this.cyanairDataSet;
            // 
            // reference_no_textBox
            // 
            this.reference_no_textBox.Location = new System.Drawing.Point(309, 215);
            this.reference_no_textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reference_no_textBox.Name = "reference_no_textBox";
            this.reference_no_textBox.Size = new System.Drawing.Size(148, 26);
            this.reference_no_textBox.TabIndex = 6;
            this.toolTip1.SetToolTip(this.reference_no_textBox, "Type in the ticket reference number.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 220);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Reference number";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 485);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1562, 231);
            this.dataGridView1.TabIndex = 8;
            // 
            // admin_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1448, 808);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reference_no_textBox);
            this.Controls.Add(this.cyanairScheduleBindingNavigator);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.admin_search_label);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "admin_search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin_search";
            this.Load += new System.EventHandler(this.admin_search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cyanairDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyanairScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyanairScheduleBindingNavigator)).EndInit();
            this.cyanairScheduleBindingNavigator.ResumeLayout(false);
            this.cyanairScheduleBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cyanairReservationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label admin_search_label;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_close;
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
        private cyanairDataSetTableAdapters.CyanairReservationTableAdapter cyanairReservationTableAdapter;
        private System.Windows.Forms.BindingSource cyanairReservationBindingSource;
        private System.Windows.Forms.TextBox reference_no_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}