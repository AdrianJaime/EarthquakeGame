using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class SafeZone : MonoBehaviour
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
        {
            if (Input.GetKey(KeyCode.S))
            {
                other.collider.GetComponentInParent<MoreMountains.CorgiEngine.DamageOnTouch>().DamageCaused = 3;

                if (Input.GetKey(KeyCode.F))
                {
                    other.collider.GetComponentInParent<MoreMountains.CorgiEngine.DamageOnTouch>().DamageCaused = 0;
                }
            }
           
        }
    }
}
