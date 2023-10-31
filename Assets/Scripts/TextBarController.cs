using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextBarController : MonoBehaviour
{
    public TextMeshProUGUI boxText;
    public TextMeshProUGUI nameText;
    public float textSpeed = 0.05f;

    private int sentenceIndex = -1;
    private StoryScene currentScene;
    private State state = State.COMPLETED;

    private enum State
    {
        PLAYING, COMPLETED
    }

    public void PlayScene(StoryScene scene)
    {
        currentScene = scene;
        sentenceIndex = -1;
        PlayNextSentence();
    }

    public void PlayNextSentence()
    {
        StartCoroutine(TypeText(currentScene.sentences[++sentenceIndex].text));
        nameText.text = currentScene.sentences[sentenceIndex].speaker.characterName;
    }

    public bool IsCompleted()
    {
        return state == State.COMPLETED;
    }

    public bool IsLastSentence()
    {
        return sentenceIndex + 1 == currentScene.sentences.Count;
    }

    private IEnumerator TypeText(string text)
    {
        boxText.text = "";
        state = State.PLAYING;
        int wordIndex = 0;

        while (state != State.COMPLETED)
        {
            boxText.text += text[wordIndex];
            yield return new WaitForSeconds(textSpeed);

            if (++wordIndex == text.Length)
            {
                state = State.COMPLETED;
                break;
            }
        }
    }
}