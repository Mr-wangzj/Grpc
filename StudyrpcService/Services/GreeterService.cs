using Grpc.Core;
using StudyrpcService;

namespace StudyrpcService.Services
{
    public class GreeterService : Greeter.GreeterBase    //Greeter.GreeterBase 是示例，该对象来自qreet.proto生成的类文件，具体位置在obj\Debug\net6.0\Protos目录下
    {
        private readonly ILogger<GreeterService> _logger;

        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        //实现greet.proto中的SayHello 服务
        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = "Hello " + request.Name
            });
        }
    }
}