using UnityEngine;
using UnityEngine.UI;

public class PetNameInput : MonoBehaviour
{
    public InputField nameInputField;
    public Text instructionsText;

    private string enteredName;

    void Start()
    {
        // Set up a listener for the input field's OnEndEdit event
        nameInputField.onEndEdit.AddListener(SubmitName);
    }

    void SubmitName(string name)
    {
        // Save the entered name
        enteredName = name;
        Debug.Log("Entered Name: " + enteredName);

        // You can do something with the entered name, such as assigning it to your pet
    }
}
