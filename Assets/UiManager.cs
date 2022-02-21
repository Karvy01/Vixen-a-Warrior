using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]GameObject overPanel;
    public static UiManager instance;
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void retry()
    {
        SceneManager.LoadScene(0);
    }
    public void Quit()
    {
        Application.Quit();
    }
   public  IEnumerator GameOverPanel()
    {
        yield return new WaitForSeconds(2f);
        overPanel.SetActive(true);
    }
}
