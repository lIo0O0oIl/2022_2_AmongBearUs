using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyStick : MonoBehaviour
{
    public RectTransform stick, backGround;     // 스틱포지션이랑 뒷배경 가지고 오기

    PlayerCtrl playerCtrl_script;

    Animator anim;

    bool isDrag;
    float limit;        // 반지름, 제한되게

    private void Start()
    {
        playerCtrl_script = GetComponent<PlayerCtrl>();

        anim = GetComponent<Animator>();

        limit = backGround.rect.width * 0.5f;       // 반으로 된 제한값
    }

    private void Update()
    {
        //드래그 하는 동안
        if (isDrag)
        {
            //stick.position = stick.position = Input.mousePosition;
            Vector2 vec = Input.mousePosition - backGround.position;        // 지금 얼마나 빠져나왔는가
            stick.localPosition = Vector2.ClampMagnitude(vec, limit);       // limit 를 넘지 않는 백터를 반환

            Vector3 dir = (stick.position - backGround.position).normalized;
            transform.position += dir * playerCtrl_script.speed * Time.deltaTime;       // 개릭터 이동

            anim.SetBool("isWalk", true);

            // 왼쪽으로 이동하는 곳 바라보라고
            if (dir.x < 0)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
            // 오른쪽으로 이동
            else
            {
                transform.localScale = new Vector3(1, 1, 1);
            }

            if (Input.GetMouseButtonUp(0))      // 손 때면 본래 위치로 되돌아가기;
            {
                stick.localPosition = new Vector3(0, 0, 0);
                anim.SetBool("isWalk", false);      // 애니도 꺼주고

                isDrag = false;
            }
        }
    }

    // 스틱을 누르면 호출
    public void ClickStick()
    {
        isDrag = true;
    }
}
