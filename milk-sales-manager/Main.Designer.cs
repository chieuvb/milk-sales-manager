namespace milk_sales_manager
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pan_navigator = new System.Windows.Forms.Panel();
            this.but_tuychon = new System.Windows.Forms.Button();
            this.but_thongke = new System.Windows.Forms.Button();
            this.but_khachhang = new System.Windows.Forms.Button();
            this.but_nhanvien = new System.Windows.Forms.Button();
            this.but_sanpham = new System.Windows.Forms.Button();
            this.buttonThanhToan = new System.Windows.Forms.Button();
            this.pan_container = new System.Windows.Forms.Panel();
            this.pan_navigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_navigator
            // 
            this.pan_navigator.BackColor = System.Drawing.Color.SkyBlue;
            this.pan_navigator.Controls.Add(this.but_tuychon);
            this.pan_navigator.Controls.Add(this.but_thongke);
            this.pan_navigator.Controls.Add(this.but_khachhang);
            this.pan_navigator.Controls.Add(this.but_nhanvien);
            this.pan_navigator.Controls.Add(this.but_sanpham);
            this.pan_navigator.Controls.Add(this.buttonThanhToan);
            this.pan_navigator.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_navigator.Location = new System.Drawing.Point(0, 0);
            this.pan_navigator.Name = "pan_navigator";
            this.pan_navigator.Size = new System.Drawing.Size(1008, 70);
            this.pan_navigator.TabIndex = 0;
            // 
            // but_tuychon
            // 
            this.but_tuychon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_tuychon.BackColor = System.Drawing.Color.MintCream;
            this.but_tuychon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_tuychon.Image = global::milk_sales_manager.Properties.Resources.icons8_options_32;
            this.but_tuychon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_tuychon.Location = new System.Drawing.Point(846, 12);
            this.but_tuychon.Name = "but_tuychon";
            this.but_tuychon.Size = new System.Drawing.Size(150, 48);
            this.but_tuychon.TabIndex = 5;
            this.but_tuychon.Text = "Tùy chọn";
            this.but_tuychon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_tuychon.UseVisualStyleBackColor = false;
            this.but_tuychon.Click += new System.EventHandler(this.But_tuychon_Click);
            // 
            // but_thongke
            // 
            this.but_thongke.BackColor = System.Drawing.Color.MintCream;
            this.but_thongke.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_thongke.Image = global::milk_sales_manager.Properties.Resources.icons8_chart_32;
            this.but_thongke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_thongke.Location = new System.Drawing.Point(636, 12);
            this.but_thongke.Name = "but_thongke";
            this.but_thongke.Size = new System.Drawing.Size(150, 48);
            this.but_thongke.TabIndex = 4;
            this.but_thongke.Text = "Thống kê";
            this.but_thongke.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_thongke.UseVisualStyleBackColor = false;
            this.but_thongke.Click += new System.EventHandler(this.But_thongke_Click);
            // 
            // but_khachhang
            // 
            this.but_khachhang.BackColor = System.Drawing.Color.MintCream;
            this.but_khachhang.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_khachhang.Image = global::milk_sales_manager.Properties.Resources.icons8_customer_32;
            this.but_khachhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_khachhang.Location = new System.Drawing.Point(480, 12);
            this.but_khachhang.Name = "but_khachhang";
            this.but_khachhang.Size = new System.Drawing.Size(150, 48);
            this.but_khachhang.TabIndex = 3;
            this.but_khachhang.Text = "Khách hàng";
            this.but_khachhang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_khachhang.UseVisualStyleBackColor = false;
            this.but_khachhang.Click += new System.EventHandler(this.But_khachhang_Click);
            // 
            // but_nhanvien
            // 
            this.but_nhanvien.BackColor = System.Drawing.Color.MintCream;
            this.but_nhanvien.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_nhanvien.Image = global::milk_sales_manager.Properties.Resources.icons8_employee_32;
            this.but_nhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_nhanvien.Location = new System.Drawing.Point(324, 12);
            this.but_nhanvien.Name = "but_nhanvien";
            this.but_nhanvien.Size = new System.Drawing.Size(150, 48);
            this.but_nhanvien.TabIndex = 2;
            this.but_nhanvien.Text = "Nhân viên";
            this.but_nhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_nhanvien.UseVisualStyleBackColor = false;
            this.but_nhanvien.Click += new System.EventHandler(this.But_nhanvien_Click);
            // 
            // but_sanpham
            // 
            this.but_sanpham.BackColor = System.Drawing.Color.MintCream;
            this.but_sanpham.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_sanpham.Image = global::milk_sales_manager.Properties.Resources.icons8_product_32;
            this.but_sanpham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_sanpham.Location = new System.Drawing.Point(168, 12);
            this.but_sanpham.Name = "but_sanpham";
            this.but_sanpham.Size = new System.Drawing.Size(150, 48);
            this.but_sanpham.TabIndex = 1;
            this.but_sanpham.Text = "Sản phẩm";
            this.but_sanpham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_sanpham.UseVisualStyleBackColor = false;
            this.but_sanpham.Click += new System.EventHandler(this.But_sanpham_Click);
            // 
            // buttonThanhToan
            // 
            this.buttonThanhToan.BackColor = System.Drawing.Color.MintCream;
            this.buttonThanhToan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThanhToan.Image = global::milk_sales_manager.Properties.Resources.icons8_bill_32;
            this.buttonThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThanhToan.Location = new System.Drawing.Point(12, 12);
            this.buttonThanhToan.Name = "buttonThanhToan";
            this.buttonThanhToan.Size = new System.Drawing.Size(150, 48);
            this.buttonThanhToan.TabIndex = 0;
            this.buttonThanhToan.Text = "Thanh toán";
            this.buttonThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonThanhToan.UseVisualStyleBackColor = false;
            this.buttonThanhToan.Click += new System.EventHandler(this.ButtonThanhToan_Click);
            // 
            // pan_container
            // 
            this.pan_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_container.Location = new System.Drawing.Point(0, 70);
            this.pan_container.Name = "pan_container";
            this.pan_container.Size = new System.Drawing.Size(1008, 611);
            this.pan_container.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.pan_container);
            this.Controls.Add(this.pan_navigator);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Phần mềm quản lý bán sữa Vinamilk";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.pan_navigator.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_navigator;
        private System.Windows.Forms.Button buttonThanhToan;
        private System.Windows.Forms.Button but_sanpham;
        private System.Windows.Forms.Button but_nhanvien;
        private System.Windows.Forms.Button but_khachhang;
        private System.Windows.Forms.Button but_thongke;
        private System.Windows.Forms.Panel pan_container;
        private System.Windows.Forms.Button but_tuychon;
    }
}

