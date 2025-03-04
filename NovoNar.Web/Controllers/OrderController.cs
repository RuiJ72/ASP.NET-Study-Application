using Microsoft.AspNetCore.Mvc;
using NovoNar.Web.Models;
using System.Collections.Generic;
using System;

public class OrderController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    // Route for searching products (GET request)
    [HttpGet("products")]
    public IActionResult SearchProducts()
    {
        return PartialView("list-products", new List<Product>());
    }

    // Route for generating a new order (POST request)
    [HttpPost("order")]
    public IActionResult GenerateOrder()
    {
        return View();
    }

    // Route to consult an order by its number (GET request)
    [HttpGet("order/{orderNumber}")]
    public IActionResult ConsultOrder(Int64 orderNumber)
    {
        return StatusCode(200, new Order());
    }

    // Route for adding an item to an order (POST request)
    [HttpPost("order/{orderNumber}/item")]
    public IActionResult IncludeOrderItem(Int64 orderNumber, [FromBody] List<OrderItem> orderItem)
    {
        return StatusCode(200, new Order());
    }

    // Route for removing an item from an order (DELETE request)
    [HttpDelete("order/{orderNumber}/item/{itemCode}")]
    public IActionResult RemoveOrderItem(Int64 orderNumber, Int64 itemCode)
    {
        return StatusCode(200, new Order());
    }

    // Route for listing items in an order (GET request)
    [HttpGet("order/{orderNumber}/list")]
    public IActionResult ListOrderItems(Int64 orderNumber)
    {
        return StatusCode(200, new Order());
    }

    // Route for changing the quantity of an item in an order (PATCH request)
    [HttpPatch("order/{orderNumber}/item/{itemCode}/{quantity}")]
    public IActionResult ChangeOrderItemQuantity(Int64 orderNumber, Int64 itemCode, int quantity)
    {
        return StatusCode(200, new Order());
    }

    // Route for closing the bill for an order (PATCH request)
    [HttpPatch("bill/{orderNumber}")]
    public IActionResult CloseBillNumber(Int64 orderNumber)
    {
        return StatusCode(200, new Order());
    }
}
