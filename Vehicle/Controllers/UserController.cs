using Vehicle.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public Project_VehicleContext db;
        public UsersController(Project_VehicleContext _db)
        {
            db = _db;
        }

        public IActionResult Get()
        {
            return Ok(db.PersonalDetails);
        }

        [HttpPost]
        public IActionResult Register(PersonalDetails personalDetails)
        {
            var u = db.PersonalDetails.Where(t => t.EmailId == personalDetails.EmailId).FirstOrDefault();
            if (u == null)
            {
                db.PersonalDetails.Add(personalDetails);
                db.SaveChanges();
                return Ok(personalDetails);
            }
            else
                return BadRequest("Email already exists");

        }

        [HttpPost("UserLogin")]
        public IActionResult Login(PersonalDetailsModel personalDetailsModel)
        {
            var u = db.PersonalDetails.Where(t => t.FullName == personalDetailsModel.FullName && t.Password == personalDetailsModel.Password).FirstOrDefault();
            if (u != null)
            {
                return Ok();
            }
            else
                return Unauthorized();

        }
    }
}


