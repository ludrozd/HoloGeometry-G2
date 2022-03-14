using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagment : MonoBehaviour
{
    public static void ChangeScene(string nameOfScene)
    {
        SceneManager.LoadScene(nameOfScene);
    }
}

