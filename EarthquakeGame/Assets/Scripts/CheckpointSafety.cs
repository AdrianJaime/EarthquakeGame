using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointSafety : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.GetComponentInParent<MoreMountains.CorgiEngine.DamageOnTouch>() != null)
            other.collider.GetComponentInParent<MoreMountains.CorgiEngine.DamageOnTouch>().DamageCaused = 0;
    }
}
