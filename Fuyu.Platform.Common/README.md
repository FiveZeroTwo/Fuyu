# Fuyu.Platform.Common

Code shared between projects.

## Http

### FuyuServer

It's a simple wrapper around `HttpServer` that's good enough for most cases.
It only supports HTTP without secure connection.

- `FuyuServer` receives incoming HTTP requests and has an internal router
that maps `FuyuBehaviour` to a path.
- `FuyuBehaviour` is what handles the path and sends back a response.
- `FuyuContext` is metadata from a request

```cs
using System;
using Fuyu.Platform.Common.Http;

// handles a request
public class HelloWorld : FuyuBehaviour
{
    // run this code when the path it's bound to is requested
    public override void Run(FuyuContext context)
    {
        // respond to the request
        SendText(context, "Hello, world!");
    }
}

public class Program
{
    static void Main()
    {
        // creates a server instance
        var server = new FuyuServer("main", "http://localhost:8000");

        // register HelloWorld behaviour to the path /helloworld
        server.AddHttpService<HelloWorld>("/helloworld");

        // start the server
        server.Start();

        // Console.ReadKey doesn't work in vscode buildin terminal
        Console.In.ReadLine();
    }
}
```

### FuyuClient

It's simple wrapper around `HttpClient` that's good enough for most cases. You
can make HTTP requests with it to a HTTP server. It only supports HTTP without
secure connection.

```cs
using System;
using System.Text;
using System.Threading.Tasks;
using Fuyu.Platform.Common.Http;

public class Program
{
    static async Task Main()
    {
        // make a client instance
        var client = new FuyuClient("http://localhost:8000");

        // make request
        var data = await client.GetAsync("/helloworld");

        // show the result
        var result = Encoding.UTF8.GetString(data);
        Console.WriteLine(result);
    }
}
```

## IO

### Resx

A simple wrapper around loading embedded files from assemblies.

It assumes the file is located in the `embedded/` folder of your csproj.

```xml
  <ItemGroup>
    <EmbeddedResource Include="embedded/path/to/file.txt" />
  </ItemGroup>
```

Loading the file is quite simple:

```cs
using System;
using Fuyu.Platform.Common.IO;

public class Program
{
    static void Main()
    {
        // set assembly to load from
        Resx.SetSource("mysource", typeof(Program).Assembly);

        // load the file
        var text = Resx.GetText("mysource", "path.to.file.txt");

        // show the result
        Console.WriteLine(text);
    }
}
```