namespace ProdeFutbol.Common.Models
{
    public class TeamResponse
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LogoPath { get; set; }

        public string LogoFullPath => string.IsNullOrEmpty(LogoPath)
            ? "https://prodefutbolweb.azurewebsites.net//images/noimage.png"
            : $"https://prodefutbol.blob.core.windows.net/teams/{LogoPath}";

    }
}
