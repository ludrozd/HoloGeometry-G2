using UnityEngine;
using UnityEngine.UI;

public class Answerer : MonoBehaviour
{
    public bool isCorrect = false;

    public Color startColor;
    public RecognizeManager recognize;

    private void Start()
    {
        startColor = GetComponent<Image>().color;
    }

    public void Answer()
    {
        if (isCorrect)
        {
            GetComponent<Image>().color = Color.green;
            Debug.Log("Correct Answer");
            recognize.correct();
        }
        else
        {
            GetComponent<Image>().color = Color.red;
            Debug.Log("Wrong Answer");
            recognize.wrong();
        }

    }

}
