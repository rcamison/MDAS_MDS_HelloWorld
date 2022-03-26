using System.Net.Http;
using System.Net.Http.Headers;
using Xunit;

namespace HelloWorldTests;
public class HelloWorldTest
{
    private static HttpClient client = new HttpClient();

    [Fact, Trait("Type", "Acceptance")]
    public async void Should_Get_GreetingMessage()
    {
        //Given
        HttpClient httpClient = new HttpClient();
        string getUrl = "http://localhost:5061/helloworld";
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, getUrl);

        //When
        var response = httpClient.SendAsync(request).GetAwaiter().GetResult();
        var message = await response.Content.ReadAsStringAsync();

        //Then
        Assert.True(response.IsSuccessStatusCode);
        Assert.Equal(message, "Hello World");
    }
}
