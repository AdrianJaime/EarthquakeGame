using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.Feedbacks;

public class DebrisSpawn : MonoBehaviour
{

    void Start()
    {

        EarthquakeSystem.Instance.debrisSlots.Add(this);

    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
