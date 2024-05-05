using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] private Animator doorAnimator;
    private int playerCount = 0;

    private void Start()
    {
        doorAnimator = transform.parent.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerCount++;
            if (playerCount == 1)
            {
                OpenDoor();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerCount--;
            if (playerCount == 0)
            {
                CloseDoor();
            }
        }
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
