using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class RestCountriesServices
{
    private string url;

    public RestCountriesServices()
    {
        //url = "https://restcountries.com/v3.1";
        url = "https://rickandmortyapi.com/api";
    }

    public async Task<Personagem> buscarPais(string nomePais)
    {
        string paisJson = await buscarPaisAPI(nomePais);

        if (paisJson == null)
        {
            return null;
        }
        else
        {
            var personagem = JsonConvert.DeserializeObject<Personagem>(paisJson);
            return personagem;
        }
    }

    private async Task<string> buscarPaisAPI(string nomePaisAPI)
    {
        //GET(READ), POST(CREATE), PUT(UPDATE), DELETE, PATCH]

        var client = new HttpClient();

        //var resposta = await client.GetAsync($"{url}/name/{nomePaisAPI}");
        var resposta = await client.GetAsync($"{url}/character/{nomePaisAPI}");

        if (resposta.StatusCode == HttpStatusCode.OK)
        {
            var repostaConteudo = await resposta.Content.ReadAsStringAsync();
            return repostaConteudo;
        }
        else
        {
            return null;
        }
    }
}