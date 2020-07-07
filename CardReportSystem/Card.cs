using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardReportSystem
{
    [Serializable]
    class Card
    {
        //日付
        public DateTime time { get; set; }
        //カードタイプ
        public string type { get; set; }
        //色
        public CardColor color { get; set; }
        //カード名
        public string name { get; set; }
        //効果
        public string Effect { get; set; }
        //画像
        public Image picture { get; set; }
        //エキスパンション
        public string Expansion { get; set; }
        //コスト
        public string Cost { get; set; }
        //レア度
        public string Rarity { get; set; }
        //所持枚数
        public int Have { get; set; }
    }

    public enum CardColor
    {
        赤,
        青,
        緑,
        白,
        黒,
        無
    }
}
