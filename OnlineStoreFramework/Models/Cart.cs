using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;

namespace OnlineStoreFramework.Models
{
    public class Cart
    {
        public Cart()
        {
            Id = Guid.NewGuid();
            DateTimeStamp = DateTime.Now;
            IsCancelled = false;
            try
            {
                var ip = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
                if (string.IsNullOrEmpty(ip))
                {
                    IPAddress = System.Web.HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
                }
            }
            catch { }
            Browser = HttpContext.Current.Request.Browser.Browser;
        }
        public Guid Id { get; set; }
        public string Browser { get; set; }
        public string IPAddress { get; set; }
        public string UserId { get; set; }
        public DateTime DateTimeStamp { get; set; }
        public bool IsCancelled { get; set; }
        public Guid ProductId { get; set; }
        public Products Products { get; set; }
    }
}