using UnityEngine;

public class dichuyen : MonoBehaviour
{
    public Animator anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float ChangeSteer = 13*Input.GetAxis("Horizontal")*Time.deltaTime;
        float ChangeMove = 13*Input.GetAxis("Vertical")*Time.deltaTime;
        // di chuyển lên xuống
        transform.Translate(0,ChangeMove,0);
        // di chuyển sang trái sang phải
        transform.Translate(ChangeSteer,0,0);
        // animation di chuyển sang trái sang phải
        anim.SetFloat("dichuyen", Mathf.Abs(ChangeSteer));
        // animation di chuyển lên xuống
        anim.SetFloat("chuyen1", Mathf.Abs(ChangeMove));
    }
}
