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
 * und je nach dem, was seine Sinne liefern,
 * kann Ronnie folgende Aktionen machen:
 *
 * ronnie.move()
 * ronnie.turnLeft()
 * ronnie.turnRight()
 * ronnie.pickupBox()
 * ronnie.putBox()
 *
 *
 ************************************************/
public class ProgRonnie : BaseScript, IRonnieInterface
{
  void invert()
  {
    if (ronnie.onBox())
    {
      ronnie.pickupBox();
    }
    else
    {
      ronnie.putBox();
    }
  }
  void walk()
  {
     invert();
     while (!ronnie.poleFront())
     {
       
       ronnie.move();
       invert();
     }

  }

  void left2right()
  { 
    walk();
    if (!ronnie.poleRight())
    { 
      ronnie.turnRight();
      ronnie.move();
      ronnie.turnRight();
    }

  }

  void right2left()
  { 
    walk();
    if (!ronnie.poleLeft())
    { 
      ronnie.turnLeft();
      ronnie.move();
      ronnie.turnLeft();
    }

  }

  public void myProg()
  {
    // hier f?gen Sie Ihren Programmcode ein
     left2right;
   
  } 
}