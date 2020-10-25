namespace GUI.GUI
{
    partial class Room
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMap = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.rdbEmpty = new System.Windows.Forms.RadioButton();
            this.rdbFull = new System.Windows.Forms.RadioButton();
            this.txtSonguoi = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTk = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.map = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTang = new System.Windows.Forms.TextBox();
            this.cbLoaip = new System.Windows.Forms.ComboBox();
            this.btnHienthi = new System.Windows.Forms.Button();
            this.grb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(417, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN PHÒNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(52, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Phòng :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(52, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại Phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(52, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tầng :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(52, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giá :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(52, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Trạng Thái :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(52, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số Người :";
            // 
            // txtMap
            // 
            this.txtMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMap.Location = new System.Drawing.Point(196, 91);
            this.txtMap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMap.Name = "txtMap";
            this.txtMap.Size = new System.Drawing.Size(137, 22);
            this.txtMap.TabIndex = 1;
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(196, 201);
            this.txtGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(137, 22);
            this.txtGia.TabIndex = 4;
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.rdbEmpty);
            this.grb1.Controls.Add(this.rdbFull);
            this.grb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb1.Location = new System.Drawing.Point(178, 240);
            this.grb1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb1.Name = "grb1";
            this.grb1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb1.Size = new System.Drawing.Size(188, 29);
            this.grb1.TabIndex = 13;
            this.grb1.TabStop = false;
            // 
            // rdbEmpty
            // 
            this.rdbEmpty.AutoSize = true;
            this.rdbEmpty.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbEmpty.Location = new System.Drawing.Point(84, 9);
            this.rdbEmpty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbEmpty.Name = "rdbEmpty";
            this.rdbEmpty.Size = new System.Drawing.Size(73, 21);
            this.rdbEmpty.TabIndex = 6;
            this.rdbEmpty.Text = "Empty";
            this.rdbEmpty.UseVisualStyleBackColor = true;
            // 
            // rdbFull
            // 
            this.rdbFull.AutoSize = true;
            this.rdbFull.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbFull.Location = new System.Drawing.Point(18, 9);
            this.rdbFull.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbFull.Name = "rdbFull";
            this.rdbFull.Size = new System.Drawing.Size(55, 21);
            this.rdbFull.TabIndex = 5;
            this.rdbFull.Text = "Full";
            this.rdbFull.UseVisualStyleBackColor = true;
            // 
            // txtSonguoi
            // 
            this.txtSonguoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSonguoi.Location = new System.Drawing.Point(196, 283);
            this.txtSonguoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSonguoi.Name = "txtSonguoi";
            this.txtSonguoi.Size = new System.Drawing.Size(137, 22);
            this.txtSonguoi.TabIndex = 7;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(53, 320);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(137, 51);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCapnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCapnhat.Location = new System.Drawing.Point(196, 320);
            this.btnCapnhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(137, 51);
            this.btnCapnhat.TabIndex = 9;
            this.btnCapnhat.Text = "Cập Nhật";
            this.btnCapnhat.UseVisualStyleBackColor = false;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Location = new System.Drawing.Point(53, 380);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(137, 57);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTk
            // 
            this.btnTk.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnTk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTk.Location = new System.Drawing.Point(196, 380);
            this.btnTk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTk.Name = "btnTk";
            this.btnTk.Size = new System.Drawing.Size(137, 57);
            this.btnTk.TabIndex = 11;
            this.btnTk.Text = "Tìm Kiếm";
            this.btnTk.UseVisualStyleBackColor = false;
            this.btnTk.Click += new System.EventHandler(this.btnTk_Click);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Reset.Location = new System.Drawing.Point(53, 446);
            this.Reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(137, 51);
            this.Reset.TabIndex = 12;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(196, 446);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(137, 51);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvRoom
            // 
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.map,
            this.loaip,
            this.tang,
            this.Gia,
            this.tt,
            this.sn});
            this.dgvRoom.Location = new System.Drawing.Point(381, 91);
            this.dgvRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.RowHeadersWidth = 62;
            this.dgvRoom.RowTemplate.Height = 28;
            this.dgvRoom.Size = new System.Drawing.Size(653, 458);
            this.dgvRoom.TabIndex = 21;
            this.dgvRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellclick);
            // 
            // map
            // 
            this.map.DataPropertyName = "room_ID";
            this.map.HeaderText = "Mã Phòng";
            this.map.MinimumWidth = 8;
            this.map.Name = "map";
            this.map.Width = 90;
            // 
            // loaip
            // 
            this.loaip.DataPropertyName = "type_room";
            this.loaip.HeaderText = "Loại Phòng";
            this.loaip.MinimumWidth = 8;
            this.loaip.Name = "loaip";
            this.loaip.Width = 80;
            // 
            // tang
            // 
            this.tang.DataPropertyName = "number_floor";
            this.tang.HeaderText = "Tầng";
            this.tang.MinimumWidth = 8;
            this.tang.Name = "tang";
            this.tang.Width = 50;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "price";
            this.Gia.HeaderText = "Giá";
            this.Gia.MinimumWidth = 8;
            this.Gia.Name = "Gia";
            this.Gia.Width = 90;
            // 
            // tt
            // 
            this.tt.DataPropertyName = "status_room";
            this.tt.HeaderText = "Trạng Thái";
            this.tt.MinimumWidth = 8;
            this.tt.Name = "tt";
            this.tt.Width = 60;
            // 
            // sn
            // 
            this.sn.DataPropertyName = "number_person";
            this.sn.HeaderText = "Số Người";
            this.sn.MinimumWidth = 8;
            this.sn.Name = "sn";
            this.sn.Width = 60;
            // 
            // txtTang
            // 
            this.txtTang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTang.Location = new System.Drawing.Point(196, 168);
            this.txtTang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTang.Name = "txtTang";
            this.txtTang.Size = new System.Drawing.Size(137, 22);
            this.txtTang.TabIndex = 3;
            // 
            // cbLoaip
            // 
            this.cbLoaip.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaip.FormattingEnabled = true;
            this.cbLoaip.Location = new System.Drawing.Point(196, 130);
            this.cbLoaip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLoaip.Name = "cbLoaip";
            this.cbLoaip.Size = new System.Drawing.Size(137, 24);
            this.cbLoaip.TabIndex = 2;
            // 
            // btnHienthi
            // 
            this.btnHienthi.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnHienthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienthi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHienthi.Location = new System.Drawing.Point(126, 502);
            this.btnHienthi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHienthi.Name = "btnHienthi";
            this.btnHienthi.Size = new System.Drawing.Size(116, 47);
            this.btnHienthi.TabIndex = 22;
            this.btnHienthi.Text = "Hiển Thị";
            this.btnHienthi.UseVisualStyleBackColor = false;
            this.btnHienthi.Click += new System.EventHandler(this.btnHienthi_Click);
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1073, 580);
            this.Controls.Add(this.btnHienthi);
            this.Controls.Add(this.cbLoaip);
            this.Controls.Add(this.txtTang);
            this.Controls.Add(this.dgvRoom);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.btnTk);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSonguoi);
            this.Controls.Add(this.grb1);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtMap);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Room";
            this.Text = "Room";
            this.Load += new System.EventHandler(this.Room_Load);
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMap;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.RadioButton rdbEmpty;
        private System.Windows.Forms.RadioButton rdbFull;
        private System.Windows.Forms.TextBox txtSonguoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTk;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn map;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaip;
        private System.Windows.Forms.DataGridViewTextBoxColumn tang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn sn;
        private System.Windows.Forms.TextBox txtTang;
        private System.Windows.Forms.ComboBox cbLoaip;
        private System.Windows.Forms.Button btnHienthi;
    }
}