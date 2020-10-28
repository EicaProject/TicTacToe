using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GameControl : MonoBehaviour
{
    public bool player, win, vsCpu; // false = X  -- true = O
    public List<GameObject> Pieces, lines;
    public int turn, Winner;
    public Text Message;
   

    void Start()
    {
        player = false;
        turn = 0;
        win = false;
        vsCpu = false;
    }

    void Update()
    {
        if (turn == 9 && !win)
            Message.text = "Empate";

        else if (win)
            whoWin();
        
        CheckWin();
    }


    public void changePlayer()
    {
        player = !player;

        if(vsCpu && player)
        {
            computerTurn();
        }
        turn++;
    }

  
    void whoWin()
    {
        if (Winner == 1)
        {
            Message.text = "Gano X";

        }
        else
        {
            Message.text = "Gano O";

        }
    }

    void computerTurn()
    {
        bool foundCeroState = false;
        while(!foundCeroState)
        {
            int randomNumber = Random.Range(0,9);
            if(Pieces[randomNumber].gameObject.GetComponent<Ficha>().state == 0)
            {
                Pieces[randomNumber].gameObject.GetComponent<Ficha>().changeShape();
                foundCeroState = true;
            }
        }
    }

    public void CheckWin()
    { 

        //HORIZONTAL
        if(Pieces[0].gameObject.GetComponent<Ficha>().state != 0 && Pieces[1].gameObject.GetComponent<Ficha>().state != 0 && Pieces[1].gameObject.GetComponent<Ficha>().state != 0)
        { 
          if (Pieces[0].gameObject.GetComponent<Ficha>().state == Pieces[1].gameObject.GetComponent<Ficha>().state &&
              Pieces[1].gameObject.GetComponent<Ficha>().state == Pieces[2].gameObject.GetComponent<Ficha>().state)
          {
            print("Se Gano HORIZONTAL 1");
                win = true;
                Winner = Pieces[0].gameObject.GetComponent<Ficha>().state;
                lines[3].SetActive(true);
            }
        }

         if (Pieces[3].gameObject.GetComponent<Ficha>().state != 0 && Pieces[4].gameObject.GetComponent<Ficha>().state != 0 && Pieces[5].gameObject.GetComponent<Ficha>().state != 0)
        {
            if (Pieces[3].gameObject.GetComponent<Ficha>().state == Pieces[4].gameObject.GetComponent<Ficha>().state &&
                Pieces[4].gameObject.GetComponent<Ficha>().state == Pieces[5].gameObject.GetComponent<Ficha>().state)
            {
                print("Se Gano HORIZONTAL 2");
                win = true;
                Winner = Pieces[3].gameObject.GetComponent<Ficha>().state;
                lines[4].SetActive(true);

            }
        }

         if (Pieces[6].gameObject.GetComponent<Ficha>().state != 0 && Pieces[7].gameObject.GetComponent<Ficha>().state != 0 && Pieces[8].gameObject.GetComponent<Ficha>().state != 0)
        {
            if (Pieces[6].gameObject.GetComponent<Ficha>().state == Pieces[7].gameObject.GetComponent<Ficha>().state &&
                Pieces[7].gameObject.GetComponent<Ficha>().state == Pieces[8].gameObject.GetComponent<Ficha>().state)
            {
                print("Se Gano HORIZONTAL 3");
                win = true;
                Winner = Pieces[6].gameObject.GetComponent<Ficha>().state;
                lines[5].SetActive(true);
            }
        }

        //VERTICAL

         if (Pieces[0].gameObject.GetComponent<Ficha>().state != 0 && Pieces[3].gameObject.GetComponent<Ficha>().state != 0 && Pieces[6].gameObject.GetComponent<Ficha>().state != 0)
        {
            if (Pieces[0].gameObject.GetComponent<Ficha>().state == Pieces[3].gameObject.GetComponent<Ficha>().state &&
                Pieces[0].gameObject.GetComponent<Ficha>().state == Pieces[6].gameObject.GetComponent<Ficha>().state)
            {
                print("Se Gano VERTICAL 1");
                win = true;
                Winner = Pieces[0].gameObject.GetComponent<Ficha>().state;
                lines[0].SetActive(true);
            }
        }

         if (Pieces[1].gameObject.GetComponent<Ficha>().state != 0 && Pieces[4].gameObject.GetComponent<Ficha>().state != 0 && Pieces[7].gameObject.GetComponent<Ficha>().state != 0)
        {
            if (Pieces[1].gameObject.GetComponent<Ficha>().state == Pieces[4].gameObject.GetComponent<Ficha>().state &&
                Pieces[1].gameObject.GetComponent<Ficha>().state == Pieces[7].gameObject.GetComponent<Ficha>().state)
            {
                print("Se Gano VERTICAL 2");
                win = true;
                Winner = Pieces[1].gameObject.GetComponent<Ficha>().state;
                lines[1].SetActive(true);
            }
        }

        if (Pieces[2].gameObject.GetComponent<Ficha>().state != 0 && Pieces[5].gameObject.GetComponent<Ficha>().state != 0 && Pieces[8].gameObject.GetComponent<Ficha>().state != 0)
        {
            if (Pieces[2].gameObject.GetComponent<Ficha>().state == Pieces[5].gameObject.GetComponent<Ficha>().state &&
                Pieces[2].gameObject.GetComponent<Ficha>().state == Pieces[8].gameObject.GetComponent<Ficha>().state)
            {
                print("Se Gano VERTICAL 3");
                win = true;
                Winner = Pieces[2].gameObject.GetComponent<Ficha>().state;
                lines[2].SetActive(true);
            }
        }

        //DIAGONAL
         if (Pieces[0].gameObject.GetComponent<Ficha>().state != 0 && Pieces[4].gameObject.GetComponent<Ficha>().state != 0 && Pieces[8].gameObject.GetComponent<Ficha>().state != 0)
        {
            if (Pieces[0].gameObject.GetComponent<Ficha>().state == Pieces[4].gameObject.GetComponent<Ficha>().state &&
                Pieces[0].gameObject.GetComponent<Ficha>().state == Pieces[8].gameObject.GetComponent<Ficha>().state)
            {
                print("Se Gano DIAGONAL 1");
                win = true;
                Winner = Pieces[0].gameObject.GetComponent<Ficha>().state;
                lines[6].SetActive(true);
            }
        }

        if (Pieces[2].gameObject.GetComponent<Ficha>().state != 0 && Pieces[4].gameObject.GetComponent<Ficha>().state != 0 && Pieces[6].gameObject.GetComponent<Ficha>().state != 0)
        {
            if (Pieces[2].gameObject.GetComponent<Ficha>().state == Pieces[4].gameObject.GetComponent<Ficha>().state &&
                Pieces[2].gameObject.GetComponent<Ficha>().state == Pieces[6].gameObject.GetComponent<Ficha>().state)
            {
                print("Se Gano DIAGONAL 2");
                win = true;
                Winner = Pieces[2].gameObject.GetComponent<Ficha>().state;
                lines[7].SetActive(true);

            }
        }
    }
}
