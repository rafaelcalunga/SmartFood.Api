using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartFood.Api.Models;
using SmartFood.Api.Services;

namespace SmartFood.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoriesController : ControllerBase
{
    private readonly DatabaseContext _db;

    public CategoriesController(DatabaseContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<IEnumerable<Category>> Get()
    {
        return await _db.Categories.ToListAsync();
    }
}
