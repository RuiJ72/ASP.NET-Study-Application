using Microsoft.AspNetCore.Mvc;
using NovoNar.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NovoNar.Web.Controllers
{
    public class TableController : Controller
    {
        public static IList<Table> _tables = new List<Table>();

        public TableController()
        {
            if(_tables.Count.Equals(0))
            {
                _tables.Add(new Table { Number = 1, Status = Table.TableStatus.Free });
                _tables.Add(new Table { Number = 2, Status = Table.TableStatus.Occupied, OpeningDate = DateTime.Now.AddMinutes(-10) });
                _tables.Add(new Table { Number = 3, Status = Table.TableStatus.Reserved });
            }
            
        }

        public IActionResult Index()
        {
            return View(_tables);
        }

        public IActionResult Edit(int id)
        {
            var table = _tables.FirstOrDefault(x => x.Number.Equals(id));

            return View(table);
        }
        
        [HttpPost]
        public IActionResult Edit([FromForm] Table table)
        {
            var tableSelected = _tables.FirstOrDefault(x => x.Number.Equals(table.Number));
            tableSelected.Status = Table.TableStatus.Reserved;
            tableSelected.OpeningDate = table.OpeningDate;

            return RedirectToAction("Index");
        }
        public IActionResult New()
        {
            return View(new Table());
        }
        
        [HttpPost]
        public IActionResult New([FromForm] Table newTable)
        {
            _tables.Add(newTable);

            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("table/list/{status}")]
        public IActionResult ListTables(int status)
        {
            Table.TableStatus tableStatus = (Table.TableStatus)status;

            var result = _tables.Where(x=> x.Status.Equals(tableStatus));

            return Ok(result);
        }
    }
}
