using System;
using System.Diagnostics.Contracts;
using System.Web.Http;

namespace NickOnTime.NickTimer.Controllers
{
	public class Api_LearnController : ApiController
	{
		[HttpGet]
		[Route("api/Api_Learn")]
		public String Get()
		{
			Contract.Ensures(Contract.Result<String>() != null);

			return "Hello API App!";
		}
	}
}
