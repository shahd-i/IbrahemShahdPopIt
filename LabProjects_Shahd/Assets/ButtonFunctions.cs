using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonFunctions : MonoBehaviour
{
    [SerializeField] InputField playerNameInput;
   
 
    // Start is called before the first frame update
    void Start()
    {
        playerNameInput.text = PersistentData.Instance.GetName();
        //playerNameInput.text = "test";

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToInstruction()
    {
        SceneManager.LoadScene("instructionsScene");
    }

    public void PlayGame()
    {
        string playerName = playerNameInput.text;
        PersistentData.Instance.SetName(playerName);
        SceneManager.LoadScene("Scene1Lab");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("menuScene");
    }
    public void LoadSettings()
    {
        SceneManager.LoadScene("Settings");
    }
}
