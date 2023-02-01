using System;
using UnityEngine;

namespace CatlikeCoding.Basics.GameObjectsAndScripts
{
    public class Clock: MonoBehaviour
    {
        /// <summary>
        /// 同一个是可以写到一行的
        /// </summary>
        [SerializeField]
        private Transform hoursPivot,
                          minutesPivot,
                          secondsPivot;

        private const float hoursToDegrees = -30f,
                            minutesToDegrees = -6f,
                            secondsToDegrees = -6f;

        private void Awake()
        {
            SetTime();
        }

        private void Update()
        {
            SmoothlySetTime();
        }

        private void SetTime()
        {
            var time = DateTime.Now;

            hoursPivot.localRotation = Quaternion.Euler(0, 0, hoursToDegrees * time.Hour);
            minutesPivot.localRotation = Quaternion.Euler(0, 0, minutesToDegrees * time.Minute);
            secondsPivot.localRotation = Quaternion.Euler(0, 0, secondsToDegrees * time.Second);
        }

        /// <summary>
        /// 平滑的设置时间
        /// </summary>
        private void SmoothlySetTime()
        {
            var time = DateTime.Now.TimeOfDay;
            hoursPivot.localRotation = Quaternion.Euler(0, 0, hoursToDegrees * (float)time.TotalHours);
            minutesPivot.localRotation = Quaternion.Euler(0, 0, minutesToDegrees * (float)time.TotalMinutes);
            secondsPivot.localRotation = Quaternion.Euler(0, 0, secondsToDegrees * (float)time.TotalSeconds);
        }
    }
}