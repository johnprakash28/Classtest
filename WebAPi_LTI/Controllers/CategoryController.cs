﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPi_LTI.Models;

namespace WebAPi_LTI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        public CategoryController(AppDbContext context)
        {
            _context = context;

        }
        public AppDbContext _context { get; }


        [HttpGet]
        public ActionResult get()
        {
            var data = _context.Categories.ToList();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public ActionResult get(int id)
        {
            var data = _context.Categories.FirstOrDefault(p => p.CatId == id);
            return Ok(data);
        }

        //to insert new record in table
        [HttpPost]
        public ActionResult post(Categories newcat)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                _context.Categories.Add(newcat);
                _context.SaveChanges();
                return Ok();
            }


        }
        //to update record of products
        [HttpPut("{id}")]
        public ActionResult put(int? id, Categories modifiedcat)
        {
            if (id == null)
                return NotFound();
            else
            {
                var data = _context.Categories.FirstOrDefault(p => p.CatId == id);
                data.CatName = modifiedcat.CatName;
                _context.SaveChanges();
                return Ok();
            }
        }

        //to delete record us httpdelete
        [HttpDelete("{id}")]
        public ActionResult delete(int? id)
        {
            if (id == null)
                return NotFound();
            else
            {
                var data = _context.Categories.FirstOrDefault(p => p.CatId == id);
                _context.Categories.Remove(data);
                _context.SaveChanges();
                return Ok();

            }
        }


    }
}

    

