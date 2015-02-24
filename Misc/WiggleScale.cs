// Make an object randomly oscillate its sscale.
// Useful for a build up to an explosion, or for a sprite-based flame for example.

using UnityEngine;
using System.Collections;

public class WiggleScale : MonoBehaviour {

    public float frequency = 10.0f;
    public float amount = 0.1f;

    private Vector3 origScale;

	// Use this for initialization
	void Start () 
    {
        origScale = transform.localScale;
        Wiggle();
	}
	
	void Wiggle()
    {
        transform.localScale = origScale;
        float delta = Random.Range(-amount, amount);
        transform.localScale += transform.localScale * delta;
        float delay = 1.0f / frequency;
        Invoke("Wiggle", delay);
    }
}
