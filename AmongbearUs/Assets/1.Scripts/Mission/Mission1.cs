using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Mission1 : MonoBehaviour
{
    public Color red;
    public Image[] images;

    Animator anim;
    PlayerCtrl playerCtrl_script;
    MissionCtrl missionCtrl_script;

    private void Start()
    {
        anim = GetComponentInChildren<Animator>();
        missionCtrl_script = FindObjectOfType<MissionCtrl>();
    }

    // 미션 시작
    public void MissionStart()
    {
        anim.SetBool("isUp", true);
        playerCtrl_script = FindObjectOfType<PlayerCtrl>();

        // 초기화
        for (int i = 0; i < images.Length; i++)
        {
            images[i].color = Color.white;
        }

        // 랜덤
        for(int i = 0; i < 4; i++)
        {
            int rand = Random.Range(0, 7); // 0~6사이의 난수 발생

            images[rand].color = red;
        }
    }

    // X 버튼 누르면 호출
    public void ClickCancle()
    {
        anim.SetBool("isUp", false);
        playerCtrl_script.MissionEnd();
    }

    // 육각형 버튼을 누르면 호출
    public void ClickButton()
    {
        // 버튼입력한 오브젝트의 이미지를 가져와서 넣어줌.
        Image img = EventSystem.current.currentSelectedGameObject.GetComponent<Image>();

        // 하얀색이면
        if (img.color == Color.white)
        {
            // 빨강색으로
            img.color = red;
        }
        // 빨간색이면
        else
        {
            // 하얀색으로
            img.color = Color.white;
        }

        // 성공여부 체크
        int count = 0;

        for (int i = 0; i < images.Length; i++)
        {
            if (images[i].color == Color.white)
            {
                count++;
            }
        }

        if (count == images.Length)
        {
            // 성공
            Invoke("MissionSuccess", 0.2f);
        }
    }

    // 미션 성공하면 호출
    public void MissionSuccess()
    {
        ClickCancle();
        missionCtrl_script.MissionSuccess(GetComponent<CircleCollider2D>());
    }
}
