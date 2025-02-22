﻿using Data_QLThuChi.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_QuanLyThuChi
{
    public partial class Form1 : Form
    {
        public string baseAddress = "http://localhost:55410/api/";
        public Form1()
        {
            InitializeComponent();
        }

        public void BindingData()
        {
            txtMakt.DataBindings.Clear();
            txtMakt.DataBindings.Add("Text", dgvKhoanThu.DataSource, "MaKT");

            //cboMaTV.DataBindings.Clear();
            //cboMaTV.DataBindings.Add("Text", dgvKhoanThu.DataSource, "MaThanhVien");

            dtpNgay.DataBindings.Clear();
            dtpNgay.DataBindings.Add("Text", dgvKhoanThu.DataSource, "Ngay");

            cboLoaiKT.DataBindings.Clear();
            cboLoaiKT.DataBindings.Add("Text", dgvKhoanThu.DataSource, "LoaiKT");

            txtKhoanThu.DataBindings.Clear();
            txtKhoanThu.DataBindings.Add("Text", dgvKhoanThu.DataSource, "KhoanThu");

            txtSoTien.DataBindings.Clear();
            txtSoTien.DataBindings.Add("Text", dgvKhoanThu.DataSource, "SoTien");

            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dgvKhoanThu.DataSource, "GhiChu");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<KhoanThu> kt = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync($"KhoanThu?thanhvien=tuanvm1"); //

                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<KhoanThu>>(); //
                    readTask.Wait();

                    kt = readTask.Result;
                }

                dgvKhoanThu.DataSource = kt;
            }

            BindingData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KhoanThu kt = new KhoanThu();
            
            kt.matv = cboMaTV.Text;
            kt.ngay = dtpNgay.Value;
            kt.loaikt = cboLoaiKT.Text;
            //kt.khoanthu = txtKhoanThu.Text.Trim();
            int sotien;
            int.TryParse(txtSoTien.Text.Trim(), out sotien);
            kt.sotien = sotien;
            kt.ghichu = txtGhiChu.Text.Trim();
            kt.dentaikhoan = Convert.ToString(txtTK.Text.Trim());

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);

                //HTTP POST
                var postTask = client.PostAsJsonAsync<KhoanThu>("KhoanThu", kt);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Thêm dữ liệu thành công");
                }
                else
                {
                    MessageBox.Show(":(");
                }
            }


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            KhoanThu kt = new KhoanThu();
            kt.makt = Convert.ToInt32(txtMakt.Text.Trim());
            kt.ngay = dtpNgay.Value;
            kt.loaikt = cboLoaiKT.Text;
            //kt.khoanthu = txtKhoanThu.Text.Trim();
            int sotien;
            int.TryParse(txtSoTien.Text.Trim(), out sotien);
            kt.sotien = sotien;
            kt.ghichu = txtGhiChu.Text.Trim();
            kt.dentaikhoan = Convert.ToString(txtTK.Text.Trim());
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);

                //HTTP POST
                var postTask = client.PutAsJsonAsync<KhoanThu>("KhoanThu", kt);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Sửa dữ liệu thành công");
                }
                else
                {
                    MessageBox.Show(":(");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string makt = txtMakt.Text.Trim();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var deleteTask = client.DeleteAsync("KhoanThu?MaKT="+makt);
                deleteTask.Wait();

                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Đã xóa");
                }
                else
                {
                    MessageBox.Show(":(");
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string makt = txtTimKiem.Text.Trim();

            KhoanThu kt = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync($"KhoanThu?MaKT={makt}");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<KhoanThu>();
                    readTask.Wait();

                    kt = readTask.Result;
                    MessageBox.Show("Tìm Thấy!");
                    List<KhoanThu> res = new List<KhoanThu>();
                    res.Add(kt);
                    dgvKhoanThu.DataSource = res;
                }
                else
                {
                    MessageBox.Show("K Thấy!");
                }
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHienTen_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string tenhienthi = "";
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync($"Account?Username={username}");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<string>();
                    readTask.Wait();

                    tenhienthi = readTask.Result;

                    if (tenhienthi != "")
                    {
                        MessageBox.Show("" + tenhienthi);
                    }
                    else
                    {
                        MessageBox.Show("Default");
                    }
                }

            }
        }

        public void GuiMail(string nguoinhan, string tieude, string noidung)
        {
            SmtpClient smtp = new SmtpClient();
            try
            {
                //ĐỊA CHỈ SMTP Server
                smtp.Host = "smtp.gmail.com";
                //Cổng SMTP
                smtp.Port = 587;
                //SMTP yêu cầu mã hóa dữ liệu theo SSL
                smtp.EnableSsl = true;
                //UserName và Password của mail
                smtp.Credentials = new NetworkCredential("tuanvm197@gmail.com", "vmt13041997");

                //Tham số lần lượt là địa chỉ người gửi, người nhận, tiêu đề và nội dung thư
                smtp.Send("Vũ Mạnh Tuấn<tuanvm197@gmail.com>", nguoinhan, tieude, noidung);
                //lbStatus.Text = "Sent.";
                MessageBox.Show("hihi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GuiMail("manhtuanst04@gmail.com", "Test tiêu đề", "Nội dung gửi");
        }
    }
}
