using TMPro;
using UnityEngine;

namespace KID
{
    /// <summary>
    /// だ计恨瞶
    /// </summary>
    public class ScoreManager : MonoBehaviour
    {
        public static int addScore = 2;

        private string nameBasketball = "膞瞴";
        private TextMeshProUGUI textScore;
        private int totalScore;

        private void Awake()
        {
            textScore = GameObject.Find("だ计").GetComponent<TextMeshProUGUI>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.name.Contains(nameBasketball))
            {
                AddScore();
            }
        }

        private void AddScore()
        {
            totalScore += addScore;
            textScore.text = "SCORE " + totalScore;
        }

        /// <summary>
        /// 跑だ计
        /// </summary>
        /// <param name="scoreToChange">璶跑だ计</param>
        private void ChangeScore(int scoreToChange)
        {
            addScore = scoreToChange;
        }
    }
}
