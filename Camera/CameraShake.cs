// FREE FOR ALL USES
// 2D only
// Put this on a camera along with the CameraFollow script.

using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour {

    [Header("Defaults")]
    public float duration = 0.5f;
    public float magnitude = 1.0f;

    [HideInInspector]
    public Vector3 originalCamPos;

    public void Shake()
    {
        StopCoroutine("_Shake");
        StartCoroutine(_Shake(duration, magnitude));
    }

    public void Shake(float _duration, float _magnitude)
    {
        StopCoroutine("_Shake");
        StartCoroutine(_Shake(_duration, _magnitude));
    }

    IEnumerator _Shake(float _duration, float _magnitude)
    {
        float elapsed = 0.0f;

        while (elapsed < _duration)
        {
            elapsed += Time.deltaTime;

            float percentComplete = elapsed / _duration;
            float damper = 1.0f - Mathf.Clamp(4.0f * percentComplete - 3.0f, 0.0f, 1.0f);

            // map value to [-1, 1]
            float x = Random.value * 2.0f - 1.0f;
            float y = Random.value * 2.0f - 1.0f;
            x *= _magnitude * damper;
            y *= _magnitude * damper;

            transform.position = new Vector3(x + originalCamPos.x, y + originalCamPos.y, originalCamPos.z);

            yield return null;
        }

        transform.position = originalCamPos;
    }
}
