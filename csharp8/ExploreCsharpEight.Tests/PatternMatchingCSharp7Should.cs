using System;

namespace ExploreCsharpEight.Tests
{

    public class PatternMatchingCSharp7Should
    {
        public class OrderManager
        {
            public void Notify(Event evt)
            {
                switch (evt)
                {
                    case OrderReceived orderReceived:
                        Handle(orderReceived);
                        break;
                    case OrderAccepted orderAccepted:
                        Handle(orderAccepted);
                        break;
                    default:
                        throw new ArgumentException();
                }
            }

            private void Handle(OrderReceived orderReceived)
            {
            }

            private void Handle(OrderAccepted orderAccepted)
            {
            }
        }
    }
}