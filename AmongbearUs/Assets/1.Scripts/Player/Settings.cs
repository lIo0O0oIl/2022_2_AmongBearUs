using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public bool isJoyStick;
    public Image touchBtn, JoyStickBtn;
    public Color blue;
    public PlayerCtrl playerCtrl_script;

    GameObject mainView, playView;

    private void Start()
    {
        mainView = playerCtrl_script.mainView;
        playView = playerCtrl_script.playView;
    }

    // ���� ��ư ������ ȣ��
    public void ClickSettings()
    {
        gameObject.SetActive(true);
        playerCtrl_script.isCantMove = true;
    }

    // �������� ���ư���
    public void ClickBack()
    {
        gameObject.SetActive(false);
        playerCtrl_script.isCantMove = false;
    }

    // ��ġ�̵��� ������ ȣ��
    public void ClickTouch()
    {
        isJoyStick = false;
        touchBtn.color = blue;
        JoyStickBtn.color = Color.white;
    }

    // ���̽�ƽ�� ������ ȣ��
    public void ClickJoyStick()
    {
        isJoyStick = true;
        touchBtn.color = Color.white;
        JoyStickBtn.color = blue;
    }

    // ���� ������ ��ư�� ������ ȣ��
    public void ClickQuit()
    {
        mainView.SetActive(true);
        playView.SetActive(false);

        // ĳ���� ����
        playerCtrl_script.DestroyPlayer();
    }
}
