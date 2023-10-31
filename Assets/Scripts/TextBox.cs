using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextBox : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public Dialog dialog;

    public void DisplayDialog()
    {
        if (textComponent != null && dialog != null)
        {
            // Set the text of the UI Text component to the dialog content.
            textComponent.text = dialog.sentences[0]; // Display the first sentence (you can iterate through all sentences in your UI).
        }
    }


}


