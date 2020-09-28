using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switcher : MonoBehaviour
{
    public Camera cam;
    public GameObject camlock;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

      void OnCollisionEnter2D(Collision2D collider)
{
    if (collider.gameObject.name == "CameraSwitch")
    {

        cam.transform.position = new Vector3(camlock.transform.position.x, camlock.transform.position.y, -10);
    }
}
}
