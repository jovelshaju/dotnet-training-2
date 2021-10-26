using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebAPIExcercise2.Models;

namespace WebAPIExcercise2.Controllers
{
    public class IPLPlayersController : ApiController
    {
        private PlayerDBContextEntities db = new PlayerDBContextEntities();

        // GET: api/IPLPlayers
        public IQueryable<IPLPlayer> GetIPLPlayers()
        {
            return db.IPLPlayers;
        }

        // GET: api/IPLPlayers/5
        [ResponseType(typeof(IPLPlayer))]
        public IHttpActionResult GetIPLPlayer(int id)
        {
            IPLPlayer iPLPlayer = db.IPLPlayers.Find(id);
            if (iPLPlayer == null)
            {
                return NotFound();
            }

            return Ok(iPLPlayer);
        }

        // PUT: api/IPLPlayers/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutIPLPlayer(int id, IPLPlayer iPLPlayer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != iPLPlayer.PId)
            {
                return BadRequest();
            }

            db.Entry(iPLPlayer).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IPLPlayerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/IPLPlayers
        [ResponseType(typeof(IPLPlayer))]
        public IHttpActionResult PostIPLPlayer(IPLPlayer iPLPlayer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.IPLPlayers.Add(iPLPlayer);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (IPLPlayerExists(iPLPlayer.PId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = iPLPlayer.PId }, iPLPlayer);
        }

        // DELETE: api/IPLPlayers/5
        [ResponseType(typeof(IPLPlayer))]
        public IHttpActionResult DeleteIPLPlayer(int id)
        {
            IPLPlayer iPLPlayer = db.IPLPlayers.Find(id);
            if (iPLPlayer == null)
            {
                return NotFound();
            }

            db.IPLPlayers.Remove(iPLPlayer);
            db.SaveChanges();

            return Ok(iPLPlayer);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool IPLPlayerExists(int id)
        {
            return db.IPLPlayers.Count(e => e.PId == id) > 0;
        }
    }
}