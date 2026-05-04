### Exercícios de Lógica e Estruturas de Dados em C#
Este repositório contém a implementação de problemas clássicos utilizados em entrevistas técnicas,
com foco em lógica, manipulação de dados e modelagem simples de domínio.
Esses exercícios é a nivel de estudos então foi usando (Console.WriteLine) como forma de saída para testar 
e validar o comportamento da aplicação durante o desenvolvimento, já que se trata de um exercício em ambiente de console.

### Palindromo 
=> Evitei inverter a string porque em C# strings são imutáveis, então isso criaria uma nova estrutura em memória.
Usando dois ponteiros, consigo comparar diretamente os caracteres das extremidades, reduzindo o uso de memória.

### Anagrama
=> Anagrama
Foi usado um dicionário como contador de frequência, porque me permite validar rapidamente se as duas palavras
têm exatamente os mesmos caracteres.

### Caixa Eletronico ATM
=> Percorro um conjunto fixo de notas e, para cada uma, faço uma divisão inteira para descobrir quantas cédulas podem ser usadas.
Em seguida, subtraio esse valor e continuo com o restante. depois printo no console as notas disponiveis para saque.
Também trato o caso onde o valor não pode ser totalmente atendido com as notas disponíveis, e gera um erro.
essa versão é eficiente e simples, mas tem limitações. Ela não testa diferentes combinações,
então pode não encontrar a melhor distribuição de notas ou até não conseguir completar o
valor dependendo das cédulas disponíveis.

### Reserva de assento (Lógica simples)
=> Modelei um sistema simples de assentos utilizando uma entidade com estado(enum)
onde cada assento pode estar livre, reservado ou vendido. Criei um serviço responsável por gerenciar esses assentos,
garantindo que só seja possível reservar quando o assento estiver disponível.

### Contador de Carater
=> Implementei  uma  contagem de frequência de caracteres utilizando um dicionário, onde cada caractere é a (chave e o valor)
representa quantas vezes ele aparece no texto, verifico se já existe no dicionário.
Se existir, incremento o contador; caso contrário, adiciono com valor inicial 1.



