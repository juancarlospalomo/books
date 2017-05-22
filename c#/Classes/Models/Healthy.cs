using System;

public class Healthy : Recipe
{

    public new string ToString() {
        return "healthy ToString()";
    }
    
    public override string find() {
        return "healthy find()";
    }

}