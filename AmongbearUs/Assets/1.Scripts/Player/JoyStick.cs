using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyStick : MonoBehaviour
{
    public RectTransform stick, backGround;     // ��ƽ�������̶� �޹�� ������ ����

    PlayerCtrl playerCtrl_script;

    Animator anim;

    bool isDrag;
    float limit;        // ������, ���ѵǰ�

    private void Start()
    {
        playerCtrl_script = GetComponent<PlayerCtrl>();

        anim = GetComponent<Animator>();

        limit = backGround.rect.width * 0.5f;       // ������ �� ���Ѱ�
    }

    private void Update()
    {
        //�巡�� �ϴ� ����
        if (isDrag)
        {
            //stick.position = stick.position = Input.mousePosition;
            Vector2 vec = Input.mousePosition - backGround.position;        // ���� �󸶳� �������Դ°�
            stick.localPosition = Vector2.ClampMagnitude(vec, limit);       // limit �� ���� �ʴ� ���͸� ��ȯ

            Vector3 dir = (stick.position - backGround.position).normalized;
            transform.position += dir * playerCtrl_script.speed * Time.deltaTime;       // ������ �̵�

            anim.SetBool("isWalk", true);

            // �������� �̵��ϴ� �� �ٶ󺸶��
            if (dir.x < 0)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
            // ���������� �̵�
            else
            {
                transform.localScale = new Vector3(1, 1, 1);
            }

            if (Input.GetMouseButtonUp(0))      // �� ���� ���� ��ġ�� �ǵ��ư���;
            {
                stick.localPosition = new Vector3(0, 0, 0);
                anim.SetBool("isWalk", false);      // �ִϵ� ���ְ�

                isDrag = false;
            }
        }
    }

    // ��ƽ�� ������ ȣ��
    public void ClickStick()
    {
        isDrag = true;
    }
}
