using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerScaler : MonoBehaviour, IActionable
{
    [SerializeField] private GameObject player;
    public int scale;
    private CharacterController characterController;
    private ThirdPersonController playerController;
    private bool isScaledDown = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player = other.gameObject;
            Debug.Log("Player Entered");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player = null;
            Debug.Log("Player Exited");
        }
    }


    public void Action()
    {
        if (player != null) 
        {
            Debug.Log("Scaler Action Player Found");
            playerController = player.GetComponent<ThirdPersonController>();
            characterController = player.GetComponent<CharacterController>();
            if (isScaledDown)
            {
                ScaleUpPlayer();
            }
            else
            {
                ScaleDownPlayer();
            }
            
        } else
        {
            Debug.Log("Scaler Action Player Not Found");
        }
    }
        
    public void ScaleDownPlayer()
    {
        player.transform.localScale /= scale;
        characterController.stepOffset /= scale;
        playerController.JumpHeight /= scale;
        playerController.MoveSpeed /= scale;
        playerController.SprintSpeed /= scale;
        isScaledDown = true;

    }
    public void ScaleUpPlayer()
    {
        player.transform.localScale *= scale;
        characterController.stepOffset *= scale;
        playerController.JumpHeight *= scale;
        playerController.MoveSpeed *= scale;
        playerController.SprintSpeed *= scale;
        isScaledDown = false;
    }


    
}
