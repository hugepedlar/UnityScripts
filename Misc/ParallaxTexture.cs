// Scrolls a texture based on position.
// Apply a wrapped texture to a quad and put this script on it
// Parent it to the camera

using UnityEngine;
using System.Collections;

public class ParallaxTexture : MonoBehaviour {

    public float scrollSpeedX = 0.1f;
    public float scrollSpeedY = 0.1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        Vector3 position = transform.position;
        position.x *= scrollSpeedX;
        position.y *= scrollSpeedY;
        renderer.material.mainTextureOffset = position;
	}
}
