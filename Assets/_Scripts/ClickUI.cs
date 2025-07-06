using TMPro;
using UnityEngine;
public class ClickUI : MonoBehaviour
{
    [Header("References")]
    // Reference to the TextMeshPro text component in the UI.
    [SerializeField] private TMP_Text textUi;

    // Base string that will be displayed before the click count.
    [SerializeField] private string myText;

    // This method updates the UI text by appending the current click count to the base text.
    public void SetText(int clickCount)
    {
        textUi.text = myText + clickCount;
    }
}
