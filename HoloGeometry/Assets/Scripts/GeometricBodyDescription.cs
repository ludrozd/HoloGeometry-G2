using UnityEngine;
using UnityEngine.UI;

public class GeometricBodyDescription : MonoBehaviour
{
    public Button button;
    public string nameOfBody;
    public string description;
    public static string nameOfGeometricBody;
    public static string descriptionOfGeometricBody;
    private void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        nameOfGeometricBody = nameOfBody;
        descriptionOfGeometricBody = description;
    }
}
