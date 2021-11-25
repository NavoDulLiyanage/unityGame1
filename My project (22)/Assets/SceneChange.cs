using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void Btn_change_scene(string scene_name) {
        SceneManager.LoadScene(scene_name);
    }
}
