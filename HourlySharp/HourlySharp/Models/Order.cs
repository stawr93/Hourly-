using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HourlySharp.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Order
    {
        public long Id { get; set; }

        public OrderSpeciality specialization { get; set; }
        

        public virtual ICollection<Offer> Offers { get; set; }

        public string OrderComment { get; set; }

        public enum OrderSpeciality
        {
            /// <summary>
            /// Сантехник
            /// </summary>
            Plumber,
            /// <summary>
            /// Электрик
            /// </summary>
            Electrician,

            /// <summary>
            /// Слесарь
            /// </summary>

            Locksmith,

            /// <summary>
            /// Монтажник
            /// </summary>

            Mounter,

            /// <summary>
            /// Айтишник
            /// </summary>

            SysAdmin,

            /// <summary>
            /// Уборщик
            /// </summary>

            Cleaner,

            /// <summary>
            /// Разнорабочий
            /// </summary>

            GeneralLaborer,
        }


    }
}