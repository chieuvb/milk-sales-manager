namespace milk_sales_manager.controls
{
    partial class ThongKeUC
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.buttonDoanhThu = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewThong = new System.Windows.Forms.DataGridView();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxNam = new System.Windows.Forms.ComboBox();
            this.panelLeft.SuspendLayout();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThong)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panelLeft.Controls.Add(this.buttonDoanhThu);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 8);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(256, 931);
            this.panelLeft.TabIndex = 2;
            // 
            // buttonDoanhThu
            // 
            this.buttonDoanhThu.Location = new System.Drawing.Point(4, 4);
            this.buttonDoanhThu.Name = "buttonDoanhThu";
            this.buttonDoanhThu.Size = new System.Drawing.Size(249, 38);
            this.buttonDoanhThu.TabIndex = 0;
            this.buttonDoanhThu.Text = "Doanh thu";
            this.buttonDoanhThu.UseVisualStyleBackColor = true;
            this.buttonDoanhThu.Click += new System.EventHandler(this.ButtonDoanhThu_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.dataGridViewThong);
            this.panelContainer.Controls.Add(this.panelHeader);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(256, 8);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1664, 931);
            this.panelContainer.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(475, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số tiền thu được (chưa trừ chi phí)";
            // 
            // dataGridViewThong
            // 
            this.dataGridViewThong.AllowUserToAddRows = false;
            this.dataGridViewThong.AllowUserToDeleteRows = false;
            this.dataGridViewThong.AllowUserToResizeColumns = false;
            this.dataGridViewThong.AllowUserToResizeRows = false;
            this.dataGridViewThong.ColumnHeadersHeight = 38;
            this.dataGridViewThong.Location = new System.Drawing.Point(6, 86);
            this.dataGridViewThong.Name = "dataGridViewThong";
            this.dataGridViewThong.ReadOnly = true;
            this.dataGridViewThong.RowHeadersVisible = false;
            this.dataGridViewThong.RowTemplate.Height = 32;
            this.dataGridViewThong.Size = new System.Drawing.Size(1540, 128);
            this.dataGridViewThong.TabIndex = 3;
            // 
            // panelHeader
            // 
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.label2);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.comboBoxNam);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1664, 48);
            this.panelHeader.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(484, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Năm:";
            // 
            // comboBoxNam
            // 
            this.comboBoxNam.DropDownHeight = 128;
            this.comboBoxNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNam.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNam.FormattingEnabled = true;
            this.comboBoxNam.IntegralHeight = false;
            this.comboBoxNam.Location = new System.Drawing.Point(548, 8);
            this.comboBoxNam.MaxDropDownItems = 4;
            this.comboBoxNam.MaxLength = 256;
            this.comboBoxNam.Name = "comboBoxNam";
            this.comboBoxNam.Size = new System.Drawing.Size(102, 32);
            this.comboBoxNam.TabIndex = 0;
            this.comboBoxNam.SelectedIndexChanged += new System.EventHandler(this.ComboBoxNam_SelectedIndexChanged);
            // 
            // ThongKeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThongKeUC";
            this.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.Size = new System.Drawing.Size(1920, 939);
            this.Tag = "Thong ke";
            this.Load += new System.EventHandler(this.ThongKeUC_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThong)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button buttonDoanhThu;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.DataGridView dataGridViewThong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxNam;
        private System.Windows.Forms.Label label2;
    }
}
