using UnityEngine;
using TMPro;

public class ScoresManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] TMP_Text scoreText;
    [SerializeField] Transform player;

    float highestY = 0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.y > highestY)
        {
            highestY = player.position.y;
            int score = Mathf.FloorToInt(highestY * 10f);
            scoreText.text = $"Score : {score.ToString("N0")}";
        }
    }
}