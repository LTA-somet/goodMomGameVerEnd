using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool isEnd;

    public SoundManager soundManager;
    public UIManager UIManager;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        Luna.Unity.LifeCycle.GameStarted();
    }
    private void Update()
    {
        if (isEnd)
        {
            if (Input.GetMouseButtonDown(0))
            {
                InstallFullGame();
            }
        }
    }
    public void InstallFullGame()
    {
        Luna.Unity.Playable.InstallFullGame();
    }
    public void EndGame()
    {
        isEnd = true;
        Luna.Unity.LifeCycle.GameEnded();
    }
}
