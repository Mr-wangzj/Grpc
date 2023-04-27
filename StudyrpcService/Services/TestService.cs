using Grpc.Core;
using StudyrpcService;
using StudyrpcService.Protos;

namespace StudyrpcService.Services
{
    public class TestService : Test.TestBase    //�ö�������qreet.proto���ɵ����ļ�������λ����obj\Debug\net6.0\ProtosĿ¼��
    {
        private readonly ILogger<TestService> _logger;

        public TestService(ILogger<TestService> logger)
        {
            _logger = logger;
        }

        //ʵ��greet.proto�е�GetNumSum ����
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