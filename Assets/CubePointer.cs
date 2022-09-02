using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePointer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Response Pointer Touch the Cube
    public void PointerEnter ()
    {
        //Chage the color of the cube to blue
        GetComponent<Renderer>().material.color = Color.blue;
    }

    //Response Pointer Exit the Cube
    public void PointerExit ()
    {
        //Change the color of the cube to white
        GetComponent<Renderer>().material.color = Color.white;

    }

    //Response to Pointer Click Event
    public void PointerCLick ()
    {
        //Kill the enemy
        Destroy(gameObject);
    }

}
