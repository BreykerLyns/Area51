using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{

    static public GameControl instance;
    public CharacterBaseMov3D currentPlayer;
    public UIManager UIManager;
    bool inTransition;

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

    void ChangeLevel (int targetLevel){
        SceneManager.LoadScene(targetLevel);

        //Refresh current player
        GameObject targetPlayer = GameObject.FindWithTag("Player");
        if (targetPlayer){
            Debug.Log("Found" + targetPlayer.name);
            currentPlayer = targetPlayer.GetComponent<CharacterBaseMov3D>();
        }
    }

    public void StartRespawnProcess () {
        if (!inTransition) {
            StartCoroutine(RespawnProcess());
            inTransition = true;
        }
    }

    public void StartLevelChangeProcess (int index) {
        if (!inTransition){
            StartCoroutine(LevelChangeProcess(index));
            inTransition = true;
        }
    }

    IEnumerator RespawnProcess () {
        yield return UIManager.FadeProcess(currentPlayer.Respawn);

        while (!currentPlayer.grounded) {
            yield return null;
        }
        currentPlayer.EnableInput();
        inTransition = false;
    }

    IEnumerator LevelChangeProcess() {
        yield return UIManager.FadeProcess(ChangeLevel, index);
        inTransition = false;
    }
}