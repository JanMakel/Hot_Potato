using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Game_controller : MonoBehaviour
{
    public int randomNumber;
    public int clickcounter;
    private void Start()
    {
        randomNumber = Random.Range(1, 11);
    }

    private void AddOneToCounter() {
        clickcounter++;
        transform.localScale += Vector3.one;
    }
    private bool HaveIWon()
    {
        if (clickcounter < randomNumber) {
            Debug.Log($"Te has quedado corto. Has realizado {clickcounter} clicks, pero el número aleatorio era {randomNumber}");
            return false;
        }
        if(clickcounter > randomNumber)
        {
            Debug.Log($"Te has pasado. Has realizdo {clickcounter} clicks, pero el número aleatorio era {randomNumber}");
            return false;
        }
  
        
         Debug.Log($"¡Has Ganado!");
         return true;
        
        
    }
    private void explode()
    {
        if(clickcounter == randomNumber)
        {
            transform.position += new Vector3(10, 25, 10);
        }
    }
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            AddOneToCounter();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (HaveIWon())
            {
                explode();
                Debug.Log("Buena ^^");
            }
        }
    }
}
