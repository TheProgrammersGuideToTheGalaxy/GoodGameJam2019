using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    [SerializeField] private string switchToSceneName;

    public void SwitchToScene()
    {
        SceneManager.LoadScene(switchToSceneName);
    }
}
