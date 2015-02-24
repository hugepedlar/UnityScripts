// Floats up and down

using UnityEngine;
using System.Collections;

public class SinPosition : MonoBehaviour {

    public float amplitude = 1.0f;
    public float omega = 1.0f;

    private float t = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        transform.position += transform.up * amplitude * Mathf.Sin(omega * t);
        t += Time.deltaTime;
	}
}
