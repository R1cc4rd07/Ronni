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
    // hier f�gen Sie Ihren Programmcode ein     

    while (!ronnie.onBox())
    {
      if (ronnie.poleFront())
      {
        ronnie.turnLeft();
        ronnie.move();
        ronnie.turnRight();
        ronnie.move();
        while (ronnie.poleRight())
        {
          ronnie.move();
        }  
        ronnie.turnRight();
        ronnie.move();
        ronnie.turnLeft();
      }
      else
      {
        ronnie.move();
      }
    }
    if (ronnie.onBox())
    {
      ronnie.pickupBox();
    }        
  }
}