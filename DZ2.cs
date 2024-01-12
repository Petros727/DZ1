//SRP

public class EmailSender{

    public void Send(){
        //...
    }
    public void SaveEmail(){
        //...
    }
}
/*ovaj kod je los jer ova klasa je namjenjena samo za slanje email sto ime kaze,
 nema potrebe za metodom SaveEmail te time kršimo SRP jer ova klasa nema samo jednu funkcionalnost */

 //OCP

 public class Wizzard{
    int Hit{get; set;}

    public Wizzard(int hit){
        Hit = hit;
    }

 }

 public class Attack{

    public void Strike(Wizzard wizzard){
        System.Console.WriteLine( "Wizzard strike");
    }
 }

 //Ovo krši OCP jer što ako želimo da neki drugi charachter napadne,
 // a to nećemo moći jer je samo objekt Wizzard može napasti.

 //LSP

 public class ColorRed{
        public virtual void Color(){
            System.Console.WriteLine( "Color is Red");
        }
 }

 public class ColorOrange: ColorRed{

    public override void Color()
    {
        System.Console.WriteLine( "Color is orange");
    }
}

public class Program{
    ColorRed red = new ColorOrange();
    red.Color();
}

/*ovo krši jer boja u ColorRed je crvena, 
a ako pozovemo preko ColorOrange objekta dobijemo narandastu boju
i samim time ne moze se zamjeniti ColorRed objekt sa COlorOrange objektom*/

//ISP

public interface IDevice{
    public void PlayMusic();
    public void Display();
}

public class Speaker:IDevice{

    public void PlayMusic(){
        System.Console.WriteLine("play");
    }

    public void Display(){
        //Eception;
    }


}

public class TV:IDevice{

    public void PlayMusic(){
        System.Console.WriteLine( "play");
    }
    public void Display(){
        System.Console.WriteLine( "Display Video");
    }
}

/* ovo krši ISP jer žvučnik ne može prikazati nešto jedino može puštati glazbu
samim time tjeramo žvučnik da bezveze implementira metodu koja mu ne treba.
Rješenje da razdvojimo u dva interface.*/

//DIP

public class LightBulb{
    public void TurnOn(){}
    public void TurnOff(){}
}

public class LightSwitch{

    public LightBulb Bulb {get; set;}

    public void SwitchOn ()
    {
        Bulb.TurnOn()
    }
    public void SwitchOff(){
        Bulb.TurnOff();
    }
}

// krši DIP jer LightSwitch klasa ovisi čvrsto o LightBubl klasi, a ne da se teži apstrakciji tj. Roditelj klasa ovisi o  implementaciji Dijete klase.