using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class RestCountriesServices
{
    private string url;

    public RestCountriesServices()
    {
        //url = "https://restcountries.com/v3.1/name/";
        //url = "https://rickandmortyapi.com/api";
        url = "https://www.apicountries.com/countries/name";
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

    public async Task<Pais2> buscarPais2(string nomePais)
    {
        string paisJson = await buscarPaisAPI(nomePais);

        if (paisJson == null)
        {
            return null;
        }
        else
        {
        //Pais2 pais = JsonConvert.DeserializeObject<List<Pais2>>(paisJson);
            var myDeserializedClass = JsonConvert.DeserializeObject<List<Pais2>>(paisJson)[0];
            return myDeserializedClass;
        }
    }

    private async Task<string> buscarPaisAPI(string nomePaisAPI)
    {
        //GET(READ), POST(CREATE), PUT(UPDATE), DELETE, PATCH]

        var client = new HttpClient();

        //var resposta = await client.GetAsync($"{url}/name/{nomePaisAPI}");
        //Para la clase pais2
        var resposta = await client.GetAsync($"{url}/{nomePaisAPI}"); 

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