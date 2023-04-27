using Grpc.Net.Client;
using StudyrpcService.Protos;
using System.Threading.Channels;

namespace rpcClient
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("------------- 测试 -----------");
            excute();
        
            string isok = Console.ReadLine();
            if (isok.ToLower()=="y")
            {
                excute();
            }
            Console.ReadKey();
        }

        private static void excute()
        {
            Console.WriteLine("------------- 输入数字1 -----------");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("------------- 输入数字2 -----------");
            double num2 = double.Parse(Console.ReadLine());
            var chl = GrpcChannel.ForAddress("http://localhost:5293");
            var client = new Test.TestClient(chl);
            var reply = client.GetNumSum(new RequestNumData { Num1 = num1, Num2=num2 });
            Console.WriteLine(reply.Success);
            Console.WriteLine(reply.Sumval);
            Console.WriteLine("是否继续Y/N");
        }
    }
}