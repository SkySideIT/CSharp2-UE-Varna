
namespace Proektirane
{
    partial class Form9
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableAdapterManager = new Proektirane.ProektiraneDataSetTableAdapters.TableAdapterManager();
            this.fakturaTableAdapter1 = new Proektirane.ProektiraneDataSetTableAdapters.FakturaTableAdapter();
            this.fakturaIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klientIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fakturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proektiraneDataSet = new Proektirane.ProektiraneDataSet();
            this.fakturaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fakturaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this._Tables = new Proektirane._Tables();
            this.tablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fakturaTableAdapter = new Proektirane._TablesTableAdapters.FakturaTableAdapter();
            this.tableAdapterManager1 = new Proektirane._TablesTableAdapters.TableAdapterManager();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.fakturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proektiraneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakturaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakturaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Tables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(49, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фактури:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back--->";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Detaili_dostavkaTableAdapter = null;
            this.tableAdapterManager.Detaili_prodajbiTableAdapter = null;
            this.tableAdapterManager.DostavchikTableAdapter = null;
            this.tableAdapterManager.DostavkaTableAdapter = null;
            this.tableAdapterManager.FakturaTableAdapter = this.fakturaTableAdapter1;
            this.tableAdapterManager.KlientiTableAdapter = null;
            this.tableAdapterManager.Naseleno_mqstoTableAdapter = null;
            this.tableAdapterManager.ProdajbiTableAdapter = null;
            this.tableAdapterManager.SlujiteliTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proektirane.ProektiraneDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            this.tableAdapterManager.Video_igriTableAdapter = null;
            // 
            // fakturaTableAdapter1
            // 
            this.fakturaTableAdapter1.ClearBeforeFill = true;
            // 
            // fakturaIDDataGridViewTextBoxColumn1
            // 
            this.fakturaIDDataGridViewTextBoxColumn1.DataPropertyName = "Faktura_ID";
            this.fakturaIDDataGridViewTextBoxColumn1.HeaderText = "Faktura_ID";
            this.fakturaIDDataGridViewTextBoxColumn1.Name = "fakturaIDDataGridViewTextBoxColumn1";
            this.fakturaIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            this.dateDataGridViewTextBoxColumn1.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            // 
            // klientIDDataGridViewTextBoxColumn1
            // 
            this.klientIDDataGridViewTextBoxColumn1.DataPropertyName = "Klient_ID";
            this.klientIDDataGridViewTextBoxColumn1.HeaderText = "Klient_ID";
            this.klientIDDataGridViewTextBoxColumn1.Name = "klientIDDataGridViewTextBoxColumn1";
            // 
            // fakturaBindingSource
            // 
            this.fakturaBindingSource.DataMember = "Faktura";
            this.fakturaBindingSource.DataSource = this.tablesBindingSource;
            // 
            // proektiraneDataSet
            // 
            this.proektiraneDataSet.DataSetName = "ProektiraneDataSet";
            this.proektiraneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fakturaBindingSource1
            // 
            this.fakturaBindingSource1.DataMember = "Faktura";
            this.fakturaBindingSource1.DataSource = this.proektiraneDataSet;
            // 
            // fakturaBindingSource2
            // 
            this.fakturaBindingSource2.DataMember = "Faktura";
            this.fakturaBindingSource2.DataSource = this._Tables;
            // 
            // _Tables
            // 
            this._Tables.DataSetName = "Tables";
            this._Tables.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablesBindingSource
            // 
            this.tablesBindingSource.DataSource = this._Tables;
            this.tablesBindingSource.Position = 0;
            // 
            // fakturaTableAdapter
            // 
            this.fakturaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.Detaili_dostavkaTableAdapter = null;
            this.tableAdapterManager1.Detaili_prodajbiTableAdapter = null;
            this.tableAdapterManager1.DostavchikTableAdapter = null;
            this.tableAdapterManager1.DostavkaTableAdapter = null;
            this.tableAdapterManager1.KlientiTableAdapter = null;
            this.tableAdapterManager1.Naseleno_mqstoTableAdapter = null;
            this.tableAdapterManager1.ProdajbiTableAdapter = null;
            this.tableAdapterManager1.SlujiteliTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Proektirane._TablesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UserTableAdapter = null;
            this.tableAdapterManager1.Video_igriTableAdapter = null;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(411, 266);
            this.dataGridView1.TabIndex = 3;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 381);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fakturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proektiraneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakturaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakturaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Tables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource tablesBindingSource;
        private _Tables _Tables;
        private ProektiraneDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn fakturaIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn klientIDDataGridViewTextBoxColumn1;
        private ProektiraneDataSetTableAdapters.FakturaTableAdapter fakturaTableAdapter1;
        private System.Windows.Forms.BindingSource fakturaBindingSource;
        private _TablesTableAdapters.FakturaTableAdapter fakturaTableAdapter;
        private ProektiraneDataSet proektiraneDataSet;
        private System.Windows.Forms.BindingSource fakturaBindingSource1;
        private System.Windows.Forms.BindingSource fakturaBindingSource2;
        private _TablesTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}