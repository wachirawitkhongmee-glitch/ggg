using UnityEngine;

// ═══════════════════════════════════════════════════════
// 📝 แบบฝึกหัด: PlatformDestroyer.cs
// หน้าที่: ลบ Platform ที่ตกต่ำกว่ากล้อง (ประหยัด Memory)
// แนบ Script นี้กับ Platform Prefab ทุกตัว
// ═══════════════════════════════════════════════════════

public class PlatformDestroyer : MonoBehaviour
{
    void Update()
    {
        // ลบตัวเองเมื่ออยู่ต่ำกว่ากล้อง 7 หน่วย (ไม่ต้องแก้)
        float camBottom = Camera.main.transform.position.y - 7f;

        // 📝 โจทย์: ต้องการลบ Platform ตัวเองทิ้งออกจาก Scene จริง ๆ (ไม่ใช่แค่ซ่อน)
        // เมื่อมันตกต่ำกว่าขอบล่างของกล้อง ต้องใช้คำสั่งไหน?
        //   A) if (transform.position.y < camBottom) Destroy(gameObject);
        //   B) if (transform.position.y < camBottom) Destroy(GetComponent<PlatformDestroyer>());
        //   C) if (transform.position.y > camBottom) Destroy(gameObject);
        //   D) if (transform.position.y < camBottom) gameObject.SetActive(false);
        // ✍️ เขียนคำตอบแทนบรรทัดด้านล่าง:
        /* TODO */
        if (transform.position.y < camBottom) Destroy(gameObject);
    }
}
