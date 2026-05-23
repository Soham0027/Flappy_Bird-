using UnityEngine;

public class Player_Movements : MonoBehaviour
{

    private Rigidbody2D rb;

    [SerializeField] private float jumpForce = 2f;  
     
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    } 


void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x , jumpForce);
        }
    }
}