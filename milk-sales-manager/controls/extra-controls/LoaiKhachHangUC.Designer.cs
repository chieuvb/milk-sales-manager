namespace milk_sales_manager.controls.extra_controls
{
    partial class LoaiKhachHangUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelNavigationBar = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.dataGridViewLoaiKhachHang = new System.Windows.Forms.DataGridView();
            this.loaiKhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoaiKhachHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiKhachHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.khachHangsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luu = new System.Windows.Forms.DataGridViewButtonColumn();
            this.xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelNavigationBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoaiKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiKhachHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNavigationBar
            // 
            this.panelNavigationBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNavigationBar.Controls.Add(this.buttonBack);
            this.panelNavigationBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavigationBar.Location = new System.Drawing.Point(0, 0);
            this.panelNavigationBar.Name = "panelNavigationBar";
            this.panelNavigationBar.Size = new System.Drawing.Size(1664, 48);
            this.panelNavigationBar.TabIndex = 0;
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.Image = global::milk_sales_manager.Properties.Resources.icons8_close_24;
            this.buttonBack.Location = new System.Drawing.Point(1619, 3);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(40, 40);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // dataGridViewLoaiKhachHang
            // 
            this.dataGridViewLoaiKhachHang.AllowUserToOrderColumns = true;
            this.dataGridViewLoaiKhachHang.AutoGenerateColumns = false;
            this.dataGridViewLoaiKhachHang.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLoaiKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLoaiKhachHang.ColumnHeadersHeight = 38;
            this.dataGridViewLoaiKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.maLoaiKhachHangDataGridViewTextBoxColumn,
            this.tenLoaiKhachHangDataGridViewTextBoxColumn,
            this.moTaDataGridViewTextBoxColumn,
            this.trangThaiDataGridViewCheckBoxColumn,
            this.khachHangsDataGridViewTextBoxColumn,
            this.luu,
            this.xoa});
            this.dataGridViewLoaiKhachHang.DataSource = this.loaiKhachHangBindingSource;
            this.dataGridViewLoaiKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLoaiKhachHang.Location = new System.Drawing.Point(0, 48);
            this.dataGridViewLoaiKhachHang.Name = "dataGridViewLoaiKhachHang";
            this.dataGridViewLoaiKhachHang.RowTemplate.Height = 32;
            this.dataGridViewLoaiKhachHang.Size = new System.Drawing.Size(1664, 883);
            this.dataGridViewLoaiKhachHang.TabIndex = 1;
            this.dataGridViewLoaiKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewLoaiKhachHang_CellContentClick);
            this.dataGridViewLoaiKhachHang.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DataGridViewLoaiKhachHang_RowPrePaint);
            // 
            // loaiKhachHangBindingSource
            // 
            this.loaiKhachHangBindingSource.DataSource = typeof(milk_sales_manager.models.LoaiKhachHang);
            // 
            // stt
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.stt.DefaultCellStyle = dataGridViewCellStyle2;
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            this.stt.Width = 64;
            // 
            // maLoaiKhachHangDataGridViewTextBoxColumn
            // 
            this.maLoaiKhachHangDataGridViewTextBoxColumn.DataPropertyName = "maLoaiKhachHang";
            this.maLoaiKhachHangDataGridViewTextBoxColumn.HeaderText = "maLoaiKhachHang";
            this.maLoaiKhachHangDataGridViewTextBoxColumn.Name = "maLoaiKhachHangDataGridViewTextBoxColumn";
            this.maLoaiKhachHangDataGridViewTextBoxColumn.Visible = false;
            // 
            // tenLoaiKhachHangDataGridViewTextBoxColumn
            // 
            this.tenLoaiKhachHangDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenLoaiKhachHangDataGridViewTextBoxColumn.DataPropertyName = "tenLoaiKhachHang";
            this.tenLoaiKhachHangDataGridViewTextBoxColumn.HeaderText = "Tên loại khách hàng";
            this.tenLoaiKhachHangDataGridViewTextBoxColumn.Name = "tenLoaiKhachHangDataGridViewTextBoxColumn";
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
            // 
            // khachHangsDataGridViewTextBoxColumn
            // 
            this.khachHangsDataGridViewTextBoxColumn.DataPropertyName = "KhachHangs";
            this.khachHangsDataGridViewTextBoxColumn.HeaderText = "KhachHangs";
            this.khachHangsDataGridViewTextBoxColumn.Name = "khachHangsDataGridViewTextBoxColumn";
            this.khachHangsDataGridViewTextBoxColumn.Visible = false;
            // 
            // luu
            // 
            this.luu.HeaderText = "";
            this.luu.Name = "luu";
            this.luu.ReadOnly = true;
            this.luu.Text = "Lưu";
            this.luu.UseColumnTextForButtonValue = true;
            // 
            // xoa
            // 
            this.xoa.HeaderText = "";
            this.xoa.Name = "xoa";
            this.xoa.ReadOnly = true;
            this.xoa.Text = "Xóa";
            this.xoa.UseColumnTextForButtonValue = true;
            // 
            // LoaiKhachHangUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewLoaiKhachHang);
            this.Controls.Add(this.panelNavigationBar);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoaiKhachHangUC";
            this.Size = new System.Drawing.Size(1664, 931);
            this.Load += new System.EventHandler(this.LoaiKhachHangUC_Load);
            this.panelNavigationBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoaiKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiKhachHangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNavigationBar;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridView dataGridViewLoaiKhachHang;
        private System.Windows.Forms.BindingSource loaiKhachHangBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiKhachHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiKhachHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn trangThaiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn khachHangsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn luu;
        private System.Windows.Forms.DataGridViewButtonColumn xoa;
    }
}
