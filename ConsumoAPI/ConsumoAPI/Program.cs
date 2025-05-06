var menu = new Menu();
var restCountriesClient = new RestCountriesServices();

var pais = menu.mostrarMenu();
var objetoPais = await restCountriesClient.buscarPais2(pais);
Console.WriteLine(objetoPais.name);
Console.WriteLine(objetoPais.capital);
Console.WriteLine(objetoPais.population);