using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using ClassLibrary.DAL;
using ClassLibrary.BLL;
using System.Data.Entity;


namespace ClassLibrary.BLL
{
    public class MemberService
    {

        private ProjDbContext db;



        public MemberService(ProjDbContext _db)
        {
            db = _db;
        }
        
        public List<Member> GetAllMembers()
        {

            return db.Members.ToList();
        }

        public Member GetMember(int _id)
        {
            return db.Members.SingleOrDefault(x => x.Id == _id);
        }

        public Member AddMember(Member memberx)
        {
            Member nm = new Member();// יצירת מתנדב חדש
            nm.Id = memberx.Id;
            nm.FirstName = memberx.FirstName;
            nm.LastName = memberx.LastName;
            nm.PhoneNo = memberx.PhoneNo;
            nm.CityCityCode = memberx.CityCityCode;
            nm.Mail = memberx.Mail;
            nm.ContactName = memberx.ContactName;
            nm.ContactPhone = memberx.ContactPhone;
            nm.ContactRelation = memberx.ContactRelation;
            nm.PantsSize = memberx.PantsSize;
            nm.ShirtSize = memberx.ShirtSize;
            nm.ShoesSize = memberx.ShoesSize;
            nm.Photo = memberx.Photo;
            nm.MirsNo = memberx.MirsNo;
        


            db.Entry(nm).State = EntityState.Added;
            db.SaveChanges();
            return nm;
        }


        public void save()
        {
            db.SaveChanges();
        }


        public bool isMemberValid(int _id, int _pass)
        {
            Member m = this.GetMember(_id);

            if (m != null)
            {
              
                if (m.Id == _pass)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
