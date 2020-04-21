namespace warehouse
{
    partial class import
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(import));
            this.lblWId = new System.Windows.Forms.Label();
            this.lblIId = new System.Windows.Forms.Label();
            this.txtWId = new System.Windows.Forms.TextBox();
            this.txtIId = new System.Windows.Forms.TextBox();
            this.dgvlist = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.w_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSId = new System.Windows.Forms.Label();
            this.txtSId = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlist)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWId
            // 
            this.lblWId.AutoSize = true;
            this.lblWId.BackColor = System.Drawing.Color.Teal;
            this.lblWId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWId.Location = new System.Drawing.Point(25, 81);
            this.lblWId.Name = "lblWId";
            this.lblWId.Size = new System.Drawing.Size(117, 19);
            this.lblWId.TabIndex = 12;
            this.lblWId.Text = "WAREHOUSE ID";
            // 
            // lblIId
            // 
            this.lblIId.AutoSize = true;
            this.lblIId.BackColor = System.Drawing.Color.Teal;
            this.lblIId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIId.ForeColor = System.Drawing.Color.Snow;
            this.lblIId.Location = new System.Drawing.Point(25, 44);
            this.lblIId.Name = "lblIId";
            this.lblIId.Size = new System.Drawing.Size(80, 19);
            this.lblIId.TabIndex = 11;
            this.lblIId.Text = "IMPORT ID";
            // 
            // txtWId
            // 
            this.txtWId.Location = new System.Drawing.Point(258, 81);
            this.txtWId.Name = "txtWId";
            this.txtWId.Size = new System.Drawing.Size(426, 22);
            this.txtWId.TabIndex = 10;
            // 
            // txtIId
            // 
            this.txtIId.Location = new System.Drawing.Point(258, 44);
            this.txtIId.Name = "txtIId";
            this.txtIId.Size = new System.Drawing.Size(426, 22);
            this.txtIId.TabIndex = 9;
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
            this.id,
            this.w_id,
            this.s_id,
            this.date});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvlist.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvlist.Location = new System.Drawing.Point(25, 209);
            this.dgvlist.MultiSelect = false;
            this.dgvlist.Name = "dgvlist";
            this.dgvlist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvlist.RowTemplate.Height = 24;
            this.dgvlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvlist.Size = new System.Drawing.Size(659, 318);
            this.dgvlist.TabIndex = 8;
            this.dgvlist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlist_CellClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Import ID";
            this.id.Name = "id";
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // w_id
            // 
            this.w_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.w_id.DataPropertyName = "w_id";
            this.w_id.HeaderText = "Warehouse ID";
            this.w_id.Name = "w_id";
            // 
            // s_id
            // 
            this.s_id.DataPropertyName = "s_id";
            this.s_id.HeaderText = "Source ID";
            this.s_id.Name = "s_id";
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            // 
            // lblSId
            // 
            this.lblSId.AutoSize = true;
            this.lblSId.BackColor = System.Drawing.Color.Teal;
            this.lblSId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSId.Location = new System.Drawing.Point(25, 120);
            this.lblSId.Name = "lblSId";
            this.lblSId.Size = new System.Drawing.Size(85, 19);
            this.lblSId.TabIndex = 13;
            this.lblSId.Text = "SOURCE ID";
            // 
            // txtSId
            // 
            this.txtSId.Location = new System.Drawing.Point(258, 120);
            this.txtSId.Name = "txtSId";
            this.txtSId.Size = new System.Drawing.Size(426, 22);
            this.txtSId.TabIndex = 14;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Teal;
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDate.Location = new System.Drawing.Point(25, 154);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(40, 19);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "Date";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(258, 154);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(426, 22);
            this.txtDate.TabIndex = 16;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(762, 307);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 63);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDetail.BackgroundImage")));
            this.btnDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDetail.Location = new System.Drawing.Point(762, 209);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(140, 63);
            this.btnDetail.TabIndex = 18;
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDel.BackgroundImage")));
            this.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDel.Location = new System.Drawing.Point(762, 404);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(140, 63);
            this.btnDel.TabIndex = 19;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 539);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtSId);
            this.Controls.Add(this.lblSId);
            this.Controls.Add(this.lblWId);
            this.Controls.Add(this.lblIId);
            this.Controls.Add(this.txtWId);
            this.Controls.Add(this.txtIId);
            this.Controls.Add(this.dgvlist);
            this.Name = "import";
            this.Text = "import";
            ((System.ComponentModel.ISupportInitialize)(this.dgvlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWId;
        private System.Windows.Forms.Label lblIId;
        private System.Windows.Forms.TextBox txtWId;
        private System.Windows.Forms.TextBox txtIId;
        private System.Windows.Forms.DataGridView dgvlist;
        private System.Windows.Forms.Label lblSId;
        private System.Windows.Forms.TextBox txtSId;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn w_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}