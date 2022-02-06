using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.Feedbacks;

public class EarthquakeSystem : MonoBehaviour
{

    private static EarthquakeSystem _instance;

    public static EarthquakeSystem Instance { get { return _instance; } }


    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }


    public MoreMountains.CorgiEngine.CameraController cam;
    public GameObject debris;
    public List<DebrisSpawn> debrisSlots = new List<DebrisSpawn>();
    public List<MMFeedbacks> feedbackList = new List<MMFeedbacks>();
    public MMFeedbacks quakeShake1, quakeShake2, quakeShake3;
    public float currentTime, timeToNextQuake;
    bool trembling = false;

    // Start is called before the first frame update
    void Start()
    {
        timeToNextQuake = Random.Range(2.0f, 4.0f);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = Time.time;
        if (currentTime > timeToNextQuake)
        {
            if (!trembling)
            {
                trembling = true;
                StartCoroutine(quakeWarnOne());
            }
        }
    }

    IEnumerator quakeWarnOne()
    {
        bool willBeQuake = false;

        if (Random.Range(-10.0f, 10.0f) > 0)
        {
            willBeQuake = true;
        }

        //camera shake
        quakeShake1.PlayFeedbacks();
        yield return new WaitForSeconds(2.0f);

        if (willBeQuake)
        {
            StartCoroutine(quakeWarnTwo());
        }
        else
        {
            timeToNextQuake = Random.Range(2.0f, 4.0f) + currentTime;
            trembling = false;

        }
    

    }

    IEnumerator quakeWarnTwo()
    {
        //camera shake
        quakeShake2.PlayFeedbacks();
        yield return new WaitForSeconds(2.0f);
        StartCoroutine(earthquake());
    }

    IEnumerator earthquake()
    {

        //camera shake
        int randy;
        quakeShake3.PlayFeedbacks();
        yield return new WaitForSeconds(1.0f);
        randy = Random.Range(0, 2);
        Instantiate(debris, debrisSlots[randy].transform.position, Quaternion.identity);
        feedbackList[randy].PlayFeedbacks();
        Debug.Log(debrisSlots[0].transform.position);
        yield return new WaitForSeconds(1.0f);
        randy = Random.Range(0, 2);
        Instantiate(debris, debrisSlots[randy].transform.position, Quaternion.identity);
        feedbackList[randy].PlayFeedbacks();
        Debug.Log(debrisSlots[1].transform.position);
        yield return new WaitForSeconds(1.0f);
        randy = Random.Range(0, 2);
        Instantiate(debris, debrisSlots[randy].transform.position, Quaternion.identity);
        feedbackList[randy].PlayFeedbacks();
        Debug.Log(debrisSlots[2].transform.position);
        timeToNextQuake = Random.Range(2.0f, 4.0f) + currentTime;
        trembling = false;
    }


}
