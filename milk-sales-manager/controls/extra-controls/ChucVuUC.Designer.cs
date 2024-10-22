using milk_sales_manager.Properties;
using System.Drawing;
using System.IO;

namespace milk_sales_manager.controls.extra_controls
{
    partial class ChucVuUC
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
            this.panelHead = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.dataGridViewChucVu = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luu = new System.Windows.Forms.DataGridViewButtonColumn();
            this.xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.maChucVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenChucVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nhanViensDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucVuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.Linen;
            this.panelHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHead.Controls.Add(this.buttonBack);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(1206, 48);
            this.panelHead.TabIndex = 0;
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.Image = Resources.icons8_close_24;
            this.buttonBack.Location = new System.Drawing.Point(1160, 3);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(41, 41);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // dataGridViewChucVu
            // 
            this.dataGridViewChucVu.AllowUserToAddRows = false;
            this.dataGridViewChucVu.AllowUserToDeleteRows = false;
            this.dataGridViewChucVu.AllowUserToResizeColumns = false;
            this.dataGridViewChucVu.AllowUserToResizeRows = false;
            this.dataGridViewChucVu.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewChucVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewChucVu.ColumnHeadersHeight = 38;
            this.dataGridViewChucVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.maChucVuDataGridViewTextBoxColumn,
            this.tenChucVuDataGridViewTextBoxColumn,
            this.moTaDataGridViewTextBoxColumn,
            this.trangThaiDataGridViewCheckBoxColumn,
            this.nhanViensDataGridViewTextBoxColumn,
            this.luu,
            this.xoa});
            this.dataGridViewChucVu.DataSource = this.chucVuBindingSource;
            this.dataGridViewChucVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewChucVu.Location = new System.Drawing.Point(0, 48);
            this.dataGridViewChucVu.Name = "dataGridViewChucVu";
            this.dataGridViewChucVu.RowHeadersVisible = false;
            this.dataGridViewChucVu.RowTemplate.Height = 32;
            this.dataGridViewChucVu.Size = new System.Drawing.Size(1206, 829);
            this.dataGridViewChucVu.TabIndex = 1;
            this.dataGridViewChucVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewChucVu_CellClick);
            this.dataGridViewChucVu.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DataGridViewChucVu_RowPrePaint);
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
            // maChucVuDataGridViewTextBoxColumn
            // 
            this.maChucVuDataGridViewTextBoxColumn.DataPropertyName = "maChucVu";
            this.maChucVuDataGridViewTextBoxColumn.HeaderText = "maChucVu";
            this.maChucVuDataGridViewTextBoxColumn.Name = "maChucVuDataGridViewTextBoxColumn";
            this.maChucVuDataGridViewTextBoxColumn.Visible = false;
            // 
            // tenChucVuDataGridViewTextBoxColumn
            // 
            this.tenChucVuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenChucVuDataGridViewTextBoxColumn.DataPropertyName = "tenChucVu";
            this.tenChucVuDataGridViewTextBoxColumn.HeaderText = "Tên chức vụ";
            this.tenChucVuDataGridViewTextBoxColumn.Name = "tenChucVuDataGridViewTextBoxColumn";
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
            this.trangThaiDataGridViewCheckBoxColumn.HeaderText = "trangThai";
            this.trangThaiDataGridViewCheckBoxColumn.Name = "trangThaiDataGridViewCheckBoxColumn";
            this.trangThaiDataGridViewCheckBoxColumn.Visible = false;
            // 
            // nhanViensDataGridViewTextBoxColumn
            // 
            this.nhanViensDataGridViewTextBoxColumn.DataPropertyName = "NhanViens";
            this.nhanViensDataGridViewTextBoxColumn.HeaderText = "NhanViens";
            this.nhanViensDataGridViewTextBoxColumn.Name = "nhanViensDataGridViewTextBoxColumn";
            this.nhanViensDataGridViewTextBoxColumn.Visible = false;
            // 
            // chucVuBindingSource
            // 
            this.chucVuBindingSource.DataSource = typeof(milk_sales_manager.models.ChucVu);
            // 
            // ChucVuUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewChucVu);
            this.Controls.Add(this.panelHead);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChucVuUC";
            this.Size = new System.Drawing.Size(1206, 877);
            this.Load += new System.EventHandler(this.ChucVuUC_Load);
            this.panelHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucVuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridView dataGridViewChucVu;
        private System.Windows.Forms.BindingSource chucVuBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn maChucVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenChucVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn trangThaiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhanViensDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn luu;
        private System.Windows.Forms.DataGridViewButtonColumn xoa;
    }
}
