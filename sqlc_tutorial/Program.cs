using DBGen;
using static DBGen.QuerySql;

Console.WriteLine("Hello, World!");
Console.WriteLine("Testing generated Code from sqlc!");

QuerySql db = new QuerySql("Data Source=data.db;");

Console.WriteLine("Creating 2 authors");
await db.CreateAuthor(new CreateAuthorArgs("Author1", "very long bio"));
await db.CreateAuthor(new CreateAuthorArgs("Author2", "very long bio"));
PrintAuthorList(await db.ListAuthors());


Console.WriteLine("Changing authors with id 1");
await db.UpdateAuthor(new("Changed Author 2", "Changed Bio", 2));

GetAuthorRow? authorId1 = await db.GetAuthor(new GetAuthorArgs(2));
if(authorId1 != null)
    Console.WriteLine($"{authorId1.Value.Id}, {authorId1.Value.Name}, {authorId1.Value.Bio}");

Console.WriteLine("Deleting Authors"); 
await db.DeleteAuthor(new(1));
await db.DeleteAuthor(new(2));
PrintAuthorList(await db.ListAuthors());

Console.WriteLine("finished");

static void PrintAuthorList(List<ListAuthorsRow> authors)
{
    foreach (var author in authors)
    {
        Console.WriteLine($"{author.Id}, {author.Name}, {author.Bio}");
    }
}