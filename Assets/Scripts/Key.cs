using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum KeyColor
{
    Green,
    Blue,
    Red
}

//this declares the colors of the keys. 

public class Key : MonoBehaviour
{
    public KeyColor keyColor;

    private void Start()
    {
        if(keyColor == KeyColor.Green)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.green;
        }
        else if (keyColor == KeyColor.Blue)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        else if (keyColor == KeyColor.Red)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }

    //this code changes the color of the material on the keys using the KeyColor tag thingamajig.

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();

            if (keyColor == KeyColor.Green)
            {
                if (player.hasGreenKey == false)
                {
                    player.hasGreenKey = true;
                    Destroy(gameObject);
                }
            }
            else if (keyColor == KeyColor.Blue)
            {
                if (player.hasBlueKey == false)
                {
                    player.hasBlueKey = true;
                    Destroy(gameObject);
                }
            }
            else if (keyColor == KeyColor.Red)
            {
                if (player.hasRedKey == false)
                {
                    player.hasRedKey = true;
                    Destroy(gameObject);
                }
            }

            //this code tells the project to destroy the key object if the player interacts with its collider. Essentially, this removes the object in the scene.
            
        }
    }
}
