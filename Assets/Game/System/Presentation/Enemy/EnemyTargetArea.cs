using UnityEngine;

public class EnemyTargetArea : MonoBehaviour
{
    private void Update()
    {
        // 常にカメラの方向に向ける
        transform.LookAt(Camera.main.transform);
    }
}