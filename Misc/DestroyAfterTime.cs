using UnityEngine;
using System.Collections;

public class DestroyAfterTime : MonoBehaviour {

    public float delay = 1.0f;

	void Start () 
    {
        Invoke("KillMe", delay);
	}
	
    void KillMe()
    {
        Destroy(gameObject);
    }
}
