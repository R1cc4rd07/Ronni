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

    while (!ronnie.onBox())
    {
      if (!ronnie.poleLeft())
      {
        ronnie.turnLeft();
        ronnie.move();
      }
      if (!ronnie.poleRight())
      {
        ronnie.turnRight();
        ronnie.move();
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