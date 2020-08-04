using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

namespace AspnetWeb
{
  class Program
  {
    static void Main(string[] args)
    {
      var server = Host.CreateDefaultBuilder().ConfigureWebHostDefaults(webHost =>
      {
        webHost.Configure(app =>
        {
          app.UseRouting();
          app.UseEndpoints(http =>
          {
            http.MapGet("/", async req =>
            {
              await req.Response.WriteAsync("<h1>hello aspnet</h1>");
            });

            http.MapGet("/html", async req =>
            {
              await req.Response.SendFileAsync("index.html");
            });
          });
        });
      });

      server.Build().Run();
    }

    public void SomeMethod(Func<string, string> someFunc)
    {
      someFunc("hello");
    }

    public string UseSomeFunc(string s)
    {
      return s;
    }

    public void UseSomeMehtod()
    {
      SomeMethod(arg =>
      {
        return arg;
      });

      SomeMethod(UseSomeFunc);
    }
  }
}
