
// 1. zadatak
public abstract class Car{
    public abstract void Drive();
}

public class Ford:Car {
    public override void Drive()
    {
      System.Console.WriteLine("BRM BRM");
    }

}

public class Toyota:Car{
    public override void Drive()
    {
     System.Console.WriteLine("brm brm2");
    }
}

public abstract class CarFactory{
    public abstract Car Create();
}

public class FordFactory:CarFactory{
    public override Car Create()
    {
        return new Ford();
    }
}

public class ToyotaFactory:CarFactory{

    public override Car Create()
    {
        return new Toyota();
    }
}

public class CarManufactor{
    Car car;
    public void Manufacture(CarFactory factory){
        car = factory.Create(); 
    }
}

//ovo je metoda tvornica i pripada skupini obrazaca stvaranja

//2. zadatak 
// Radi se o metodi tvornica iz obrazaca stvaranja

public interface Champion{
    public void Attack();
}

public class Mech: Champion{
    string specialEffect;

    public Mech(string specialEffect){
        this.specialEffect = specialEffect;
    }

    public void Attack(){
        System.Console.WriteLine($"Attack - {specialEffect}");
    }
}

public class Assassin: Champion{
    string ability;

    public Mech(string ability){
        this.ability = ability;
    }

    public void Attack(){
        System.Console.WriteLine($"Attack - {ability}");
    }
}

public abstract class ChampionFactory{
    public abstract Champion Create(string attackEffect);
}

public class MechFactory:ChampionFactory{
    public override Champion Create(string attackEffect)
    {
        return new Mech(attackEffect);
    }
}

public class AssassinFactory:ChampionFactory{

    public override Champion Create(string attackEffect)
    {
        return new Assassin(attackEffect);
    }
}

public class Game{
    Champion champion;
    public void ChampionCreator(ChampionFactory factory, string attackEffect){
        champion = factory.Create(attackEffect); 
    }    
}

//3. zadatak
// ovo je graditelj 
public class PresetPermissions{
    public void Admin(){

    }

    public void User(){

    }

    public void Manager(){

    }
}
public interface IPermission{
    public void Allow();
}

public class EditPermission:IPermission{
    public void Allow(){
            System.Console.WriteLine("Give permission");
    }
}

public class DeletePermission:IPermission{
    public void Allow(){
        System.Console.WriteLine("Remove permission");
    }
}

public class  CreatePermission{
    public void Allow(){
        System.Console.WriteLine("Create new Permission");
    }
}

public class ViewPermission:IPermission{
    public void Allow(){
        System.Console.WriteLine("This is your permission");
    }
}

public interface AccountConfigurator{
    public void AddEditPermission(EditPermission permission);
    public void AddDeletePermission(DeletePermissionPermission permission);
    public void AddCreatePermission(CreatePermissionPermission permission);
    public void AddEViewPermission(ViewPermissionPermission permission);

    public void ClearPermission();
}


public class AccountBuilder : AccountConfigurator {
    private List<IPermission> permissions = new List<IPermission>();
    public void AddEditPermission(EditPermission permission) {
        permissions.Add(permission);
    }

    public void AddDeletePermission(DeletePermission permission) {
        permissions.Add(permission);
    }

    public void AddCreatePermission(CreatePermission permission) {
        permissions.Add(permission);
    }
    public void AddViewPermission(ViewPermission permission) {
        permissions.Add(permission);
    }
    public void ClearPermissions() {
        permissions.Clear();
    }
    public List<IPermission> Build() {
        return permissions;
    }
}

public class Account {
    public void ConfigureAccount(AccountConfigurator configurator) {
        configurator.AddEditPermission(new EditPermission());
        configurator.AddDeletePermission(new DeletePermission());
        configurator.AddCreatePermission(new CreatePermission());
        configurator.AddViewPermission(new ViewPermission());
    }
}

