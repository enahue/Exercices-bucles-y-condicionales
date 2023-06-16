//Ejercicio 1 - If
//Escribe un programa que:

//Pida datos a un cliente: Nombre, email, cupón

//Determine si un cliente tiene un cupon descuento

//Muestre un precio rebajado en función del descuento

//Muestre el precio de un producto sin descuento si no hay cupón

//Nota: puedes poner un precio fijo de un producto o uno variable.

using System.Net.Http.Headers;

double smartphone = 1000.00;
Console.WriteLine("Smartphone Galaxy 20s - precio: " + smartphone + " Usd");
Console.WriteLine("¡Comprar ahora! \n");

Console.Write("Nombre: ");
string name = Console.ReadLine();
Console.Write("Correo: ");
string email = Console.ReadLine();
Console.Write("Cupon: ");
string coupon = Console.ReadLine();
Console.WriteLine("\n");

if (coupon == "30DES")
{
    double discount = smartphone * (30.00 / 100);
    double final_price = smartphone - discount;

    Console.WriteLine("Resumen de pedido: \n");
    Console.WriteLine("Nombre: " + name);
    Console.WriteLine("Correo: " + email);
    Console.WriteLine("Cupon Aplicado: " + coupon + " - 30% de descuento");
    Console.WriteLine("Producto: Smartphone Galaxy 20s");
    Console.WriteLine("Precio: " + smartphone + " Usd");
    Console.WriteLine("Descuento: " + discount + " Usd");
    Console.WriteLine("Precio final: " + final_price + " Usd");

}
else
{
    Console.WriteLine("Resumen de pedido: \n");
    Console.WriteLine("Nombre: " + name);
    Console.WriteLine("Correo: " + email);
    Console.WriteLine("Producto: Smartphone Galaxy 20s");
    Console.WriteLine("Precio: " + smartphone + " Usd");

}

