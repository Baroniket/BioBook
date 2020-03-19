using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VideoManager : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;

    public GameObject AC_Scroll, PC_Scroll, DNA_Scroll, Skin_Scroll, Skull_Scroll, Mito_Scroll, Anemia_Scroll;
    public Button back1, back2, back3, back4, back5, back6, back7;
    public GameObject AC_Vid, PC_Vid, DNA_Vid, Skin_Vid, Skull_Vid, Mito_Vid, Anemia_Vid;
    void OnEnable()
    {
        //Register Button Events
        button1.onClick.AddListener(() => buttonCallBack(button1));
        button2.onClick.AddListener(() => buttonCallBack(button2));
        button3.onClick.AddListener(() => buttonCallBack(button3));
        button4.onClick.AddListener(() => buttonCallBack(button4));
        button5.onClick.AddListener(() => buttonCallBack(button5));
        button6.onClick.AddListener(() => buttonCallBack(button6));
        button7.onClick.AddListener(() => buttonCallBack(button7));
        back1.onClick.AddListener(() => buttonCallBack(back1));
        back2.onClick.AddListener(() => buttonCallBack(back2));
        back3.onClick.AddListener(() => buttonCallBack(back3));
        back4.onClick.AddListener(() => buttonCallBack(back4));
        back5.onClick.AddListener(() => buttonCallBack(back5));
        back6.onClick.AddListener(() => buttonCallBack(back6));
        back7.onClick.AddListener(() => buttonCallBack(back7));
    }


    void start()
    {
        AC_Vid.SetActive(false);
        back1.gameObject.SetActive(false);
        PC_Vid.SetActive(false);
        back2.gameObject.SetActive(false);
        DNA_Vid.SetActive(false);
        back3.gameObject.SetActive(false);
        Skin_Vid.SetActive(false);
        back4.gameObject.SetActive(false);
        Skull_Vid.SetActive(false);
        back5.gameObject.SetActive(false);
        Mito_Vid.SetActive(false);
        back6.gameObject.SetActive(false);
        Anemia_Vid.SetActive(false);
        back7.gameObject.SetActive(false);
    }

    private void buttonCallBack(Button buttonPressed)
    {
        if (buttonPressed == button1)
        {
            //Your code for button 1
            Debug.Log("Clicked: " + button1.name);
            AC_Scroll.SetActive(false);
            AC_Vid.SetActive(true);
            back1.gameObject.SetActive(true);
            button1.gameObject.SetActive(false);

        }

        if (buttonPressed == button2)
        {
            //Your code for button 2
            Debug.Log("Clicked: " + button2.name);
            PC_Scroll.SetActive(false);
            PC_Vid.SetActive(true);
            back2.gameObject.SetActive(true);
            button2.gameObject.SetActive(false);
        }

        if (buttonPressed == button3)
        {
            //Your code for button 3
            Debug.Log("Clicked: " + button3.name);
            DNA_Scroll.SetActive(false);
            DNA_Vid.SetActive(true);
            back3.gameObject.SetActive(true);
            button3.gameObject.SetActive(false);
        }

        if (buttonPressed == button4)
        {
            //Your code for button 4
            Debug.Log("Clicked: " + button4.name);
            Skin_Scroll.SetActive(false);
            Skin_Vid.SetActive(true);
            back4.gameObject.SetActive(true);
            button4.gameObject.SetActive(false);
        }

        if (buttonPressed == button5)
        {
            //Your code for button 5
            Debug.Log("Clicked: " + button5.name);
            Skull_Scroll.SetActive(false);
            Skull_Vid.SetActive(true);
            back5.gameObject.SetActive(true);
            button5.gameObject.SetActive(false);
        }

        if (buttonPressed == button6)
        {
            //Your code for button 6
            Debug.Log("Clicked: " + button6.name);
            Mito_Scroll.SetActive(false);
            Mito_Vid.SetActive(true);
            back6.gameObject.SetActive(true);
            button6.gameObject.SetActive(false);
        }

        if (buttonPressed == button7)
        {
            //Your code for button 7
            Debug.Log("Clicked: " + button7.name);
            Anemia_Scroll.SetActive(false);
            Anemia_Vid.SetActive(true);
            back7.gameObject.SetActive(true);
            button7.gameObject.SetActive(false);
        }

        if (buttonPressed == back1)
        {
            //Your code for back 1
            Debug.Log("Clicked: " + back1.name);
            AC_Scroll.SetActive(true);
            AC_Vid.SetActive(false);
            button1.gameObject.SetActive(true);
            back1.gameObject.SetActive(false);
        }

        if (buttonPressed == back2)
        {
            //Your code for back 2
            Debug.Log("Clicked: " + back2.name);
            PC_Scroll.SetActive(true);
            PC_Vid.SetActive(false);
            button2.gameObject.SetActive(true);
            back2.gameObject.SetActive(false);
        }

        if (buttonPressed == back3)
        {
            //Your code for back 3
            Debug.Log("Clicked: " + back3.name);
            DNA_Scroll.SetActive(true);
            DNA_Vid.SetActive(false);
            button3.gameObject.SetActive(true);
            back3.gameObject.SetActive(false);
        }

        if (buttonPressed == back4)
        {
            //Your code for back 4
            Debug.Log("Clicked: " + back4.name);
            Skin_Scroll.SetActive(true);
            Skin_Vid.SetActive(false);
            button4.gameObject.SetActive(true);
            back4.gameObject.SetActive(false);
        }

        if (buttonPressed == back5)
        {
            //Your code for back 5
            Debug.Log("Clicked: " + back5.name);
            Skull_Scroll.SetActive(true);
            Skull_Vid.SetActive(false);
            button5.gameObject.SetActive(true);
            back5.gameObject.SetActive(false);
        }

        if (buttonPressed == back6)
        {
            //Your code for back 6
            Debug.Log("Clicked: " + back6.name);
            Mito_Scroll.SetActive(true);
            Mito_Vid.SetActive(false);
            button6.gameObject.SetActive(true);
            back6.gameObject.SetActive(false);
        }

        if (buttonPressed == back7)
        {
            //Your code for back 7
            Debug.Log("Clicked: " + back7.name);
            Anemia_Scroll.SetActive(true);
            Anemia_Vid.SetActive(false);
            button7.gameObject.SetActive(true);
            back7.gameObject.SetActive(false);
        }
    }
}
