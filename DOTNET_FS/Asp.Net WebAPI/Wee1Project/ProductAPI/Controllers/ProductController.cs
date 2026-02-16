using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ProductAPI.Models;
namespace ProductAPI.Controllers;
[Route("product")]
public class ProductController:ControllerBase
{
    public static List<Product> ProductsList=new List<Product>
    {
        new Product{productid=1001,productname="Monitor",productprice=7500},
        new Product{productid=3033,productname="Shoes",productprice=1500},
        new Product{productid=11,productname="Cooker",productprice=2000}
    };
    [HttpGet("displayproduct/{id}")]
    public IActionResult DisplayProduct(int id)
    {
        var product=ProductsList.FirstOrDefault(p=>p.productid==id);
        if(product==null) return NotFound($"{id} not found");
        return Ok(product);
    }
    [HttpPost("addproduct")]
    public IActionResult AddProduct([FromBody] Product newproduct)
    {
        if(newproduct==null) return NoContent();
        ProductsList.Add(newproduct);
        return CreatedAtAction(nameof(DisplayProduct),new {id=newproduct.productid},newproduct);
    }
    [HttpPut("updateproduct/{id}")]
    public IActionResult UpdateProduct(int id,[FromBody] Product updatedproduct)
    {
        var product=ProductsList.FirstOrDefault(p=>p.productid==id);
        if(product==null) return NotFound($"Product {id} not found");
        product.productid=updatedproduct.productid;
        product.productname=updatedproduct.productname;
        product.productprice=updatedproduct.productprice;
        return Ok(product);
    }
    [HttpDelete("deleteproduct/{id}")]
    public IActionResult DeleteProduct(int id)
    {
        var product=ProductsList.FirstOrDefault(p=>p.productid==id);
        if(product==null) return NotFound($"Product id {id} not found");
        ProductsList.Remove(product);
        return Ok("Deleted succesfully");
    }
}