using UnityEngine;
public class animation : MonoBehaviour
{
    public float rotationSpeed = 100f;
    private float rotationDirection = 0f;
    void Start()
    {
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rotationDirection = 1f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rotationDirection = -1f;
        }
        else
        {
            rotationDirection = 0f;
        }
        transform.Rotate(Vector3.up * rotationDirection * rotationSpeed * Time.deltaTime);
    }
}
