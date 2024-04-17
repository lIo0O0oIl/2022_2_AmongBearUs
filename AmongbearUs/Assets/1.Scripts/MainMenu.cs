using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject missionView, killView;

    public void ClickQuit()     // 나가기
    {
#if UNITY_EDITOR
        // 유니티 에디터 실행 멈춤
        UnityEditor.EditorApplication.isPlaying = false;
#else
Application.Quit();
#endif
    }

    // 미션 버튼 누르면 호출
    public void ClickMission()
    {
        gameObject.SetActive(false);
        missionView.SetActive(true);            // 나 끄고 미션 켜주기

        GameObject player = Instantiate(Resources.Load("Character"), new Vector3(0, -2, 0), Quaternion.identity) as GameObject;     // 캐릭터 가져와주기
        PlayerCtrl playerCtrl = player.GetComponent<PlayerCtrl>();
        playerCtrl.mainView = gameObject;
        playerCtrl.playView = missionView;
        playerCtrl.isMission = true;

        missionView.SendMessage("MissionReset");
    }

    // 킬 버튼 누르면 호출
    public void ClickKill()
    {
        gameObject.SetActive(false);
        killView.SetActive(true);       // 나 끄고 킬 켜주기

        GameObject player = Instantiate(Resources.Load("Character"), new Vector3(0, -2, 0), Quaternion.identity) as GameObject;
        PlayerCtrl playerCtrl = player.GetComponent<PlayerCtrl>();
        playerCtrl.mainView = gameObject;
        playerCtrl.playView = killView;
        playerCtrl.isMission = false;

        killView.SendMessage("KillReset");
    }
}
