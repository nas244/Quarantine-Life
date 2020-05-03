using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Start_Menu : MonoBehaviour
{
    [SerializeField]
    private LevelLoader Loader;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
    }

    public void OnStartButton()
    {
        Loader.LoadLevel("");
    }

    public void OnQuitButton()
    {
        Application.Quit();
    }
}
