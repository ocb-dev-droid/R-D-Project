using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngineInternal;

public class StageManager : MonoBehaviour
{


    public string currentStage;
    public void getStage()
    {
        currentStage = SceneManager.GetActiveScene().name;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        getStage();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
