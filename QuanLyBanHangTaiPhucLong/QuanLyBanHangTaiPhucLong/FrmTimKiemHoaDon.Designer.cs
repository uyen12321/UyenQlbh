
namespace QuanLyBanHangTaiPhucLong
{
    partial class FrmTimKiemHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTimKiemHoaDon));
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.rbtnMaNV = new System.Windows.Forms.RadioButton();
            this.rbtnHoTen = new System.Windows.Forms.RadioButton();
            this.btnTimNV = new System.Windows.Forms.Button();
            this.btnThoatTimKiem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaHD
            // 
            this.txtMaHD.BackColor = System.Drawing.Color.White;
            this.txtMaHD.Location = new System.Drawing.Point(310, 68);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(170, 26);
            this.txtMaHD.TabIndex = 27;
            // 
            // rbtnMaNV
            // 
            this.rbtnMaNV.AutoSize = true;
            this.rbtnMaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.rbtnMaNV.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMaNV.ForeColor = System.Drawing.Color.Brown;
            this.rbtnMaNV.Location = new System.Drawing.Point(135, 67);
            this.rbtnMaNV.Name = "rbtnMaNV";
            this.rbtnMaNV.Size = new System.Drawing.Size(141, 27);
            this.rbtnMaNV.TabIndex = 31;
            this.rbtnMaNV.TabStop = true;
            this.rbtnMaNV.Text = "Mã hóa đơn:";
            this.rbtnMaNV.UseVisualStyleBackColor = false;
            // 
            // rbtnHoTen
            // 
            this.rbtnHoTen.AutoSize = true;
            this.rbtnHoTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.rbtnHoTen.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnHoTen.ForeColor = System.Drawing.Color.Brown;
            this.rbtnHoTen.Location = new System.Drawing.Point(574, 67);
            this.rbtnHoTen.Name = "rbtnHoTen";
            this.rbtnHoTen.Size = new System.Drawing.Size(170, 27);
            this.rbtnHoTen.TabIndex = 32;
            this.rbtnHoTen.TabStop = true;
            this.rbtnHoTen.Text = "Mã khách hàng:";
            this.rbtnHoTen.UseVisualStyleBackColor = false;
            // 
            // btnTimNV
            // 
            this.btnTimNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTimNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimNV.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnTimNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimNV.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimNV.ForeColor = System.Drawing.Color.Brown;
            this.btnTimNV.Location = new System.Drawing.Point(375, 420);
            this.btnTimNV.Name = "btnTimNV";
            this.btnTimNV.Size = new System.Drawing.Size(122, 52);
            this.btnTimNV.TabIndex = 29;
            this.btnTimNV.Text = "Tìm";
            this.btnTimNV.UseVisualStyleBackColor = false;
            this.btnTimNV.Click += new System.EventHandler(this.btnTimNV_Click);
            // 
            // btnThoatTimKiem
            // 
            this.btnThoatTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThoatTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoatTimKiem.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnThoatTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoatTimKiem.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatTimKiem.ForeColor = System.Drawing.Color.Brown;
            this.btnThoatTimKiem.Location = new System.Drawing.Point(597, 420);
            this.btnThoatTimKiem.Name = "btnThoatTimKiem";
            this.btnThoatTimKiem.Size = new System.Drawing.Size(122, 52);
            this.btnThoatTimKiem.TabIndex = 30;
            this.btnThoatTimKiem.Text = "Thoát";
            this.btnThoatTimKiem.UseVisualStyleBackColor = false;
            this.btnThoatTimKiem.Click += new System.EventHandler(this.btnThoatTimKiem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(25, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1024, 253);
            this.dataGridView1.TabIndex = 34;
            // 
            // txtMaKH
            // 
            this.txtMaKH.BackColor = System.Drawing.Color.White;
            this.txtMaKH.Location = new System.Drawing.Point(782, 67);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(190, 26);
            this.txtMaKH.TabIndex = 35;
            // 
            // FrmTimKiemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1078, 533);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.btnThoatTimKiem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTimNV);
            this.Controls.Add(this.rbtnHoTen);
            this.Controls.Add(this.rbtnMaNV);
            this.Controls.Add(this.txtMaHD);
            this.Name = "FrmTimKiemHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm hoá đơn";
            this.Load += new System.EventHandler(this.FrmTimKiemHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.RadioButton rbtnMaNV;
        private System.Windows.Forms.RadioButton rbtnHoTen;
        private System.Windows.Forms.Button btnTimNV;
        private System.Windows.Forms.Button btnThoatTimKiem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMaKH;
    }
}