using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HourlySharp.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.Data;
    using System.Globalization;

    public class Offer
    {
        /// <summary>
        /// price
        /// </summary>
        public float price { get; set; }
        /// <summary>
        /// time
        /// </summary>
        public DateTime time { get; set; }
        /// <summary>
        /// order
        /// </summary>
        public Order order { get; set; }

        [Key]
        public long id { get; set; } 
    }

}