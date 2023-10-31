using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public StoryScene currentScene;
    public TextBarController textBar;
    public BackgroundController backgroundController;
    public SpriteController_ spriteController;

    private bool isTransitioning;

    void Start()
    {
        StartScene(currentScene);
    }

    public void ChangeScene(StoryScene newScene)
    {
        spriteController.ChangeAnimation("isTransitioning");
        backgroundController.SwitchImage(newScene.background);
        StartScene(newScene);
    }

    void StartScene(StoryScene scene)
    {
        currentScene = scene;
        textBar.PlayScene(currentScene);
    }

    void Update()
    {
        if (textBar.IsCompleted() && textBar.IsLastSentence())
        {
            StoryScene newScene = currentScene.nextScene;
            if (newScene != null)
            {
                ChangeScene(newScene);
            }
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            textBar.PlayNextSentence();
        }
    }
}