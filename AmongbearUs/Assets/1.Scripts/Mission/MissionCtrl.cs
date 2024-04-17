using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionCtrl : MonoBehaviour
{
    public Slider gauge;
    public CircleCollider2D[] colls;

    public GameObject text_anim, mainView, effect, mainCamera;

    int missionCount;

    //미션 초기화
    public void MissionReset()
    {
        gauge.value = 0;
        missionCount = 0;

        for (int i = 0; i < colls.Length; i++)
        {
            colls[i].enabled = true;
        }

        text_anim.SetActive(false);
        effect.SetActive(false);
    }

    // 미션 성공하면 호출
    public void MissionSuccess(CircleCollider2D coll)
    {
        missionCount++;

        gauge.value = missionCount / 7f;        // 게이지 채워줌

        // 성공한 미션은 다시 플레이 못하게
        coll.enabled = false;

        // 모든 미션 성공 체크
        if (gauge.value == 1)
        {
            text_anim.SetActive(true);
            effect.transform.position = mainCamera.transform.position;
            effect.SetActive(true);

            Invoke("Change", 3f);
        }
    }

    // 모든 미션 성공 후 화면전환
    public void Change()
    {
        mainView.SetActive(true);
        gameObject.SetActive(false);

        // 캐릭터 삭제
        FindObjectOfType<PlayerCtrl>().DestroyPlayer();
    }
}
