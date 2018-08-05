using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ClassLibrary.DAL;
using ClassLibrary.BLL;


namespace WebApi.Controllers
{
    public class LoginController : ApiController
    {
        MemberService mService;
        //TeamService tService;

        public LoginController()
        {
            ProjDbContext db = new ProjDbContext();
            mService = new MemberService(db);
            //tService = new TeamService(db);
        }


        [HttpPost]
        [Route("api/Login/{_id}/{_pass}")]
        public Member login(int _id, int _pass)
        {

            if (mService.isMemberValid(_id, _pass))
            {
                return mService.GetMember(_id);
            }
            return null;
        }
    }
}
