using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject missionView, killView;

    public void ClickQuit()     // ������
    {
#if UNITY_EDITOR
        // ����Ƽ ������ ���� ����
        UnityEditor.EditorApplication.isPlaying = false;
#else
Application.Quit();
#endif
    }

    // �̼� ��ư ������ ȣ��
    public void ClickMission()
    {
        gameObject.SetActive(false);
        missionView.SetActive(true);            // �� ���� �̼� ���ֱ�

        GameObject player = Instantiate(Resources.Load("Character"), new Vector3(0, -2, 0), Quaternion.identity) as GameObject;     // ĳ���� �������ֱ�
        PlayerCtrl playerCtrl = player.GetComponent<PlayerCtrl>();
        playerCtrl.mainView = gameObject;
        playerCtrl.playView = missionView;
        playerCtrl.isMission = true;

        missionView.SendMessage("MissionReset");
    }

    // ų ��ư ������ ȣ��
    public void ClickKill()
    {
        gameObject.SetActive(false);
        killView.SetActive(true);       // �� ���� ų ���ֱ�

        GameObject player = Instantiate(Resources.Load("Character"), new Vector3(0, -2, 0), Quaternion.identity) as GameObject;
        PlayerCtrl playerCtrl = player.GetComponent<PlayerCtrl>();
        playerCtrl.mainView = gameObject;
        playerCtrl.playView = killView;
        playerCtrl.isMission = false;

        killView.SendMessage("KillReset");
    }
}
