using UnityEngine;

public class ChangeOffset : MonoBehaviour
{

    public float verticalOffsetSpeed = 1.0f;
    private Renderer _renderer;

    void Start()
    {
        _renderer = GetComponent<Renderer>();

       
    }

    void Update()
    {
        if (_renderer != null)
        {
            float newOffsetY = Mathf.Repeat(Time.time * verticalOffsetSpeed, 1);
            _renderer.material.mainTextureOffset = new Vector2(
                _renderer.material.mainTextureOffset.x,
                newOffsetY
            );
        }
    }
}
