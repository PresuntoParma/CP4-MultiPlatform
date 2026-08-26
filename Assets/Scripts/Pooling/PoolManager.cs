using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    [SerializeField] private GameObject cannonBallPrefab;
    public int ballsAmmount;
    public List<GameObject> Balls;

    private void Awake()
    {
        GenerateBalls();
    }

    private void GenerateBalls()
    {
        for (int i = 0; i < ballsAmmount; i++)
        {
            var ball = Instantiate(cannonBallPrefab);
            ball.transform.parent = transform;
            ball.SetActive(false);
            Balls.Add(ball);
        }
    }

    public GameObject GetBall()
    {
        for (int i = 0; i < ballsAmmount; i++)
        {
            if (!Balls[i].activeInHierarchy)
                return Balls[i];
        }
        return null;
    }
}
