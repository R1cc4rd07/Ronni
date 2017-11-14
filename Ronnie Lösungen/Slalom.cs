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
      do
      {
        if (ronnie.poleLeft())
        {
          ronnie.move();
          ronnie.turnLeft();
          ronnie.move();
          ronnie.move();
          ronnie.turnLeft();
          ronnie.move();
        }
        if (ronnie.poleRight())
        {
          ronnie.move();
          ronnie.turnRight();
          ronnie.move();
          ronnie.move();
          ronnie.turnRight();
          ronnie.move();
        }
      }
      while (!ronnie.onBox());
  }
}