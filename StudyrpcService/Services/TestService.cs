using Grpc.Core;
using StudyrpcService;
using StudyrpcService.Protos;

namespace StudyrpcService.Services
{
    public class TestService : Test.TestBase    //该对象来自qreet.proto生成的类文件，具体位置在obj\Debug\net6.0\Protos目录下
    {
        private readonly ILogger<TestService> _logger;

        public TestService(ILogger<TestService> logger)
        {
            _logger = logger;
        }

        //实现greet.proto中的GetNumSum 服务
        public override Task<SumResult> GetNumSum(RequestNumData request, ServerCallContext context)
        {
            return Task.FromResult(new SumResult
            {
                Success=true,
                Sumval= request.Num1 + request.Num2
            });
        }
    }
}