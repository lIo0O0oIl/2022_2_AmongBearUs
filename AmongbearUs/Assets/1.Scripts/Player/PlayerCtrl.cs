using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PlayerCtrl : MonoBehaviour
{
    public GameObject JoyStick, mainView, playView;
    public Settings settings_scripts;
    public Button btn;
    public Sprite use, kill;
    public Text text_cool;

    Animator anim;
    GameObject coll;            // 미션
    KillCtrl killCtrl_script;

    public float speed = 3;

    public bool isCantMove, isMission;

    float timer;
    bool isCool, isAnim;

    private void Start()
    {
        anim = GetComponent<Animator>();

        Camera.main.transform.parent = transform;
        Camera.main.transform.localPosition = new Vector3(0, 0, -10);       // 카메라 따라다니게

        // 미션이라면
        if (isMission)
        {
            btn.GetComponent<Image>().sprite = use;

            text_cool.text = "";
        }
        // 킬 퀘스트라면
        else
        {
            killCtrl_script = FindObjectOfType<KillCtrl>();

            btn.GetComponent<Image>().sprite = kill;

            timer = 5;
            isCool = true;
        }
    }

    private void Update()
    {
        // 킬 쿨타임
        if (isCool)
        {
            timer -= Time.deltaTime;
            text_cool.text = Mathf.Ceil(timer).ToString();

            if (text_cool.text == "0")
            {
                text_cool.text = "";
                isCool = false;
            }
        }

        if (isCantMove)
        {
            JoyStick.SetActive(false);
        }
        else
        {
            Move();
        }

        // 애니메이션이 끝났다면
        if (isAnim && killCtrl_script.kill_anim.GetComponent<Animator>().
            GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
        {
            killCtrl_script.kill_anim.SetActive(false);
            killCtrl_script.Kill();
            isCantMove = false;
            isAnim = false;
        }
    }

    // 캐릭터 움직임 관리
    void Move()
    {
        if (settings_scripts.isJoyStick)        // 조이스틱이면
        {
            JoyStick.SetActive(true);
        }
        else
        {
            JoyStick.SetActive(false);

            // 좌클릭(터치)했는지 판단
            if (Input.GetMouseButton(0))
            {
                if (!EventSystem.current.IsPointerOverGameObject())
                {
                    Vector3 dir = (Input.mousePosition
                        - new Vector3(Screen.width * 0.5f, Screen.height * 0.5f)).normalized;
                    // 클릭시점에서 중앙값을 빼서 방향 구해주기

                    transform.position += dir * speed * Time.deltaTime;     // 이동

                    anim.SetBool("isWalk", true);

                    // 왼쪽으로 이동          이동하는 곳 바라보라고
                    if (dir.x < 0)
                    {
                        transform.localScale = new Vector3(-1, 1, 1);
                    }
                    // 오른쪽으로 이동
                    else
                    {
                        transform.localScale = new Vector3(1, 1, 1);
                    }
                }
            }
            else
            {
                anim.SetBool("isWalk", false);
            }
        }
    }

    //캐릭터 삭제
    public void DestroyPlayer()
    {
        Camera.main.transform.parent = null;

        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)     // 조이스틱 활성화 비활성화
    {
        if (collision.tag == "Mission" && isMission)
        {
            coll = collision.gameObject;

            btn.interactable = true;
        }

        if (collision.tag == "NPC" && !isMission && !isCool)
        {
            coll = collision.gameObject;

            btn.interactable = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Mission")
        {
            coll = null;

            btn.interactable = false;
        }

        if (collision.tag == "Kill" == !isMission)
        {
            coll = null;

            btn.interactable = false;
        }
    }

    // USE 버튼 누르면 호출
    public void ClickButton()
    {
        // 미션일 때
        if (isMission)
        {
            // MissionStart를 호출
            coll.SendMessage("MissionStart");
        }
        // 킬일 때
        else
        {
            Kill();
        }

        isCantMove = true;
        btn.interactable = false;
    }

    void Kill()
    {
        // 죽이는 애니메이션
        killCtrl_script.kill_anim.SetActive(true);
        isAnim = true;

        // 죽은 이미지로 변경
        coll.SendMessage("Dead");

        // 죽은 NPC는 다시 죽일 수 없게
        coll.GetComponent<CircleCollider2D>().enabled = false;
    }

    // 미션1창 종료하면(X누르면) 호출
    public void MissionEnd()
    {
        isCantMove = false;
    }
}
