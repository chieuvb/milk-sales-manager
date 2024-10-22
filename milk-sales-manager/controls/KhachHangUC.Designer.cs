namespace milk_sales_manager.controls
{
    partial class KhachHangUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonLoaiKhachHang = new System.Windows.Forms.Button();
            this.buttonKhachHangMoi = new System.Windows.Forms.Button();
            this.panelChiTiet = new System.Windows.Forms.Panel();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.groupBoxThongTinKhachHang = new System.Windows.Forms.GroupBox();
            this.textBoxDiemTichLuy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxLoaiKhachHang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTenKhachHang = new System.Windows.Forms.TextBox();
            this.dateTimePickerNgayDangKy = new System.Windows.Forms.DateTimePicker();
            this.textBoxDiaChi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDiemTichLuy = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxSoDienThoai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewKhachHang = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhachHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemTichLuyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDangKyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKhachHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoaiKhachHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelChiTiet.SuspendLayout();
            this.groupBoxThongTinKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.buttonLoaiKhachHang);
            this.panelMenu.Controls.Add(this.buttonKhachHangMoi);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 8);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(256, 931);
            this.panelMenu.TabIndex = 2;
            // 
            // buttonLoaiKhachHang
            // 
            this.buttonLoaiKhachHang.BackColor = System.Drawing.Color.Snow;
            this.buttonLoaiKhachHang.Location = new System.Drawing.Point(3, 446);
            this.buttonLoaiKhachHang.Name = "buttonLoaiKhachHang";
            this.buttonLoaiKhachHang.Size = new System.Drawing.Size(248, 36);
            this.buttonLoaiKhachHang.TabIndex = 1;
            this.buttonLoaiKhachHang.Text = "Loại khách hàng";
            this.buttonLoaiKhachHang.UseVisualStyleBackColor = false;
            this.buttonLoaiKhachHang.Click += new System.EventHandler(this.ButtonLoaiKhachHang_Click);
            // 
            // buttonKhachHangMoi
            // 
            this.buttonKhachHangMoi.BackColor = System.Drawing.Color.Snow;
            this.buttonKhachHangMoi.Image = global::milk_sales_manager.Properties.Resources.icons8_add_24;
            this.buttonKhachHangMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKhachHangMoi.Location = new System.Drawing.Point(3, 3);
            this.buttonKhachHangMoi.Name = "buttonKhachHangMoi";
            this.buttonKhachHangMoi.Size = new System.Drawing.Size(248, 38);
            this.buttonKhachHangMoi.TabIndex = 0;
            this.buttonKhachHangMoi.Text = "Đăng ký khách hàng mới";
            this.buttonKhachHangMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonKhachHangMoi.UseVisualStyleBackColor = false;
            this.buttonKhachHangMoi.Click += new System.EventHandler(this.ButtonKhachHangMoi_Click);
            // 
            // panelChiTiet
            // 
            this.panelChiTiet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChiTiet.Controls.Add(this.buttonXoa);
            this.panelChiTiet.Controls.Add(this.buttonLuu);
            this.panelChiTiet.Controls.Add(this.groupBoxThongTinKhachHang);
            this.panelChiTiet.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelChiTiet.Location = new System.Drawing.Point(1152, 0);
            this.panelChiTiet.Name = "panelChiTiet";
            this.panelChiTiet.Size = new System.Drawing.Size(512, 931);
            this.panelChiTiet.TabIndex = 3;
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonXoa.Location = new System.Drawing.Point(330, 600);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(128, 48);
            this.buttonXoa.TabIndex = 16;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.ButtonXoa_Click);
            // 
            // buttonLuu
            // 
            this.buttonLuu.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.buttonLuu.Location = new System.Drawing.Point(93, 600);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(128, 48);
            this.buttonLuu.TabIndex = 15;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = false;
            this.buttonLuu.Click += new System.EventHandler(this.LuttonLuu_Click);
            // 
            // groupBoxThongTinKhachHang
            // 
            this.groupBoxThongTinKhachHang.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBoxThongTinKhachHang.Controls.Add(this.textBoxDiemTichLuy);
            this.groupBoxThongTinKhachHang.Controls.Add(this.label5);
            this.groupBoxThongTinKhachHang.Controls.Add(this.comboBoxLoaiKhachHang);
            this.groupBoxThongTinKhachHang.Controls.Add(this.label1);
            this.groupBoxThongTinKhachHang.Controls.Add(this.textBoxTenKhachHang);
            this.groupBoxThongTinKhachHang.Controls.Add(this.dateTimePickerNgayDangKy);
            this.groupBoxThongTinKhachHang.Controls.Add(this.textBoxDiaChi);
            this.groupBoxThongTinKhachHang.Controls.Add(this.label6);
            this.groupBoxThongTinKhachHang.Controls.Add(this.label2);
            this.groupBoxThongTinKhachHang.Controls.Add(this.labelDiemTichLuy);
            this.groupBoxThongTinKhachHang.Controls.Add(this.label3);
            this.groupBoxThongTinKhachHang.Controls.Add(this.textBoxEmail);
            this.groupBoxThongTinKhachHang.Controls.Add(this.textBoxSoDienThoai);
            this.groupBoxThongTinKhachHang.Controls.Add(this.label4);
            this.groupBoxThongTinKhachHang.Location = new System.Drawing.Point(3, 29);
            this.groupBoxThongTinKhachHang.Name = "groupBoxThongTinKhachHang";
            this.groupBoxThongTinKhachHang.Size = new System.Drawing.Size(502, 511);
            this.groupBoxThongTinKhachHang.TabIndex = 14;
            this.groupBoxThongTinKhachHang.TabStop = false;
            this.groupBoxThongTinKhachHang.Text = "Thông tin khách hàng";
            this.groupBoxThongTinKhachHang.Enter += new System.EventHandler(this.GroupBoxThongTinKhachHang_Enter);
            // 
            // textBoxDiemTichLuy
            // 
            this.textBoxDiemTichLuy.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiemTichLuy.Location = new System.Drawing.Point(145, 445);
            this.textBoxDiemTichLuy.MaxLength = 128;
            this.textBoxDiemTichLuy.Name = "textBoxDiemTichLuy";
            this.textBoxDiemTichLuy.Size = new System.Drawing.Size(194, 29);
            this.textBoxDiemTichLuy.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Phân loại:";
            // 
            // comboBoxLoaiKhachHang
            // 
            this.comboBoxLoaiKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLoaiKhachHang.FormattingEnabled = true;
            this.comboBoxLoaiKhachHang.Location = new System.Drawing.Point(145, 118);
            this.comboBoxLoaiKhachHang.Name = "comboBoxLoaiKhachHang";
            this.comboBoxLoaiKhachHang.Size = new System.Drawing.Size(324, 26);
            this.comboBoxLoaiKhachHang.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khách hàng:";
            // 
            // textBoxTenKhachHang
            // 
            this.textBoxTenKhachHang.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenKhachHang.Location = new System.Drawing.Point(145, 56);
            this.textBoxTenKhachHang.MaxLength = 128;
            this.textBoxTenKhachHang.Name = "textBoxTenKhachHang";
            this.textBoxTenKhachHang.Size = new System.Drawing.Size(324, 29);
            this.textBoxTenKhachHang.TabIndex = 1;
            // 
            // dateTimePickerNgayDangKy
            // 
            this.dateTimePickerNgayDangKy.Location = new System.Drawing.Point(145, 385);
            this.dateTimePickerNgayDangKy.MaxDate = new System.DateTime(2976, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerNgayDangKy.MinDate = new System.DateTime(1976, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerNgayDangKy.Name = "dateTimePickerNgayDangKy";
            this.dateTimePickerNgayDangKy.Size = new System.Drawing.Size(324, 26);
            this.dateTimePickerNgayDangKy.TabIndex = 12;
            // 
            // textBoxDiaChi
            // 
            this.textBoxDiaChi.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiaChi.Location = new System.Drawing.Point(145, 176);
            this.textBoxDiaChi.Multiline = true;
            this.textBoxDiaChi.Name = "textBoxDiaChi";
            this.textBoxDiaChi.Size = new System.Drawing.Size(324, 97);
            this.textBoxDiaChi.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ngày đăng ký:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Địa chỉ:";
            // 
            // labelDiemTichLuy
            // 
            this.labelDiemTichLuy.AutoSize = true;
            this.labelDiemTichLuy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiemTichLuy.Location = new System.Drawing.Point(36, 451);
            this.labelDiemTichLuy.Name = "labelDiemTichLuy";
            this.labelDiemTichLuy.Size = new System.Drawing.Size(103, 18);
            this.labelDiemTichLuy.TabIndex = 10;
            this.labelDiemTichLuy.Text = "Điểm tích lũy: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số điện thoại:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(145, 332);
            this.textBoxEmail.MaxLength = 128;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(324, 29);
            this.textBoxEmail.TabIndex = 9;
            // 
            // textBoxSoDienThoai
            // 
            this.textBoxSoDienThoai.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoDienThoai.Location = new System.Drawing.Point(145, 297);
            this.textBoxSoDienThoai.MaxLength = 16;
            this.textBoxSoDienThoai.Name = "textBoxSoDienThoai";
            this.textBoxSoDienThoai.Size = new System.Drawing.Size(324, 29);
            this.textBoxSoDienThoai.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email:";
            // 
            // dataGridViewKhachHang
            // 
            this.dataGridViewKhachHang.AllowUserToAddRows = false;
            this.dataGridViewKhachHang.AllowUserToDeleteRows = false;
            this.dataGridViewKhachHang.AllowUserToResizeColumns = false;
            this.dataGridViewKhachHang.AllowUserToResizeRows = false;
            this.dataGridViewKhachHang.AutoGenerateColumns = false;
            this.dataGridViewKhachHang.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewKhachHang.ColumnHeadersHeight = 38;
            this.dataGridViewKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.tenKhachHangDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.soDienThoaiDataGridViewTextBoxColumn,
            this.diemTichLuyDataGridViewTextBoxColumn,
            this.ngayDangKyDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.maKhachHangDataGridViewTextBoxColumn,
            this.maLoaiKhachHangDataGridViewTextBoxColumn});
            this.dataGridViewKhachHang.DataSource = this.khachHangBindingSource;
            this.dataGridViewKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewKhachHang.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewKhachHang.Name = "dataGridViewKhachHang";
            this.dataGridViewKhachHang.RowHeadersVisible = false;
            this.dataGridViewKhachHang.RowTemplate.Height = 32;
            this.dataGridViewKhachHang.Size = new System.Drawing.Size(1152, 931);
            this.dataGridViewKhachHang.TabIndex = 4;
            this.dataGridViewKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewKhachHang_CellClick);
            this.dataGridViewKhachHang.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DataGridViewKhachHang_RowPrePaint);
            // 
            // stt
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.stt.DefaultCellStyle = dataGridViewCellStyle2;
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            this.stt.Width = 48;
            // 
            // tenKhachHangDataGridViewTextBoxColumn
            // 
            this.tenKhachHangDataGridViewTextBoxColumn.DataPropertyName = "tenKhachHang";
            this.tenKhachHangDataGridViewTextBoxColumn.HeaderText = "Tên khách hàng";
            this.tenKhachHangDataGridViewTextBoxColumn.Name = "tenKhachHangDataGridViewTextBoxColumn";
            this.tenKhachHangDataGridViewTextBoxColumn.Width = 300;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "diaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            // 
            // soDienThoaiDataGridViewTextBoxColumn
            // 
            this.soDienThoaiDataGridViewTextBoxColumn.DataPropertyName = "soDienThoai";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.soDienThoaiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.soDienThoaiDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.soDienThoaiDataGridViewTextBoxColumn.Name = "soDienThoaiDataGridViewTextBoxColumn";
            this.soDienThoaiDataGridViewTextBoxColumn.Width = 200;
            // 
            // diemTichLuyDataGridViewTextBoxColumn
            // 
            this.diemTichLuyDataGridViewTextBoxColumn.DataPropertyName = "diemTichLuy";
            this.diemTichLuyDataGridViewTextBoxColumn.HeaderText = "diemTichLuy";
            this.diemTichLuyDataGridViewTextBoxColumn.Name = "diemTichLuyDataGridViewTextBoxColumn";
            this.diemTichLuyDataGridViewTextBoxColumn.Visible = false;
            // 
            // ngayDangKyDataGridViewTextBoxColumn
            // 
            this.ngayDangKyDataGridViewTextBoxColumn.DataPropertyName = "ngayDangKy";
            this.ngayDangKyDataGridViewTextBoxColumn.HeaderText = "ngayDangKy";
            this.ngayDangKyDataGridViewTextBoxColumn.Name = "ngayDangKyDataGridViewTextBoxColumn";
            this.ngayDangKyDataGridViewTextBoxColumn.Visible = false;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Visible = false;
            // 
            // maKhachHangDataGridViewTextBoxColumn
            // 
            this.maKhachHangDataGridViewTextBoxColumn.DataPropertyName = "maKhachHang";
            this.maKhachHangDataGridViewTextBoxColumn.HeaderText = "maKhachHang";
            this.maKhachHangDataGridViewTextBoxColumn.Name = "maKhachHangDataGridViewTextBoxColumn";
            this.maKhachHangDataGridViewTextBoxColumn.Visible = false;
            // 
            // maLoaiKhachHangDataGridViewTextBoxColumn
            // 
            this.maLoaiKhachHangDataGridViewTextBoxColumn.DataPropertyName = "maLoaiKhachHang";
            this.maLoaiKhachHangDataGridViewTextBoxColumn.HeaderText = "maLoaiKhachHang";
            this.maLoaiKhachHangDataGridViewTextBoxColumn.Name = "maLoaiKhachHangDataGridViewTextBoxColumn";
            this.maLoaiKhachHangDataGridViewTextBoxColumn.Visible = false;
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataSource = typeof(milk_sales_manager.models.KhachHang);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.dataGridViewKhachHang);
            this.panelContainer.Controls.Add(this.panelChiTiet);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(256, 8);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1664, 931);
            this.panelContainer.TabIndex = 5;
            // 
            // KhachHangUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KhachHangUC";
            this.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.Size = new System.Drawing.Size(1920, 939);
            this.Tag = "Khach hang";
            this.Load += new System.EventHandler(this.KhachHangUC_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelChiTiet.ResumeLayout(false);
            this.groupBoxThongTinKhachHang.ResumeLayout(false);
            this.groupBoxThongTinKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelChiTiet;
        private System.Windows.Forms.DataGridView dataGridViewKhachHang;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhachHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemTichLuyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDangKyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhachHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiKhachHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBoxSoDienThoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDiaChi;
        private System.Windows.Forms.TextBox textBoxTenKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDiemTichLuy;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayDangKy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxThongTinKhachHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxLoaiKhachHang;
        private System.Windows.Forms.Button buttonKhachHangMoi;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.TextBox textBoxDiemTichLuy;
        private System.Windows.Forms.Button buttonLoaiKhachHang;
        private System.Windows.Forms.Panel panelContainer;
    }
}
