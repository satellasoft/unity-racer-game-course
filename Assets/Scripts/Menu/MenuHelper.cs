using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHelper : MonoBehaviour
{
    public GameObject creditsPanel;

    public void LoadSceneByName(string sceneName = null)
    {
        if (sceneName == null)
        {
            Debug.LogWarning("Informe o nome da cena a ser carregado");
            return;
        }

        SceneManager.LoadScene(sceneName);
    }

    public void ShowCredits(bool show = true)
    {
        creditsPanel.SetActive(show);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
