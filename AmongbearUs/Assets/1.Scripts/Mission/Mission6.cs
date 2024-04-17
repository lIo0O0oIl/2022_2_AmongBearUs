using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Mission6 : MonoBehaviour
{
    public bool[] isColor = new bool[4];
    public RectTransform[] rights;
    public LineRenderer[] lines;

    Animator anim;
    PlayerCtrl playerCtrl_script;
    MissionCtrl missionCtrl_script;

    Vector2 clickPos;
    LineRenderer line;
    Color leftC, rightC;

    bool isDrag;
    float leftY, rightY;

    private void Start()
    {
        anim = GetComponentInChildren<Animator>();
        missionCtrl_script = FindObjectOfType<MissionCtrl>();
    }

    private void Update()
    {
            // �巡��
        if (isDrag)
        {
            line.SetPosition(1, new Vector3(Input.mousePosition.x - clickPos.x,
                Input.mousePosition.y - clickPos.y, -10));

            //�巡�� ��
            if (Input.GetMouseButtonUp(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                RaycastHit hit;

                // ������ ���� ��Ҵٸ�
                if (Physics.Raycast(ray, out hit))
                {
                    GameObject rightLine = hit.transform.gameObject;

                    // ������ �� y��
                    rightY = rightLine.GetComponent<RectTransform>().anchoredPosition.y;

                    // ������ �� ����
                    rightC = rightLine.GetComponent<Image>().color;

                    line.SetPosition(1, new Vector3(500, rightY - leftY, -10));

                    // �� ��
                    if (leftC == rightC)
                    {
                        switch (leftY)
                        {
                            case 225: isColor[0] = true; break;
                            case 75: isColor[1] = true; break;
                            case -75: isColor[2] = true; break;
                            case -225: isColor[3] = true; break;
                        }
                    }
                    else
                    {
                        switch (leftY)
                        {
                            case 225: isColor[0] = false; break;
                            case 75: isColor[1] = false; break;
                            case -75: isColor[2] = false; break;
                            case -225: isColor[3] = false; break;
                        }
                    }

                    // �������� üũ
                    if (isColor[0] && isColor[1] && isColor[2] && isColor[3])
                    {
                        Invoke("MissionSuccess", 0.2f);
                    }
                }

                // ���� �ʾҴٸ�
                else
                {
                    line.SetPosition(1, new Vector3(0, 0, -10));
                }
                
                isDrag = false;
            }
        }
    }

    // �̼� ����
    public void MissionStart()
    {
        anim.SetBool("isUp", true);
        playerCtrl_script = FindObjectOfType<PlayerCtrl>();

        // �ʱ�ȭ
        for (int i = 0; i < 4; i++)
        {
            isColor[i] = false;
            lines[i].SetPosition(1, new Vector3(0, 0, -10));
        }

        // ����
        for (int i = 0; i < rights.Length; i++)
        {
            Vector3 temp = rights[i].anchoredPosition;

            int rand = Random.Range(0, 4);
            rights[i].anchoredPosition = rights[rand].anchoredPosition;

            rights[rand].anchoredPosition = temp;
        }
    }

    // X ��ư ������ ȣ��
    public void ClickCancle()
    {
        anim.SetBool("isUp", false);
        playerCtrl_script.MissionEnd();
    }

    // �� ������ ȣ��
    public void ClickLine(LineRenderer click)
    {
        clickPos = Input.mousePosition;
        line = click;

        // ���� �� y��
        leftY = click.transform.parent.GetComponent<RectTransform>().anchoredPosition.y;

        // ���� �� ����
        leftC = click.transform.parent.GetComponent<Image>().color;

        isDrag = true;
    }

    // �̼� �����ϸ� ȣ��
    public void MissionSuccess()
    {
        ClickCancle();
        missionCtrl_script.MissionSuccess(GetComponent<CircleCollider2D>());
    }
}
