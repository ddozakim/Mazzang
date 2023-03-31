using UnityEngine.UI;
using UnityEngine;
using System.Reflection;
using UnityEngine.SceneManagement;
using System.Globalization;

public class UIManager : MonoBehaviour
{
    private float LimitTime=30f;
    public Text text_Timer;
    public Image image;
    public Text title;
 
    
    public string SceneToLoad;
    // Update is called once per frame
    void Update()
    {
        title.text = "마스크를 쓰지 않은 마짱인의 수는?!";
        if (LimitTime >= 0) { 
            LimitTime -= Time.deltaTime;
            text_Timer.text = "Time : " + Mathf.Round(LimitTime);
           
        }
      
        else
        {
            SceneManager.LoadScene(SceneToLoad);
        }
       

    }

  
}
