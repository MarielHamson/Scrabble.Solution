using System.IO;
using Microsoft.AspNetCore.Hosting;
using System;
using Scrabble;
using System.Collections.Generic;
using System.Linq;

namespace Scrabble
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var host = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseIISIntegration()
        .UseStartup<Startup>()
        .Build();

      host.Run();
    }
  }
}