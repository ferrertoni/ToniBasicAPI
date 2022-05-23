namespace t.data.EF.Migrations
{
    using System.Data.Entity.Migrations;
    using t.domain.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<t.data.EF.EFDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(t.data.EF.EFDbContext context)
        {
            
        }
    }
}


/*
context.User.AddOrUpdate(User.Create(1, "Toni", "Toni"));
context.User.AddOrUpdate(User.Create(2, "Lluis", "Lluis"));
context.User.AddOrUpdate(User.Create(3, "Genis", "Genis"));
context.User.AddOrUpdate(User.Create(4, "Maker", "Maker"));

context.Topic.AddOrUpdate(Topic.Create(1, "Futbol"));
context.Topic.AddOrUpdate(Topic.Create(2, "Basket"));
context.Topic.AddOrUpdate(Topic.Create(3, "Tenis"));

context.Post.AddOrUpdate(Post.Create(1, "El furbo", 1, 1));
context.Post.AddOrUpdate(Post.Create(2, "El furbo2", 1, 1));
context.Post.AddOrUpdate(Post.Create(3, "El furbo3", 1, 1));
context.Post.AddOrUpdate(Post.Create(4, "El Basket", 1, 2));
context.Post.AddOrUpdate(Post.Create(5, "El Basket2", 1, 2));
context.Post.AddOrUpdate(Post.Create(6, "BarcelonaFC", 3, 1));
context.Post.AddOrUpdate(Post.Create(7, "BarcelonaBK", 3, 2));
context.Post.AddOrUpdate(Post.Create(8, "BarcelonaNadal", 3, 3));
context.SaveChanges();


var students = new List<Student>
            {
            new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Student{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };
*/