using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppServiceTestClient.ServiceReference1;

namespace AppServiceTestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            AppServiceClient client = new AppServiceClient();
            //Add Client actions here.
            Console.WriteLine(client.GetData(1));
            Console.Read();
            client.Close();
        }
    }
}
