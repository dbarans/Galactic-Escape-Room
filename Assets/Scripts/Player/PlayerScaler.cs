using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScaler : MonoBehaviour
{
    [SerializeField] private GameObject player;
    public int scale;
    private CharacterController characterController;
    private ThirdPersonController playerController;
    private Animator animator;


    private void Start()
    {
        playerController = player.GetComponent<ThirdPersonController>();
        characterController = player.GetComponent<CharacterController>();
        animator = player.GetComponent<Animator>();
        ScaleDownPlayer();
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
