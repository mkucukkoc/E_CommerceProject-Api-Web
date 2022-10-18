using DataAccessLayer;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
[ApiController]
[Route("api/[controller]")]
public class ProductsController:ControllerBase
{
    private readonly AppDbContext context;

    public ProductsController(AppDbContext context)
    {
        this.context = context;
    }
    [HttpGet]
    public ActionResult<List<Product>> GetProducts()
    {
        var products = context.Products.ToList();
        return Ok(products);
    } 
    [HttpGet("{id}")]
    public  ActionResult<Product> GetProduct(int id)
    {
        
        return context.Products.Find(id);;
    } 

}