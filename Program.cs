// Praticando interpolação de strings
using System.Text;

var price = 10.2;
var texto = "O preço do produto é " + price + " apenas na promoção" ; // Concatenação
var texto1 = string.Format("O preço do produto é {0} apenas na promoção", price); // Interpolação
var texto3 = $"O preço do produto é {price} apenas na promoção"; //interpolação com cifrão

Console.WriteLine(texto);
Console.WriteLine(texto1);
Console.WriteLine(texto3);

var teste = "Testando";
Console.WriteLine(teste.CompareTo("Testando")); // Retorna 0 se as strings forem iguais
Console.WriteLine(teste.CompareTo("testando")); // Retorna 1 se as strings forem diferentes
// CompareTo é case sensitive.


var texto4 = "Esse texto é um teste";
Console.WriteLine(texto4.Contains("teste")); // Retorna true se a string contém a palavra teste
Console.WriteLine(texto4.Contains("Teste")); // Retorna false se a string não contém a palavra teste
Console.WriteLine(texto4.Contains("Teste", StringComparison.OrdinalIgnoreCase)); // Retorna true se a string contém a palavra teste, ignorando o case sensitive

var texto5 = "Esse texto é um teste";
Console.WriteLine(texto5.StartsWith("Esse")); // Retorna true se a string começa com a palavra Esse
Console.WriteLine(texto5.StartsWith("este")); // Retorna false se a string não começa com a palavra este
Console.WriteLine(texto5.StartsWith("este", StringComparison.OrdinalIgnoreCase)); // Retorna true se a string começa com a palavra este, ignorando o case sensitive
Console.WriteLine(texto5.EndsWith("teste")); // Retorna true se a string termina com a palavra teste
Console.WriteLine(texto5.EndsWith("Teste")); // Retorna false se a string não termina com a palavra Teste

var texto6 = "Esse texto é um teste";
Console.WriteLine(texto6.Equals("Esse texto é um teste")); // Retorna true se as strings são iguais
Console.WriteLine(texto6.Equals("esse texto é um teste")); // Retorna false se as strings são diferentes
Console.WriteLine(texto6.Equals("esse texto é um teste", StringComparison.OrdinalIgnoreCase)); // Retorna true se as strings são iguais, ignorando o case sensitive

//Índices
var texto7 = "Esse texto é um teste";
Console.WriteLine(texto7.IndexOf("texto")); // Retorna 5, pois a palavra texto começa no índice 5
Console.WriteLine(texto7.LastIndexOf("é")); // Retorna 9, pois a palavra é começa no índice 9. Retorna a última ocorrência da palavra.

//Manipulando strings
var texto8 = "Esse texto é um teste";
Console.WriteLine(texto8.Replace("Esse", "Isto")); // Substitui a palavra Este por Isto. Retorna Isto texto é um teste.

var divisao = texto8.Split(" "); // Divide a string em um array de strings, separando por espaço
// Como resultado teremos um array com as palavras: Esse, texto, é, um, teste
Console.WriteLine(divisao[0]); // Retorna Esse
Console.WriteLine(divisao[1]); // Retorna texto
Console.WriteLine(divisao[2]); // Retorna é 
Console.WriteLine(divisao[3]); // Retorna um
Console.WriteLine(divisao[4]); // Retorna teste

var resultado = texto8.Substring(5, 5); // Retorna texto, pois começa no índice 5 e tem 5 caracteres
Console.WriteLine(resultado);

Console.WriteLine(texto8.Trim()); // Remove os espaços em branco do início e do fim da string
Console.WriteLine(texto8.ToUpper()); // Converte a string para maiúscula
Console.WriteLine(texto8.ToLower()); // Converte a string para minúscula

//StringBuilder
var texto9 = "Esse texto é um teste";
texto9 += " para mostrar o StringBuilder";
// O StringBuilder é mais eficiente para manipular strings, pois não cria uma nova string a cada alteração

var testando = new StringBuilder();
testando.Append("Esse texto é um teste");
testando.Append(" para mostrar o StringBuilder");
Console.WriteLine(testando.ToString());
