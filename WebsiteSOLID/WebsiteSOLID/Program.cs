using WebsiteSOLID;

IRequest request = new HttpRequest();
IRequest request2 = new FileRequest();

Console.WriteLine("Indtast URL:");
string path = Console.ReadLine();

await request.MakeRequest(path);
Console.ReadLine();
await request2.MakeRequest(path);