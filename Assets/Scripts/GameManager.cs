using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float highScore;

    public AudioClip sound1;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G))
        {
            audioSource.PlayOneShot(sound1);
        }

    }
}
