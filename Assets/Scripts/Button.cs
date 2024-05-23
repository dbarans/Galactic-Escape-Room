using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour, IHittable
{
    [SerializeField] private GameObject buttonLight;
    [SerializeField] private Button secondButton;
    [SerializeField] private DoorManager doorManager;
    public bool TurnOn;


    private void Start()
    {
        TurnOn = false;
    }
    private void ChangeColor(Color color)
    {
        Light buttonLightComponent = buttonLight.GetComponent<Light>();
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
        if (TurnOn && secondButton.TurnOn)
        {
            doorManager.Action();
        }
    }

}
