using UnityEngine;

public class camera : MonoBehaviour
{
    [SerializeField] GameObject f;
    void LateUpdate()
    {
        // camera di theo nhan vat
        transform.position = f.transform.position + new Vector3(0, 0, -30);
    }
}
