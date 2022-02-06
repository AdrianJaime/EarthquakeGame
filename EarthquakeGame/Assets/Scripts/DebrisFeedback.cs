using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Feedbacks;

public class DebrisFeedback : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EarthquakeSystem.Instance.feedbackList.Add(this.GetComponent<MMFeedbacks>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
