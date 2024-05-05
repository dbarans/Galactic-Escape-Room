using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    [SerializeField] private Animator doorAnimator;

    private void Start()
    {
        doorAnimator = transform.parent.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OpenDoor();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CloseDoor();
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
