using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("source")]
    public string source { get; set; }

    [JsonProperty("destination")]
    public string destination { get; set; }

    [JsonProperty("unshortened")]
    public bool unshortened { get; set; }

    [JsonProperty("reason")]
    public object reason { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
