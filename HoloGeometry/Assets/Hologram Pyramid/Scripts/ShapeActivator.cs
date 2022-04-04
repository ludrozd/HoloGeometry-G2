using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeActivator : MonoBehaviour
{
    public GameObject[] geomObject;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < geomObject.Length; i++)
        {
            geomObject[i].SetActive(false);
        }

            for (int i = 0; i < geomObject.Length; i++)
        {
            if (GeometricBodyDescription.nameOfGeometricBody.Equals(geomObject[i].name))
            {
                geomObject[i].SetActive(true);
            } 
        }        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
