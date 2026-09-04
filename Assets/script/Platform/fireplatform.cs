using System.Collections;
using UnityEngine;

public class fireplatform : MonoBehaviour
{
    public float burnDuration = 5f;
    playercontroller playercontroller;
    private void Start()
    {
        playercontroller = GameObject.FindGameObjectWithTag("Player").GetComponent<playercontroller>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // ตรวจสอบว่าโดนแพลตฟอร์มที่ใส่แท็กไว้หรือไม่ (Check if touched a tagged platform)
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(setfire());
        }
    }
    public IEnumerator setfire()
    {
        playercontroller.FireEnable(true);
        yield return new WaitForSeconds(burnDuration);
        playercontroller.FireEnable(false); 
    }
}
