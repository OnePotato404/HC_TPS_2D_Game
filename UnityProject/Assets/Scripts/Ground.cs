using UnityEngine;

public class Ground : MonoBehaviour
{
    // 宣告變數 (定義欄位 field)
    // 修飾詞 欄位類型 欄位名稱 (指定 值) 結束
    // private 私人(隱藏)，public 公開(顯示)
    // int 整數
    [Header("地板移動度"), Range(0,200)]
    public int speed = 10;
    public Transform ground;
    
    private void Update()
    {
        //呼叫方法
        Move();
    }

    //方法 / 函式 ,Method / Function 語法:
    //修飾詞 方法類型 方法名稱 () { 陳述式(敘述.演算法)}
    /// <summary>
    /// 地板的移動方法
    /// </summary>
    private void Move()
    {
        ground.Translate(-speed * Time.deltaTime, 0, 0);
    }
}
