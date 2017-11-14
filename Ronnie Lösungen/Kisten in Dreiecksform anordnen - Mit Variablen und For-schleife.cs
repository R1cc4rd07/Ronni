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

    int anzKisten=1;
   // Es m?ssen 7 Reihen gelegt werden, also 7 mal wiederholen
    for (int i=0;i<7;i++)
    {
      for (int k=0; k<anzKisten; k++)
      {
         ronnie.putBox();
         ronnie.move();
      }
      if (i%2==0)  // Pr?fen, ob Reihe gerade ?ber modulo
      {
         ronnie.turnRight();
         ronnie.move();
         ronnie.turnRight();

      }
      else
      {
         ronnie.turnLeft();
         ronnie.move();
         ronnie.turnLeft();

      } 
      anzKisten+=2;   // Anzahl Kisten um 2 erh?hen
    }
  }
}