using Xunit;
using HelloWorldApi.UseCases;

namespace HelloWorldTests
{
    public class GetGreetingUseCaseTests
    {
        [Fact]
        public void GetGreetingUseCase_should_return_greeting()
        {
            var getGreetingUseCase = new GetGreetingUseCase();

            var result = getGreetingUseCase.Execute();

            Assert.Equal("Hello World", result);
        }
    }
}