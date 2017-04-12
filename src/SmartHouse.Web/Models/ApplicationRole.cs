using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SmartHouse.Web.Models
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole() : base() { }
    }
}