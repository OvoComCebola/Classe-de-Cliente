using Godot;
using System;
using System.Collections.Generic;

public partial class HungryCustomer : BaseCustomer
{
    public HungryCustomer(string name, string description, int id,
                          List<string> preferred, List<string> disliked,
                          int minIng, int maxIng,
                          string spritePath, string animationName)
    {
        _customerName = name;
        _customerDescription = description;
        _customerId = id;
        _preferredIngredients = preferred;
        _dislikedIngredients = disliked;
        _minIngredients = minIng;
        _maxIngredients = maxIng;
        _spritePath = spritePath;
        _animationName = animationName;
    }

    public override string GetCustomerName()
    {
        return _customerName;
    }

    public override string GetCustomerDescription()
    {
        return _customerDescription;
    }

    public override int GetCustomerId()
    {
        return _customerId;
    }

    public override List<string> GetPreferredIngredients()
    {
        return _preferredIngredients;
    }

    public override List<string> GetDislikedIngredients()
    {
        return _dislikedIngredients;
    }

    public override int GetMinIngredients()
    {
        return _minIngredients;
    }

    public override int GetMaxIngredients()
    {
        return _maxIngredients;
    }

    public override string GetSpritePath()
    {
        return _spritePath;
    }

    public override string GetAnimationName()
    {
        return _animationName;
    }
}
