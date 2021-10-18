using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// Some code was used from https://answers.unity.com/questions/1109479/how-to-reload-a-scene-using-scenemanager.html

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Goes to the city streets scene.
    public void CityStreetScene()
    {
        SceneManager.LoadScene(1);
    }

    // Goes to the rooftop scene.
    public void RooftopScene()
    {
        SceneManager.LoadScene(2);
    }

    // Goes back into the title scene.
    public void RestartScene()
    {
        SceneManager.LoadScene(0);
    }
}
