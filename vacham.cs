using UnityEngine;

public class vacham : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D a)
    {
        Debug.Log("touched");
    }
    private void OnTriggerEnter2D(Collider2D a)
    {
        Debug.Log("you pass the circle");
    }
}
