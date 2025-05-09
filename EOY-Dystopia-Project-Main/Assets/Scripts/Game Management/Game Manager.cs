using System;
using System.Collections;
using System.Collections.Generic;
using System.Resources;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    
    public bool firstBoot = true;

    public bool isPaused = false;
    
    public bool freezePlayerMovement = false;
    public bool freezePlayerLook = false;
    public bool canInteract = true;
    
    public EnemySave enemySave;
    public BunkerData bunkerData;
    
    public EventManager EventManager { get; private set; }
    public InputManager InputManager {get ; private set;}
    public UIManager UIManager { get; private set; }
    public SceneController SceneController { get; private set; }
    public EnemyController EnemyController { get; private set; }
    public ResourceManagement ResourceManager { get; private set; }
    public PowerSystem PowerSystem { get; private set; }

  
    

    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        EventManager = GetComponent<EventManager>();
        InputManager = GetComponent<InputManager>();
        UIManager = GetComponent<UIManager>();
        SceneController = GetComponent<SceneController>();
        EnemyController = FindObjectOfType<EnemyController>();
        ResourceManager = GetComponent<ResourceManagement>();
        PowerSystem = GetComponent<PowerSystem>();
    }
    
    private void Start()
    {
      firstBoot = true;
      Instance.EventManager.GameBoot();
      
      // InputManager.InputMap.UI.Pause.performed += ctx => UIManager.PauseMenu();
      // InputManager.InputMap.UI.Resume.performed += ctx => UIManager.ResumeGame();
      EventManager.OnGameOver += EndGame;
         
      bunkerData.BunkerHealth = bunkerData.BunkerMaxHealth;
      enemySave.enemyTransforms = new List<Vector3>();
      enemySave.enemyHealths = new List<float>();
         
        

    }

    private void Update()
    {
      
       
       
    }
    
   

    private void Pause()
    {
        isPaused = true;
        Time.timeScale = 0;
    }
    private void Resume()
    {
        isPaused = false;
        Time.timeScale = 1;
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.DeleteAll();
    }
    
    private void EndGame(bool show, string cause)
    {
        Time.timeScale = 0;
        freezePlayerMovement = true;
        freezePlayerLook = true;
        canInteract = false;
        UIManager.EndGameScreen(true, cause);
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
    public void RestartGame()
    {
        Time.timeScale = 0;
        SceneController.LoadScene("MainMenu");
        PlayerPrefs.DeleteAll();
        enemySave.enemyTransforms.Clear();
        enemySave.enemyHealths.Clear();
        bunkerData.BunkerHealth = bunkerData.BunkerMaxHealth;
        ResourceManager.playerHunger = ResourceManager.maxHunger;
        ResourceManager.playerThirst = ResourceManager.maxThirst;
    }

    // private void Update()
    // {
    //     if (Input.GetKeyDown(KeyCode.Escape))
    //     {
    //         isPaused = !isPaused;
    //     }
    //
    //     Time.timeScale = isPaused ? 0 : 1;
    // }
}
