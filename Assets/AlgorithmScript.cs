using UnityEngine;

public class AlgorithmScript : MonoBehaviour
{
    private int hp = 500;

    private void Start()
    {
        for (int i = 0; i < hp; i++)
        {
            Debug.Log(i);
        }
    }

    private void Update()
    {
        hp--;

        if (hp >= 400 && hp % 10 == 0)
        {
            Debug.Log("体力が十分にあります");
        }
        else if (hp >= 200 && hp % 10 == 0)
        {
            Debug.Log("体力が減ってきました");
        }
        else if (hp >= 100 && hp % 10 == 0)
        {
            Debug.Log("体力を回復させてください");
        }
        else if (hp / 10 == 0)
        {
            Debug.Log("もうすぐ体力がなくなります");
        }
    }
}
