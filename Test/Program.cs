using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using NetFrameworkServer;

namespace NetFrameworkServer
{
    class Program
    {
        static void Main(string[] args)
        {
           TestHttpServer t = new TestHttpServer(IPAddress.Any, 80);
           t.Start();

           while (true) ;
        }
    }

    class TestHttpSession : HttpSession
    {
        public TestHttpSession(HttpServer server) : base(server)
        {
        }
        protected override void OnReceivedRequest(HttpRequest request)
        {
            SendResponseAsync(Response.MakeGetResponse("<h1>Hello World!</h1>", "text/html"));
        }
    }

    class TestHttpServer : HttpServer
    {
        public TestHttpServer(IPAddress address, int port) : base(address, port)
        {
        }

        public TestHttpServer(string address, int port) : base(address, port)
        {
        }

        public TestHttpServer(IPEndPoint endpoint) : base(endpoint)
        {
        }

        protected override TcpSession CreateSession() { return new TestHttpSession(this); }
    }
}
