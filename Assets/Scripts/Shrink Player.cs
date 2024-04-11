using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;

    private void Start()
    {
        ShrinkPlayerSize();
        
    }
    public void ShrinkPlayerSize()
    {
        player.gameObject.transform.localScale *= 0.1f;
    }
}
