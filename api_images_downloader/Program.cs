// See https://aka.ms/new-console-template for more information
using (var client = new HttpClient())
{
    using (var s = client.GetStreamAsync("https://random-d.uk/api/168.jpg"))
    {
        using (var fs = new FileStream("localfile.jpg", FileMode.OpenOrCreate))
        {
            s.Result.CopyTo(fs);
        }
    }
}