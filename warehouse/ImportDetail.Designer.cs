namespace warehouse
{
    partial class ImportDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportDetail));
            this.lblPId = new System.Windows.Forms.Label();
            this.txtPId = new System.Windows.Forms.TextBox();
            this.lblQuanity = new System.Windows.Forms.Label();
            this.txtQuanity = new System.Windows.Forms.TextBox();
            this.dgvlist = new System.Windows.Forms.DataGridView();
            this.p_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quanity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlist)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPId
            // 
            this.lblPId.AutoSize = true;
            this.lblPId.BackColor = System.Drawing.Color.Teal;
            this.lblPId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPId.ForeColor = System.Drawing.Color.Snow;
            this.lblPId.Location = new System.Drawing.Point(28, 48);
            this.lblPId.Name = "lblPId";
            this.lblPId.Size = new System.Drawing.Size(95, 19);
            this.lblPId.TabIndex = 13;
            this.lblPId.Text = "PRODUCT ID";
            // 
            // txtPId
            // 
            this.txtPId.Location = new System.Drawing.Point(261, 48);
            this.txtPId.Name = "txtPId";
            this.txtPId.Size = new System.Drawing.Size(233, 22);
            this.txtPId.TabIndex = 12;
            // 
            // lblQuanity
            // 
            this.lblQuanity.AutoSize = true;
            this.lblQuanity.BackColor = System.Drawing.Color.Teal;
            this.lblQuanity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuanity.ForeColor = System.Drawing.Color.Snow;
            this.lblQuanity.Location = new System.Drawing.Point(28, 104);
            this.lblQuanity.Name = "lblQuanity";
            this.lblQuanity.Size = new System.Drawing.Size(71, 19);
            this.lblQuanity.TabIndex = 15;
            this.lblQuanity.Text = "QUANITY";
            // 
            // txtQuanity
            // 
            this.txtQuanity.Location = new System.Drawing.Point(261, 104);
            this.txtQuanity.Name = "txtQuanity";
            this.txtQuanity.Size = new System.Drawing.Size(233, 22);
            this.txtQuanity.TabIndex = 14;
            // 
            // dgvlist
            // 
            this.dgvlist.AllowUserToAddRows = false;
            this.dgvlist.AllowUserToDeleteRows = false;
            this.dgvlist.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvlist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvlist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvlist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.p_id,
            this.quanity});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvlist.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvlist.Location = new System.Drawing.Point(28, 158);
            this.dgvlist.Name = "dgvlist";
            this.dgvlist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvlist.RowTemplate.Height = 24;
            this.dgvlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvlist.Size = new System.Drawing.Size(466, 318);
            this.dgvlist.TabIndex = 16;
            this.dgvlist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlist_CellClick);
            // 
            // p_id
            // 
            this.p_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.p_id.DataPropertyName = "p_id";
            this.p_id.HeaderText = "Product ID";
            this.p_id.Name = "p_id";
            this.p_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // quanity
            // 
            this.quanity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quanity.DataPropertyName = "quanity";
            this.quanity.HeaderText = "Quanity";
            this.quanity.Name = "quanity";
            // 
            // btnDel
            // 
            this.btnDel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDel.BackgroundImage")));
            this.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDel.Location = new System.Drawing.Point(530, 353);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(140, 63);
            this.btnDel.TabIndex = 22;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDetail.BackgroundImage")));
            this.btnDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDetail.Location = new System.Drawing.Point(530, 158);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(140, 63);
            this.btnDetail.TabIndex = 21;
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(530, 256);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 63);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ImportDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 516);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvlist);
            this.Controls.Add(this.lblQuanity);
            this.Controls.Add(this.txtQuanity);
            this.Controls.Add(this.lblPId);
            this.Controls.Add(this.txtPId);
            this.Name = "ImportDetail";
            this.Text = "ImportDetail";
            ((System.ComponentModel.ISupportInitialize)(this.dgvlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPId;
        private System.Windows.Forms.TextBox txtPId;
        private System.Windows.Forms.Label lblQuanity;
        private System.Windows.Forms.TextBox txtQuanity;
        private System.Windows.Forms.DataGridView dgvlist;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn quanity;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnAdd;
    }
}