namespace milk_sales_manager.controls.extra_controls
{
    partial class NhaSanXuatUC
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
            this.pan_menu = new System.Windows.Forms.Panel();
            this.but_back = new System.Windows.Forms.Button();
            this.nhaSanXuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dat_nhasanxuat = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luu = new System.Windows.Forms.DataGridViewButtonColumn();
            this.xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.maNhaSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhaSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanPhams = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaSanXuatBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pan_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhaSanXuatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dat_nhasanxuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaSanXuatBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pan_menu
            // 
            this.pan_menu.Controls.Add(this.but_back);
            this.pan_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_menu.Location = new System.Drawing.Point(0, 0);
            this.pan_menu.Margin = new System.Windows.Forms.Padding(4);
            this.pan_menu.Name = "pan_menu";
            this.pan_menu.Size = new System.Drawing.Size(1206, 48);
            this.pan_menu.TabIndex = 1;
            // 
            // but_back
            // 
            this.but_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_back.Image = global::milk_sales_manager.Properties.Resources.icons8_close_24;
            this.but_back.Location = new System.Drawing.Point(1162, 4);
            this.but_back.Margin = new System.Windows.Forms.Padding(4);
            this.but_back.Name = "but_back";
            this.but_back.Size = new System.Drawing.Size(40, 40);
            this.but_back.TabIndex = 0;
            this.but_back.UseVisualStyleBackColor = true;
            this.but_back.Click += new System.EventHandler(this.But_back_Click);
            // 
            // dat_nhasanxuat
            // 
            this.dat_nhasanxuat.AllowUserToOrderColumns = true;
            this.dat_nhasanxuat.AutoGenerateColumns = false;
            this.dat_nhasanxuat.ColumnHeadersHeight = 38;
            this.dat_nhasanxuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.maNhaSanXuat,
            this.tenNhaSanXuat,
            this.dienThoai,
            this.diaChi,
            this.sanPhams,
            this.luu,
            this.xoa});
            this.dat_nhasanxuat.DataSource = this.nhaSanXuatBindingSource1;
            this.dat_nhasanxuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dat_nhasanxuat.Location = new System.Drawing.Point(0, 48);
            this.dat_nhasanxuat.Name = "dat_nhasanxuat";
            this.dat_nhasanxuat.RowTemplate.Height = 32;
            this.dat_nhasanxuat.Size = new System.Drawing.Size(1206, 829);
            this.dat_nhasanxuat.TabIndex = 2;
            this.dat_nhasanxuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dat_nhasanxuat_CellClick);
            this.dat_nhasanxuat.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Dat_nhasanxuat_EditingControlShowing);
            this.dat_nhasanxuat.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.Dat_nhasanxuat_RowPrePaint);
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            // 
            // luu
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.luu.DefaultCellStyle = dataGridViewCellStyle1;
            this.luu.HeaderText = "";
            this.luu.Name = "luu";
            this.luu.Text = "Lưu";
            this.luu.UseColumnTextForButtonValue = true;
            // 
            // xoa
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.xoa.DefaultCellStyle = dataGridViewCellStyle2;
            this.xoa.HeaderText = "";
            this.xoa.Name = "xoa";
            this.xoa.Text = "Xóa";
            this.xoa.UseColumnTextForButtonValue = true;
            // 
            // maNhaSanXuat
            // 
            this.maNhaSanXuat.DataPropertyName = "maNhaSanXuat";
            this.maNhaSanXuat.HeaderText = "maNhaSanXuat";
            this.maNhaSanXuat.MaxInputLength = 10;
            this.maNhaSanXuat.Name = "maNhaSanXuat";
            // 
            // tenNhaSanXuat
            // 
            this.tenNhaSanXuat.DataPropertyName = "tenNhaSanXuat";
            this.tenNhaSanXuat.HeaderText = "tenNhaSanXuat";
            this.tenNhaSanXuat.Name = "tenNhaSanXuat";
            // 
            // dienThoai
            // 
            this.dienThoai.DataPropertyName = "dienThoai";
            this.dienThoai.HeaderText = "dienThoai";
            this.dienThoai.MaxInputLength = 10;
            this.dienThoai.Name = "dienThoai";
            // 
            // diaChi
            // 
            this.diaChi.DataPropertyName = "diaChi";
            this.diaChi.HeaderText = "diaChi";
            this.diaChi.Name = "diaChi";
            // 
            // sanPhams
            // 
            this.sanPhams.DataPropertyName = "SanPhams";
            this.sanPhams.HeaderText = "SanPhams";
            this.sanPhams.Name = "sanPhams";
            // 
            // nhaSanXuatBindingSource1
            // 
            this.nhaSanXuatBindingSource1.DataSource = typeof(milk_sales_manager.models.NhaSanXuat);
            // 
            // NhaSanXuatUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dat_nhasanxuat);
            this.Controls.Add(this.pan_menu);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NhaSanXuatUC";
            this.Size = new System.Drawing.Size(1206, 877);
            this.Tag = "nhasanxuat";
            this.Load += new System.EventHandler(this.NhaSanXuatUC_Load);
            this.pan_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nhaSanXuatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dat_nhasanxuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaSanXuatBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_back;
        private System.Windows.Forms.Panel pan_menu;
        private System.Windows.Forms.BindingSource nhaSanXuatBindingSource;
        private System.Windows.Forms.DataGridView dat_nhasanxuat;
        private System.Windows.Forms.BindingSource nhaSanXuatBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhaSanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhaSanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanPhams;
        private System.Windows.Forms.DataGridViewButtonColumn luu;
        private System.Windows.Forms.DataGridViewButtonColumn xoa;
    }
}
