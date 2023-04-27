using Grpc.Core;
using StudyrpcService;

namespace StudyrpcService.Services
{
    public class GreeterService : Greeter.GreeterBase    //Greeter.GreeterBase ��ʾ�����ö�������qreet.proto���ɵ����ļ�������λ����obj\Debug\net6.0\ProtosĿ¼��
    {
        private readonly ILogger<GreeterService> _logger;

        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        //ʵ��greet.proto�е�SayHello ����
        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = "Hello " + request.Name
            });
        }
    }
}