using UnityEngine;
using TMPro;
using System.Collections;

public class TypewriterEffect : MonoBehaviour
{
    public TextMeshProUGUI uiText;
    public float delay = 0.1f;

    private string fullText;
    private string currentText = "";

    void Start()
    {
        // Set the fullText variable directly in code
        fullText = "You are a worker for the city.\nYour boss sends you into the rough part of town.\nYour job is to find out why the city block has lost water. ";
        StartCoroutine(ShowText());
    }

    IEnumerator ShowText()
    {
        for (int i = 0; i < fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i + 1);
            uiText.text = currentText;
            yield return new WaitForSeconds(delay);
        }
    }
}
