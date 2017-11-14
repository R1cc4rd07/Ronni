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

    while (true)
    {
      while(true)
      {
         // Pr?fe Links
         ronnie.move();
         ronnie.turnLeft();
         ronnie.move();
         if (ronnie.onBox())
         {
           ronnie.turnRight();
           ronnie.turnRight();
           ronnie.move();
           ronnie.turnLeft();
           ronnie.putBox();
         }
         else
         {
           ronnie.turnRight();
           ronnie.turnRight();
           ronnie.move();
           ronnie.putBox();
           ronnie.move();
           ronnie.turnLeft();
           ronnie.move();
           ronnie.putBox();
           ronnie.turnRight();
           ronnie.turnRight();
         break;   // Abbruch der Schleife
       }
      }
      while(true)
      {
        // Pr?fe Rechts
        ronnie.move();
        ronnie.turnRight();
        ronnie.move();
        if (ronnie.onBox())
        {
          ronnie.turnRight();
          ronnie.turnRight();
          ronnie.move();
          ronnie.turnRight();
          ronnie.putBox();
        }
        else
        {
          ronnie.turnRight();
          ronnie.turnRight();
          ronnie.move();
          ronnie.putBox();
          ronnie.move();
          ronnie.turnRight();
          ronnie.move();
          ronnie.putBox();
          ronnie.turnRight();
          ronnie.turnRight();
          break;   // Abbruch der Schleife
        }   
      }
    }
  }
}