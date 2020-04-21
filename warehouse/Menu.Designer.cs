namespace warehouse
{
    partial class Menu
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
            this.title = new System.Windows.Forms.Label();
            this.btnWarehouse = new System.Windows.Forms.Button();
            this.btnSource = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(33, 18);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(207, 25);
            this.title.TabIndex = 0;
            this.title.Text = "Warehouses Manager";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnWarehouse
            // 
            this.btnWarehouse.Location = new System.Drawing.Point(61, 64);
            this.btnWarehouse.Name = "btnWarehouse";
            this.btnWarehouse.Size = new System.Drawing.Size(144, 23);
            this.btnWarehouse.TabIndex = 1;
            this.btnWarehouse.Text = "Warehouse";
            this.btnWarehouse.UseVisualStyleBackColor = true;
            this.btnWarehouse.Click += new System.EventHandler(this.btnWarehouse_Click);
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(61, 103);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(144, 23);
            this.btnSource.TabIndex = 2;
            this.btnSource.Text = "Source";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(61, 142);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(144, 23);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 262);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnSource);
            this.Controls.Add(this.btnWarehouse);
            this.Controls.Add(this.title);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button btnWarehouse;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.Button btnImport;
    }
}