using UnityEngine;

[SelectionBase]
public class Breakable : MonoBehaviour
{
    [SerializeField] GameObject intactwindow;
    [SerializeField] GameObject brokenwindow;

    BoxCollider bc;

    private void Awake()
    {
        intactwindow.SetActive(true);
        brokenwindow.SetActive(false);

        bc = GetComponent<BoxCollider>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected with " + collision.gameObject.name); // Debugging line
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
        if (rb != null && rb.velocity.magnitude > 2) // U¿yj velocity z Rigidbody
        {
            Break();
        }
    }

    private void Break()
    {
        Debug.Log("Window is breaking!"); // Debugging line
        intactwindow.SetActive(false);
        Debug.Log("Intact window deactivated."); // Debugging line
        brokenwindow.SetActive(true);
        Debug.Log("Broken window activated."); // Debugging line

        bc.enabled = false;
    }
}
