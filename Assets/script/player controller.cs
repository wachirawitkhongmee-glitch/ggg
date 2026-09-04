using UnityEngine;

public class playercontroller : MonoBehaviour
{

        [SerializeField] float moveSpeed = 0f;
        [SerializeField] float jumpForco = 10f;

        [SerializeField] private Rigidbody2D rb;

    public GameObject fireSprite;


        void Start()
    { 
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float move = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity =
            new Vector2(move * moveSpeed, rb.linearVelocity.y);

        if (transform.position.x < -2.8f)
            transform.position = new Vector3(2.8f, transform.position.y, 0f);
        else if (transform.position.x > 2.8f)
            transform.position = new Vector3( -2.8f, transform.position.y, 0f);



    }



    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Platform") && rb.linearVelocity.y <= 0.2f)
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, y: jumpForco);
    }

    public void FireEnable(bool isOn)
    {
        fireSprite.SetActive(isOn);
    }

}
