using System.Collections;
using System.Collections.Generic;
//using BigRookGames.Weapons;
using UnityEngine;

public class RayCaster : MonoBehaviour
{
    public Camera playerCamera;
    AudioSource beamAudioSource;
    public AudioClip beamSound;
    public GunfireController gunfireController;
    public GameObject pistol;
    public GameObject rocketLauncher;
    // Start is called before the first frame update
    void Start()
    {
       Cursor.lockState = CursorLockMode.Locked; // カーソルをロックする 
       beamAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) // 左クリックが押されたとき
        {
            if(pistol.activeSelf == true)
            {
                Shot();
                beamAudioSource.PlayOneShot(beamSound);   
            }
        }
        if(Input.GetMouseButtonDown(0)) // 左クリックが押されたとき
        {
            if(rocketLauncher.activeSelf == true)
            {
                gunfireController.FireWeapon();
                ScoreCounter.destroyedEnemyCount -= 5;
                if (ScoreCounter.destroyedEnemyCount <= 5)
                {
                    rocketLauncher.SetActive(false);
                    pistol.SetActive(true);
                }
            }
        }
    }

    void Shot()
    {
        int distance = 50;
        Vector3 center = new Vector3(Screen.width / 2, Screen.height / 2, 0); // 画面の中心を取得
        Ray ray = playerCamera.ScreenPointToRay(center); // 画面の中心からRayを飛ばす
        RaycastHit hitInfo; // Rayが当たったオブジェクトの情報を格納する変数
        if(Physics.Raycast(ray, out hitInfo, distance)) // Rayがオブジェクトに当たったとき
        {
            if(hitInfo.collider.tag == "Enemy") // Rayが当たったオブジェクトのタグが"Enemy"のとき
            {
               hitInfo.collider.SendMessage("Damage");
            }
        }
    }
}
