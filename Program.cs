using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using ExemplosExplorando___Aula2___Parte_2.Models;

// 'IF Ternário':
// É uma sintaxe onde você retorna dois resultados baseados em uma condição booleana de 'IF' e 'ELSE'
// Este modelo de 'IF' retorna sempre 'true' ou 'false', ou seja, não pode ter dois ou mais 'IFs'

Console.Write("Escreva um numero e sabia se é par ou ímpar: ");
int n = Convert.ToInt32(Console.ReadLine());
bool Par = true;

Par = n % 2 == 0;
Console.WriteLine($"O numero {n} é " + (Par/*bool*/ ?/*caso for:*/ "par"/*true*/ :/*ou*/ "ímpar"/*false*/));
//                                       ^ Exibe o resultado booleano... 
//                                          ^ Caso for:
//                                             ^ 'true' (verdadeiro)...
//                                                  ^ ou...
//                                                      ^ 'false' (falso);


// // Usando tuplas em classe (LeituraArquivo):

// LeituraArquivo ler = new();

// var (sucesso, conteudo, quantidade) = ler.LerArquivo("Models/arquivoLeitura.txt");
// //^ É um tipo de dado que compila qualquer conteudo, seja string, inteiro, double, booleano, etc;
// //      ^ Representa o booleano na classe LeituraArquivo;
// //              ^ Representa a array;
// //                       ^ Representa o inteiro contador;
// if (sucesso /*bool sempre representa true quando criada*/)
// foreach (var linha in conteudo)
// {
//     Console.WriteLine(linha);
//     Console.WriteLine($"Quantidade linhas: {quantidade}");
// }
// else
// {
//     Console.WriteLine("Não foi possivel ler o arquivo.");
// }


// // Coleções - Tuplas 
// // 'Tuplas' são uma SINTAXE de COLEÇÃO, onde você guarda as coleções dentro dela

// // Usando um tipo de sintaxe abreviada:
// (int Id, string Nome, string Sobrenome, double Nota) tupla = (15356, "George", "Catarino", 65.3);
// // ^   ^       ^ Coloca os TIPOS de dados que você deseja inserir;
// //                     ^ Nome da variável;
// //                              ^       ^         ^ Digita os dados nos argumentos da variável, que devem seguir a mesma ordem dos tipos;
// Console.WriteLine("");
// Console.ForegroundColor = ConsoleColor.Cyan;
// Console.WriteLine($"Os dados resumidos do aluno: {tupla}");
// Console.WriteLine("");
// Console.WriteLine("Os dados detalhados: ");
// Console.ResetColor();

// Console.ForegroundColor = ConsoleColor.Green;
// Console.WriteLine($"    - ID: {tupla.Id}");
// Console.WriteLine($"    - Nome: {tupla.Nome}");
// Console.WriteLine($"    - Sobrenome: {tupla.Sobrenome}");
// Console.WriteLine($"    - Nota Final: {tupla.Nota}");
// Console.ResetColor();



// /* Coleções - Dictionary
// Dictionary é uma coleção de dados do tipo "<chave - valor>" (chave composta), em que você armazena valores únicos mas sem uma ordem 
// específica. Os valores dentro do Dictionary são únicos, com o elemento da CHAVE única. O VALOR pode ser repetido. Caso não sejam 
// únicos, ele implementa uma exceção. */

// // Dictionary<string, string> Estados = new Dictionary<string, string>();
// // // ^ O tipo de coleção
// // //          ^ O tipo da CHAVE (tipo 1). É oque garante que o elementos sejam únicos no 'Dictionary'
// // //                  ^ O tipo do VALOR (tipo 2)

// // Estados.Add("MG", "Minas Gerais");
// // // ^ Nome da variável da coleção 'Dictionary';
// // //       ^ Método para adicionar ao Dictionary;
// // //           ^ O 'tipo 1', que é a CHAVE(KEY), que identifica este espaço;
// // //                  ^ E o 'tipo 2', que é o VALOR da chave anterior;
// // Estados.Add("SP", "São Paulo");
// // Estados.Add("GO", "Goias");
// // Estados.Add("RJ", "Rio de Janeiro");
// // /* Como os valores de cada chave e valor são únicos, não é possivel adicionar uma CHAVE repetida, pois ocorrerá uma exceção
// // quando executar a linha do código com o Dictionary.Key repetida. */

// Dictionary<string, string> Estados = new()
// {
//     // ^ O tipo de coleção
//     //          ^ O tipo da CHAVE (tipo 1). É oque garante que o elementos sejam únicos no 'Dictionary'
//     //                  ^ O tipo do VALOR (tipo 2)

//     //{ "MG", "Minas Gerais" },
//     { "MG", "Belo Horizonte" },
//     // ^ Nome da variável da coleção 'Dictionary';
//     //       ^ Método para adicionar ao Dictionary;
//     //           ^ O 'tipo 1', que é a CHAVE(KEY), que identifica este espaço;
//     //                  ^ E o 'tipo 2', que é o VALOR da chave anterior;
//     { "SP", "São Paulo" },
//     { "GO", "Goiania" },
//     { "RJ", "Rio de Janeiro" }
// };
// /* Como os valores de cada chave e valor são únicos, não é possivel adicionar uma CHAVE repetida, pois ocorrerá uma exceção
// quando executar a linha do código com o Dictionary.Key repetida. */

// Console.Clear();

// foreach (var item in Estados)
// {
//     Console.WriteLine("+");
//     Console.WriteLine($"Chave(Key): {item.Key} / Valor(Value): {item.Value}".ToUpper());
// }   
// Console.ForegroundColor = ConsoleColor.Green;
// Console.WriteLine("------------------------------------------------------");
// Console.ResetColor();

// // Para alterar um VALOR de um dos Dictionarys já adicionados, invocamos apenas o nome do Dictionary, e a sua 'chave'
// // E então colocamos o sinal de atribuição ao lado, e atribuimos um novo 'valor' á esta 'chave'
// // Estados["MG"] = "Belo Horizonte";
// // Estados["GO"] = "Goiania";

// Console.ForegroundColor = ConsoleColor.Cyan;
// Console.Write("\nDeseja adicionar algum estado: ");
// Console.ResetColor();

// string adicionarEstado = Console.ReadLine().ToUpper();

// switch (adicionarEstado)
// {
//     case "SIM":
//     {  
//         bool adicionarMenu = true;

//         while (adicionarMenu)
//         {
//             Console.ForegroundColor = ConsoleColor.Cyan;
//             Console.Write("\nDigite uma sigla de estado que voce deseja adicionar: ");
//             Console.ResetColor();
//             string sigla = Console.ReadLine().ToUpper();

//             if (Estados.ContainsKey(sigla))
//             {
//                 Console.ForegroundColor = ConsoleColor.Red;
//                 Console.WriteLine("Esta sigla de estado já está inserida no dicionário! Por favor, repetir.");
//                 Console.ResetColor();
//             }
//             else
//             {
//                 Console.ForegroundColor = ConsoleColor.Blue;
//                 Console.WriteLine("\nAdicionado com sucesso!");
//                 Console.ResetColor();
//                 adicionarMenu = false;
//             }

//             Console.ForegroundColor = ConsoleColor.Cyan;
//             Console.Write("\nDigite a capital desse estado: ");
//             Console.ResetColor();
            
//             string capital = Console.ReadLine().ToUpper();

//             if (Estados.ContainsValue(capital))
//             {
//                 Console.BackgroundColor = ConsoleColor.Red;
//                 Console.WriteLine("Esta capital de estado está errada! Por favor, repetir.");
//                 Console.ResetColor();
//                 Console.Beep();
//                 return;
//             }
//             else 
//             { 
//                 Estados.Add(sigla, capital);
//                 Console.ForegroundColor = ConsoleColor.Blue;
//                 Console.WriteLine("\nAdicionado com sucesso!");
//                 Console.ResetColor();
//             }
//         }

//         Console.ForegroundColor = ConsoleColor.Cyan;
//         Console.Write("\nDeseja adicionar outro estado: ");
//         Console.ResetColor();
        
//         string confirmar = Console.ReadLine().ToUpper();

//         if (confirmar == "SIM")
//         {
//             adicionarMenu = true;
//         }
//         else if (confirmar == "NAO" || confirmar == "NÃO")
//         {
//             adicionarMenu = false;
//         }
//     }
//     break;

//     case "NAO":
//     {
//         Console.ForegroundColor = ConsoleColor.Cyan;
//         Console.Write("\nDeseja remover algum estado da lista: ");
//         Console.ResetColor();
//         string confirmar1 = Console.ReadLine().ToUpper();

//         if (confirmar1 == "SIM")
//         {
//             bool removerMenu = true;
//             while (removerMenu)
//             {
//             // Para remover, assim como em 'Listas' ou em 'Arrays', se usa o método 'Remove', e usa o argumento que precisamos remover;
//             // No argumento, usamos apenas a Chave/Key para referenciar oque precisamos remover;

//                 Console.ForegroundColor = ConsoleColor.Cyan;
//                 Console.Write("\nDigite a sigla de um dos estados da lista que voce deseja remover: ");
//                 Console.ResetColor();
//                 string remover = Console.ReadLine().ToUpper();
//                 if (Estados.ContainsKey(remover))
//                 {
//                     Estados.Remove(remover);
//                     Console.ForegroundColor = ConsoleColor.Blue;
//                     Console.WriteLine($"\nItem {remover} removido com sucesso!");
//                     Console.ResetColor();
                    
//                     foreach (var item in Estados)
//                     {
//                         Console.WriteLine("+");
//                         Console.WriteLine($"Chave(Key): {item.Key} / Valor(Value): {item.Value}".ToUpper());
//                     }
//                     removerMenu = false;
//                 } 
//                 else 
//                 {
//                     Console.BackgroundColor = ConsoleColor.Red;
//                     Console.WriteLine("Item não existe, ou foi executado uma exceção.");
//                     Console.ResetColor();
//                     Console.Beep();
//                 }
//             }
//         }

//         if (confirmar1 == "NAO" || confirmar1 == "NÃO")
//         {
//             Console.ForegroundColor = ConsoleColor.Red;
//             Console.WriteLine("Programa se encerrando...");
//             Console.ResetColor();
//         }
//         break;
//     // else if (adicionarEstado != "SIM" || adicionarEstado != "NAO" || adicionarEstado != "NÃO")
//     // {
//     //     Console.ForegroundColor = ConsoleColor.Red;
//     //     Console.WriteLine("\nDigite uma resposta válida.");
//     //     Console.ResetColor();
//     //     Console.Beep();
//     //     menu = true;
//     // }
//     }
// }



// /* Coleções - Stack (Pilha/Montante)
// Este tipo de coleção, o Stack/Pilha, funciona com a sigla 'LIFO': "Last In, First Out", que significa que o último elemento adicionado
// á fila Stack será o primeiro a sair. Por exemplo: [5-6-4-2-9]. Neste caso, o primeiro elemento a entrar foi o '9'. Se esta array 
// fosse uma Queue, o primeiro a sair seria o mesmo '9', por ter sido o primeiro a entrar. No caso da Stack, o primeiro a sair 
// será o '5'. */
// internal class Program
// {
//     public static void Main(string[] args)
//         {
//         Console.WriteLine("Empurrando números pares de 4 - 10 na pilha: ");

//         Stack<int> pilha = new Stack<int>();

//         // Parecido com o 'Enqueue', o 'Push' literalmente empurra os números para dentro da stack/pilha;
//         pilha.Push(4);
//         //^ Nome da variável da fila criada
//         //    ^ O método 'Enqueue', que adiciona elementos á Queue (fila)
//         //        ^ O elemento (dentro do argumento) que será adicionado na lista
//         pilha.Push(6);
//         pilha.Push(8);
//         pilha.Push(10);

//         foreach (int numero in pilha)
//         {
//             Console.WriteLine(numero);
//             /*  No terminal, mostrará a pilha com os exatos números empurrados para a stack. Porém, na ordem inversa da mostrada no
//             código, pois o ÚLTIMO SEMPRE SAIRÁ PRIMEIRO NA STACK/PILHA, e assim sucessivamente.*/
//         }

//         // O método 'Pop' elimina sempre o elemento que está NO TOPO da pilha, ou seja, sempre o primeiro elemento adicionado;
//         Console.WriteLine($"Eliminando o elemento que está em cima: {pilha.Pop()}");
        
//         foreach (int numero in pilha)
//         {
//             Console.WriteLine(numero);
//         }
//         }
// }



// /* 
// Coleções - Queue (Fila)
// Coleções são conjuntos de elementos do mesmo tipo, como o 'Array' ou 'Listas';
// O 'Queue' é da mesma forma, pertece á classe 'Coleções', e é bem semelhante ao 'Array' ou 'Lista', mas com regras diferentes;
// Como o nome sugere, a fila é formada por ordem de adição, tendo os posicionamentos sendo contabilidados e importantes para as saídas;
// Quem foi adicionado primeiro, ficará na primeira posição, e sairá primeiro, seguindo a mesma ordem para todos os outros elementos;
// Esta frase acima é retradada numa sigla chamada 'FIFO': "First In, First Out"
// */

// internal class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("Adicionando número de 1 - 10 na fila: ");
        
//         Queue<int> fila = new Queue<int>();

//         // O 'Enqueue' é um método que adiciona na lista criada o elemento que você coloca no argumento do parentêses dele;
//         fila.Enqueue(1);
//         //^ Nome da variável da fila criada
//         //    ^ O método 'Enqueue', que adiciona elementos á Queue (fila)
//         //          ^ O elemento (dentro do argumento) que será adicionado na lista
//         fila.Enqueue(2);
//         fila.Enqueue(3);
//         fila.Enqueue(4);
//         fila.Enqueue(5);
//         fila.Enqueue(6);
//         fila.Enqueue(7);
//         fila.Enqueue(8);
//         fila.Enqueue(9);
//         fila.Enqueue(10);

//         foreach (var item in fila)
//         {
//             Console.WriteLine(item.ToString());
//         }

//         Console.WriteLine($"\nRemovendo o número {fila.Dequeue()} da fila: ");

//         // Como dito acima, não podemos escolher qual elementos retiramos da fila, pois eles saem na mesma ordem que entraram
//         // Por isso, o 'Dequeue' não necessita ter nenhum argumento fornecido em seu método para funcionar
//         // Pois a escolha para sair sempre será do primeiro da fila no momento

//         // Neste caso de agora, ele já foi chamado direto na interpolação do texto do console acima, e funciona da mesma forma
//         // Isso acontece por que ele retorna os elementos

//         // fila.Dequeue();

//         foreach (var item in fila)
//         {
//             Console.WriteLine(item.ToString());
//         }
//     }
// }



// // Utilizando o 'throw new' na aba de classes com métodos.
// new ExemploExcecao().Metodo1();

// Console.WriteLine("Tratamento de exceções");

// /* 'try' é um bloco, um método de execução que "testa" o código antes de ele ser mostrado para o usuário final,
// e caso ocorra algum erro, vai para o 'catch' que fica no final do laço 'try' e mostra a mensagem de erro
// programada no próprio código para mostrar oque está havendo com ele*/

// try
// {
//     string[] Texto = File.ReadAllLines("Models/arquivoLeitura.txt");

//     foreach (string linha in Texto)
//     {
//         Console.WriteLine(linha);
//     }
// } catch (FileNotFoundException error) // O método/bloco 'catch' é assegurador do 'try', que mostra o motivo do erro e faz o tratamento
// {
//     Console.BackgroundColor = ConsoleColor.Red;
//     Console.WriteLine("Arquivo não encontrado. " + error.Message);
//     Console.ResetColor();
//     Console.Beep();
// } catch (ArgumentException error) // Se pode ter vários 'catchs', que cada um insinua um erro diferente
// {
//     Console.BackgroundColor = ConsoleColor.Red;
//     Console.WriteLine("Argumento inválido. " + error.Message);
//     Console.ResetColor();
//     Console.Beep();
// } catch (DirectoryNotFoundException error)
// {
//     Console.BackgroundColor = ConsoleColor.Red;
//     Console.WriteLine("Diretório/Pasta não encontrada. " + error.Message);
//     Console.ResetColor();
//     Console.Beep();
// } catch (Exception error) /* No final dos vários 'catchs', o último sempre deve ser o 'Exception', 
//                           que generaliza todos os outros específicos, quando as outras exceções não são verdadeiras*/
// {
//     Console.BackgroundColor = ConsoleColor.DarkYellow;
//     Console.WriteLine("Ocorreu uma exceção genérica. " + error.Message);
//     Console.ResetColor();
//     Console.Beep();
// } finally
// {
//     Console.ForegroundColor = ConsoleColor.Magenta;
//     Console.WriteLine("Acabou");
//     Console.ResetColor();
// }
