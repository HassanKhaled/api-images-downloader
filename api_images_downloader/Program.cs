


var apiUrl = "https://random-d.uk/api/random"; // Example API endpoint

using var client = new HttpClient();

try
{
    // Making the GET request
    var response = await client.GetAsync(apiUrl);

    // Ensure the request was successful
    response.EnsureSuccessStatusCode();

    // Read the response content as a string
    var content = await response.Content.ReadAsStringAsync();

    Console.WriteLine(content);

    Console.ReadKey();

}
catch (HttpRequestException e)
{
    Console.WriteLine($"Request error: {e.Message}");
}


// See https://aka.ms/new-console-template for more information
//using (var client = new HttpClient())
//{
//    using (var s = client.GetStreamAsync("https://random-d.uk/api/168.jpg"))
//    {
//        using (var fs = new FileStream("localfile.jpg", FileMode.OpenOrCreate))
//        {
//            s.Result.CopyTo(fs);
//        }
//    }
//}