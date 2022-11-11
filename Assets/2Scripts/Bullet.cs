using UnityEngine;

namespace _2Scripts
{
    public class Bullet : MonoBehaviour
    {
        public int damage;
        public bool isMelee;
        public bool isRock;

        private void OnCollisionEnter(Collision collision)
        {
            if (!isRock && collision.gameObject.tag == "Floor")
            {
                Destroy(gameObject, 3);
            }

        }

        private void OnTriggerEnter(Collider other)
        {

            if (!isMelee && other.gameObject.tag == "Wall")
            {
                Destroy(gameObject);
            }

            if (!isRock && !isMelee && other.gameObject.tag == "Floor")
            {
                Destroy(gameObject);
            }
        }
    }
}
