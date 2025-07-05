using Unity.VisualScripting;
using UnityEngine;

public class ClickCar : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private ClickUI clickUi;
    [SerializeField] private ClickAudio clickAudio;
    private int clickCount = 0;
    void Update()
    {
        OnClicked();
    }
    private void OnClicked()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickCount++;
            clickUi.SetText(clickCount);
            clickAudio.SetSound();
        }
    }
}
