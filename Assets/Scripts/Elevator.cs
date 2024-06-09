using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Elevator : MonoBehaviour, IActionable
{
    [SerializeField] private GameObject door;
    [SerializeField] private GameObject cabin;
    [SerializeField] private float cabinSpeed = 1.0f;
    private float cabinTime = 0.0f;
    private bool isMoving = false;
    private Vector3 cabinStartPosition;
    [SerializeField] private float CabinDistance = 10.0f;
    [SerializeField] private string nextSceneName;

    private void Start()
    {
        door.GetComponent<Animator>().SetTrigger("OpenDoor");
    }

    public void Action()
    {
        door.GetComponent<Animator>().SetTrigger("CloseDoor");
        MoveCabin();
    }
    private void MoveCabin()
    {
        
        cabinStartPosition = cabin.transform.position;
        isMoving = true;


    }
    private void Update()
    {
        if (isMoving)
        {
            cabinTime += Time.deltaTime * cabinSpeed;
            cabin.transform.position = Vector3.Lerp(cabinStartPosition, cabinStartPosition + Vector3.up * CabinDistance, cabinTime);
            if (cabinTime >= 1.0f)
            {
                isMoving = false;
                cabinTime = 0.0f;
                SceneManager.LoadScene(nextSceneName);
            }
        }
    }

}
