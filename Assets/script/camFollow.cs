using Unity.VisualScripting;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform player;
    float highestY;
    private void Start()
    {
        highestY = transform.position.y;
    }

    private void LateUpdate()
    {
        if (player.position.y > highestY)
        {
            highestY = player.position.y;
            transform.position = new Vector3(
                transform.position.x,
                highestY,
                transform.position.z
             );
        }
    }
}