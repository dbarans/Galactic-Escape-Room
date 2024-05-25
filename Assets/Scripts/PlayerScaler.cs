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
    private Animator animator;


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
            animator = player.GetComponent<Animator>();
            ScaleDownPlayer();
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
        animator.SetFloat("MotionSpeed", 10);
        animator.SetFloat("Speed", 10);

    }
    public void ScaleUpPlayer()
    { 

    }


    
}
