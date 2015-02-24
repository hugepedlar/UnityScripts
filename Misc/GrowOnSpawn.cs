using UnityEngine;
using System.Collections;

public class GrowOnSpawn : MonoBehaviour {

    public float timeToGrow = 1.0f;

    private Vector3 origScale;

	// Use this for initialization
	void Awake () 
    {
        origScale = transform.localScale;
	}

    void Start()
    {
        transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
        StartCoroutine(Grow());
    }
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    IEnumerator Grow()
    {
        float t = 0;
        while (t < timeToGrow)
        {
            transform.localScale = Vector3.Lerp(Vector3.zero, origScale, (t/timeToGrow));
            yield return null;
            t += Time.deltaTime;
        }
        transform.localScale = origScale;
    }
}
