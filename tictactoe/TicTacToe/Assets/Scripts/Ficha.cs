using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ficha : MonoBehaviour
{
    public GameControl gameControl;
    public Image Player_X_Shape;  // X image
    public Image Player_O_Shape;  // O image
    public int state = 0;  // 0=empty  1=X    2=O  

    void Start()
    {
        Player_X_Shape.enabled = false;
        Player_O_Shape.enabled = false;
        state = 0;
    }

    public void changeShape()
    {
        if (gameObject.GetComponent<Ficha>().state == 0)
        {
            if (!gameControl.player)
            {
                Player_X_Shape.enabled = true;
                Player_O_Shape.enabled = false;
                gameObject.GetComponent<Ficha>().state = 1;
            }
            else if (gameControl.player)
            {
                Player_X_Shape.enabled = false;
                Player_O_Shape.enabled = true;
                gameObject.GetComponent<Ficha>().state = 2;               
            }
            gameControl.changePlayer();
        }
    }

}
