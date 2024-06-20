using UnityEngine;

public class BlinkingLight : MonoBehaviour
{
    public Light lightSource; // Источник света
    public float blinkInterval = 1.0f; // Интервал мигания в секундах
    private float timeElapsed = 0.0f;
    private bool lightOn = true;

    void Start()
    {
        if (lightSource == null)
        {
            lightSource = GetComponent<Light>();
        }
    }

    void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= blinkInterval)
        {
            timeElapsed = 0.0f;
            lightOn = !lightOn;
            lightSource.enabled = lightOn;
        }
    }
}
