using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.DAL;

namespace ClassLibrary.BLL
{
    public class TeamService
    {

        private ProjectDbContext db;

        public TeamService(ProjectDbContext _db)
        {
            db = _db;
        }

     
        public Team GetTeam(string _tnum)
        {
            int _tnumx = Int32.Parse(_tnum);
            return db.Teams.SingleOrDefault(x => x.TeamNo == _tnumx);
        }


        public void save()
        {
            db.SaveChanges();
        }

    }
}