namespace warehouse
{
    partial class sources
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sources));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvlist = new System.Windows.Forms.DataGridView();
            this.btnlist = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.s_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlist)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvlist
            // 
            this.dgvlist.BackgroundColor = System.Drawing.Color.Teal;
            this.dgvlist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvlist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.s_id,
            this.s_name,
            this.s_phone,
            this.s_adress});
            this.dgvlist.GridColor = System.Drawing.Color.Teal;
            this.dgvlist.Location = new System.Drawing.Point(12, 110);
            this.dgvlist.Name = "dgvlist";
            this.dgvlist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvlist.RowTemplate.Height = 24;
            this.dgvlist.Size = new System.Drawing.Size(631, 286);
            this.dgvlist.TabIndex = 0;
            // 
            // btnlist
            // 
            this.btnlist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlist.BackgroundImage")));
            this.btnlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnlist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlist.Location = new System.Drawing.Point(662, 110);
            this.btnlist.Name = "btnlist";
            this.btnlist.Size = new System.Drawing.Size(123, 64);
            this.btnlist.TabIndex = 1;
            this.btnlist.UseVisualStyleBackColor = true;
            this.btnlist.Click += new System.EventHandler(this.btnlist_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnadd.BackgroundImage")));
            this.btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadd.Location = new System.Drawing.Point(662, 222);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(123, 60);
            this.btnadd.TabIndex = 2;
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndelete.BackgroundImage")));
            this.btndelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndelete.Location = new System.Drawing.Point(662, 327);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(123, 57);
            this.btndelete.TabIndex = 3;
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "PHONE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "ADDRESS";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(79, 9);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(157, 22);
            this.txtid.TabIndex = 8;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(79, 32);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(200, 22);
            this.txtname.TabIndex = 9;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(79, 59);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(157, 22);
            this.txtphone.TabIndex = 10;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(94, 87);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(206, 22);
            this.txtaddress.TabIndex = 11;
            // 
            // s_id
            // 
            this.s_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.s_id.DataPropertyName = "s_id";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.s_id.DefaultCellStyle = dataGridViewCellStyle1;
            this.s_id.HeaderText = "Mã số";
            this.s_id.Name = "s_id";
            // 
            // s_name
            // 
            this.s_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.s_name.DataPropertyName = "s_name";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.s_name.DefaultCellStyle = dataGridViewCellStyle2;
            this.s_name.HeaderText = "Tên";
            this.s_name.Name = "s_name";
            // 
            // s_phone
            // 
            this.s_phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.s_phone.DataPropertyName = "s_phone";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.s_phone.DefaultCellStyle = dataGridViewCellStyle3;
            this.s_phone.HeaderText = "Số điện thoại";
            this.s_phone.Name = "s_phone";
            // 
            // s_adress
            // 
            this.s_adress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.s_adress.DataPropertyName = "s_adress";
            this.s_adress.HeaderText = "Địa chỉ";
            this.s_adress.Name = "s_adress";
            // 
            // sources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 396);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnlist);
            this.Controls.Add(this.dgvlist);
            this.Name = "sources";
            this.Text = "sources";
            ((System.ComponentModel.ISupportInitialize)(this.dgvlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvlist;
        private System.Windows.Forms.Button btnlist;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_adress;
    }
}