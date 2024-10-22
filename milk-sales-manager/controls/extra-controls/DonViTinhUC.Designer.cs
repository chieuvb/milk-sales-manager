namespace milk_sales_manager.controls.extra_controls
{
    partial class DonViTinhUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pan_menu = new System.Windows.Forms.Panel();
            this.but_back = new System.Windows.Forms.Button();
            this.dat_donvi = new System.Windows.Forms.DataGridView();
            this.donViBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDonViDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDonViDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chiTietSanPhamsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luu = new System.Windows.Forms.DataGridViewButtonColumn();
            this.xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pan_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_donvi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donViBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pan_menu
            // 
            this.pan_menu.Controls.Add(this.but_back);
            this.pan_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_menu.Location = new System.Drawing.Point(0, 0);
            this.pan_menu.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.pan_menu.Name = "pan_menu";
            this.pan_menu.Size = new System.Drawing.Size(1206, 48);
            this.pan_menu.TabIndex = 3;
            // 
            // but_back
            // 
            this.but_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_back.Image = global::milk_sales_manager.Properties.Resources.icons8_close_24;
            this.but_back.Location = new System.Drawing.Point(1161, 4);
            this.but_back.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.but_back.Name = "but_back";
            this.but_back.Size = new System.Drawing.Size(40, 40);
            this.but_back.TabIndex = 0;
            this.but_back.UseVisualStyleBackColor = true;
            this.but_back.Click += new System.EventHandler(this.But_back_Click);
            // 
            // dat_donvi
            // 
            this.dat_donvi.AllowUserToOrderColumns = true;
            this.dat_donvi.AutoGenerateColumns = false;
            this.dat_donvi.ColumnHeadersHeight = 38;
            this.dat_donvi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.maDonViDataGridViewTextBoxColumn,
            this.tenDonViDataGridViewTextBoxColumn,
            this.moTaDataGridViewTextBoxColumn,
            this.trangThaiDataGridViewCheckBoxColumn,
            this.chiTietSanPhamsDataGridViewTextBoxColumn,
            this.luu,
            this.xoa});
            this.dat_donvi.DataSource = this.donViBindingSource;
            this.dat_donvi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dat_donvi.Location = new System.Drawing.Point(0, 48);
            this.dat_donvi.Name = "dat_donvi";
            this.dat_donvi.RowTemplate.Height = 32;
            this.dat_donvi.Size = new System.Drawing.Size(1206, 829);
            this.dat_donvi.TabIndex = 4;
            this.dat_donvi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dat_donvi_CellClick);
            this.dat_donvi.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.Dat_donvi_RowPrePaint);
            // 
            // donViBindingSource
            // 
            this.donViBindingSource.DataSource = typeof(milk_sales_manager.models.DonVi);
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.Width = 64;
            // 
            // maDonViDataGridViewTextBoxColumn
            // 
            this.maDonViDataGridViewTextBoxColumn.DataPropertyName = "maDonVi";
            this.maDonViDataGridViewTextBoxColumn.HeaderText = "Mã đơn vị";
            this.maDonViDataGridViewTextBoxColumn.Name = "maDonViDataGridViewTextBoxColumn";
            this.maDonViDataGridViewTextBoxColumn.Visible = false;
            // 
            // tenDonViDataGridViewTextBoxColumn
            // 
            this.tenDonViDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenDonViDataGridViewTextBoxColumn.DataPropertyName = "tenDonVi";
            this.tenDonViDataGridViewTextBoxColumn.HeaderText = "Tên đơn vị";
            this.tenDonViDataGridViewTextBoxColumn.Name = "tenDonViDataGridViewTextBoxColumn";
            // 
            // moTaDataGridViewTextBoxColumn
            // 
            this.moTaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.moTaDataGridViewTextBoxColumn.DataPropertyName = "moTa";
            this.moTaDataGridViewTextBoxColumn.HeaderText = "Mô tả";
            this.moTaDataGridViewTextBoxColumn.Name = "moTaDataGridViewTextBoxColumn";
            // 
            // trangThaiDataGridViewCheckBoxColumn
            // 
            this.trangThaiDataGridViewCheckBoxColumn.DataPropertyName = "trangThai";
            this.trangThaiDataGridViewCheckBoxColumn.HeaderText = "Trạng thái";
            this.trangThaiDataGridViewCheckBoxColumn.Name = "trangThaiDataGridViewCheckBoxColumn";
            this.trangThaiDataGridViewCheckBoxColumn.Visible = false;
            this.trangThaiDataGridViewCheckBoxColumn.Width = 200;
            // 
            // chiTietSanPhamsDataGridViewTextBoxColumn
            // 
            this.chiTietSanPhamsDataGridViewTextBoxColumn.DataPropertyName = "ChiTietSanPhams";
            this.chiTietSanPhamsDataGridViewTextBoxColumn.HeaderText = "ChiTietSanPhams";
            this.chiTietSanPhamsDataGridViewTextBoxColumn.Name = "chiTietSanPhamsDataGridViewTextBoxColumn";
            this.chiTietSanPhamsDataGridViewTextBoxColumn.Visible = false;
            // 
            // luu
            // 
            this.luu.HeaderText = "";
            this.luu.Name = "luu";
            this.luu.Text = "Lưu";
            this.luu.UseColumnTextForButtonValue = true;
            // 
            // xoa
            // 
            this.xoa.HeaderText = "";
            this.xoa.Name = "xoa";
            this.xoa.Text = "Xóa";
            this.xoa.UseColumnTextForButtonValue = true;
            // 
            // DonViTinhUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dat_donvi);
            this.Controls.Add(this.pan_menu);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DonViTinhUC";
            this.Size = new System.Drawing.Size(1206, 877);
            this.Tag = "donvitinh";
            this.Load += new System.EventHandler(this.DonViTinhUC_Load);
            this.pan_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dat_donvi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donViBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_menu;
        private System.Windows.Forms.Button but_back;
        private System.Windows.Forms.DataGridView dat_donvi;
        private System.Windows.Forms.BindingSource donViBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDonViDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDonViDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn trangThaiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiTietSanPhamsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn luu;
        private System.Windows.Forms.DataGridViewButtonColumn xoa;
    }
}
