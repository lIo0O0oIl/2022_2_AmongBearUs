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

    // �̼� ����
    public void MissionStart()
    {
        anim.SetBool("isUp", true);
        playerCtrl_script = FindObjectOfType<PlayerCtrl>();

        // �ʱ�ȭ
        for (int i = 0; i < images.Length; i++)
        {
            images[i].color = Color.white;
        }

        // ����
        for(int i = 0; i < 4; i++)
        {
            int rand = Random.Range(0, 7); // 0~6������ ���� �߻�

            images[rand].color = red;
        }
    }

    // X ��ư ������ ȣ��
    public void ClickCancle()
    {
        anim.SetBool("isUp", false);
        playerCtrl_script.MissionEnd();
    }

    // ������ ��ư�� ������ ȣ��
    public void ClickButton()
    {
        // ��ư�Է��� ������Ʈ�� �̹����� �����ͼ� �־���.
        Image img = EventSystem.current.currentSelectedGameObject.GetComponent<Image>();

        // �Ͼ���̸�
        if (img.color == Color.white)
        {
            // ����������
            img.color = red;
        }
        // �������̸�
        else
        {
            // �Ͼ������
            img.color = Color.white;
        }

        // �������� üũ
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
            // ����
            Invoke("MissionSuccess", 0.2f);
        }
    }

    // �̼� �����ϸ� ȣ��
    public void MissionSuccess()
    {
        ClickCancle();
        missionCtrl_script.MissionSuccess(GetComponent<CircleCollider2D>());
    }
}
