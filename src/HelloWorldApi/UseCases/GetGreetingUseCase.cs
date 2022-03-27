using HelloWorldApi.Shared;

namespace HelloWorldApi.UseCases
{
    public class GetGreetingUseCase
    {
        public string Execute()
        {
            return Constants.ApiMessage;
        }
    }
}
