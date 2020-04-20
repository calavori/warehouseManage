namespace warehouse
{
    partial class Kho
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kho));
            this.dgvlist = new System.Windows.Forms.DataGridView();
            this.btnlist = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.khoDataSet = new warehouse.khoDataSet();
            this.khoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.w_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.w_adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvlist
            // 
            this.dgvlist.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvlist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvlist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvlist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.w_id,
            this.w_adress});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvlist.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvlist.Location = new System.Drawing.Point(25, 121);
            this.dgvlist.Name = "dgvlist";
            this.dgvlist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvlist.RowTemplate.Height = 24;
            this.dgvlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvlist.Size = new System.Drawing.Size(659, 318);
            this.dgvlist.TabIndex = 0;
            this.dgvlist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlist_CellContentClick);
            // 
            // btnlist
            // 
            this.btnlist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlist.BackgroundImage")));
            this.btnlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnlist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlist.Location = new System.Drawing.Point(718, 153);
            this.btnlist.Name = "btnlist";
            this.btnlist.Size = new System.Drawing.Size(140, 63);
            this.btnlist.TabIndex = 1;
            this.btnlist.UseVisualStyleBackColor = true;
            this.btnlist.Click += new System.EventHandler(this.btnlist_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnadd.BackgroundImage")));
            this.btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadd.Location = new System.Drawing.Point(718, 262);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(140, 63);
            this.btnadd.TabIndex = 2;
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndelete.BackgroundImage")));
            this.btndelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndelete.Location = new System.Drawing.Point(718, 376);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(140, 63);
            this.btndelete.TabIndex = 3;
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(67, 42);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(342, 22);
            this.txtid.TabIndex = 4;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(142, 93);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(426, 22);
            this.txtaddress.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(25, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(25, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "ADDRESS";
            // 
            // khoDataSet
            // 
            this.khoDataSet.DataSetName = "khoDataSet";
            this.khoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khoDataSetBindingSource
            // 
            this.khoDataSetBindingSource.DataSource = this.khoDataSet;
            this.khoDataSetBindingSource.Position = 0;
            // 
            // w_id
            // 
            this.w_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.w_id.DataPropertyName = "w_id";
            this.w_id.HeaderText = "Mã kho";
            this.w_id.Name = "w_id";
            this.w_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // w_adress
            // 
            this.w_adress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.w_adress.DataPropertyName = "w_adress";
            this.w_adress.HeaderText = "Địa chỉ kho";
            this.w_adress.Name = "w_adress";
            // 
            // Kho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 464);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnlist);
            this.Controls.Add(this.dgvlist);
            this.Name = "Kho";
            this.Text = "Kho";
            ((System.ComponentModel.ISupportInitialize)(this.dgvlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvlist;
        private System.Windows.Forms.Button btnlist;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource khoDataSetBindingSource;
        private khoDataSet khoDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn w_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn w_adress;
    }
}