namespace GUI
{
    partial class Customer
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
            this.lblcustomer_ID = new System.Windows.Forms.Label();
            this.lblcustomer_name = new System.Windows.Forms.Label();
            this.lblcustomer_age = new System.Windows.Forms.Label();
            this.lblcustomer_address = new System.Windows.Forms.Label();
            this.grbcustomer_gender = new System.Windows.Forms.GroupBox();
            this.rdbnu = new System.Windows.Forms.RadioButton();
            this.rdbnam = new System.Windows.Forms.RadioButton();
            this.lblcustomer_phone = new System.Windows.Forms.Label();
            this.txtcustomer_ID = new System.Windows.Forms.TextBox();
            this.txtcustomer_name = new System.Windows.Forms.TextBox();
            this.txtcustomer_age = new System.Windows.Forms.TextBox();
            this.txtcustomer_address = new System.Windows.Forms.TextBox();
            this.txtcustomer_phone = new System.Windows.Forms.TextBox();
            this.dvgCustomer = new System.Windows.Forms.DataGridView();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnhienthi = new System.Windows.Forms.Button();
            this.grbcustomer_gender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltieude
            // 
            this.lbltieude.AutoSize = true;
            this.lbltieude.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltieude.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltieude.Location = new System.Drawing.Point(425, 23);
            this.lbltieude.Name = "lbltieude";
            this.lbltieude.Size = new System.Drawing.Size(329, 29);
            this.lbltieude.TabIndex = 0;
            this.lbltieude.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // lblcustomer_ID
            // 
            this.lblcustomer_ID.AutoSize = true;
            this.lblcustomer_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomer_ID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcustomer_ID.Location = new System.Drawing.Point(12, 76);
            this.lblcustomer_ID.Name = "lblcustomer_ID";
            this.lblcustomer_ID.Size = new System.Drawing.Size(122, 18);
            this.lblcustomer_ID.TabIndex = 1;
            this.lblcustomer_ID.Text = "Mã khách hàng";
            // 
            // lblcustomer_name
            // 
            this.lblcustomer_name.AutoSize = true;
            this.lblcustomer_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomer_name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcustomer_name.Location = new System.Drawing.Point(12, 118);
            this.lblcustomer_name.Name = "lblcustomer_name";
            this.lblcustomer_name.Size = new System.Drawing.Size(127, 18);
            this.lblcustomer_name.TabIndex = 2;
            this.lblcustomer_name.Text = "Tên khách hàng";
            // 
            // lblcustomer_age
            // 
            this.lblcustomer_age.AutoSize = true;
            this.lblcustomer_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomer_age.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcustomer_age.Location = new System.Drawing.Point(12, 160);
            this.lblcustomer_age.Name = "lblcustomer_age";
            this.lblcustomer_age.Size = new System.Drawing.Size(41, 18);
            this.lblcustomer_age.TabIndex = 3;
            this.lblcustomer_age.Text = "Tuổi";
            // 
            // lblcustomer_address
            // 
            this.lblcustomer_address.AutoSize = true;
            this.lblcustomer_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomer_address.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcustomer_address.Location = new System.Drawing.Point(12, 202);
            this.lblcustomer_address.Name = "lblcustomer_address";
            this.lblcustomer_address.Size = new System.Drawing.Size(60, 18);
            this.lblcustomer_address.TabIndex = 4;
            this.lblcustomer_address.Text = "Địa chỉ";
            // 
            // grbcustomer_gender
            // 
            this.grbcustomer_gender.Controls.Add(this.rdbnu);
            this.grbcustomer_gender.Controls.Add(this.rdbnam);
            this.grbcustomer_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbcustomer_gender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbcustomer_gender.Location = new System.Drawing.Point(15, 245);
            this.grbcustomer_gender.Name = "grbcustomer_gender";
            this.grbcustomer_gender.Size = new System.Drawing.Size(348, 70);
            this.grbcustomer_gender.TabIndex = 5;
            this.grbcustomer_gender.TabStop = false;
            this.grbcustomer_gender.Text = "Giới tính";
            // 
            // rdbnu
            // 
            this.rdbnu.AutoSize = true;
            this.rdbnu.Location = new System.Drawing.Point(256, 23);
            this.rdbnu.Name = "rdbnu";
            this.rdbnu.Size = new System.Drawing.Size(50, 22);
            this.rdbnu.TabIndex = 1;
            this.rdbnu.TabStop = true;
            this.rdbnu.Text = "Nữ";
            this.rdbnu.UseVisualStyleBackColor = true;
            // 
            // rdbnam
            // 
            this.rdbnam.AutoSize = true;
            this.rdbnam.Location = new System.Drawing.Point(172, 22);
            this.rdbnam.Name = "rdbnam";
            this.rdbnam.Size = new System.Drawing.Size(64, 22);
            this.rdbnam.TabIndex = 0;
            this.rdbnam.TabStop = true;
            this.rdbnam.Text = "Nam";
            this.rdbnam.UseVisualStyleBackColor = true;
            // 
            // lblcustomer_phone
            // 
            this.lblcustomer_phone.AutoSize = true;
            this.lblcustomer_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomer_phone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcustomer_phone.Location = new System.Drawing.Point(12, 345);
            this.lblcustomer_phone.Name = "lblcustomer_phone";
            this.lblcustomer_phone.Size = new System.Drawing.Size(107, 18);
            this.lblcustomer_phone.TabIndex = 6;
            this.lblcustomer_phone.Text = "Số điện thoại";
            // 
            // txtcustomer_ID
            // 
            this.txtcustomer_ID.Location = new System.Drawing.Point(187, 77);
            this.txtcustomer_ID.Name = "txtcustomer_ID";
            this.txtcustomer_ID.Size = new System.Drawing.Size(176, 22);
            this.txtcustomer_ID.TabIndex = 7;
            // 
            // txtcustomer_name
            // 
            this.txtcustomer_name.Location = new System.Drawing.Point(187, 118);
            this.txtcustomer_name.Name = "txtcustomer_name";
            this.txtcustomer_name.Size = new System.Drawing.Size(176, 22);
            this.txtcustomer_name.TabIndex = 8;
            // 
            // txtcustomer_age
            // 
            this.txtcustomer_age.Location = new System.Drawing.Point(187, 160);
            this.txtcustomer_age.Name = "txtcustomer_age";
            this.txtcustomer_age.Size = new System.Drawing.Size(176, 22);
            this.txtcustomer_age.TabIndex = 9;
            // 
            // txtcustomer_address
            // 
            this.txtcustomer_address.Location = new System.Drawing.Point(187, 202);
            this.txtcustomer_address.Name = "txtcustomer_address";
            this.txtcustomer_address.Size = new System.Drawing.Size(176, 22);
            this.txtcustomer_address.TabIndex = 10;
            // 
            // txtcustomer_phone
            // 
            this.txtcustomer_phone.Location = new System.Drawing.Point(187, 345);
            this.txtcustomer_phone.Name = "txtcustomer_phone";
            this.txtcustomer_phone.Size = new System.Drawing.Size(176, 22);
            this.txtcustomer_phone.TabIndex = 11;
            // 
            // dvgCustomer
            // 
            this.dvgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makh,
            this.tenkh,
            this.tuoi,
            this.diachi,
            this.gioitinh,
            this.sodienthoai});
            this.dvgCustomer.Location = new System.Drawing.Point(390, 74);
            this.dvgCustomer.Name = "dvgCustomer";
            this.dvgCustomer.RowHeadersWidth = 51;
            this.dvgCustomer.RowTemplate.Height = 24;
            this.dvgCustomer.Size = new System.Drawing.Size(792, 480);
            this.dvgCustomer.TabIndex = 12;
            this.dvgCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellclick);
            this.dvgCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCustomer_CellContentClick);
            // 
            // makh
            // 
            this.makh.DataPropertyName = "customer_ID";
            this.makh.HeaderText = "Mã khách hàng";
            this.makh.MinimumWidth = 6;
            this.makh.Name = "makh";
            this.makh.Width = 80;
            // 
            // tenkh
            // 
            this.tenkh.DataPropertyName = "customer_name";
            this.tenkh.HeaderText = "Tên khách hàng";
            this.tenkh.MinimumWidth = 6;
            this.tenkh.Name = "tenkh";
            this.tenkh.Width = 150;
            // 
            // tuoi
            // 
            this.tuoi.DataPropertyName = "customer_age";
            this.tuoi.HeaderText = "Tuổi";
            this.tuoi.MinimumWidth = 6;
            this.tuoi.Name = "tuoi";
            this.tuoi.Width = 50;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "customer_address";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.Width = 125;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "customer_gender";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.MinimumWidth = 6;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Width = 50;
            // 
            // sodienthoai
            // 
            this.sodienthoai.DataPropertyName = "customer_phone";
            this.sodienthoai.HeaderText = "Số điện thoại";
            this.sodienthoai.MinimumWidth = 6;
            this.sodienthoai.Name = "sodienthoai";
            this.sodienthoai.Width = 125;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(15, 381);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 42);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInsert.Location = new System.Drawing.Point(271, 381);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(92, 42);
            this.btnInsert.TabIndex = 14;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(15, 449);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 42);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(152, 451);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 42);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(152, 510);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 44);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Location = new System.Drawing.Point(271, 447);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(92, 44);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnhienthi
            // 
            this.btnhienthi.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnhienthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhienthi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnhienthi.Location = new System.Drawing.Point(152, 381);
            this.btnhienthi.Name = "btnhienthi";
            this.btnhienthi.Size = new System.Drawing.Size(99, 42);
            this.btnhienthi.TabIndex = 20;
            this.btnhienthi.Text = "Hiển thị";
            this.btnhienthi.UseVisualStyleBackColor = false;
            this.btnhienthi.Click += new System.EventHandler(this.btnhienthi_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1194, 588);
            this.Controls.Add(this.btnhienthi);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dvgCustomer);
            this.Controls.Add(this.txtcustomer_phone);
            this.Controls.Add(this.txtcustomer_address);
            this.Controls.Add(this.txtcustomer_age);
            this.Controls.Add(this.txtcustomer_name);
            this.Controls.Add(this.txtcustomer_ID);
            this.Controls.Add(this.lblcustomer_phone);
            this.Controls.Add(this.grbcustomer_gender);
            this.Controls.Add(this.lblcustomer_address);
            this.Controls.Add(this.lblcustomer_age);
            this.Controls.Add(this.lblcustomer_name);
            this.Controls.Add(this.lblcustomer_ID);
            this.Controls.Add(this.lbltieude);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.grbcustomer_gender.ResumeLayout(false);
            this.grbcustomer_gender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltieude;
        private System.Windows.Forms.Label lblcustomer_ID;
        private System.Windows.Forms.Label lblcustomer_name;
        private System.Windows.Forms.Label lblcustomer_age;
        private System.Windows.Forms.Label lblcustomer_address;
        private System.Windows.Forms.GroupBox grbcustomer_gender;
        private System.Windows.Forms.Label lblcustomer_phone;
        private System.Windows.Forms.TextBox txtcustomer_ID;
        private System.Windows.Forms.TextBox txtcustomer_name;
        private System.Windows.Forms.TextBox txtcustomer_age;
        private System.Windows.Forms.TextBox txtcustomer_address;
        private System.Windows.Forms.TextBox txtcustomer_phone;
        private System.Windows.Forms.DataGridView dvgCustomer;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton rdbnu;
        private System.Windows.Forms.RadioButton rdbnam;
        private System.Windows.Forms.DataGridViewTextBoxColumn makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodienthoai;
        private System.Windows.Forms.Button btnhienthi;
    }
}

