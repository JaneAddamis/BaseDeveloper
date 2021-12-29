using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estimation.ai.common
{
    public class BidValue
    {
        public Suit suit;
        public int value;
        public BidType type;

        public BidValue()
        {
            SetPassBid();
        }

        public string toString()
        {
            string result = "";
            if(type != BidType.PASS)
            {
                result = ": " + type.ToString() + "," +suit.ToString() + "-" + value;
            }
            else
            {
                result = ": PASS,"+value;
            }
            return result;
        }

        public BidValue(Suit suit, BidType type, int value)
        {
            this.suit = suit;
            this.value = value;
            this.type = type;
        }
        
        public BidValue(BidValue value)
        {
            this.suit = value.suit;
            this.value = value.value;
            this.type = value.type;
        }

        public void SetPassBid()
        {
            this.suit = Suit.NONE;
            value = -1;
            type = BidType.PASS;
        }

        public BidType GetBidType(BidValue value)
        {
            BidType type = BidType.CALL;

            return type;
        }
    }
}
