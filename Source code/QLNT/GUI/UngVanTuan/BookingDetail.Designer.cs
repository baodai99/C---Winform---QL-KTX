namespace GUI
{
    partial class BookingDetail
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
            this.lbltieude = new System.Windows.Forms.Label();
            this.dvgdanhsachdadat = new System.Windows.Forms.DataGridView();
            this.maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaydat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgdanhsachdadat)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltieude
            // 
            this.lbltieude.AutoSize = true;
            this.lbltieude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltieude.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltieude.Location = new System.Drawing.Point(208, 24);
            this.lbltieude.Name = "lbltieude";
            this.lbltieude.Size = new System.Drawing.Size(308, 25);
            this.lbltieude.TabIndex = 0;
            this.lbltieude.Text = "DANH SÁCH PHÒNG ĐÃ ĐẶT";
            this.lbltieude.Click += new System.EventHandler(this.lbltieude_Click);
            // 
            // dvgdanhsachdadat
            // 
            this.dvgdanhsachdadat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgdanhsachdadat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphong,
            this.makhachhang,
            this.ngaydat});
            this.dvgdanhsachdadat.Location = new System.Drawing.Point(38, 73);
            this.dvgdanhsachdadat.Name = "dvgdanhsachdadat";
            this.dvgdanhsachdadat.RowHeadersWidth = 51;
            this.dvgdanhsachdadat.RowTemplate.Height = 24;
            this.dvgdanhsachdadat.Size = new System.Drawing.Size(654, 367);
            this.dvgdanhsachdadat.TabIndex = 1;
            this.dvgdanhsachdadat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgdanhsachdadat_CellContentClick);
            // 
            // maphong
            // 
            this.maphong.DataPropertyName = "room_ID";
            this.maphong.HeaderText = "Mã phòng";
            this.maphong.MinimumWidth = 6;
            this.maphong.Name = "maphong";
            this.maphong.Width = 110;
            // 
            // makhachhang
            // 
            this.makhachhang.DataPropertyName = "customer_ID";
            this.makhachhang.HeaderText = "Mã khách hàng";
            this.makhachhang.MinimumWidth = 6;
            this.makhachhang.Name = "makhachhang";
            this.makhachhang.Width = 120;
            // 
            // ngaydat
            // 
            this.ngaydat.DataPropertyName = "date_hire";
            this.ngaydat.HeaderText = "Ngày đặt";
            this.ngaydat.MinimumWidth = 6;
            this.ngaydat.Name = "ngaydat";
            this.ngaydat.Width = 200;
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthoat.Location = new System.Drawing.Point(282, 467);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(107, 39);
            this.btnthoat.TabIndex = 2;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // BookingDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(747, 518);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.dvgdanhsachdadat);
            this.Controls.Add(this.lbltieude);
            this.Name = "BookingDetail";
            this.Text = "BookingDeatail";
            this.Load += new System.EventHandler(this.BookingDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgdanhsachdadat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltieude;
        private System.Windows.Forms.DataGridView dvgdanhsachdadat;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaydat;
    }
}