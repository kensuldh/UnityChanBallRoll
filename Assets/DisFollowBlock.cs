using UnityEngine;
using System.Collections;

public class DisFollowBlock : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;
    private Vector3 posi;
    public float AxisLine;
    public bool isLookAt;
    private float translation;

    // Use this for initialization
    void Start()
    {
        // 差を取っておく
        offset = this.transform.position - player.transform.position;
        posi = this.transform.position - player.transform.position;
        this.posi.y += player.transform.position.y;

    }


    void LateUpdate()
    {
        //this.translation = player.transform.position.z * 0.1f + offset.z;
        //if (isLookAt)
        //{
        //    this.transform.Translate(0, translation, 0);
        //}
        //else {
        // 毎フレーム差を足しておく
        this.posi.z = -player.transform.position.z + AxisLine;
        this.transform.position = posi;
        //}
    }
}
