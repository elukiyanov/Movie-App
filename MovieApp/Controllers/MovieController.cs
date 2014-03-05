using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieApp.Models;
using System.IO;

namespace MovieApp.Controllers
{
    public class MovieController : Controller
    {

      
        public ActionResult AllMovies()
        {
            var movieEntities = new MoviesDB();
            return View(movieEntities.GetMovie(0));
        }



        [HttpPost]
        public ActionResult AllMovies(string sortRadioButton)
        {
            int radioButtonPressed = Convert.ToInt32(Request.Form["sortRadioButton"]);
            var movieEntities = new MoviesDB();
            return View(movieEntities.GetMovie(radioButtonPressed));
        }


        /*-------------------------------------------*/
        /*                   Create                  */
        /*-------------------------------------------*/



        public ActionResult AddMovie()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AddMovie(Movie movie)
        {

            var movieEntities = new MoviesDB();
            bool isCreated = movieEntities.CreateMovie(movie);

            if (isCreated)
            {
                return RedirectToAction("AllMovies");
            }
            else
            {
                return View();
            }
        }




        /*-------------------------------------------*/
        /*                   Edit                    */
        /*-------------------------------------------*/

        public ActionResult Edit(int id)
        {
            var moviesDB = new MoviesDB();
            return View(moviesDB.GetMovieByID(id));
        }



        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            var moviesDB = new MoviesDB();
            moviesDB.UpdateMovie(movie);

            return RedirectToAction("AllMovies");
        }




        [HttpPost]
        public ActionResult Upload(Movie movie)
        {
            if (Request.Files.Count > 0)
            {
                var file = Request.Files[0];

                if (file != null && file.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/Images/Uploads"), fileName);
                    file.SaveAs(path);

                    var moviesDB = new MoviesDB();
                    moviesDB.UpdateMovieImage(movie, fileName);
                }
            }

            return RedirectToAction("AllMovies");
        }




        /*-------------------------------------------*/
        /*                   Delete                  */
        /*-------------------------------------------*/


        public ActionResult Delete(int id)
        {
            var moviesDB = new MoviesDB();
            return View(moviesDB.GetMovieByID(id));
        }


        [HttpPost]
        public ActionResult Delete(int id, FormCollection frm)
        {
            var moviesDB = new MoviesDB();
            bool IsDeleted = moviesDB.DeleteMovie(id);

            if (IsDeleted)
            {
                return RedirectToAction("AllMovies");
            }
            else
            {
                return View();
            }
        }



    }//---------------- End
}
