using UnityEngine;
using Zenject;
public class ClickCar : MonoBehaviour
{
    // References to other classes that handle UI update, audio feedback, and non-MonoBehaviour logic.
    private ClickUI clickUi;
    private ClickAudio clickAudio;
    private NonMonoExample nonMonoExample;
    private int clickCount = 0;

    private void Update()
    {
        // Continuously checks every frame if the left mouse button was pressed.
        if (Input.GetMouseButtonDown(0))
        {
            // If clicked, execute the click logic.
            OnClicked();
        }
    }

    // This method is used by Zenject to inject dependencies when the object is created.
    // It replaces the typical Unity-style `Start()` or `Awake()` dependency assignments with constructor injection.
    [Inject]
    private void Constructor(ClickUI clickableUI, ClickAudio clickableAudio, NonMonoExample notMonoExample)
    {
        // Assign the injected dependencies to local variables.
        clickUi = clickableUI;
        clickAudio = clickableAudio;
        nonMonoExample = notMonoExample;
    }

    // This method is called when the left mouse button is clicked.
    private void OnClicked()
    {
        clickCount++;

        // Updates the UI text with the new click count.
        clickUi.SetText(clickCount);

        // Plays the associated click sound via the ClickAudio class.
        clickAudio.SetSound();

        // Executes additional logic that is not tied to a MonoBehaviour.
        nonMonoExample.Clicked();
    }
}
