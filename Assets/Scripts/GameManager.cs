using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        instance = this;

        DontDestroyOnLoad(this);
    }

    public void AddScore(int ammount)
    {
        score += ammount;
    }
}
