using System.Net.Http;
using System.Net.Http.Headers;
using Xunit;

namespace HelloWorldTests;
public class HelloWorldTest
{
    private static HttpClient client = new HttpClient();

    [Fact, Trait("Type", "Acceptance")]
    private void Should_Get_A_Pokemon_By_Its_Id()
    {
        //Given
        HttpClient httpClient = new HttpClient();
        string getUrl = "http://localhost:5061/helloworld";
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, getUrl);

        //When
        var response = httpClient.SendAsync(request).GetAwaiter().GetResult();

        //Then
        Assert.True(response.IsSuccessStatusCode);
    }
}
