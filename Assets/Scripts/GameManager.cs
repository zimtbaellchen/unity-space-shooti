using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score;
    public bool gameOver = false;
    public bool restart = false;
   
    void Awake()
    {
        instance = this;
    }

}
