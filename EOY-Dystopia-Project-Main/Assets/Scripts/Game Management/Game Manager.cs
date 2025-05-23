using System;
using System.Collections;
using System.Collections.Generic;
using System.Resources;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public string GAME_NAME = "DEFCON 1";
    public string GAME_VERSION = "0.8.12";
    
    public bool firstBoot = true;

    public bool isPaused = false;
    
    [Header("Game Config")]
    public bool freezePlayerMovement = false;
    public bool freezePlayerLook = false;
    public bool canInteract = true;
    public bool isInTerminal = false;
    
    public EnemySave enemySave;
    public BunkerData bunkerData;
    public SettingsData settingsData;
    
    public EventManager EventManager { get; private set; }
    public AudioManager AudioManager { get; private set; }
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
        AudioManager = GetComponent<AudioManager>();
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
      
      InputManager.InputMap.Universal.Enable();
      InputManager.InputMap.Universal.Pause.performed += Pause;
         
      bunkerData.BunkerHealth = bunkerData.BunkerMaxHealth;
      enemySave.enemyTransforms = new List<Vector3>();
      enemySave.enemyHealths = new List<float>();
         
        

    }
    
    private void Update()
    {
      
       
       
    }
    
    private void Pause(InputAction.CallbackContext obj)
    {
        if (!SceneManager.GetSceneByName("Main Menu").isLoaded)
        {
            // Toggle pause menu visibility
            isPaused = !isPaused;

            // Only update Time and input states if NOT in terminal
            if (!isInTerminal)
            {
                Time.timeScale = isPaused ? 0 : 1;
                freezePlayerMovement = isPaused;
                freezePlayerLook = isPaused;
                canInteract = !isPaused;
            }
            

            UIManager.PauseMenu(isPaused);

            if (isInTerminal)
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }

        if (SceneManager.GetSceneByName("Settings").isLoaded)
        {
            SceneManager.UnloadSceneAsync("Settings");
            Time.timeScale = 1;
            isPaused = false;
            freezePlayerMovement = false;
            freezePlayerLook = false;
            canInteract = true;
        }
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
    
    public void StartGame()
    {
        StartCoroutine(SceneController.InsideScene());
        Time.timeScale = 1f;
    }
    
    public void Settings()
    {
        if(SceneManager.GetSceneByName("Settings").isLoaded)
        {
            SceneManager.UnloadSceneAsync("Settings");
            Time.timeScale = 1;
            isPaused = false;
        }
        else
        {
            SceneManager.LoadSceneAsync("Settings", LoadSceneMode.Additive);
            Time.timeScale = 0;
            isPaused = true;
        }
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
    public void RestartGame()
    {
        StartCoroutine(SceneController.LoadScene("Main Menu"));
        PlayerPrefs.DeleteAll();
        enemySave.enemyTransforms = new List<Vector3>();
        enemySave.enemyHealths = new List<float>();
        bunkerData.BunkerHealth = bunkerData.BunkerMaxHealth;
        ResourceManager.playerHunger = ResourceManager.maxHunger;
        ResourceManager.playerThirst = ResourceManager.maxThirst;
        ResourceManager.money = 0;
        PowerSystem.isPowerActive = true;
        UIManager.EndGameScreen(false);
        UIManager.PauseMenu(false);
        UIManager.TutorialScreen(false);
     
    }
    
    public void RepairBunker()
    {
        if (bunkerData.BunkerHealth < bunkerData.BunkerMaxHealth)
        {
            bunkerData.BunkerHealth += bunkerData.RepairAmount;
            bunkerData.BunkerHealth = Mathf.Clamp(bunkerData.BunkerHealth, 0, bunkerData.BunkerMaxHealth);
        }
     
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
