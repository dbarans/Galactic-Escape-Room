using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jupm_Animation : MonoBehaviour
{
    public Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) // Je�li naci�ni�to spacj�
        {
            animator.SetTrigger("Jump"); // Odtw�rz animacj� otwierania drzwi
        }


    }
}