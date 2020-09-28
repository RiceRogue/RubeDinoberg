using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public bool hasGameStarted = false;
    // Start is called before the first frame update
    public static GameManager gmSingleton;
    void Start()
    {
        gmSingleton = this;
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
