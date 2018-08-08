using ClassLibrary.BLL;
using ClassLibrary.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;

namespace WebApi.Controllers
{
    public class MemberController : ApiController
    {
        MemberService mService;

        public MemberController()
        {
            ProjDbContext db = new ProjDbContext();
            mService = new MemberService(db);
        }


        [HttpGet]
        [Route("api/Member")]
        public List<Member> GetMembers()
        {
            return mService.GetAllMembers();
        }

        [HttpGet]
        [Route("api/Member/{_id}")]
        public Member GetMember(int _id)
        {
            return mService.GetMember(_id);
        }


        [HttpPut]
        [Route("api/Member")]
        public void Put()
        {
            HttpPostedFile f = HttpContext.Current.Request.Files["file"];
            string _id = HttpContext.Current.Request.Params["new_ID"];
            f.SaveAs(HttpContext.Current.Server.MapPath("~/images/userimage") + f);
        }

        [HttpPost]
        [Route("api/Member")]
        public Member AddMember(Member New_Member)
        {
            return mService.AddMember(New_Member);
        }

    }
}