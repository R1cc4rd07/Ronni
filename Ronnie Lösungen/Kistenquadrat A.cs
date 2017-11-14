using System;
using Ronnie01;

/**********************************************
 * Ronnie hat folgende "Sinne", 
 *      die jeweils true oder false liefern:
 *
 *  ronnie.poleFront()  
 *  ronnie.poleLeft()  
 *  ronnie.poleRight()
 *  ronnie.coneFront()
 *  ronnie.onBox()
 *
 *  und je nach dem, was seine Sinne liefern,
 *  kann Ronnie folgende Aktionen machen:
 *
 *  ronnie.move()
 *  ronnie.turnLeft()
 *  ronnie.turnRight()
 *  ronnie.pickupBox()
 *  ronnie.putBox()
 *
 ************************************************/
public class ProgRonnie : BaseScript, IRonnieInterface
{
  public void myProg()
  {
    // hier fügen Sie Ihren Programmcode ein     

    int laenge = 4; // Seitenl?nge
    
     for (int i=0;i < laenge;i++)   // Anzahl der Reihen
     {
        for (int k=0; k<laenge; k++)  // Anzahl der abgelegten Kisten
        {
           ronnie.putBox();
           ronnie.move();
        }
        ronnie.turnLeft();  // Ronnie dreht sich um 180?
        ronnie.turnLeft();
        ronnie.move();
        while(ronnie.onBox())  // Ronnie geht zur?ck
        {
          ronnie.move();
        }
        ronnie.turnLeft();  // Ronnie geht in n?chste Reihe
        ronnie.move();
        ronnie.turnLeft();
        ronnie.move();
      
     }
  }
}