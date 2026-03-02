using UnityEngine;
using UnityEngine.UI;

public class SliderTemplate : MonoBehaviour
{
    public Slider mainSlider;

    public void Template()
    {
        Debug.Log(mainSlider.value);
    }
}
