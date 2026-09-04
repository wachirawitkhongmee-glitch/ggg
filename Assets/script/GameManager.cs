using UnityEngine;
using UnityEngine.SceneManagement;

// ═══════════════════════════════════════════════════════
// 📝 แบบฝึกหัด: GameManager.cs
// หน้าที่: Game Over เมื่อ Player ตกต่ำกว่ากล้อง
// ═══════════════════════════════════════════════════════

public class GameManager : MonoBehaviour
{
    [SerializeField] Transform player;

    void Update()
    {
        // Game Over เมื่อ Player ตกต่ำกว่ากล้อง (ให้แล้ว ไม่ต้องแก้)
        float camBottom = Camera.main.transform.position.y - 7f;

        // 📝 โจทย์: ต้องการจบเกม (โหลด Scene "GameOver") เฉพาะตอนที่ Player
        // ตกต่ำกว่ากล้องเท่านั้น ต้องใช้คำสั่งไหน?
        //   A) if (player.position.y < camBottom) SceneManager.LoadScene("GameOver");
        //   B) if (player.position.y < camBottom) Destroy(player.gameObject);
        //   C) if (player.position.y > camBottom) SceneManager.LoadScene("GameOver");
        //   D) SceneManager.LoadScene("GameOver");
        // ✍️ เขียนคำตอบแทนบรรทัดด้านล่าง:
        /* TODO */
        if (player.position.y < camBottom) SceneManager.LoadScene("GameOver");
    }
}
