﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using BO;
using DAL;

namespace SampleBackEnd.Controllers
{
    public class KategoriController : ApiController
    {
        // GET: api/Kategori
        public IEnumerable<Kategori> Get()
        {
            KategoriDAL kategoriDAL = new KategoriDAL();
            return kategoriDAL.GetAll();
        }

        // GET: api/Kategori/5
        public Kategori Get(int id)
        {
            KategoriDAL kategoriDAL = new KategoriDAL();
            return kategoriDAL.GetById(id);
        }

        // POST: api/Kategori
        public IHttpActionResult Post(Kategori kategori)
        {
            KategoriDAL kategoriDAL = new KategoriDAL();
            try
            {
                kategoriDAL.Create(kategori);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/Kategori/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Kategori/5
        public void Delete(int id)
        {
        }
    }
}
