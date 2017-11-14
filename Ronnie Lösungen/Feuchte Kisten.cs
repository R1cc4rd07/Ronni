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

int anzahl=0;  // Kistenz?hler
   
   while (!ronnie.poleFront()) // solange kein Poller vor Ronnie
   {                           // sammelt Ronnie Kisten ein
      if (ronnie.onBox())
      {
         ronnie.pickupBox();
         anzahl++; // oder anzahl = anzahl + 1; // Kiste z?hlen
      }
      ronnie.move();
      
   }
   if (ronnie.onBox())
   {
      ronnie.pickupBox();
      anzahl++; // oder anzahl = anzahl + 1; // Kiste z?hlen
   }
   
   ronnie.turnLeft();
   ronnie.turnLeft();
   while (ronnie.poleLeft()&&ronnie.poleRight())
   {
      ronnie.move();
   }
   ronnie.turnLeft();
   for(int i=0; i < anzahl; i++)
   {
      ronnie.putBox();
      ronnie.move();
   }
   
  }
}