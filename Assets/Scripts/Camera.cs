using Unity.VisualScripting;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;//プレイヤーのTransform
    public float fixedY = 5f;//ジャンプを無視したy座標
    public float distanceZ = -10f;//プレイヤーからの距離

    private void LateUpdate()
    {
        //プレイヤーの横移動を追いかける
        Vector3 targetPos = new Vector3(player.position.x, fixedY, player.position.z + distanceZ);
        transform.position = targetPos;
    }
}

