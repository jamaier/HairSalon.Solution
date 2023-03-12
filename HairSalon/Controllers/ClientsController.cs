using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers;

public class ClientsController : Controller
{
  private readonly HairSalonContext _db;

  public ClientsController(HairSalonContext db)
  {
    _db = db;
  }

  public ActionResult Create(int stylistId)
  {
    if(_db.Stylists.ToList().Count == 0)
    {
      ViewBag.Bool = false;
    }
    ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "StylistName", new {value = stylistId});
    return View();
  }

  [HttpPost]
  public ActionResult Create(Client newClient)
  {
    _db.Clients.Add(newClient);
    _db.SaveChanges();
    return RedirectToAction("Index", "Stylists");
  }

  public ActionResult Details(int clientId)
  {
    Client TargetClient = _db.Clients.Include(client => client.Stylist).FirstOrDefault(client => client.ClientId == clientId);
    ViewBag.Properties = TargetClient.GetType().GetProperties();
    return View(TargetClient);
  }

      public ActionResult Edit(int id)
    {
      Client thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Stylist");
      return View(thisClient);
    }

    [HttpPost]
    public ActionResult Edit(Client client)
    {
      _db.Clients.Update(client);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
}