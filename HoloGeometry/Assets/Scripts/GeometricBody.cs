using UnityEngine;

[CreateAssetMenu(fileName = "Geometric Body", menuName = "Geometrical Body")]
public class GeometricBody : ScriptableObject
{
    public new string name;
    public GameObject body;
    public AudioClip audio;
}
