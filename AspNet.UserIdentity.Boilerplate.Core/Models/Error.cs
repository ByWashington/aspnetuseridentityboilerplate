using Newtonsoft.Json;

namespace AspNet.UserIdentity.Boilerplate.Core.Models
{
	public class Error
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public override string ToString() => JsonConvert.SerializeObject(this);
    }

}

