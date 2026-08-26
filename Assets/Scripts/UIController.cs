using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private Text textScore;

    private void Start()
    {
        GameManager.instance.OnScoreChange += UpdateScore;
    }

    public void UpdateScore()
    {
        textScore.text = "Score: " + GameManager.instance.score;
    }
}
