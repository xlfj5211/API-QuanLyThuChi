﻿namespace WF_QuanLyThuChi.GUI.GUI_KhoanThu
{
    partial class UC_KhoanThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_KhoanThu));
            this.bandedGridColumn1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.btnThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.makt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.loaikt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sotien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ghichu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dentaikhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Xoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoa = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.Sua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSua = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnXem = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpThoiGianXem = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bandedGridColumn1
            // 
            this.bandedGridColumn1.Name = "bandedGridColumn1";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnThemMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMoi.Image")));
            this.btnThemMoi.Location = new System.Drawing.Point(1553, 0);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(122, 55);
            this.btnThemMoi.TabIndex = 6;
            this.btnThemMoi.Text = "Thêm Mới";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1675, 763);
            this.panel2.TabIndex = 5;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.btnXoa,
            this.btnSua});
            this.gridControl1.Size = new System.Drawing.Size(1675, 763);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.makt,
            this.loaikt,
            this.ngay,
            this.sotien,
            this.ghichu,
            this.dentaikhoan,
            this.Xoa,
            this.Sua});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Danh sách các khoản thu";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            // 
            // makt
            // 
            this.makt.Caption = "Mã";
            this.makt.FieldName = "makt";
            this.makt.Name = "makt";
            this.makt.Width = 82;
            // 
            // loaikt
            // 
            this.loaikt.Caption = "Loại Khoản Thu";
            this.loaikt.FieldName = "loaikt";
            this.loaikt.Name = "loaikt";
            this.loaikt.Visible = true;
            this.loaikt.VisibleIndex = 0;
            this.loaikt.Width = 255;
            // 
            // ngay
            // 
            this.ngay.Caption = "Ngày";
            this.ngay.FieldName = "ngay";
            this.ngay.Name = "ngay";
            this.ngay.Visible = true;
            this.ngay.VisibleIndex = 1;
            this.ngay.Width = 255;
            // 
            // sotien
            // 
            this.sotien.Caption = "Số Tiền";
            this.sotien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.sotien.FieldName = "sotien";
            this.sotien.Name = "sotien";
            this.sotien.Visible = true;
            this.sotien.VisibleIndex = 2;
            this.sotien.Width = 255;
            // 
            // ghichu
            // 
            this.ghichu.Caption = "Ghi Chú";
            this.ghichu.FieldName = "ghichu";
            this.ghichu.Name = "ghichu";
            this.ghichu.Visible = true;
            this.ghichu.VisibleIndex = 3;
            this.ghichu.Width = 255;
            // 
            // dentaikhoan
            // 
            this.dentaikhoan.Caption = "Đến Tài Khoản";
            this.dentaikhoan.FieldName = "dentaikhoan";
            this.dentaikhoan.Name = "dentaikhoan";
            this.dentaikhoan.Visible = true;
            this.dentaikhoan.VisibleIndex = 4;
            this.dentaikhoan.Width = 467;
            // 
            // Xoa
            // 
            this.Xoa.ColumnEdit = this.btnXoa;
            this.Xoa.Name = "Xoa";
            this.Xoa.Visible = true;
            this.Xoa.VisibleIndex = 5;
            this.Xoa.Width = 58;
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Name = "btnXoa";
            // 
            // Sua
            // 
            this.Sua.ColumnEdit = this.btnSua;
            this.Sua.Name = "Sua";
            this.Sua.Visible = true;
            this.Sua.VisibleIndex = 6;
            this.Sua.Width = 59;
            // 
            // btnSua
            // 
            this.btnSua.AutoHeight = false;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Name = "btnSua";
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1675, 38);
            this.panel1.TabIndex = 4;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(747, 6);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(209, 24);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "QUẢN LÝ KHOẢN THU";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnXem);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnThemMoi);
            this.panel3.Controls.Add(this.dtpThoiGianXem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1675, 55);
            this.panel3.TabIndex = 6;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(288, 17);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 9;
            this.btnXem.Text = "Xem";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Thời gian xem";
            // 
            // dtpThoiGianXem
            // 
            this.dtpThoiGianXem.CustomFormat = "yyyy-MM";
            this.dtpThoiGianXem.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGianXem.Location = new System.Drawing.Point(82, 17);
            this.dtpThoiGianXem.Name = "dtpThoiGianXem";
            this.dtpThoiGianXem.Size = new System.Drawing.Size(200, 20);
            this.dtpThoiGianXem.TabIndex = 8;
            // 
            // UC_KhoanThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_KhoanThu";
            this.Size = new System.Drawing.Size(1675, 866);
            this.Load += new System.EventHandler(this.UC_KhoanThu_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn1;
        private DevExpress.XtraEditors.SimpleButton btnThemMoi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeader;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn makt;
        private DevExpress.XtraGrid.Columns.GridColumn loaikt;
        private DevExpress.XtraGrid.Columns.GridColumn ngay;
        private DevExpress.XtraGrid.Columns.GridColumn sotien;
        private DevExpress.XtraGrid.Columns.GridColumn ghichu;
        private DevExpress.XtraGrid.Columns.GridColumn dentaikhoan;
        private DevExpress.XtraGrid.Columns.GridColumn Xoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit btnXoa;
        private DevExpress.XtraGrid.Columns.GridColumn Sua;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit btnSua;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton btnXem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpThoiGianXem;
    }
}