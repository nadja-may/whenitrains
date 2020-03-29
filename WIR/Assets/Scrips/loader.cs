using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void closeGame()
    {
        Application.Quit();
        Debug.Log("closed");
    }

    public void toMenu()
    {
        SceneManager.LoadScene(0);
        Debug.Log("backtomenu");
    }

    public void startExplain()
    {
        SceneManager.LoadScene(1);
        Debug.Log("toexplain");
    }
    public void startGame()
    {
        SceneManager.LoadScene(2);
        Debug.Log("togame");
    }
}
