using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool hasGreenKey = false;
    public bool hasBlueKey = false;
    public bool hasRedKey = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            //changed this too KeyCode.E as KeyCode.A would move the player left when they opened the door.
            //more of a quality of life change. 

        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, 10f))
            {
                if (hit.collider.tag == "Door")
                {
                    LockedDoor door = hit.collider.GetComponent<LockedDoor>();

                    if (door.isDoorLocked == false)
                    {
                        door.OpenDoor();
                    }
                    else
                    {
                        if (door.keyColorRequired == KeyColor.Green && hasGreenKey)
                        {
                            door.OpenDoor();
                        }

                        else if (door.keyColorRequired == KeyColor.Blue && hasBlueKey)
                        {
                            door.OpenDoor();
                        }
                        else if (door.keyColorRequired == KeyColor.Red && hasRedKey)
                        {
                            door.OpenDoor();
                        }

                    }
                    // this code makes the door go to its finalDestination if the player has the correct key
                    // and is pressing 'E' on the correct color of door.
                    /*
                    /initially these lines of code were organized as 
                    if(door.keyColorRequired == KeyColor.Green && hasGreenKey) ||
                    (door.keyColorRequired == KeyColor.Blue && hasBlueKey)
                    (door.keyColorRequired == KeyColor.Red && hasRedKey)
                    but this wouldn't work as it needs multiple if else statements to correctly cycle through all of the KeyColors. 
                    */

                }
            }
        }
    }
}
