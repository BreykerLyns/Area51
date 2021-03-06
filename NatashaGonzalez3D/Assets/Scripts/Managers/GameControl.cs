﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {

    static public GameControl instance;
    public CharacterBaseMov3D currentPlayer;
    public UIManager uIManager;
    public bool inTransition { get; private set; }

    public int currentLevel { get { return SceneManager.GetActiveScene().buildIndex; } }

    void Awake () {
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            if (instance != this) {
                if (gameObject != instance.gameObject) {
                    Destroy(gameObject);
                } else {
                    Destroy(this);
                }
            }
        }
    }

    void ChangeLevel (int targetLevel) {
        SceneManager.LoadScene(targetLevel);
    }

    public void StartRespawnProcess () {
        if (!inTransition) {
            StartCoroutine(RespawnProcess());
            inTransition = true;
        }
    }

    public void StartLevelChangeProcess (int index) {
        if (!inTransition) {
            StartCoroutine(LevelChangeProcess(index));
            inTransition = true;
        }
    }

    IEnumerator RespawnProcess () {
        yield return uIManager.FadeProcess(currentPlayer.Respawn);

        while (!currentPlayer.grounded) {
            yield return null;
        }
        currentPlayer.EnableInput();
        inTransition = false;
    }

    IEnumerator LevelChangeProcess (int index) {
        yield return uIManager.FadeProcess(ChangeLevel, index);
        inTransition = false;
    }
}
