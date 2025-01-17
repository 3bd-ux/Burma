using UnityEngine;
namespace Assignment35
{
    public class MethodChainingExample : MonoBehaviour
    {
        [SerializeField] private MethodChainingExample chainer;

        void Start()
        {
            chainer = GetComponent<MethodChainingExample>();
            chainer.SetPosition(new Vector3(0, 1, 0)).SetRotation(new Vector3(45, 0, 0)).SetScale(new Vector3(2, 2, 2));
        }


        public MethodChainingExample SetPosition(Vector3 position)
        {
            transform.position = position;
            return this;
        }
        public MethodChainingExample SetRotation(Vector3 rotation)
        {
            transform.rotation = Quaternion.Euler(rotation);
            return this;
        }
        public MethodChainingExample SetScale(Vector3 scale)
        {
            transform.localScale = scale;
            return this;
        }
    }
}