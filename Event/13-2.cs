using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{

    delegate void MyDel(int a);
    class MainApp
    {
        class Market
        {
            public event MyDel CustomerEvent;

            public void BuySomething(int CustomerNo)
            {
                if(CustomerNo == 30)
                {
                    CustomerEvent(CustomerNo);
                }
            }
        }
        public static void Main(string[] args)
        {
            Market market = new Market();
            market.CustomerEvent += new MyDel(delegate(int a) {
                Console.WriteLine($"축하합니다! {a}번째 고객 이벤트에 당첨되셨습니다.");
            });

            for(int i = 0; i < 100; i += 10)
            {
                market.BuySomething(i);
            }
        }
    }
}
