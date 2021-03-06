using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {
    [SerializeField] float Speed = 35.0f;
    Quaternion originalRotationValue;
    private void Start()
    {
        originalRotationValue = this.transform.rotation;
    }

    void Update()
    {
        rotateBody(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        if (Input.GetKey(KeyCode.Space))
            returnToStartingPosition();
        if (Input.GetKey(KeyCode.Escape))
            SceneManagment.ChangeScene("LearnMenu");
    }

    void rotateBody(float moveHorizontal, float moveVertical)
    {
        transform.RotateAround(this.transform.position, new Vector3(moveHorizontal, moveVertical), Speed * Time.deltaTime);
    }
    void returnToStartingPosition()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, originalRotationValue, Speed * Time.time );
    }
}
