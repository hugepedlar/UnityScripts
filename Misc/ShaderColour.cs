// Makes a sprite flash white, for example when uder attack
// Bit of a hack but it works.

using UnityEngine;
using System.Collections;

public class ShaderColour : MonoBehaviour {

    private SpriteRenderer[] myRenderers;
    private Shader shaderGUItext;
    private Shader shaderSpritesDefault;

    void Start()
    {
        myRenderers = gameObject.GetComponentsInChildren<SpriteRenderer>();
        shaderGUItext = Shader.Find("GUI/Text Shader");
        shaderSpritesDefault = Shader.Find("Sprites/Default"); // or whatever sprite shader is being used

    }
	
	public void SetColour(Color colour, float duration)
    {
        foreach (SpriteRenderer sr in myRenderers)
        {
            sr.material.shader = shaderGUItext;
            sr.color = colour;
        }
        Invoke("ResetColour", duration);
    }

    void ResetColour()
    {
        foreach (SpriteRenderer sr in myRenderers)
        {
            sr.material.shader = shaderSpritesDefault;
            sr.color = Color.white;
        }
    }
}
