using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    [SerializeField] private GameObject[] doorsToOpenOnStart;
    [SerializeField] private GameObject[] doorsToCloseOnAction;
    [SerializeField] private GameObject[] doorsToOpenOnAction;

    private void Start()
    {      
        OpenOrCloseDoors(doorsToOpenOnStart, "OpenDoor");
    }

    public void Action()
    {
        OpenOrCloseDoors(doorsToOpenOnAction, "OpenDoor");
        OpenOrCloseDoors(doorsToCloseOnAction, "CloseDoor");
    }

    private void OpenOrCloseDoors(GameObject[] doors, string msg)
    {
        foreach (GameObject door in doors)
        {
            Animator animator = door.GetComponent<Animator>();
            animator.SetTrigger(msg);
        }
    }
}
