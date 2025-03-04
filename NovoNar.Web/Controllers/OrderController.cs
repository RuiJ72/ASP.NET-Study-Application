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

    [HttpGet("products")]
    public IActionResult SearchProducts()
    {
        return PartialView("list-products", new List<Product>());

    }

    [HttpPost]
    [Route("order")]
    public IActionResult GenerateOrder()
    {
        return View();
    }

    [HttpGet("order/{}")]
    public IActionResult ConsultOrder(Int64 orderNumber) => StatusCode(200, new Order());

    [HttpPost("order/{orderNumber}/item")]
    public IActionResult IncludeOrderItem(Int64 orderNumber, [FromBody] List<OrderItem> orderItem) => StatusCode(200, new Order());

    [HttpDelete("order/{orderNumber}/item/{itemCode}")]
    public IActionResult RemoveOrderItem(Int64 orderNumber, Int64 itemCode) => StatusCode(200, new Order());

    [HttpGet("order/{orderNumber}/list")]
    public IActionResult ListOrderItems(Int64 orderNumber) => StatusCode(200, new Order());

    [HttpPatch("order/{orderNumber}/item/{itemCode}/{quantity}")]
    public IActionResult ChangeOrderItemQuantity(Int64 orderNumber, Int64 itemCode, int quantity) => StatusCode(200, new Order());

    [HttpPatch("bill/{orderNumber}")]
    public IActionResult CloseBillNumber(Int64 orderNumber) => StatusCode(200, new Order());
}
