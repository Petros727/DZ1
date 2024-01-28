 Primjeni Dekorater na ovaj set klasa:

public interface IIngredient{
    public void AddIngredient();
}

public class BaseDecorater():IIngredient{
    private IIngredient ingredient;

    public BaseDecorater(IIngredient ingredient){
        this.ingredient=ingredient;    }


    public virtual void AddIngredient(){  
        ingredient.AddIngredient();
    }
}
public class Noodles:BaseDecorater
{
    public Noodles(IIngredient ingredient):base(ingredient){

    }

    public override void AddIngredient()
    {
        base.AddIngredient();
        Console.WriteLine("Add Noodles");
    }
}

public class Beef:BaseDecorater{
     public Beef(IIngredient ingredient):base(ingredient){

    }

    public override void AddIngredient()
    {
        base.AddIngredient();
        Console.WriteLine("Add Beef");
    }
}

public class Mushrooms:BaseDecorater
{
    public Mushrooms(IIngredient ingredient):base(ingredient){

    }

    public override void AddIngredient()
    {
        base.AddIngredient();
        Console.WriteLine("Add mushrooms");
    }
}

public class Water:BaseDecorater
{
   

    public override void AddIngredient()
    {
        base.AddIngredient();
        Console.WriteLine("Add Water");
    }
}

public class Meal
{
   private IIngredient ingredient
    
public void MakeMushroomNoodleSoup()
{
    ingredient= new BaseDecorater(new Mushrooms(new Noodles(new Water())));
    ingredient.AddIngredient();
}

public void MakeBeefNoodleSoup()
{
 ingredient= new BaseDecorater(new Beef(new Noodles(new Water())));
    ingredient.AddIngredient();
}

public void MakeMushroomBeefSoup()
{
    ingredient= new BaseDecorater(new Mushrooms(new Beef(new Noodles(new Water()))));
    ingredient.AddIngredient();
}
}

public static class ClientCode
{
    public static void Run()
{
    new Meal().MakeBeefNoodleSoup();
}
}
