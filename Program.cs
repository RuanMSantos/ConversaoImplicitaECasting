float a = 1.5f;
double b = a;

// Neste  caso estamos fazendo uma conversão implicita, onde o a que é float,
// quando atribuído a b, já é automaticamente convertido.

// caso tentemos converter implicitamente um double em float, vai gerar um erro,
// pois o float tem uma capacidade bem menor de armazenamento, 4bytes enquanto
// double tem 8bytes. Por isso temos que realizar o casting para conseguir 
// realizar a conversão

// double c = 1.5;
// float d = c;

double c = 1.5332354;
float d = (float)c;

// Vale ressaltar, que se caso o valor de double for grande o suficiente para 
// ultrapassar o valor de float, algumas casas seram perdidas após a conversão.

// Um detalhe legal é so a função de conversão ToString()
// Nela é possível passar varios parametros de sobrecarga, um deles é o número de
// casas decimais do numero

Console.WriteLine(c.ToString("F2"));