using onlineLibrary.Context;
using onlineLibrary.UserEntities;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();
app.Map("/add", async () =>
{
    using var db = new ApplicationContext();

        // ������� ��� ������� User
    UserEntity tom = new UserEntity { Name = "Tom", Password = "p33", Post = UserPost.User};
    UserEntity alice = new UserEntity { Name = "Alice", Password = "p26", Post = UserPost.User};

    // ��������� �� � ��
    db.Users.Add(tom);
    db.Users.Add(alice);
    await db.SaveChangesAsync();
    Console.WriteLine("������� ������� ���������");
});
app.Map("/show", () =>
{
    using(ApplicationContext db = new ApplicationContext())
    {
        var users = db.Users.ToList();
        Console.WriteLine("������ ��������:");
        foreach (UserEntity u in users)
        {
            Console.WriteLine($"{u.Id}.{u.Name} - {u.Password}");
        }
    }
});
app.MapControllers();

app.Run();

