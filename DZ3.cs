public interface ITV
{
    public void DisplayMovie();
}

public interface IMonitor
{
    public void DisplayGame();
}

public class SamsungTV : ITV
{
    public void DisplayMovie()
    {
        //...
    }
}

public class SamsungMonitor : IMonitor
{
    public void DisplayGame()
    {
        //...
    }
}

public class DellTv : ITV
{
    public void DisplayMovie()
    {
        //...
    }
}

public class DellMonitor : IMonitor
{
    public void DisplayGame()
    {
        //...
    }
}

public abstract class ProductFactory
{
    public abstract ITV CreateTv();
    public abstract IMonitor CreateMonitor();
}

public class SamsungFactory : ProductFactory
{
    public override ITV CreateTv()
    {
        return new SamsungTV();
    }
    public override IMonitor CreateMonitor()
    {
        return new SamsungMonitor();
    }
}
public class DellFactory : ProductFactory
{
    public override ITV CreateTv()
    {
        return new DellTv();
    }
    public override IMonitor CreateMonitor()
    {
        return new DellMonitor();
    }
}

public class Store
{
    List<ProductFactory> factories = new List<ProductFactory>{
        new SamsungFactory(), new DellFactory() };
public Store()
{
    factories.ForEach(factorie =>
    {
        factorie.CreateTv();
        factorie.CreateMonitor();
    });
}
public void SellTv()
{
    //...
}
public void SellMonitor()
{
    //...
}
}