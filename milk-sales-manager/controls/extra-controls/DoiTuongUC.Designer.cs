namespace milk_sales_manager.controls.extra_controls
{
    partial class DoiTuongUC
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
            this.dat_doituong = new System.Windows.Forms.DataGridView();
            this.doiTuongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDoiTuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDoiTuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.luu = new System.Windows.Forms.DataGridViewButtonColumn();
            this.xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.sanPhamsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pan_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_doituong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doiTuongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pan_menu
            // 
            this.pan_menu.Controls.Add(this.but_back);
            this.pan_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_menu.Location = new System.Drawing.Point(0, 0);
            this.pan_menu.Margin = new System.Windows.Forms.Padding(6);
            this.pan_menu.Name = "pan_menu";
            this.pan_menu.Size = new System.Drawing.Size(1206, 48);
            this.pan_menu.TabIndex = 2;
            // 
            // but_back
            // 
            this.but_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_back.Image = global::milk_sales_manager.Properties.Resources.icons8_close_24;
            this.but_back.Location = new System.Drawing.Point(1162, 4);
            this.but_back.Margin = new System.Windows.Forms.Padding(6);
            this.but_back.Name = "but_back";
            this.but_back.Size = new System.Drawing.Size(40, 40);
            this.but_back.TabIndex = 0;
            this.but_back.UseVisualStyleBackColor = true;
            this.but_back.Click += new System.EventHandler(this.But_back_Click);
            // 
            // dat_doituong
            // 
            this.dat_doituong.AllowUserToAddRows = false;
            this.dat_doituong.AllowUserToDeleteRows = false;
            this.dat_doituong.AllowUserToResizeColumns = false;
            this.dat_doituong.AllowUserToResizeRows = false;
            this.dat_doituong.AutoGenerateColumns = false;
            this.dat_doituong.ColumnHeadersHeight = 38;
            this.dat_doituong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.maDoiTuongDataGridViewTextBoxColumn,
            this.tenDoiTuongDataGridViewTextBoxColumn,
            this.moTaDataGridViewTextBoxColumn,
            this.trangThaiDataGridViewCheckBoxColumn,
            this.luu,
            this.xoa,
            this.sanPhamsDataGridViewTextBoxColumn});
            this.dat_doituong.DataSource = this.doiTuongBindingSource;
            this.dat_doituong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dat_doituong.Location = new System.Drawing.Point(0, 48);
            this.dat_doituong.Margin = new System.Windows.Forms.Padding(4);
            this.dat_doituong.Name = "dat_doituong";
            this.dat_doituong.RowTemplate.Height = 32;
            this.dat_doituong.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dat_doituong.Size = new System.Drawing.Size(1206, 829);
            this.dat_doituong.TabIndex = 3;
            this.dat_doituong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dat_loaihang_CellClick);
            this.dat_doituong.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.Dat_loaihang_RowPrePaint);
            // 
            // doiTuongBindingSource
            // 
            this.doiTuongBindingSource.DataSource = typeof(milk_sales_manager.models.DoiTuong);
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.Width = 64;
            // 
            // maDoiTuongDataGridViewTextBoxColumn
            // 
            this.maDoiTuongDataGridViewTextBoxColumn.DataPropertyName = "maDoiTuong";
            this.maDoiTuongDataGridViewTextBoxColumn.HeaderText = "maDoiTuong";
            this.maDoiTuongDataGridViewTextBoxColumn.Name = "maDoiTuongDataGridViewTextBoxColumn";
            this.maDoiTuongDataGridViewTextBoxColumn.Visible = false;
            // 
            // tenDoiTuongDataGridViewTextBoxColumn
            // 
            this.tenDoiTuongDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenDoiTuongDataGridViewTextBoxColumn.DataPropertyName = "tenDoiTuong";
            this.tenDoiTuongDataGridViewTextBoxColumn.HeaderText = "Đối tượng sử dụng";
            this.tenDoiTuongDataGridViewTextBoxColumn.Name = "tenDoiTuongDataGridViewTextBoxColumn";
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
            // sanPhamsDataGridViewTextBoxColumn
            // 
            this.sanPhamsDataGridViewTextBoxColumn.DataPropertyName = "SanPhams";
            this.sanPhamsDataGridViewTextBoxColumn.HeaderText = "SanPhams";
            this.sanPhamsDataGridViewTextBoxColumn.Name = "sanPhamsDataGridViewTextBoxColumn";
            this.sanPhamsDataGridViewTextBoxColumn.Visible = false;
            // 
            // DoiTuongUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dat_doituong);
            this.Controls.Add(this.pan_menu);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DoiTuongUC";
            this.Size = new System.Drawing.Size(1206, 877);
            this.Tag = "phanloaihang";
            this.Load += new System.EventHandler(this.PhanLoaiHangUC_Load);
            this.pan_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dat_doituong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doiTuongBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_menu;
        private System.Windows.Forms.Button but_back;
        private System.Windows.Forms.DataGridView dat_doituong;
        private System.Windows.Forms.BindingSource doiTuongBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDoiTuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDoiTuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn trangThaiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn luu;
        private System.Windows.Forms.DataGridViewButtonColumn xoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanPhamsDataGridViewTextBoxColumn;
    }
}
