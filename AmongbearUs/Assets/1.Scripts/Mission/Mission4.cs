using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Mission4 : MonoBehaviour
{
    public Transform numbers;
    public Color blue;

    Animator anim;
    PlayerCtrl playerCtrl_script;
    MissionCtrl missionCtrl_script;

    int count;

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

        //�ʱ�ȭ
        for (int i = 0; i < numbers.childCount; i++)
        {
            numbers.GetChild(i).GetComponent<Image>().color = Color.white;
            numbers.GetChild(i).GetComponent<Button>().enabled = true;
        }

        // ���� ���� ��ġ
        for (int i = 0; i < 10; i++)
        {
            Sprite temp = numbers.GetChild(i).GetComponent<Image>().sprite;

            int rand = Random.Range(0, 10);
            numbers.GetChild(i).GetComponent<Image>().sprite
                = numbers.GetChild(rand).GetComponent<Image>().sprite;

            numbers.GetChild(rand).GetComponent<Image>().sprite = temp;
        }

        count = 1;
    }

    // X ��ư ������ ȣ��
    public void ClickCancle()
    {
        anim.SetBool("isUp", false);
        playerCtrl_script.MissionEnd();
    }

    // ���� ��ư ������ ȣ��
    public void ClickNumber()
    {
        if (count.ToString()
            == EventSystem.current.currentSelectedGameObject.GetComponent<Image>().sprite.name)
        {
            // ������
            EventSystem.current.currentSelectedGameObject.GetComponent<Image>().color = blue;

            // ��ư ��Ȱ��ȭ
            EventSystem.current.currentSelectedGameObject.GetComponent<Button>().enabled = false;

            count++;

            // �������� üũ
            if (count == 11)
            {
                Invoke("MissionSuccess", 0.2f);
            }
        }

    }

    // �̼� �����ϸ� ȣ��
    public void MissionSuccess()
    {
        ClickCancle();
        missionCtrl_script.MissionSuccess(GetComponent<CircleCollider2D>());
    }
}
