public class Platform : MonoBehaviour
{
    //Скорость движения платформы
    public float speed;
    //Направление движения платформы
    public Vector3 direction;
    //Состояние платформы: активна / не активна
    public bool isActive;
 
 
    //Обновление движения платформы каждый кадр
    void Update()
    {
 
        if (isActive)
        {
 
            transform.position += direction * speed * Time.deltaTime;
        }
    }
 
 
    //Столкновение платформы с двумя типами объектов
    void OnTriggerEnter(Collider other) {
        /*Если платформа достигает точки остановки, то она меняет направление
        своего движения*/
        if (other.tag == "PlatformStop")
        {
            direction *= -1;
        }
        //Если платформы коснулся игрок, то она активируется
        if(other.tag == "Player")
        {
            isActive = true;
        }
    }
