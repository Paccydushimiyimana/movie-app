using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moviework
{
    public class Movie
    {
        [Key]
        public string Title { get; set; }
        public int Year { get; set; }
        public string Badget { get; set; }
        public string Category { get; set; }
    }
    public class MovieContext: DbContext
    {
        public MovieContext(): base("Moviedb") { }
        public DbSet<Movie> Movies { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
              using (var ctx = new MovieContext())
              {
                  /*var movie = new Movie() { Title = "BatMan",Year=2015,Badget="20K $",Category="Action" };
                  var movi = new Movie() { Title = "The White house", Year = 2005, Badget = "17K $", Category = "Documentary" };
                  var mov = new Movie() { Title = "Avengers", Year = 2018, Badget = "26K $", Category = "Action" };
                  ctx.Movies.Add(movie);
                  ctx.Movies.Add(movi);
                  ctx.Movies.Add(mov);
                  ctx.SaveChanges();*/


                var posta = ctx.Movies.FirstOrDefault(p => p.Title =="BatMan");
                var postb = ctx.Movies.FirstOrDefault(p => p.Title == "The White house");
                var postc = ctx.Movies.FirstOrDefault(p => p.Title == "Avengers");

                Console.WriteLine(" Db current Content");
                Console.WriteLine("_____________________");


                Console.WriteLine(posta.Title);
                Console.WriteLine(posta.Year);
                Console.WriteLine(posta.Badget);
                Console.WriteLine(posta.Category);
                Console.WriteLine();
                Console.WriteLine(postb.Title);
                Console.WriteLine(postb.Year);
                Console.WriteLine(postb.Badget);
                Console.WriteLine(postb.Category);
                Console.WriteLine();
                Console.WriteLine(postc.Title);
                Console.WriteLine(postc.Year);
                Console.WriteLine(postc.Badget);
                Console.WriteLine(postc.Category);
                Console.ReadKey();
                Console.WriteLine("Enter title;Year;Badget;Category");
                var mo = new Movie()
                {
                Title = Console.ReadLine(),
                
                Year = Console.Read(),
                
                Badget = Console.ReadLine(),
                
                Category = Console.ReadLine(),
                };
                ctx.SaveChanges();
              }

        }
    }
}
