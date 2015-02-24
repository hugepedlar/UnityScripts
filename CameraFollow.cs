// FREE FOR ALL USES
// 2D only
// This script requires the CameraShake script to be on the same gameObject.
// It also requires a separate GameObject tagged "Player" with a rigidBody2D.

// 'damping' controls the smoothness of the camera movement.
// 'leading' controls how far ahead of the target's trajectory the camera aims for.

using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float damping = 2.0f;
    public float leading = 0.4f;

    private Vector3 oldTargetPosition;
    private Vector3 currentPosition;
    private Vector3 originalPosition;
    private Vector3 wantedPosition;

    private CameraShake cameraShake;

    void Start()
    {
        if (target == null)
        {
            target = GameObject.FindGameObjectWithTag("Player").transform;
        }

        oldTargetPosition = target.position;
        originalPosition = transform.position;

        cameraShake = GetComponent<CameraShake>();
    }

    void LateUpdate()
    {
        if (target == null)
        {
            target = GameObject.FindGameObjectWithTag("Player").transform;
        }
        
        wantedPosition = target.position + (Vector3)target.rigidbody2D.velocity * leading;
        currentPosition = transform.position;
        currentPosition = Vector3.Lerp(currentPosition, wantedPosition, damping * Time.deltaTime);
        currentPosition.z = originalPosition.z;
        transform.position = currentPosition;
        cameraShake.originalCamPos = currentPosition;
    }
}
