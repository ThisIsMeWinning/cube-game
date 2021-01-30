using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Options()
    {
        SceneManager.LoadScene("Options");
    }
    public void Player()
    {
        SceneManager.LoadScene("Player");
    }
    public void Version()
    {
        SceneManager.LoadScene("Version");
    }
    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }
}
