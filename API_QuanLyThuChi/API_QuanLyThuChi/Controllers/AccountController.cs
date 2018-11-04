﻿using Data_QLThuChi.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_QuanLyThuChi.Controllers
{
    public class AccountController : ApiController
    {
        Account_DAO dao = new Account_DAO();
        public IHttpActionResult Get_Login(string username, string password)
        {
            int res = dao.Login(username, password);
            if(res == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(res);
            }
        }

        public IHttpActionResult Get_TenHienThi(string Username)
        {
            string tenmacdinh = "Người Dùng";
            try
            {
                string res = dao.TenHienThi(Username);
                if (res != null && res != "")
                {
                    return Ok(res);
                }
                else
                {
                    return Ok(tenmacdinh);
                }
            }
            catch
            {
                return NotFound();
            }

        }
    }
}