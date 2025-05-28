using UnityEngine;

public class Scene_Changer : MonoBehaviour
{
    //もしプレイヤーがドアと重なって
    //上ボタンを押したら
    //シーン移動

    // Start is called before the first frame update
    void Start()
    {

    }
    //Update内で使いたいので外側で宣言、取得しておく
    //この時の変数の名前はnameとかにすると危ない！別のものにする！！
    public string collidedObjectName;

    // Update is called once per frame
    void Update()
    {
        //入力を受け取る
        if (collidedObjectName == "human" && Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("移動");

        }
    }

 

    //引数には衝突・侵入したオブジェクトが渡されます。
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger Stay: " + other.gameObject.name);
        //侵入したものの名前を取得(簡単な名前の中に代入)
        collidedObjectName = other.gameObject.name;
    }


}
