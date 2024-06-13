using StarterAssets;
using UnityEngine;

public class ActionRay : MonoBehaviour
{
    private StarterAssetsInputs assetsInputs;

    [SerializeField] private Camera playerCamera;
    [SerializeField] private float rayDistance = 1.5f;

    private void Start()
    {
        assetsInputs = GetComponent<StarterAssetsInputs>();
       
    }

    private void Update()
    {
        DrawDebugRay();
        

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

        if (Physics.Raycast(cameraPosition, cameraForward, out hit, rayDistance))
        {
            TriggerAction(hit.collider.gameObject);
            Debug.Log("Trafiony obiekt: " + hit.collider.gameObject.name);
        }

    }
    private void TriggerAction(GameObject hitObject)
    {
        IHittable hittable = hitObject.GetComponent<IHittable>();
        if (hittable != null)
        {
            hittable.OnHit();
        }
        else
        {
            Debug.Log("No hitable object!");
        }
    }


    private void DrawDebugRay()
    {
        Vector3 cameraPosition = playerCamera.transform.position;
        Vector3 cameraForward = playerCamera.transform.forward;

        Debug.DrawRay(cameraPosition, cameraForward * rayDistance, Color.red);
    }
}
