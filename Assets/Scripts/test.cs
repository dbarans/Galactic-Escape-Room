using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    [SerializeField] private DoorManager doorManager;
    void Start()
    {
        doorManager.Action();
    }
}