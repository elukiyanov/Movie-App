using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;

namespace MovieApp.Models
{
    public class MoviesDB
    {



        //public string _connectionString = @"Data Source=MAN01-DY90FV1\SQLEXPRESS2012; Initial Catalog=MoviesDB; Integrated Security=True";
        public string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MoviesAppConnection"].ToString(); 


        /*-------------------------------------------*/
        /*                   GET                     */
        /*-------------------------------------------*/




        public IEnumerable<Movie> GetMovie(int movieId) 
        {
            try
            {
                using (System.Data.SqlClient.SqlConnection sqlCon = new System.Data.SqlClient.SqlConnection(_connectionString))
                {
                    sqlCon.Open();
                    var param = new DynamicParameters();
                    param.Add("@ORDER", movieId, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
                    var movies = sqlCon.Query<Movie>("SP_GetAllMovies", param, commandType: System.Data.CommandType.StoredProcedure);
                    sqlCon.Close();
                    return movies;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        public Movie GetMovieByID(int movieId)
        {
            using (System.Data.SqlClient.SqlConnection sqlCon = new System.Data.SqlClient.SqlConnection(_connectionString))
            {
                var param = new DynamicParameters();
                param.Add("@ID", movieId, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
                var movie = sqlCon.Query<Movie>("SP_GetMovieByID", param, commandType: System.Data.CommandType.StoredProcedure).First();

                return movie;
            }
        }


        /*-------------------------------------------*/
        /*               Create/Insert               */
        /*-------------------------------------------*/

   


        /// <summary>
        /// 
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        public bool CreateMovie(Movie movie)
        {
            try
            {
                using (System.Data.SqlClient.SqlConnection sqlCon = new System.Data.SqlClient.SqlConnection(_connectionString))
                {
                    sqlCon.Open();

                    var param = new DynamicParameters();
                    param.Add("@TITLE", movie.Title, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
                    param.Add("@RATING", movie.Rating, dbType: System.Data.DbType.Double, direction: System.Data.ParameterDirection.Input);
                    param.Add("@RELEASE", movie.Release, dbType: System.Data.DbType.DateTime, direction: System.Data.ParameterDirection.Input);

                    sqlCon.Execute("SP_CreateMovie", param, commandType: System.Data.CommandType.StoredProcedure);
                    sqlCon.Close();
                }

                return true;
            }
            catch (Exception x)
            {
                return false;
            }
        }



        public bool CreateMovie(string title, double rating, DateTime release)
        {
            try
            {
                using (System.Data.SqlClient.SqlConnection sqlCon = new System.Data.SqlClient.SqlConnection(_connectionString))
                {
                    sqlCon.Open();

                    var param = new DynamicParameters();
                    param.Add("@TITLE", title, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
                    param.Add("@RATING", rating, dbType: System.Data.DbType.Double, direction: System.Data.ParameterDirection.Input);
                    param.Add("@RELEASE", release, dbType: System.Data.DbType.DateTime, direction: System.Data.ParameterDirection.Input);

                    sqlCon.Execute("SP_CreateMovie", param, commandType: System.Data.CommandType.StoredProcedure);
                    sqlCon.Close();
                }

                return true;
            }
            catch (Exception x)
            {
                return false;
            }
        }





        /*-------------------------------------------*/
        /*                   Update                  */
        /*-------------------------------------------*/




        public bool UpdateMovie(Movie movie)
        {
            try
            {
                using (System.Data.SqlClient.SqlConnection sqlCon = new System.Data.SqlClient.SqlConnection(_connectionString))
                {
                    sqlCon.Open();

                    var param = new DynamicParameters();
                    param.Add("@ID", movie.ID, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
                    param.Add("@TITLE", movie.Title, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
                    param.Add("@RATING", movie.Rating, dbType: System.Data.DbType.Double, direction: System.Data.ParameterDirection.Input);
                    param.Add("@RELEASE", movie.Release, dbType: System.Data.DbType.DateTime, direction: System.Data.ParameterDirection.Input);
                    param.Add("@GENRE", movie.Genre, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
                    param.Add("@ACTORS", movie.Actors, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
                    param.Add("@DIRECTOR", movie.Director, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
                    param.Add("@SYNOPSIS", movie.Synopsis, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);

                    sqlCon.Execute("SP_UpdateMovie", param, commandType: System.Data.CommandType.StoredProcedure);
                    sqlCon.Close();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



        public bool UpdateMovieImage(Movie movie, string imageName)
        {
            try
            {
                using (System.Data.SqlClient.SqlConnection sqlCon = new System.Data.SqlClient.SqlConnection(_connectionString))
                {
                    sqlCon.Open();

                    var param = new DynamicParameters();
                    param.Add("@ID", movie.ID, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
                    param.Add("@IMAGE", imageName, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);

                    sqlCon.Execute("SP_UpdateMovieImage", param, commandType: System.Data.CommandType.StoredProcedure);
                    sqlCon.Close();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        /*-------------------------------------------*/
        /*                  Delete                   */
        /*-------------------------------------------*/





        public bool DeleteMovie(int ID)
        {
            try
            {
                using (System.Data.SqlClient.SqlConnection sqlCon = new System.Data.SqlClient.SqlConnection(_connectionString))
                {
                    sqlCon.Open();

                    var param = new DynamicParameters();
                    param.Add("@ID", ID, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
                    sqlCon.Execute("SP_DeleteMovieByID", param, commandType: System.Data.CommandType.StoredProcedure);

                    sqlCon.Close();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }           
}