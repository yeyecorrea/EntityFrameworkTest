// Usamos el DBcontext

using EFGetStarted.Data;
using EFGetStarted.Models;

using var db = new BlogginContext();

Console.WriteLine($"DataBase path: {db.DbPath}");

// Crear
Console.WriteLine("Insert new Blog");
db.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
db.SaveChanges();

// Leer
Console.WriteLine("Querying for a Blog");
var blog = db.blogs.OrderBy(b => b.BlogId)
    .First();

// Actualizar 
Console.WriteLine("Updating the blog and adding a post");
blog.Url = "https://devblogs.microsoft.com/dotnet";
blog.Posts.Add(
    new Post { Title = "Hello World", Content = "I wrote an app using EF Core!" });
db.SaveChanges();

// Eliminar
Console.WriteLine("Delete the blog");
db.Remove(blog);
db.SaveChanges();