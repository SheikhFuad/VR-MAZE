using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    public Transform door;

    public float openSpeed = 5;

    private bool open = false;

    // Update is called once per frame
    void Update()
    {
        Vector3 closedPosition = new Vector3(door.position.x, 7.5f, door.position.z);
        Vector3 openPosition = new Vector3(door.position.x, 2.5f, door.position.z);

        if (!open) {
            door.position = Vector3.Lerp(door.position, openPosition, Time.deltaTime * openSpeed);
        }
        else {
            door.position = Vector3.Lerp(door.position, closedPosition, Time.deltaTime * openSpeed);
        }
    }

    public void OpenDoor() {
        if(!open)
            open = true;
        else
            open = false;
    }
}
