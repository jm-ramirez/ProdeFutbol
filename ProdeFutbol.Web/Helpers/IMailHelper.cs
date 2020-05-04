using ProdeFutbol.Common.Models;

namespace ProdeFutbol.Web.Helpers
{
	public interface IMailHelper
	{
		Response SendMail(string to, string subject, string body);
	}
}
