using System;
using System.Drawing;

namespace BudgetTracker
{
    partial class main
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.MenuStrip menuStrip1;
            this.cREATEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cHARTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblExpenseName = new System.Windows.Forms.Label();
            this.txtExpenseName = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lvExpenses = new System.Windows.Forms.ListView();
            this.lblTotalExpenses = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.modelDataSet = new DudgetTracker.ModelDataSet();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new DudgetTracker.ModelDataSetTableAdapters.itemsTableAdapter();
            this.tableAdapterManager = new DudgetTracker.ModelDataSetTableAdapters.TableAdapterManager();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AllowMerge = false;
            menuStrip1.AutoSize = false;
            menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            menuStrip1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cREATEToolStripMenuItem,
            this.cHARTSToolStripMenuItem});
            menuStrip1.Location = new System.Drawing.Point(0, 770);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            menuStrip1.Size = new System.Drawing.Size(1022, 70);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // cREATEToolStripMenuItem
            // 
            this.cREATEToolStripMenuItem.Name = "cREATEToolStripMenuItem";
            this.cREATEToolStripMenuItem.Size = new System.Drawing.Size(100, 70);
            this.cREATEToolStripMenuItem.Text = "MY LIST";
            // 
            // cHARTSToolStripMenuItem
            // 
            this.cHARTSToolStripMenuItem.Name = "cHARTSToolStripMenuItem";
            this.cHARTSToolStripMenuItem.Size = new System.Drawing.Size(100, 70);
            this.cHARTSToolStripMenuItem.Text = "CHARTS";
            this.cHARTSToolStripMenuItem.Click += new System.EventHandler(this.cHARTSToolStripMenuItem_Click);
            // 
            // lblExpenseName
            // 
            this.lblExpenseName.AutoSize = true;
            this.lblExpenseName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenseName.Location = new System.Drawing.Point(27, 81);
            this.lblExpenseName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpenseName.Name = "lblExpenseName";
            this.lblExpenseName.Size = new System.Drawing.Size(182, 29);
            this.lblExpenseName.TabIndex = 0;
            this.lblExpenseName.Text = "ExpenseName:";
            this.lblExpenseName.Click += new System.EventHandler(this.lblExpenseName_Click);
            // 
            // txtExpenseName
            // 
            this.txtExpenseName.Location = new System.Drawing.Point(298, 86);
            this.txtExpenseName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtExpenseName.Name = "txtExpenseName";
            this.txtExpenseName.Size = new System.Drawing.Size(235, 26);
            this.txtExpenseName.TabIndex = 1;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(27, 132);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(111, 29);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Amount:";
            this.lblAmount.Click += new System.EventHandler(this.lblAmount_Click_1);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(298, 145);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(235, 26);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(27, 196);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(71, 29);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date:";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(298, 201);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(235, 26);
            this.dtpDate.TabIndex = 5;
            // 
            // lvExpenses
            // 
            this.lvExpenses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvExpenses.FullRowSelect = true;
            this.lvExpenses.HideSelection = false;
            this.lvExpenses.Location = new System.Drawing.Point(68, 316);
            this.lvExpenses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvExpenses.Name = "lvExpenses";
            this.lvExpenses.Size = new System.Drawing.Size(763, 259);
            this.lvExpenses.TabIndex = 7;
            this.lvExpenses.UseCompatibleStateImageBehavior = false;
            this.lvExpenses.View = System.Windows.Forms.View.Details;
            this.lvExpenses.SelectedIndexChanged += new System.EventHandler(this.lvExpenses_SelectedIndexChanged);
            // 
            // lblTotalExpenses
            // 
            this.lblTotalExpenses.AutoEllipsis = true;
            this.lblTotalExpenses.AutoSize = true;
            this.lblTotalExpenses.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalExpenses.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblTotalExpenses.Location = new System.Drawing.Point(307, 681);
            this.lblTotalExpenses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalExpenses.Name = "lblTotalExpenses";
            this.lblTotalExpenses.Size = new System.Drawing.Size(260, 29);
            this.lblTotalExpenses.TabIndex = 8;
            this.lblTotalExpenses.Text = "Total Expenses: £0.00";
            this.lblTotalExpenses.Click += new System.EventHandler(this.lblTotalExpenses_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 62);
            this.panel1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(-86, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(414, 65);
            this.label2.TabIndex = 1;
            this.label2.Text = "EXPENSE APP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExpense.Location = new System.Drawing.Point(298, 257);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(239, 41);
            this.btnAddExpense.TabIndex = 14;
            this.btnAddExpense.Text = "ADD EXPENSE";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // modelDataSet
            // 
            this.modelDataSet.DataSetName = "ModelDataSet";
            this.modelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "items";
            this.itemsBindingSource.DataSource = this.modelDataSet;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.itemsTableAdapter = this.itemsTableAdapter;
            this.tableAdapterManager.UpdateOrder = DudgetTracker.ModelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1022, 840);
            this.Controls.Add(this.btnAddExpense);
            this.Controls.Add(this.panel1);
            this.Controls.Add(menuStrip1);
            this.Controls.Add(this.lblTotalExpenses);
            this.Controls.Add(this.lvExpenses);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtExpenseName);
            this.Controls.Add(this.lblExpenseName);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUDGETAPPLICATION";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private void btnAddExpense_MouseLeave(object sender, EventArgs e)
        {
            btnAddExpense.BackColor = Color.LightGray; // Change the button's background color
        }

        private void btnAddExpense_MouseEnter(object sender, EventArgs e)
        {
            btnAddExpense.BackColor = Color.LightGray; // Change the button's background color
        }


        private System.Windows.Forms.Label lblExpenseName;
        private System.Windows.Forms.TextBox txtExpenseName;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ListView lvExpenses;
        private System.Windows.Forms.ToolStripMenuItem cREATEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cHARTSToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddExpense;
        private DudgetTracker.ModelDataSet modelDataSet;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private DudgetTracker.ModelDataSetTableAdapters.itemsTableAdapter itemsTableAdapter;
        private DudgetTracker.ModelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        public System.Windows.Forms.Label lblTotalExpenses;
    }
}