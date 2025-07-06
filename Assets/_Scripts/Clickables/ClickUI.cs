using TMPro;
using UnityEngine;
public class ClickUI : MonoBehaviour
{
    [Header("Referances")]
    [SerializeField] private TMP_Text textUi;
    [SerializeField] private string myText;
    public void SetText(int clickCount)
    {
        textUi.text = myText + clickCount;
    }
}
