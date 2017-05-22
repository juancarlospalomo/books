using System;

public class Recipe
{

    public Recipe()
    {

    }

    public int id { get; set; }
    public string name { get; set; }

    public override string ToString() {
        return string.Format($"{id}:{name}");
    }

    public virtual string find() {
        return id.ToString();
    }

}