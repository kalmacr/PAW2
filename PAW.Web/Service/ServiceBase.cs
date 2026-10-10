namespace PAW.Web.Service
{
    public  abstract class ServiceBase
    {
        protected string BaseUrl { get; set; } = "https://localhost:7036/";
        protected string SetPathUrl(string name) => $"{BaseUrl}{name}";
    }
}
