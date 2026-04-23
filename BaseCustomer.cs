using Godot;
using System;
using System.Collections.Generic;

public abstract partial class BaseCustomer : Node
{
    
    protected string _customerName;
    protected string _customerDescription;
    protected int _customerId;

    
    protected List<string> _preferredIngredients = new List<string>();
    protected List<string> _dislikedIngredients = new List<string>();
    protected int _minIngredients;
    protected int _maxIngredients;

    
    protected string _spritePath;
    protected string _animationName;

    
    public abstract string GetCustomerName();
    public abstract string GetCustomerDescription();
    public abstract int GetCustomerId();

    public abstract List<string> GetPreferredIngredients();
    public abstract List<string> GetDislikedIngredients();
    public abstract int GetMinIngredients();
    public abstract int GetMaxIngredients();

    
    public abstract string GetSpritePath();
    public abstract string GetAnimationName();

    
    public virtual void PrintCustomerInfo()
    {
        GD.Print($"[Cliente] Nome: {GetCustomerName()}, ID: {GetCustomerId()}, Descrição: {GetCustomerDescription()}");
        GD.Print($"  Preferências: Min {GetMinIngredients()} / Max {GetMaxIngredients()} ingredientes.");
        GD.Print($"  Gosta de: {string.Join(", ", GetPreferredIngredients())}");
        GD.Print($"  Não gosta de: {string.Join(", ", GetDislikedIngredients())}");
        GD.Print($"  Sprite: {GetSpritePath()}, Animação: {GetAnimationName()}");
    }

    
    public bool LikesIngredient(string ingredient)
    {
        return GetPreferredIngredients().Contains(ingredient) && !GetDislikedIngredients().Contains(ingredient);
    }

    
    public bool DislikesIngredient(string ingredient)
    {
        return GetDislikedIngredients().Contains(ingredient);
    }

    
    public bool IsIngredientCountPreferred(int count)
    {
        return count >= GetMinIngredients() && count <= GetMaxIngredients();
    }
}
