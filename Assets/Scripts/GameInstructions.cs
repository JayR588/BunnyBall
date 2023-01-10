using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInstructions : MonoBehaviour
{
   public string gameInstructions = "Move the character by using the W, A, S and D keys";
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameInstructions);
    }

}
