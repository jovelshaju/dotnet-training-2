﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PViewExcercise.Data;
using PViewExcercise.Models;

namespace PViewExcercise.Controllers
{
    public class PlayersController : Controller
    {
        private PlayerDBContext db = new PlayerDBContext();

        static List<Player> listPlayers;
        public PlayersController()
        {
            if (db.Players.Count() == 0)
            {
                listPlayers = new List<Player>()
                {
                    new Player(){ PId=101, PName="Sachin Tendulkar", PCountry="India",PType="Batsman"},

                    new Player(){ PId=102, PName="A B DeVillers", PCountry="South Africa",PType="All Rounder"},

                    new Player(){ PId=103, PName="Ricky Ponting", PCountry="Australia",PType="Bowler"}
                };
                foreach (Player player in listPlayers)
                {
                    db.Players.Add(player);
                    db.SaveChanges();

                }
            }
            

        }

        public ActionResult DisplayPlayers()
        {

            return PartialView("PlayerPView", db.Players.ToList());
        }
        
        //// GET: Players
        //public ActionResult Index()
        //{
        //    return View(db.Players.ToList());
        //}

        //// GET: Players/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Player player = db.Players.Find(id);
        //    if (player == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(player);
        //}

        //// GET: Players/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Players/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "PId,PName,PType,PCountry")] Player player)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Players.Add(player);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(player);
        //}

        //// GET: Players/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Player player = db.Players.Find(id);
        //    if (player == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(player);
        //}

        //// POST: Players/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "PId,PName,PType,PCountry")] Player player)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(player).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(player);
        //}

        //// GET: Players/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Player player = db.Players.Find(id);
        //    if (player == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(player);
        //}

        //// POST: Players/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Player player = db.Players.Find(id);
        //    db.Players.Remove(player);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
