using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string SceneLoad;
    public void SceneChange()
    {
        SceneManager.LoadScene(SceneLoad);
    }
}
