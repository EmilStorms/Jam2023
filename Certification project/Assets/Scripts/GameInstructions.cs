using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInstructions : MonoBehaviour
{
    public string gameInstructions = "Move the player by using W,A,S and D keys";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameInstructions);
    }

}
