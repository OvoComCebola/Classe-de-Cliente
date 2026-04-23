using Godot;
using System;
using System.Collections.Generic;

public partial class Main : Node
{
    public override void _Ready()
    {
        GD.Print("\n--- Demonstração de Clientes com Preferências ---");

        
        HungryCustomer customer1 = new HungryCustomer(
            "Cliente Apressado",
            "Gosta de hambúrgueres simples e rápidos.",
            1,
            new List<string> { "Carne", "Queijo" },
            new List<string> { "Picles", "Cebola" },
            2, 
            3, 
            "res://Sprites/customer_apressado.png", 
            "idle_apressado" 
        );

        HungryCustomer customer2 = new HungryCustomer(
            "Cliente Gourmet",
            "Prefere hambúrgueres elaborados com muitos vegetais.",
            2,
            new List<string> { "Alface", "Tomate", "Molho Especial" },
            new List<string> { "Bacon" },
            4, 
            6, 
            "res://Sprites/customer_gourmet.png", 
            "idle_gourmet" 
        );

        
        List<BaseCustomer> allCustomers = new List<BaseCustomer>();
        allCustomers.Add(customer1);
        allCustomers.Add(customer2);

        GD.Print("\n--- Informações Detalhadas dos Clientes ---");
        foreach (BaseCustomer customer in allCustomers)
        {
            customer.PrintCustomerInfo();
            GD.Print($"  Gosta de 'Carne'? {customer.LikesIngredient("Carne")}");
            GD.Print($"  Não gosta de 'Picles'? {customer.DislikesIngredient("Picles")}");
            GD.Print($"  3 ingredientes é preferível? {customer.IsIngredientCountPreferred(3)}");
            GD.Print($"  5 ingredientes é preferível? {customer.IsIngredientCountPreferred(5)}");
            GD.Print("------------------------------------------");
        }
    }
}
