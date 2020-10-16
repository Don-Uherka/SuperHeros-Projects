using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeros_project.Data;
using SuperHeros_project.Models;

namespace SuperHeros_project.Controllers
{
    public class SuperHeroController : Controller
    {
        private ApplicationDbContext db;
        public SuperHeroController(ApplicationDbContext db)
        {
            this.db = db;
        }
        // GET: SuperHeroController1
        public ActionResult Index()
        {
            //query db to get all superheros
            //pass that into the view
            var superheroList = db.superHeroes;
            //if(superheroList == null)
            //{
            //    return RedirectToAction("Create");
            //}

            return View(superheroList);
        }

        // GET: SuperHeroController1/Details/5
        public ActionResult Details(int id)
        {
            var HeroDetail = db.superHeroes.Find(id);
            //query db for the single superhero who has 'id'
            //pass that into view
            return View(HeroDetail);
        }

        // GET: SuperHeroController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuperHeroController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SuperHero superHero)
        {
            try
            {
                db.superHeroes.Add(superHero);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHeroController1/Edit/5
        public ActionResult Edit(int id)
        {
            var HeroEdit = db.superHeroes.Find(id);
            return View(HeroEdit);
        }

        // POST: SuperHeroController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SuperHero superHero)
        {
            try
            {
                db.superHeroes.Update(superHero);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHeroController1/Delete/5
        public ActionResult Delete(int id)
        {
            var HeroToRemove = db.superHeroes.Find(id);
            
            return View(HeroToRemove);
        }

        // POST: SuperHeroController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, SuperHero superHeroes)
        {
            try
            {
                db.superHeroes.Remove(superHeroes);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
