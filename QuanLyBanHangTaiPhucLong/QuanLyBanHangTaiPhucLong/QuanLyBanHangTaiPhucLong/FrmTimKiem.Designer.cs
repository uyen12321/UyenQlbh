namespace QuanLyBanHangTaiPhucLong
{
    partial class FrmTimKiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTimKiem));
            this.txtTimKIem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnThoatNV = new System.Windows.Forms.Button();
            this.btnTimNV = new System.Windows.Forms.Button();
            this.rbtnMaNV = new System.Windows.Forms.RadioButton();
            this.rbtnHoTen = new System.Windows.Forms.RadioButton();
            this.rbtnCMND = new System.Windows.Forms.RadioButton();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTimKIem
            // 
            this.txtTimKIem.Location = new System.Drawing.Point(497, 113);
            this.txtTimKIem.Name = "txtTimKIem";
            this.txtTimKIem.Size = new System.Drawing.Size(318, 30);
            this.txtTimKIem.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(299, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập từ khóa cần tìm";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.btnThoatNV);
            this.panel6.Controls.Add(this.btnTimNV);
            this.panel6.Location = new System.Drawing.Point(334, 287);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(387, 79);
            this.panel6.TabIndex = 18;
            // 
            // btnThoatNV
            // 
            this.btnThoatNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThoatNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoatNV.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnThoatNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoatNV.ForeColor = System.Drawing.Color.Brown;
            this.btnThoatNV.Location = new System.Drawing.Point(249, 13);
            this.btnThoatNV.Name = "btnThoatNV";
            this.btnThoatNV.Size = new System.Drawing.Size(108, 52);
            this.btnThoatNV.TabIndex = 8;
            this.btnThoatNV.Text = "Thoát";
            this.btnThoatNV.UseVisualStyleBackColor = false;
            this.btnThoatNV.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTimNV
            // 
            this.btnTimNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTimNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimNV.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnTimNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimNV.ForeColor = System.Drawing.Color.Brown;
            this.btnTimNV.Location = new System.Drawing.Point(12, 13);
            this.btnTimNV.Name = "btnTimNV";
            this.btnTimNV.Size = new System.Drawing.Size(108, 52);
            this.btnTimNV.TabIndex = 7;
            this.btnTimNV.Text = "Tìm";
            this.btnTimNV.UseVisualStyleBackColor = false;
            // 
            // rbtnMaNV
            // 
            this.rbtnMaNV.AutoSize = true;
            this.rbtnMaNV.ForeColor = System.Drawing.Color.Brown;
            this.rbtnMaNV.Location = new System.Drawing.Point(265, 198);
            this.rbtnMaNV.Name = "rbtnMaNV";
            this.rbtnMaNV.Size = new System.Drawing.Size(150, 27);
            this.rbtnMaNV.TabIndex = 23;
            this.rbtnMaNV.TabStop = true;
            this.rbtnMaNV.Text = "Mã nhân viên";
            this.rbtnMaNV.UseVisualStyleBackColor = true;
            // 
            // rbtnHoTen
            // 
            this.rbtnHoTen.AutoSize = true;
            this.rbtnHoTen.ForeColor = System.Drawing.Color.Brown;
            this.rbtnHoTen.Location = new System.Drawing.Point(521, 198);
            this.rbtnHoTen.Name = "rbtnHoTen";
            this.rbtnHoTen.Size = new System.Drawing.Size(92, 27);
            this.rbtnHoTen.TabIndex = 24;
            this.rbtnHoTen.TabStop = true;
            this.rbtnHoTen.Text = "Họ tên";
            this.rbtnHoTen.UseVisualStyleBackColor = true;
            // 
            // rbtnCMND
            // 
            this.rbtnCMND.AutoSize = true;
            this.rbtnCMND.ForeColor = System.Drawing.Color.Brown;
            this.rbtnCMND.Location = new System.Drawing.Point(701, 198);
            this.rbtnCMND.Name = "rbtnCMND";
            this.rbtnCMND.Size = new System.Drawing.Size(153, 27);
            this.rbtnCMND.TabIndex = 25;
            this.rbtnCMND.TabStop = true;
            this.rbtnCMND.Text = "CMND/CCCD";
            this.rbtnCMND.UseVisualStyleBackColor = true;
            // 
            // FrmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1078, 744);
            this.Controls.Add(this.rbtnCMND);
            this.Controls.Add(this.rbtnHoTen);
            this.Controls.Add(this.rbtnMaNV);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimKIem);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmTimKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm";
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimKIem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnThoatNV;
        private System.Windows.Forms.Button btnTimNV;
        private System.Windows.Forms.RadioButton rbtnMaNV;
        private System.Windows.Forms.RadioButton rbtnHoTen;
        private System.Windows.Forms.RadioButton rbtnCMND;
    }
}