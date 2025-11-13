using UnityEngine;

public class DoorMovement : MonoBehaviour {
    [SerializeField] private float smooth = 1.0f;
    [SerializeField] private float DoorOpenAngle = -90.0f;
    [SerializeField] private float DoorCloseAngle = 0.0f;

    private Quaternion targetRotation;

    private void Start() {
        targetRotation = Quaternion.Euler(0, DoorCloseAngle, 0);
    }

    private void Update() {
        transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, Time.deltaTime * 5 * smooth);

        if (Quaternion.Angle(transform.localRotation, targetRotation) < 0.5f)
            transform.localRotation = targetRotation;
    }

    public void Open() {
        targetRotation = Quaternion.Euler(0, DoorOpenAngle, 0);
    }

    public void Close() {
        targetRotation = Quaternion.Euler(0, DoorCloseAngle, 0);
    }

    public bool IsOpen() {
        return Quaternion.Angle(transform.localRotation, Quaternion.Euler(0, DoorOpenAngle, 0)) < 1f;
    }

    public bool IsClose() {
        return Quaternion.Angle(transform.localRotation, Quaternion.Euler(0, DoorCloseAngle, 0)) < 1f;
    }
}
