using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System;


public class PlayerScaler : MonoBehaviour, IActionable
{
    private GameObject player;
    public int scale;
    private CharacterController characterController;
    private ThirdPersonController playerController;
    private bool isScaledDown = false;
    [SerializeField] private GameObject[] lights;
    

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
                StartFlashLightCoroutine();
                ScaleUpPlayer();
            }
            else
            {
                StartFlashLightCoroutine();
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
        playerController.Gravity /= (float)Math.Sqrt(scale);
        isScaledDown = true;

    }
    public void ScaleUpPlayer()
    {
        player.transform.localScale *= scale;
        characterController.stepOffset *= scale;
        playerController.JumpHeight *= scale;
        playerController.MoveSpeed *= scale;
        playerController.SprintSpeed *= scale;
        playerController.Gravity *= (float)Math.Sqrt(scale);
        isScaledDown = false;
    }
    IEnumerator FlashLight(GameObject light)
    {
        Light lightComponent = light.GetComponent<Light>();
        lightComponent.intensity *= 1000;
        yield return new WaitForSeconds(0.1f);
        lightComponent.intensity /= 1000;
         
    }
    private void StartFlashLightCoroutine()
    {
        foreach (GameObject light in lights)
        {
            StartCoroutine(FlashLight(light));       
        }
        
    }

    
}
