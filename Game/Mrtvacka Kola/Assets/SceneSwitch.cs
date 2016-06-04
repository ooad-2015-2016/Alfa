using UnityEngine;
using System.Collections;

public class SceneSwitch : MonoBehaviour {

    public string sceneName;
    private bool clickLock;
    
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0) && !clickLock)
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }

    public void LoadScene()
    {
        clickLock = true;
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
}
