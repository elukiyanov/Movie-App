using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieApp.Models
{

    /// <summary>
    /// 
    /// </summary>
    public class Movie
    {

        public int ID { get; set; }
        public string Title { get; set; }
        public double Rating { get; set; }
        public DateTime Release { get; set; }
        public string CoverImage { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Actors { get; set; }
        public string Synopsis { get; set; }

        public string ReleaseFormated 
        {
            get
            {
                return Release.ToShortDateString();
            }
            set{}
        }


        public string ImageURL
        {
            get
            {
                if (CoverImage == null)
                {
                    return "/Images/Uploads/noimage.jpg";
                }
                else
                {
                    return "/Images/Uploads/" + CoverImage;
                }
               
            }
            set { }
        }
    }
}