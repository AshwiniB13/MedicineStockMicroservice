using CSPharmacyMedicineSupplyManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSMedicineStockMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineStockController : ControllerBase
    {
        private readonly PharmacyMedicineSupplyManagementContext db;

        public MedicineStockController(PharmacyMedicineSupplyManagementContext _db)
        {
            db = _db;
        }

        [HttpGet] //Fetch Data
        public async Task<ActionResult> GetMedicineFromStock()
        {
            return Ok(await db.MedicineStocks.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> AddMedicineToStock(MedicineStock p)
        {
            if (ModelState.IsValid)
            {
                db.MedicineStocks.Add(p);
                await db.SaveChangesAsync();
                return Ok(p);
            }
            else
                return BadRequest();
        }
    }
}
