using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public InputField playerNameInput;
    public Button startButton;
    public Button quitButton;

    void Start()
    {
        // Tambahkan listener untuk tombol Start
        startButton.onClick.AddListener(OnStartClicked);
        // Tambahkan listener untuk tombol Quit
        quitButton.onClick.AddListener(OnQuitClicked);
    }

    void OnStartClicked()
    {
        string playerName = playerNameInput.text;

        if (!string.IsNullOrEmpty(playerName))
        {
            Debug.Log("Game Started with Player: " + playerName);
            // Pindah ke scene game (gantikan "GameScene" dengan nama scene kamu)
            SceneManager.LoadScene("main");
        }
        else
        {
            Debug.LogWarning("Player name cannot be empty!");
        }
    }

    void OnQuitClicked()
    {
        Debug.Log("Game Quit");
        Application.Quit();
    }
}
