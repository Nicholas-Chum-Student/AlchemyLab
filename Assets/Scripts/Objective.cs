using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Objective : MonoBehaviour
{
    [SerializeField] private Text objectiveDisplay;

    [SerializeField] private string objectiveText = "I'm an objective!";
    [SerializeField] private string completedText = "Woo, you've completed an objective!";

    [SerializeField] public UnityEvent OnCompleteObjective = new UnityEvent();

    private void OnEnable()
    {
        objectiveDisplay.text = objectiveText;
    }

    public void CompleteObjective()
    {
        if (gameObject.activeSelf) 
        {
            objectiveDisplay.text = "";

            OnCompleteObjective.Invoke();

            gameObject.SetActive(false);
        }
    }
}
