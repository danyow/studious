using UnityEngine;

namespace CatlikeCoding.Basics.BuildingGraph
{
    public class Graph: MonoBehaviour
    {
        [SerializeField]
        private Transform pointPrefab;

        [SerializeField, Range(10, 100)]
        private float resolution;

        private void Awake()
        {
            var step = 2f / resolution;
            var scale = Vector3.one * step;
            var position = Vector3.zero;
            for(var i = 0; i < resolution; i++)
            {
                var point = Instantiate(pointPrefab, transform, false);

                position.x = (i + 0.5f) * step - 1f;
                position.y = position.x;
                point.localPosition = position;
                point.localScale = scale;
            }
        }
    }
}