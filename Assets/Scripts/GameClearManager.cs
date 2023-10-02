using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameClearManager : MonoBehaviour
{
    public float r;

    public static float timeScore;

    // Start is called before the first frame update
    void Start()
    {
        timeScore = UIManager.time;

        naichilab.RankingLoader.Instance.SendScoreAndShowRanking(timeScore);
    }

    public void Replay()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
