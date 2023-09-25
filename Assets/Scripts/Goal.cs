using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Goal : MonoBehaviour
{
    GameObject PositionChecker;

    // Start is called before the first frame update
    void Start()
    {
        PositionChecker = GameObject.Find("PlayerArmature");
    }

    // Update is called once per frame
    void Update()
    {
        if (PositionChecker.gameObject.transform.position.y < -10)
        {
            GameOver();
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            GameOver();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Invoke("GameClear", 1.0f);
    }

    private void GameOver()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void GameClear()
    {
        SceneManager.LoadScene("GameClear");
    }

}
