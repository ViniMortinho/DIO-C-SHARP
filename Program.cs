//CAST IMPLÍCITO 
//Se utiliza para converter un valor de una variavel a outro tipo.

using ExemplosFundamentos.models;

//int a = 5;
//double b = a; 

int a = int.MaxValue;
long b = Convert.ToInt32(a);

Console.WriteLine(b);



//CAST EXPLICÍTOS
//Se utiliza para converter um valor de uma variavel a outro tipo, mas é necessário informar o tipo que você quer
//Se utiliza para converter um valor de uma variável a outro tipo, forçando o compilador a realizar a conversão
//Se usa para convertir um valor de uma variável a outra tipagem, é necessário indicar o novo tipo da vari
//int x = 10;
//float y = (float)x;
//Console.WriteLine(y);



//CAST DE TIPAGEM SIMPLE A PARA OBJETO
//Para realizar esse cast precisamos importar o namespace System.Convert e utilizar o metodo ToInt32()
//int z = 10;
//object w = Convert.ToInt32(z);
//Console.WriteLine(w);


//CAST DE OBJETO PARA INT
//Utilizando o operador (int), que faz o cast do objeto para int
//object v = "10";
//int u = (int)v;
//Console.WriteLine(u);


//CAST DE STRING PARA INT
//Utilizando o operador (int), que faz o cast da string para int
//string s = "10";
//int t = int.Parse(s);
//Console.WriteLine(t);


//CAST DE STRING PARA FLOAT
//Utilizando o operador (float), que faz o cast da string para float
//string ss = "10.789";
//float tf = float.Parse(ss);
//Console.WriteLine(tf);













//CONVERSÃO PARA STRING
//CASOS DE USO:
//1. Para concatenar strings;
//2. Para realizar operações de busca e substituição em um texto (buscar palavra, substituir
//palavra);
//3. Para criptografia ou decifragem de dados;
//4. Para armazenamento de informações no banco de dados;
//5. Para enviar mensagens por email;
//6. Para impressão de relatórios;
//7. Para geração de códigos QR;
//8. Para conversões de tipos de variáveis;
//9. Para validação de entrada de dados;
//10. Para formatar números;
//11. Para gerar nomes de arquivos;
//12. Para gerar URLs;
//13. Para obter a representação do valor numérico como string;
//14. Para obter o tamanho da string;
//15. Para obter o comprimento da string;
//16. Para obter os caracteres especiais de uma string;
//17. Para obter as vogais de uma string;
//18. Para obter as consoantes de uma string;
//19. Para obter as letras minúsculas de uma string;
//20. Para obter as letras maiúsculas de uma string;
//21. Para obter as primeiras letras de cada palavra de uma string;
//22. Para obter as últimas letras de cada palavra de uma string;
//23. Para obter as palavras com mais de 5 letras de uma string;
//24. Para obter as palavras com menos de 5 letras de uma string;
//25. Para obter as palavras que começam com letra específica;
//26. Para obter as palavras que terminam com letra específica;
//27. Para obter as palavras que contêm letra específica;
//28. Para obter as palavras que não contêm letra específica;
//29. Para obter as palavras que são divisíveis por outro número;
//30. Para obter as palavras que não são divisíveis por outro número;
//31. Para obter as palavras que são pares;
//32. Para obter as palavras que são impares;
//33. Para obter as palavras que tem o mesmo comprimento de outras palavras;
//34. Para obter as palavras que tem o mesmo tamanho de outras palavras;
//35. Para obter as palavras que estão na mesma posição de outras palavras;
//36. Para obter as palavras que estão fora da mesma posição de outras palavras;
//37. Para obter as palavras que estão antes das palavras de outros grupos;
//38. Para obter as palavras que estão depois das palavras de outros grupos;
//39. Para obter as palavras que estão entre as palavras de outros grupos;
//40. Para obter as palavras que estão dentro dos limites de outro grupo;
//41. Para obter as palavras que estão fora dos limites de outro grupo;
//42. Para obter as palavras que estão acima de outras palavras;
//43. Para obter as palavras que estão abaixo de outras palavras;
//44. Para obter as palavras que estão à esquerda de outras palavras;
//45. Para obter as palavras que estão à direita de outras palavras;
//46. Para obter as palavras que estão centralizadas em relação a outra palavra;
//47. Para obter as palavras que estão descentralizadas em relação a outra palavra;
//48. Para obter as palavras que estão repetidas;
//49. Para obter as palavras que estão sem repetições;
//50. Para obter as palavras que estão em ordem alfabética crescente;


//using ExemplosFundamentos.models;
//int inteiro = 5;

//string a = inteiro.ToString ();

//Console.WriteLine(a);














//DIFERENÇA ENTRE CONVERT E PARSE
//CONVERTER UM TIPO DE DADOS PARA OUTRO
//PARSER: ANALISAR O QUE VEM NA MANIFESTAÇÃO DO PROGRAMA



//int a = Convert.ToInt32(null);
//int a = int.Parse(null);



//Console.WriteLine("Valor convertido para int: " + a);









//Cast ou Casting

//int a = Convert.ToInt32("5");

//int a = int.Parse("5c");

//Console.WriteLine(a);









/* using System.Security.Cryptography;
using ExemplosFundamentos.models;

int a = 10;
int b = 20;

int c = a + b;
c = c +5;

c += 5;

c -=5;

Console.WriteLine(c); */











//string aprentação = "Olá mundo!";
/* String é uma varialvel E precisa receber um nome para ser identificada dentro do código */

//int quantidade = 1;
/* int usada paraa numeros inteiros  */
//double preco = 20.5; 
/* double usado para numeros decimais */
//Boolean disponivel = true;
/* boolean usado para valores verdadeiro ou falso (true ou false)*/

//double altura = 1.80;

/* using ExemplosFundamentos.models;

Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Vini";
pessoa1.Idade = 40;
pessoa1.Apresentar();  */
