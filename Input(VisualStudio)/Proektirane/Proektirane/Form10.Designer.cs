
namespace Proektirane
{
    partial class Form10
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.videoigriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proektiraneDataSet = new Proektirane.ProektiraneDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.video_igriTableAdapter = new Proektirane.ProektiraneDataSetTableAdapters.Video_igriTableAdapter();
            this.fKDetailiprodajbiVideoigriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detaili_prodajbiTableAdapter = new Proektirane.ProektiraneDataSetTableAdapters.Detaili_prodajbiTableAdapter();
            this.videoigriBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoigriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proektiraneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDetailiprodajbiVideoigriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoigriBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Видеоигри:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 268);
            this.dataGridView1.TabIndex = 1;
            // 
            // videoigriBindingSource
            // 
            this.videoigriBindingSource.DataMember = "Video_igri";
            this.videoigriBindingSource.DataSource = this.proektiraneDataSet;
            // 
            // proektiraneDataSet
            // 
            this.proektiraneDataSet.DataSetName = "ProektiraneDataSet";
            this.proektiraneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back--->";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // video_igriTableAdapter
            // 
            this.video_igriTableAdapter.ClearBeforeFill = true;
            // 
            // fKDetailiprodajbiVideoigriBindingSource
            // 
            this.fKDetailiprodajbiVideoigriBindingSource.DataMember = "FK_Detaili_prodajbi_Video_igri";
            this.fKDetailiprodajbiVideoigriBindingSource.DataSource = this.videoigriBindingSource;
            // 
            // detaili_prodajbiTableAdapter
            // 
            this.detaili_prodajbiTableAdapter.ClearBeforeFill = true;
            // 
            // videoigriBindingSource1
            // 
            this.videoigriBindingSource1.DataMember = "Video_igri";
            this.videoigriBindingSource1.DataSource = this.proektiraneDataSet;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoigriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proektiraneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDetailiprodajbiVideoigriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoigriBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private ProektiraneDataSet proektiraneDataSet;
        private System.Windows.Forms.BindingSource videoigriBindingSource;
        private ProektiraneDataSetTableAdapters.Video_igriTableAdapter video_igriTableAdapter;
        private System.Windows.Forms.BindingSource fKDetailiprodajbiVideoigriBindingSource;
        private ProektiraneDataSetTableAdapters.Detaili_prodajbiTableAdapter detaili_prodajbiTableAdapter;
        private System.Windows.Forms.BindingSource videoigriBindingSource1;
    }
}