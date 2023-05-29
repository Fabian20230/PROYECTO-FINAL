
using PROYECTO_FINAL;

public class Program
{
    public static void Main()
    {
        Pickup pickup = new Pickup();
        pickup.Marca = "Ford";
        pickup.Modelo = "Ranger";
        pickup.Color = "Rojo";
        pickup.Anio = 2022;
        pickup.Placa = "ABC123";
        pickup.Tipo = "PickUp";
        pickup.VelocidadMaxima = 200;

        pickup.Encender();
        pickup.Acelerar(50);
        pickup.Bocina();
        pickup.Frenar(20);
        pickup.Apagar();

        Sedan sedan = new Sedan();
        sedan.Marca = "Toyota";
        sedan.Modelo = "Camry";
        sedan.Color = "Azul";
        sedan.Anio = 2023;
        sedan.Placa = "DEF456";
        sedan.Tipo = "Sedan";
        sedan.VelocidadMaxima = 180;

        sedan.Encender();
        sedan.Acelerar(30);
        sedan.Bocina();
        sedan.Frenar(10);
        sedan.Apagar();

        Suv suv = new Suv();
        suv.Marca = "Chevrolet";
        suv.Modelo = "Traverse";
        suv.Color = "Negro";
        suv.Anio = 2022;
        suv.Placa = "GHI789";
        suv.Tipo = "SUV";
        suv.VelocidadMaxima = 220;

        suv.Encender();
        suv.Acelerar(60);
        suv.Bocina();
        suv.Frenar(30);
        suv.Apagar();

    }



}

