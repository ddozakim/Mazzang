using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinalScene : MonoBehaviour
{
    public InputField input;
    public string SceneToLoad_Sucess;
    public string SceneToLoad_Fail;

    // Update is called once per frame

    public void change()
    {
        string answer = input.text;

        


            if (answer == "9")
            {

                SceneManager.LoadScene(SceneToLoad_Sucess);


            }
            else
            {

                SceneManager.LoadScene(SceneToLoad_Fail);

            }
        
    }

}

