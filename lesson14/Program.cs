namespace lesson14
{
    internal class Program
    {
        static HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            string jokeUrl = "https://v2.jokeapi.dev/joke/Any?format=txt&type=twopart";
            string exchangeUrl = "http://api.exchangeratesapi.io/v1/latest?access_key=e25c3769318e3b5a9f2414cd483ef9b5&symbols=USD,AUD,CAD,PLN,BYN";

            try
            {
                string jokeResponse = await client.GetStringAsync(jokeUrl);
                Console.WriteLine(jokeResponse);
                string exchangeResponse = await client.GetStringAsync(exchangeUrl);
                Console.WriteLine("\n"+exchangeResponse);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }
    }
}
