using UnityEngine;



public class Movingplatform : MonoBehaviour
{
    public float speed;
    public float minX;
    public float maxX;

    private int dir = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * (dir * speed * Time.deltaTime);
        if (transform.position.x >= maxX)
        {
            dir = -1;
        }
        else if (transform.position.x <= minX)
        {
            dir = 1;
        }
    }
}
