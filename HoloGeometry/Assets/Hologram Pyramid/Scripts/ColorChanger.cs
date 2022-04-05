using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    public GameObject[] geometricObjects;
    public Button btn;
    public Color color;


    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(ChangeColor);
    }

    public void ChangeColor()
    {
        for(int i=0; i < geometricObjects.Length; i++)
        {
            var cubeRenderer = geometricObjects[i].GetComponent<Renderer>();
            //Call SetColor using the shader property name "_Color" and setting the color to red
            cubeRenderer.material.SetColor("_Color", color);
        }
    }
}
