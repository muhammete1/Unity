using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu1 : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayButton (){
        SceneManager.LoadScene(1);
    }
    public void QuitButton() {
        Application.Quit();
    }
}
