using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shake : MonoBehaviour
{
    [SerializeField] Transform title, button;
    public void callCoroutine()
    {
        StartCoroutine(CameraShake(1.15f, .7f));
    }
    private void Update()
    {
    }
    public IEnumerator CameraShake (float duration, float magnitude)
    {
        Vector3 titleOriginalPos = title.localPosition;
        Vector3 buttonOriginalPos = button.localPosition;

        float elapsed = 0.0f;

        while(elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            title.localPosition = new Vector3(title.localPosition.x - x, title.localPosition.y - y, titleOriginalPos.z);
            button.localPosition = new Vector3(button.localPosition.x - x, button.localPosition.y - y, buttonOriginalPos.z);

            elapsed += Time.deltaTime;

            yield return null;
        }

        title.localPosition = titleOriginalPos;
        button.localPosition = buttonOriginalPos;
        SceneManager.LoadScene("NewCorgi3D");
    }
}
