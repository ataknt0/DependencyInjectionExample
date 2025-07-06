using UnityEngine;
using Zenject;
public class ClickCar : MonoBehaviour
{
    [Header("References")]
    private ClickUI clickUi;
    private ClickAudio clickAudio;
    private NonMonoExample nonMonoExample;
    private int clickCount = 0;
    private void Update()
    {
        OnClicked();
    }
    [Inject]
    private void Constructor(ClickUI clickableUI, ClickAudio clickableAudio, NonMonoExample notMonoExample)
    {
        clickUi = clickableUI;
        clickAudio = clickableAudio;
        nonMonoExample = notMonoExample;
    }
    private void OnClicked()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickCount++;
            clickUi.SetText(clickCount);
            clickAudio.SetSound();
            nonMonoExample.Clicked();
        }
    }
}
