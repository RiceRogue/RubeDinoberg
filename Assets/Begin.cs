using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Begin : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameManager gM;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!GameManager.gmSingleton.hasGameStarted){
            if(Input.GetKey(KeyCode.Space)){
                GameManager.gmSingleton.hasGameStarted = true;
            }
    }

        if(GameManager.gmSingleton.hasGameStarted){
            gameObject.GetComponent<Rigidbody2D>().simulated = true;
        }
    }
}

