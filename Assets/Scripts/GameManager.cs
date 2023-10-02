using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float highScore;

    public AudioClip sound1;
    AudioSource audioSource;

    private float time;
    [SerializeField] AudioClip clip1;
    [SerializeField] AudioClip clip2;
    [SerializeField] AudioClip clip3;
    [SerializeField] AudioClip clip4;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            audioSource.PlayOneShot(sound1);
        }

        time += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && time > 1)
        {
            RandomizeSfx(clip1, clip2, clip3, clip4);

            time = 0;
        }
    }

    public void RandomizeSfx(params AudioClip[] clips)
    {
        var randomIndex = Random.Range(0, clips.Length);
        audioSource.PlayOneShot(clips[randomIndex]);
    }
}
