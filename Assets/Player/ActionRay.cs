using StarterAssets;
using UnityEngine;

public class ActionRay : MonoBehaviour
{
    private StarterAssetsInputs assetsInputs;

    [SerializeField] private Camera playerCamera;

    private void Start()
    {
        assetsInputs = GetComponent<StarterAssetsInputs>();
       
    }

    private void Update()
    {
        

        if (assetsInputs.action)
        {
            assetsInputs.action = false;
            CastRayFromCamera();

        }
    }

    private void CastRayFromCamera()
    {
       
        Vector3 cameraPosition = playerCamera.transform.position;
        Vector3 cameraForward = playerCamera.transform.forward;

       
        RaycastHit hit;

        
        if (Physics.Raycast(cameraPosition, cameraForward, out hit))
        {
           
            Debug.Log("Trafiony obiekt: " + hit.collider.gameObject.name);

          
        }

      
        Debug.DrawRay(cameraPosition, cameraForward * 100f, Color.red);
    }
}
