var menu = new Menu();
var restCountriesClient = new RestCountriesServices();

var pais = menu.mostrarMenu();
var objetoPais = await restCountriesClient.buscarPais(pais);
Console.WriteLine(objetoPais.name);