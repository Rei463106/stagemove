using UnityEngine;

public class player_move : MonoBehaviour
{
    //Start�̒��Ő錾�������̂͑��̂Ƃ���Ŏg�p�ł��Ȃ��c�̂ōŏ��ɐ錾���Ă���
    //�ŏ���RigidBody2D�Ə����Ă��GetComponent�̕K�v�͂Ȃ��H�H
    private Rigidbody2D rb;
    [SerializeField] float speed = 3.0f;


    void Start()
    {
        //����������Ȃ��ƁA���̃f�[�^�������ĂȂ����̂��Ăяo�����ƂɂȂ�B
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //�������Z�n��FixedUpdate�̒��ł��̂���ʓI
    private void FixedUpdate()
    {
        //���E���̓L�[�����������̒l����
        float horizontalKey = Input.GetAxis("Horizontal");

        //�E�L�[
        //new�ŁA���ڑ��������������Ă���I�I
        //A�̃R���|�[�l���g��b�̏�񂪓�������A.b�Ŏ擾
        if (horizontalKey > 0)
        {
            rb.velocity = new Vector2(speed,rb.velocity.y);
        }
        //���L�[
        else if(horizontalKey < 0) 
        {
           rb.velocity=new Vector2(-speed,rb.velocity.y);
        }
        else
        {
          rb.velocity=Vector2.zero;
        }
    }
}
