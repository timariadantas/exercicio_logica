using System;
using exercicios_logico;



 Palindromo.Verificar("ana");
Palindromo.Verificar("pedro");
CaixaEletronico.Sacar(120);
Atm.Sacar(120);
Atm.Sacar(30);
ContarCarater.Contar("banana");

var service = new AssentoService();

service.CriarAssentos(5);
Console.WriteLine("\nTentando reservar assento 1...");
var sucesso = service.ReservarAssento(1);

if (sucesso)
    Console.WriteLine("Reserva realizada com sucesso!");
else
    Console.WriteLine("Erro ao reservar assento.");

Console.WriteLine("\n Lista de assentos ");
    var lista = service.ListarAssentos();
    foreach (var a in lista)
{
    Console.WriteLine($"Assento {a.Id} - {a.Status}");
}


