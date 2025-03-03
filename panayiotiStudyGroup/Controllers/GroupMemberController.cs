using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace panayiotiStudyGroup.Controllers
{
    public class GroupMemberController : Controller
    {
        // GET: GroupMember
        public ActionResult ListOfMembers()
        {
            List<Models.GroupMember> member = new List<Models.GroupMember>();

            member.Add(new Models.GroupMember { StudentNumber = "u22571460", Name = "Panayioti", Surname = "Constantopoulos", EmailAddress = "u22571460@tuks.co.za" });
            member.Add(new Models.GroupMember { StudentNumber = "u22666797", Name = "Tiano", Surname = "Menegazzi", EmailAddress = "u22666797@tuks.co.za" });
            member.Add(new Models.GroupMember { StudentNumber = "u24593240", Name = "Sofia", Surname = "Finlayson", EmailAddress = "u24593240@tuks.co.za" });
            member.Add(new Models.GroupMember { StudentNumber = "u24571700", Name = "Theodoros", Surname = "Constantopoulos", EmailAddress = "u24571700@tuks.co.za" });
            member.Add(new Models.GroupMember { StudentNumber = "u24616185", Name = "Lukas", Surname = "Brink", EmailAddress = "u24616185@tuks.co.za" });

            return View(member);
        }
    }
}