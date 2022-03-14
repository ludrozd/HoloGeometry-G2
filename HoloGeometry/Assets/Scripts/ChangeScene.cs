using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    public void MoveToAnotherScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
