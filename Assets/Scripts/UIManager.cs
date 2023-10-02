using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text timeText;

    public static float time;

    public Slider slider;
    private float GravityMaxTime= 1.0f;
    public float ReverceTime;

    void Update()
    {
        time += Time.deltaTime;
        timeText.text = " Time："+time.ToString("f2");

        slider.value = (1 - ReverceTime) / GravityMaxTime;
    }
}
