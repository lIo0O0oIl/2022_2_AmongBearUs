# AmongBearUs

<div align="center">
<a href="#">
  <img alt="image" src="https://github.com/lIo0O0oIl/2022_2_AmongBearUs/assets/98943168/d1d2491e-4adb-454b-a9b2-672836bbf76b">
</a>
<!--타이틀 잘라서 넣어주기-->

<!--
[![Hits](https://hits.seeyoufarm.com/api/count/incr/badge.svg?url=https%3A%2F%2Fgithub.com%2FlIo0O0oIl%2F2022_1_Only_One_Chance&count_bg=%23EEEE0E&title_bg=%23555555&icon=&icon_color=%23E7E7E7&title=hits&edge_flat=false)](https://hits.seeyoufarm.com)
-->

</div> <!--가운데 정렬은 여기까지-->

## 프로젝트 정보
> **1학년 여름방학 유니티 기초반 수업**  
> **2022.7.21 ~ 2022.7.29**

## 게임 설명
<div align="center">

|  InGame   |
| :-------: |
| <a href="#"> <img alt="image" width="250" src=""> <img alt="image" width="250" src=""> </a> |

|   Intro   |   Outro   |
|:---------:|:---------:|
| <a href="#"> <img alt="image" width="250" src=""> </a> | <a href="#"> <img alt="image" width="250" src=""> </a> |

</div>

> **Only One Chance는 1학년 1학기 동안 배운 내용을 응용해서 약 1개월동안 만든 간단한 PC 슈팅게임입니다.**  
> **플레이어 쪽으로 날라오는 적, 한 방향으로 내려오는 적이 랜덤으로 생성되며 3가지의 패턴을 가진 보스가 존재합니다.**

## 빌드본 다운
> **구글 드라이브** : [https://drive.google.com/file/d/1yi15vQp7MBOX9OUXNNc79FEmomPVpFd9/view?usp=sharing] <br>

## 개발팀 소개
<div align="center">

| <a href="https://github.com/lIo0O0oIl"> lIo0O0oIl </a> |
| :-----------: |
| <a href="https://github.com/lIo0O0oIl"> <img alt="image" width="200" src="https://github.com/lIo0O0oIl.png"> </a> |
| 1인 개발 |

</div>

## 사용한 것들
<div align="left"> <a href="#">
<img src="https://img.shields.io/badge/unity-%23000000.svg?style=for-the-badge&logo=unity&logoColor=white">
<img src="https://img.shields.io/badge/Visual%20Studio%202022-5C2D91?style=for-the-badge&logo=Visual%20Studio&logoColor=white">
<img src="https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=GitHub&logoColor=white">
</a> </div>
<a href="#">
  <img src="https://img.shields.io/badge/Unity_Version-2021.3.8f1-blue?style=flat-square">
</a>

## 구조
```bash
AMONGBEARUS\ASSETS
├─0. Scenes
│      SampleScene.unity
│
├─1.Scripts
│  │  KillCtrl.cs
│  │  MainMenu.cs
│  │  NPCCtrl.cs
│  │
│  ├─Mission
│  │      Mission1.cs
│  │      Mission2.cs
│  │      Mission3.cs
│  │      Mission4.cs
│  │      Mission5.cs
│  │      Mission6.cs
│  │      MissionCtrl.cs
│  │
│  └─Player
│          JoyStick.cs
│          PlayerCtrl.cs
│          Settings.cs
│
├─2. Sprites
│  │  AtlasAll.spriteatlas
│  │  Icon.png
│  │
│  ├─0. Particle
│  │      Bubble.mat
│  │      bubble.png
│  │      Rose.mat
│  │      rose.png
│  │
│  ├─1. UI
│  │  ├─Main Menu
│  │  │      AmongBearUs_Title.png
│  │  │      human-skull.png
│  │  │      Main_1.png
│  │  │      Main_2.png
│  │  │      Main_3.png
│  │  │      Main_Title.png
│  │  │      mission.png
│  │  │      quit 1.png
│  │  │
│  │  ├─Player
│  │  │      JoyStick.png
│  │  │      Kill.png
│  │  │      Use.png
│  │  │
│  │  └─Setting
│  │          Setting.png
│  │          Setting_Back.png
│  │          Setting_Btn.png
│  │
│  ├─2. Character
│  │  ├─1
│  │  │      1.png
│  │  │      2.png
│  │  │      3.png
│  │  │      4.png
│  │  │      5.png
│  │  │      6.png
│  │  │      7.png
│  │  │      Dead.png
│  │  │
│  │  ├─2
│  │  │      1.png
│  │  │      2.png
│  │  │      3.png
│  │  │      4.png
│  │  │      5.png
│  │  │      6.png
│  │  │      7.png
│  │  │      Dead.png
│  │  │
│  │  ├─3
│  │  │      1.png
│  │  │      2.png
│  │  │      3.png
│  │  │      4.png
│  │  │      5.png
│  │  │      6.png
│  │  │      7.png
│  │  │      Dead.png
│  │  │
│  │  ├─4
│  │  │      1.png
│  │  │      2.png
│  │  │      3.png
│  │  │      4.png
│  │  │      5.png
│  │  │      6.png
│  │  │      7.png
│  │  │      Dead.png
│  │  │
│  │  └─5
│  │          1.png
│  │          2.png
│  │          3.png
│  │          4.png
│  │          5.png
│  │          6.png
│  │          7.png
│  │          Dead.png
│  │
│  ├─3. Map
│  │      1. Back.png
│  │      10. Hallway_4.png
│  │      2. Cafeteria.png
│  │      3. Lab.png
│  │      4. Prop_Down.png
│  │      5. Prop_Up.png
│  │      6. Electric.png
│  │      7. Hallway_1.png
│  │      8. Hallway_2.png
│  │      9. Hallway_3.png
│  │
│  ├─4. Item
│  │      Mission1.png
│  │      Mission2.png
│  │      Mission3.png
│  │      Mission4.png
│  │      Mission5.png
│  │      Mission6.png
│  │
│  ├─5. Mission
│  │  │  Cancle.png
│  │  │  Guage.png
│  │  │
│  │  ├─Mission1
│  │  │      Mission1_Back.png
│  │  │      Mission1_Btn.png
│  │  │
│  │  ├─Mission2
│  │  │      Mission2_1.png
│  │  │      Mission2_2.png
│  │  │      Mission2_3.png
│  │  │      Mission2_4.png
│  │  │      Mission2_5.png
│  │  │      Mission2_Back.png
│  │  │      Mission2_Handle.png
│  │  │
│  │  ├─Mission3
│  │  │      Mission3_Back.png
│  │  │
│  │  ├─Mission4
│  │  │      1.png
│  │  │      2.png
│  │  │      3.png
│  │  │      4.png
│  │  │      5.png
│  │  │      6.png
│  │  │      7.png
│  │  │      8.png
│  │  │      9.png
│  │  │      10.png
│  │  │      Mission4_Back.png
│  │  │
│  │  ├─Mission5
│  │  │      Mission5_Back.png
│  │  │      Mission5_Hadle.png
│  │  │      Mission5_Rotate.png
│  │  │
│  │  └─Mission6
│  │          Mission6_Back.png
│  │
│  ├─6. KillAnimation
│  │      1.png
│  │      2.png
│  │      3.png
│  │      4.png
│  │      5.png
│  │      6.png
│  │      7.png
│  │      8.png
│  │      9.png
│  │      10.png
│  │      11.png
│  │      12.png
│  │
│  └─7. good
│          celebration.png
│          Light.mat
│          Light.psd
│          missionClear.psd
│
├─3. Animation
│      BackGround.controller
│      Character.controller
│      Character_Idle.anim
│      Character_Walk.anim
│      KillAnimation.anim
│      Kill_Anim.controller
│      MissionUI.controller
│      Mission_Down.anim
│      Mission_Idle_Down.anim
│      Mission_Idle_Up.anim
│      Mission_Up.anim
│      Text.controller
│      Text_Success.anim
│      Trash_Shake.anim
│
├─4. Material
│      Blue.mat
│      Green.mat
│      Red.mat
│      Yellow.mat
│
└─Resources
    │  Character.prefab
    │  NPC.prefab
    │
    └─Trash
            Trash1.prefab
            Trash2.prefab
            Trash3.prefab
            Trash4.prefab
            Trash5.prefab
```

## 참고
<img>
기초반 수업 자료들
