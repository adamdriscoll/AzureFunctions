using System.Net;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
{
    // Get request body
    var data = await req.Content.ReadAsFormDataAsync();

    string response = $"Hey, {data["user_name"]}!";

    return req.CreateResponse(HttpStatusCode.OK, new SlackResponse(response));
}

public class SlackResponse {
    public SlackResponse(string text) {
        this.text = text;
    }

    public string text {get;}
}