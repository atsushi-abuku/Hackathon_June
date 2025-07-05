using Unity.VisualScripting;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;//�v���C���[��Transform
    public float fixedY = 5f;//�W�����v�𖳎�����y���W
    public float distanceZ = -10f;//�v���C���[����̋���

    private void LateUpdate()
    {
        //�v���C���[�̉��ړ���ǂ�������
        Vector3 targetPos = new Vector3(player.position.x, fixedY, player.position.z + distanceZ);
        transform.position = targetPos;
    }
}

