using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour, IHittable
{
    [SerializeField] private GameObject buttonLight;
    [SerializeField] private Button[] buttons;
    [SerializeField] private MonoBehaviour actionScript;
    private IActionable actionableComponent;
    public bool TurnOn;
    private Light buttonLightComponent;


    private void Start()
    {
        TurnOn = false;
        buttonLightComponent = buttonLight.GetComponent<Light>();
        actionableComponent = actionScript as IActionable;
    }

    private void ChangeColor(Color color)
    {
        
        buttonLightComponent.color = color;
    }
   
    IEnumerator ButtonClick()
    {
        ChangeColor(Color.green);
        TurnOn = true;

        yield return new WaitForSeconds(3);

        ChangeColor(Color.red);
        TurnOn = false;
    }

    public void OnHit()
    {
        StartCoroutine(ButtonClick());
        CheckAllButtons(); 
    }

    private void CheckAllButtons()
    {
        foreach (Button button in buttons)
        {
            if (!button.TurnOn)
            {
                return;
            }
        }

        actionableComponent?.Action();
        
    }

}
