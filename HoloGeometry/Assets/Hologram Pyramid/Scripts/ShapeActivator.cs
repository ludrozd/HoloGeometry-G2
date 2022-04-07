using UnityEngine;

public class ShapeActivator : MonoBehaviour
{
    public GameObject[] geomObject;
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
}
