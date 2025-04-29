using UnityEngine;

public class PropellerRotation : MonoBehaviour
{
    public float rotationSpeed = 1000f; // Speed of the propeller rotation

    // Update is called once per frame
    void Update()
    {
        // Rotate the propeller around its forward axis
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
