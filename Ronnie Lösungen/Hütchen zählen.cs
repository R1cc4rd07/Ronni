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

   int anzahl=0;
   
   while (!ronnie.coneFront()&&!ronnie.poleRight())
   {
     if (ronnie.poleFront())
     {
       ronnie.turnLeft();
       ronnie.move();
       ronnie.turnRight();
       ronnie.move();
       ronnie.move();
       ronnie.turnRight();
       if (ronnie.coneFront())
       {
         anzahl++;
         ronnie.turnLeft();
         ronnie.move();
         ronnie.turnRight();
         ronnie.move();
         ronnie.turnLeft();
       }
       else
       {
         ronnie.move();
         ronnie.turnLeft();
       }
     }
     else
     {
       ronnie.move();
     }
   }
   ronnie.turnLeft();
   for (int i=0; i<anzahl; i++)
   {
     ronnie.putBox();
     ronnie.move();
   }
  }
}