using UnityEngine;
using UnityEngine.UI;

public class TextManagment : MonoBehaviour
{
    public Text geometricBodyDescription;
    public static string description;
    void Start()
    {
        geometricBodyDescription.text = GeometricBodyDescription.descriptionOfGeometricBody;
    }

}
