using UnityEngine;
using UnityEngine.Events;

namespace Otutama.Timer
{
    public class RandomTimer : MonoBehaviour
    {
        [SerializeField]
        private float maxInterval = default; // 最小実行間隔
        [SerializeField]
        private float minInterval = default; // 最大実行間隔
        [SerializeField]
        private bool callAtStart = false; // Start時にイベントを実行するかどうか
        [SerializeField]
        private UnityEvent events = new UnityEvent(); // 実行するイベント

        private float time;
        private float interval;

        private void Start()
        {
            ResetTimer();
            if (callAtStart == true)
            {
                events.Invoke();
            }
        }

        private void Update()
        {
            time += Time.deltaTime;
            if (time >= interval)
            {
                events.Invoke();
                ResetTimer();
            }
        }

        private void ResetTimer()
        {
            time = 0f;
            interval = Random.Range(minInterval, maxInterval);
            Debug.Log("set interval:" + interval);
        }
    }
}
