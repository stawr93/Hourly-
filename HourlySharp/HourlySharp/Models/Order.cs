using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HourlySharp.Models
{
    public class Order
    {
        public long Id { get; set; }

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


        public string OrderComment { get; set; }

 


    }
}