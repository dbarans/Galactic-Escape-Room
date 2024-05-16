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
        
    }
}
