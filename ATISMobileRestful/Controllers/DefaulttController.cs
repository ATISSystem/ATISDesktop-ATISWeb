

using System.Web.Http;



namespace ATISMobileRestful.Controllers
{
    public class DefaulttController : ApiController
    {

        [HttpPost]
        public bool AddEmpDetails()
        {
            return true;
            //write insert logic  
        }
        [HttpGet]
        public string GetEmpDetails()
        {
            return string.Empty;
        }
        [HttpDelete]
        public string DeleteEmpDetails()
        {
            return string.Empty;

        }
        [HttpPut]
        public string UpdateEmpDetails()
        {
            return string.Empty;

        }
    }
}
