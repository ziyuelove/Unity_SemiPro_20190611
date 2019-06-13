using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeRgn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        OnChangeRgn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnChangeRgn()
    {
        string strSceneName = Game.GetGame().strChangeRgn;
        if (ResourceManager.GetInstance().bLoadFromStream)
            StartCoroutine(ResourceManager.GetInstance().LoadScene(strSceneName));
        else
            SceneManager.LoadSceneAsync(strSceneName);
    }
}
