using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using Microsoft.Ajax.Utilities;

namespace SampleProjectAspNetMvc.Models
{
    public class UserInfo
    {
        public string Name { get; set; }
        public string MailAddress { get; set; }
        public string Experience { get; set; }
    }
}