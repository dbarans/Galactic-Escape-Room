using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionRay : MonoBehaviour
{

    private StarterAssetsInputs assetsInputs;

    private void Start()
    {
        assetsInputs = GetComponent<StarterAssetsInputs>();
    }
    void Update()
    {
        if (assetsInputs.action)
        {
            assetsInputs.action = false;
            CastRay();

        }
    }
    private void CastRay()
    {
       
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

    
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("Trafiony obiekt: " + hit.collider.gameObject.name);

        }
    }
}
