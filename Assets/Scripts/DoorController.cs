using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private Animator doorAnimator;
    void Start()
    {
        doorAnimator = GetComponent<Animator>();
        OpenDoor();

    }

    private void OpenDoor()
    {
        Debug.Log("Opening door");
        doorAnimator.SetTrigger("OpenDoor");
    }

    private void CloseDoor()
    {
        Debug.Log("Closing door");
        doorAnimator.SetTrigger("CloseDoor");
    }
}
