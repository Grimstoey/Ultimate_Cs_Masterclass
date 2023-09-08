﻿public class Dog
{
    private string _name;
    private string _breed;
    private int _weight;

    public Dog(string name, string breed, int weight)
    {
        _name = name;
        _breed = breed;
        _weight = weight;
    }

    public Dog(string name, int weight) : this(name, "mixed-breed", weight)
    {
    }

    public string Describe()
    {
        string describing;
        string size;
        if(_weight > 0 && _weight < 5)
        {
            size = "tiny";
        }
        else if(_weight >= 5 && _weight < 30)
        {
            size = "medium";
        }
        else
        {
            size = "large";
        }

        describing = ($"This dog is named {_name}, it's a {_breed}, and it weighs {_weight} kilograms, so it's a {size} dog.");
        return describing;
    }
}
