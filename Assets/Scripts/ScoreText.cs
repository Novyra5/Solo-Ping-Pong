using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public TextMeshProUGUI textScore;

    public void SetScore(int value)
    {
        textScore.text = value.ToString();
    }
}
