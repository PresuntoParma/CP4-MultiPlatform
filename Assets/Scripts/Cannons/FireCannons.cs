using UnityEngine;

public class FireCannons : MonoBehaviour
{
    [SerializeField] private Cannon[] cannons;

    private void Start()
    {
        Invoke("ActivateCannon", (Random.Range(0.1f, 1f)));
    }

    private void ActivateCannon()
    {
        if (GameManager.instance.playing)
        {
            cannons[Random.Range(0, cannons.Length - 1)].Fire();
        }

        Invoke("ActivateCannon", (Random.Range(0.1f, 1f)));
    }
}
