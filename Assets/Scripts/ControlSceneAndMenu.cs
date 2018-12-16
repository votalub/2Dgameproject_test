using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSceneAndMenu : MonoBehaviour {
    public GameObject buttonsMenu;
    public GameObject buttonsExit;

    public void ShowExitButtons()   // функция которая будет вызываться нажатием кнопки выхода
    {
        buttonsMenu.SetActive(false);
        buttonsExit.SetActive(true);
    }
    public void BackInMenu()   // возврат в главное меню
    {
        buttonsMenu.SetActive(true);
        buttonsExit.SetActive(false);
    }
    public void ExitGame()   // возврат в главное меню
    {
        Application.Quit();
    }

   public void NewGameLoadScene()   // возврат в главное меню
    {
        Application.LoadLevel("SampleScene");
    } 

}
